using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TransButton {
    public class ImagePanel : Panel, IHaveImage {

        public Bitmap Image { get; set; }

        protected override void OnPaintBackground(PaintEventArgs e) {
            e.Graphics.DrawImage(Image, 0, 0);
        }
    }
}
