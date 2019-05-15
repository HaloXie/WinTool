using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuSoft.Client.Common.Controls
{
    public class DispatchCardGroup : Pane
    {
        int currentIndex = -1;
        bool leftOver = false;
        bool rightOver = false;
        bool leftDown = false;
        bool rightDown = false;

        public override Size MinimumSize { get => new Size(200, 200); }

        public IList<DispatchCard> Cards { get; }

        public int CurrentIndex
        {
            get
            {
                return currentIndex;
            }
            set
            {
                if (value < 0 || value >= Cards.Count)
                {
                    currentIndex = -1;
                }
                else
                {
                    currentIndex = value;
                }
                Invalidate(LeftBounds);
                Invalidate(RightBounds);
            }
        }

        Rectangle LeftBounds => new Rectangle(25, Height / 2 - 50, 50, 100);

        Rectangle RightBounds
        {
            get
            {
                var left = LeftBounds;
                return new Rectangle(Width - left.Right, left.Y, left.Width, left.Height);
            }
        }

        bool LeftEnabled => CurrentIndex > 0;

        bool RightEnabled => CurrentIndex < Cards.Count - 1;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            var left = LeftBounds;
            var right = RightBounds;
            if (leftDown = left.Contains(new Point(e.X, e.Y)))
            {
                //Invalidate(left);
            }
            else if (rightDown = right.Contains(new Point(e.X, e.Y)))
            {
                //Invalidate(right);
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var left = LeftBounds;
            var right = RightBounds;
            bool over;
            if (leftOver != (over = left.Contains(new Point(e.X, e.Y))))
            {
                Invalidate(left);
                leftOver = over;
            }
            if (rightOver != (over = right.Contains(new Point(e.X, e.Y))))
            {
                Invalidate(right);
                rightOver = over;
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            leftOver = false;
            rightOver = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(229, 237, 239));
            var color = Color.FromArgb(240, 248, 250);
            GraphicsPath path;
            var left = LeftBounds;
            g.FillPath(new SolidBrush(color), path = left.CreateRound(8));
            var arrow = new GraphicsPath();
            arrow.AddLine(left.X + left.Width / 3, left.Y + left.Height / 2, left.X + left.Width * 2 / 3 - 8, left.Y + left.Height / 4);
            arrow.AddLine(left.X + left.Width * 2 / 3, left.Y + left.Height / 4 + 8, left.X + left.Width / 3 + 8, left.Y + left.Height / 2);
            arrow.AddLine(left.X + left.Width / 3 + 8, left.Y + left.Height / 2, left.X + left.Width * 2 / 3, left.Y + left.Height * 3 / 4 - 8);
            arrow.AddLine(left.X + left.Width * 2 / 3 - 8, left.Y + left.Height * 3 / 4, left.X + left.Width / 3, left.Y + left.Height / 2);
            arrow.CloseFigure();
            if (LeftEnabled)
            {
                g.FillPath(new SolidBrush(Color.DimGray), arrow);
            }
            else
            {
                g.FillPath(new SolidBrush(Color.FromArgb(229, 237, 239)), arrow);
            }
            if (leftOver)
            {
                g.DrawPath(Pens.White, path);
                g.DrawPath(Pens.White, arrow);
            }
            var right = RightBounds;
            g.FillPath(new SolidBrush(color), path = right.CreateRound(8));
            arrow = new GraphicsPath();
            arrow.AddLine(right.X + right.Width / 3 + 8, right.Y + right.Height / 4, right.X + right.Width * 2 / 3, right.Y + right.Height / 2);
            arrow.AddLine(right.X + right.Width * 2 / 3, right.Y + right.Height / 2, right.X + right.Width / 3 + 8, right.Y + right.Height * 3 / 4);
            arrow.AddLine(right.X + right.Width / 3, right.Y + right.Height * 3 / 4 - 8, right.X + right.Width * 2 / 3 - 8, right.Y + right.Height / 2);
            arrow.AddLine(right.X + right.Width * 2 / 3 - 8, right.Y + right.Height / 2, right.X + right.Width / 3, right.Y + right.Height / 4 + 8);
            arrow.CloseFigure();
            if (LeftEnabled)
            {
                g.FillPath(new SolidBrush(Color.DimGray), arrow);
            }
            else
            {
                g.FillPath(new SolidBrush(Color.FromArgb(229, 237, 239)), arrow);
            }
            if (rightOver)
            {
                g.DrawPath(Pens.White, path);
                g.DrawPath(Pens.White, arrow);
            }
        }
    }
}
