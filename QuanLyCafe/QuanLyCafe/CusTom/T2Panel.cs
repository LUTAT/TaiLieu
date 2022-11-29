using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PhanMemQuanLyQuanCafe.Custom
{
    internal class T2Panel : Panel
    {

        private int boderRadius = 30;
        private float gradientAngel = 30;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.DodgerBlue;

        //Constructor
        public T2Panel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 300);

        }



        //properties
        public int BoderRadius
        {
            get => boderRadius;
            set { boderRadius = value; this.Invalidate(); }
        }
        public float GradientAngel
        {
            get => gradientAngel;
            set { gradientAngel = value; this.Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
        }

        //methods

        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        //Overrident methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.gradientAngel);
            Graphics graphicsArtant = e.Graphics;
            graphicsArtant.FillRectangle(brush, ClientRectangle);

            //BoderRadius

           RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (boderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, boderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor,2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}
