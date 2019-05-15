using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuSoft.Client.Common.Controls
{
    public class UserViewer : Pane
    {
        UserView user;

        public override Size MinimumSize => new Size(360, 60);

        public UserView User
        {
            get
            {
                return user;
            }
            set
            {
                if (user == value)
                {
                    return;
                }
                user = value;
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

        public UserViewer()
        {
            base.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(Color.FromArgb(240, 248, 250));
            var font = new Font(Font.FontFamily, Math.Min(Width / 6, Height / 2) / 4f,
                FontStyle.Bold, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            var rect = new Rectangle(0, 0, Width / 6, Height);
            g.DrawLine(new Pen(Color.FromArgb(229, 237, 239)), rect.Right, Height / 6, rect.Right, Height * 5 / 6);
            rect = new Rectangle(rect.Right, rect.Height / 6, rect.Width, rect.Height / 3);
            g.DrawString("  工作产线:", font, new SolidBrush(ForeColor), rect,
                new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            rect.Offset(0, rect.Height);
            g.DrawString("  操作工序:", font, new SolidBrush(ForeColor), rect,
                new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            rect.Offset(rect.Width, 0);
            g.DrawString("  工作工位:", font, new SolidBrush(ForeColor), rect,
                new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            rect.Offset(0, -rect.Height);
            g.DrawString("  工作单元:", font, new SolidBrush(ForeColor), rect,
                new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            rect.Offset(rect.Width, 0);
            g.DrawString("  工作中心:", font, new SolidBrush(ForeColor), rect,
                new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            rect.Offset(0, rect.Height);
            g.DrawString("  操作人员:", font, new SolidBrush(ForeColor), rect,
                new StringFormat(StringFormatFlags.NoClip) { LineAlignment = StringAlignment.Center });
            g.DrawLine(new Pen(Color.FromArgb(229, 237, 239)), rect.Right, Height / 6, rect.Right, Height * 5 / 6);
        }
    }
}
