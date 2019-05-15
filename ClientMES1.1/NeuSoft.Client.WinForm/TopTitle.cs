using System.Windows.Forms;
using NeuSoft.Client.Common.Controls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using NeuSoft.Client.Common;
using System;

namespace NeuSoft.Client.WinForm
{
    public class TopTitle : Control
    {
        static GraphicsPath CreatePath(Rectangle rect)
        {
            var path = new GraphicsPath();
            path.AddLine(rect.X + rect.Width / 2, rect.Y, rect.Right, rect.Y + rect.Height / 4);
            path.AddLine(rect.Right, rect.Bottom - rect.Height / 4, rect.X + rect.Width / 2, rect.Bottom);
            path.AddLine(rect.X, rect.Bottom - rect.Height / 4, rect.X, rect.Y + rect.Height / 4);
            path.CloseFigure();
            return path;
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (base.Text == value)
                {
                    return;
                }
                base.Text = value;
                Invalidate();
            }
        }

        public override Size MinimumSize { get => new Size(60, 60); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(Color.SteelBlue);
            var height = Height / 3;
            var icon = new Rectangle(height, height, height, height);
            g.FillPath(Brushes.White, CreatePath(icon.Extend(8)));
            g.FillPath(Brushes.SteelBlue, CreatePath(icon.Extend(5)));
            g.FillPath(Brushes.White, CreatePath(icon));
            if (Text != null && Text.Trim() != string.Empty)
            {
                var font = new Font(Font.FontFamily, Math.Min(Width, Height) / 4f,
                    Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
                g.DrawString(Text, font, Brushes.White, height * 3, Height / 2,
                    new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            }
        }
    }
}
