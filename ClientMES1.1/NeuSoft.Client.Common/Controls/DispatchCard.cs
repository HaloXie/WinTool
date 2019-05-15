using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace NeuSoft.Client.Common.Controls
{
    public class DispatchCard : Pane
    {
        const int OFFSET = 8;
        const int RADIUS = 8;
        bool selected;
        Color stateColor;
        bool enter;
        Color haloColor;
        bool refreshed;
        string title;
        Color titleColor;

        public override Size MinimumSize { get => new Size(100, 100); }

        void Initialize()
        {
            selected = false;
            stateColor = Color.Green;
            enter = false;
            haloColor = Color.DodgerBlue;
            refreshed = false;
            base.ForeColor = Color.DimGray;
            base.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            titleColor = Color.Black;
        }

        public DispatchCard() : base() => Initialize();

        public DispatchCard(Control parent) : base(parent) => Initialize();

        public DispatchCard(Control parent, int left, int top, int width, int height) : base(parent, left, top, width, height) => Initialize();

        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                if (selected == value)
                {
                    return;
                }
                selected = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        Rectangle StateBounds
        {
            get
            {
                int radius = (Math.Min(Width, Height) - OFFSET * 2) / 20;
                return radius < 1 ? Rectangle.Empty : new Rectangle(OFFSET + radius, OFFSET + radius, radius * 2, radius * 2);
            }
        }

        Rectangle RefreshBounds
        {
            get
            {
                var bounds = StateBounds;
                return bounds == Rectangle.Empty ? Rectangle.Empty : new Rectangle(Width - bounds.X - bounds.Width, bounds.Y, bounds.Width, bounds.Height);
            }
        }

        public virtual Color StateColor
        {
            get
            {
                return stateColor;
            }
            set
            {
                if (stateColor == value)
                {
                    return;
                }
                stateColor = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        public virtual Color HaloColor
        {
            get
            {
                return haloColor;
            }
            set
            {
                if (haloColor == value)
                {
                    return;
                }
                haloColor = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
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

        public virtual string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (title == value)
                {
                    return;
                }
                title = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }

        public virtual Color TitleColor
        {
            get
            {
                return titleColor;
            }
            set
            {
                if (titleColor == value)
                {
                    return;
                }
                titleColor = value;
                if (AutoUpdate)
                {
                    Invalidate();
                }
            }
        }


        public event EventHandler RefreshClick;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            refreshed = RefreshBounds.Contains(new Point(e.X, e.Y));
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (refreshed && refreshed == RefreshBounds.Contains(new Point(e.X, e.Y)))
            {
                RefreshClick?.Invoke(this, EventArgs.Empty);
            }
            refreshed = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            enter = true;
            if (AutoUpdate)
            {
                Invalidate();
            }
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            enter = false;
            if (AutoUpdate)
            {
                Invalidate();
            }
            base.OnMouseLeave(e);
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
            foreach (var halo in core.Shadow(RADIUS, BackColor))
            {
                pen.Color = halo.Key;
                g.DrawPath(pen, halo.Value);
            }
            g.FillPath(Brushes.White, core.CreateRound(RADIUS));
            if (Focused || enter)
            {
                g.DrawPath(new Pen(HaloColor, 2), core.Extend(1).CreateRound(RADIUS));
            }
            var state = StateBounds;
            var stateBrush = new SolidBrush(StateColor);
            if (state != Rectangle.Empty)
            {
                g.FillPath(stateBrush, state.CreateRound(state.Width / 2));
            }
            var refresh = RefreshBounds;
            if (refresh != Rectangle.Empty)
            {
                refresh.Inflate(-2, -2);
                var paths = refresh.CreateRecycle(refresh.Width / 2, 30);
                pen = new Pen(Color.FromArgb(157, Color.Gray), refresh.Width / (float)RADIUS);
                g.DrawPath(pen, paths[0]);
                g.DrawPath(pen, paths[1]);
                if (paths[2] != null)
                {
                    pen.Width = 1;
                    g.FillPath(new SolidBrush(pen.Color), paths[2]);
                    g.FillPath(new SolidBrush(pen.Color), paths[3]);
                }
            }
            var pic = new Rectangle(core.X + core.Width * 3 / 10, state.Bottom + state.Height / 2, core.Width * 2 / 5, core.Height * 2 / 5);
            if (BackgroundImage == null)
            {
                int cut = Math.Min(pic.Width, pic.Height) / 4;
                g.FillPath(stateBrush, pic.CreateRoundClip(Math.Min(Width, Height) / Math.Min(MinimumSize.Width, MinimumSize.Height), cut));
                int offset = (Math.Min(Size.Width, Size.Height) - OFFSET * 2) / 48;
                g.FillPath(Brushes.White, pic.Extend(-offset).CreateRoundClip(1, cut - offset / 2));
                if (offset / 2 > 0)
                {
                    var rect = new Rectangle(pic.X + pic.Width / 6, pic.Y + pic.Height / 3, pic.Width * 2 / 3, offset);
                    g.FillPath(stateBrush, rect.CreateRound(offset / 2));
                    rect = new Rectangle(rect.X, rect.Y + pic.Height / 8, rect.Width, rect.Height);
                    g.FillPath(stateBrush, rect.CreateRound(offset / 2));
                    rect = new Rectangle(rect.X, rect.Y + pic.Height / 8, rect.Width, rect.Height);
                    g.FillPath(stateBrush, rect.CreateRound(offset / 2));
                    rect = new Rectangle(rect.X, rect.Y + pic.Height / 8, rect.Width / 2, rect.Height);
                    g.FillPath(stateBrush, rect.CreateRound(offset / 2));
                }
                else
                {
                    var rect = new Rectangle(pic.X + pic.Width / 6, pic.Y + pic.Height / 3, pic.Width * 2 / 3, offset);
                    g.FillRectangle(stateBrush, rect);
                    rect = new Rectangle(rect.X, rect.Y + pic.Height / 8, rect.Width, rect.Height);
                    g.FillRectangle(stateBrush, rect);
                    rect = new Rectangle(rect.X, rect.Y + pic.Height / 8, rect.Width, rect.Height);
                    g.FillRectangle(stateBrush, rect);
                    rect = new Rectangle(rect.X, rect.Y + pic.Height / 8, rect.Width / 2, rect.Height);
                    g.FillRectangle(stateBrush, rect);
                }
            }
            if (Font != null)
            {
                var bottom = pic.Bottom;
                if (Title != null && Title.Trim() != string.Empty)
                {
                    var font = new Font(Font.FontFamily, Math.Min(Width, Height) / 18f,
                        FontStyle.Bold, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
                    var text = new Rectangle(state.X, bottom + state.Height, refresh.Right - state.X, state.Height * 3 / 2);
                    g.DrawString(Title, font, new SolidBrush(TitleColor), text, new StringFormat(StringFormatFlags.NoClip));
                    bottom += text.Height;
                }
                if (Text != null && Text.Trim() != string.Empty)
                {
                    var font = new Font(Font.FontFamily, Math.Min(Width, Height) / 24f,
                        Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
                    var text = new Rectangle(state.X, bottom + state.Height, refresh.Right - state.X, core.Bottom - bottom - state.Height * 2);
                    g.DrawString(Text, font, new SolidBrush(ForeColor), text, new StringFormat(StringFormatFlags.NoClip));
                }
            }
        }
    }
}
