using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace NeuSoft.Client.Common.Controls
{
    public class CountButton : Pane
    {
        const int OFFSET = 8;
        const int RADIUS = 8;
        bool enter;
        Color haloColor;
        int count;

        public override Size MinimumSize { get => new Size(60, 60); }

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
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                if (base.ForeColor == value)
                {
                    return;
                }
                base.ForeColor = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                if (base.Font == value)
                {
                    return;
                }
                base.Font = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        public virtual int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (count == value)
                {
                    return;
                }
                count = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        void Initialize()
        {
            enter = false;
            haloColor = Color.White;
            count = 0;
            base.ForeColor = Color.White;
            base.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
        }

        public CountButton() : base() => Initialize();

        public CountButton(Control parent) : base(parent) => Initialize();

        public CountButton(Control parent, int left, int top, int width, int height) : base(parent, left, top, width, height) => Initialize();

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Focus();
            if (AutoUpdate)
            {
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (AutoUpdate)
            {
                Invalidate();
            }
            base.OnLostFocus(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(BackColor);
            var core = new Rectangle(OFFSET, OFFSET, Size.Width - OFFSET * 2, Size.Height - OFFSET * 2);
            Pen pen = new Pen(BackColor);
            foreach (var halo in core.Shadow(RADIUS, 4, BackColor))
            {
                pen.Color = halo.Key;
                g.DrawPath(pen, halo.Value);
            }
            var foreColor = ForeColor;
            var backColor = Color.DodgerBlue;
            if (Focused || enter)
            {
                foreColor = backColor;
                backColor = ForeColor;
                g.FillPath(new SolidBrush(backColor), core.CreateRound(RADIUS));
                g.DrawPath(new Pen(foreColor, 2), core.Extend(1).CreateRound(RADIUS));
            }
            else
            {
                g.FillPath(new SolidBrush(backColor), core.CreateRound(RADIUS));
            }
            if (Font != null)
            {
                if (Text != null && Text.Trim() != string.Empty)
                {
                    var font = new Font(Font.FontFamily, Math.Min(Width, Height) / 6f,
                        Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
                    var text = core.Extend(OFFSET);
                    g.DrawString(Text, font, new SolidBrush(foreColor), text, new StringFormat(StringFormatFlags.NoClip)
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
                }
                if (Count > 0)
                {
                    var text = Count > 99 ? "99+" : Count.ToString();
                    var font = new Font("Arial Narrow", Math.Min(Width, Height) / 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
                    var size = TextRenderer.MeasureText("99+", font);
                    var width = Math.Max(size.Width, size.Height);
                    var count = new Rectangle(Width - width, 0, width, width);
                    g.FillPath(Brushes.Red, count.CreateRound(width / 2));
                    g.DrawString(text, font, Brushes.White, count, new StringFormat(StringFormatFlags.NoClip)
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
                }
            }
        }
    }
}
