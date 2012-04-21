using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace TransButton {
    public static class Helper {
        public static void Offset(this RectangleF source, int x, int y) { source.X += x; source.Y += y; }

        
        public static Bitmap GetSS(this Graphics grx, Rectangle bounds) {
            var res = new Bitmap(bounds.Width, bounds.Height);
            var gxc = Graphics.FromImage(res);
            IntPtr hdc = grx.GetHdc();
            PlatformAPI.BitBlt(gxc.GetHdc(), 0, 0, bounds.Width, bounds.Height, hdc, bounds.Left, bounds.Top, PlatformAPI.SRCCOPY);
            grx.ReleaseHdc(hdc);
            return res;
        }

        public static Bitmap Clip(this Bitmap source, Rectangle bounds) {
            var grx = Graphics.FromImage(source);
            return grx.GetSS(bounds);
        }

        
        public static Color BackgroundImageColor(this Bitmap bmp) {
            return bmp.GetPixel(0, 0);
        }
              

        public static Bitmap GetBitmap(string name) {
            Bitmap bmp = null;
            var asm = Assembly.GetExecutingAssembly();
            var resNames = asm.GetManifestResourceNames();
            foreach (string s in resNames) {
                if (s.IndexOf(name) > 0) {
                    using (var imgStream = asm.GetManifestResourceStream(s)) {
                        if (!(null == imgStream)) {
                            bmp = new Bitmap(imgStream);
                            if (!(null == bmp)) {
                                return bmp;
                            }
                            bmp = null;
                            imgStream.Close();
                        }
                    }
                }
            }
            return null;
        }
    }

    public static class Brushes {
        public static Brush White { get { return new SolidBrush(Color.White); } }
        public static Brush ControlDark { get { return new SolidBrush(SystemColors.ControlDark); } }
    }



    [StructLayout(LayoutKind.Sequential)]
    internal struct Rect {
        public int Left, Top, Right, Bottom;
        public static implicit operator Rectangle(Rect value) {
            return new Rectangle(value.Left, value.Top, value.Right - value.Left, value.Bottom - value.Top);
        }

        public static implicit operator Rect(Rectangle value) {
            return new Rect() { Top = value.Top, Left = value.Left, Bottom = value.Bottom, Right = value.Right };
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct POINT {
        public int X;
        public int Y;

        public POINT(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public static implicit operator System.Drawing.Point(POINT p) {
            return new System.Drawing.Point(p.X, p.Y);
        }

        public static implicit operator POINT(System.Drawing.Point p) {
            return new POINT(p.X, p.Y);
        }
    }


    internal class PlatformAPI {
        [DllImport("coredll.dll")]
        public static extern int DrawText(IntPtr hDC, string lpString, int nCount, ref Rect lpRect, uint uFormat);

        [DllImport("coredll.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("coredll.dll")]
        public static extern int BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

        public const uint SRCCOPY = 0x00CC0020;
    }
}
