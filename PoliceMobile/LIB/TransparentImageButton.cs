using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace TransButton {
    public class TransparentImageButton : Control, IHaveImage {
        #region vars
        private bool _isPressed;
        private StringFormat _stringFormat;
        private Rectangle _buttonTextRect = Rectangle.Empty;
        private Brush _foreBrush;
        private Bitmap _imgOffscreen;
        
        #endregion

        #region ctor
        public TransparentImageButton() : base() {
            _stringFormat = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            _foreBrush = new SolidBrush(this.ForeColor);
        }
        #endregion

        #region props
        public Bitmap Image { get; set; }

        public Bitmap PressedImage {get;set;}
        
        public StringFormat StringFormat {
            get { return _stringFormat; }
        }

        public override Color ForeColor {
            get {
                return base.ForeColor;
            }
            set {
                base.ForeColor = value;
                _foreBrush = new SolidBrush(base.ForeColor);
            }
        }
        #endregion

        #region onverrides

        protected override void Dispose(bool disposing) {
            if (Image != null) {
                Image.Dispose();
                Image = null;
            }
            if (PressedImage != null) {
                PressedImage.Dispose();
                PressedImage = null;
            }

            if (_imgOffscreen != null) {
                _imgOffscreen.Dispose();
                _imgOffscreen = null;
            }
            
            base.Dispose(disposing);
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
            //prevent
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics gxOff; 
            Rectangle imgRect;
            var image = (_isPressed && PressedImage != null) ? PressedImage : Image;

            if (_imgOffscreen == null) {
                _imgOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
            }

            gxOff = Graphics.FromImage(_imgOffscreen);

            gxOff.Clear(this.BackColor);            


            //if (!_isPressed) backBrush = new SolidBrush(Parent.BackColor);
            //else  backBrush = new SolidBrush(Color.LightGray);

            //gxOff.FillRectangle(backBrush, this.ClientRectangle);

            if (this.Parent is IHaveImage) {
                var par = this.Parent as IHaveImage;
                gxOff.DrawImage(par.Image.Clip(this.Bounds), 0, 0);
            }

            //if (_imgUdrscreen != null) {
            //    gxOff.DrawImage(_imgUdrscreen, 0, 0);
            //}

            if (image != null) {
                var imageLeft = (this.Width - image.Width) / 2;
                var imageTop = (this.Height - image.Height) / 2;

                if (!_isPressed) imgRect = new Rectangle(imageLeft, imageTop, image.Width, image.Height);
                else imgRect = new Rectangle(imageLeft + 1, imageTop + 1, image.Width, image.Height);
               
                var imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(image.BackgroundImageColor(), image.BackgroundImageColor());
                gxOff.DrawImage(image, imgRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttr);
            }

            if (_isPressed) {
                var rc = this.ClientRectangle;
                rc.Width--;
                rc.Height--;
                gxOff.DrawRectangle(new Pen(Color.Black), rc);
            }

            e.Graphics.DrawImage(_imgOffscreen, 0, 0);

            base.OnPaint(e);
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            _isPressed = this.Focused; this.Invalidate();
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e) {
            _isPressed = false; this.Invalidate();
            base.OnKeyUp(e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            _isPressed = this.Focused; this.Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            _isPressed = false; this.Invalidate();
            base.OnMouseUp(e);
        }
        #endregion       
    }
}
