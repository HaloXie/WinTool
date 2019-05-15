using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NeuSoft.Client.Common
{
    public static class gdi
    {
        public static Rectangle Extend(this Rectangle rect, int offset)
            => new Rectangle(rect.X - offset, rect.Y - offset, rect.Width + offset * 2, rect.Height + offset * 2);

        public static RectangleF Extend(this RectangleF rect, float offset)
            => new RectangleF(rect.X - offset, rect.Y - offset, rect.Width + offset * 2, rect.Height + offset * 2);

        public static GraphicsPath CreateRound(this Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static GraphicsPath CreateRoundClip(this Rectangle rect, int radius, int cut)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.Right - cut, rect.Y, rect.Right, rect.Y + cut);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static GraphicsPath[] CreateRecycle(this Rectangle rect, int radius, float gapAngle)
        {
            var paths = new GraphicsPath[4];
            paths[0] = new GraphicsPath();
            paths[0].AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            paths[0].AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90 - gapAngle);
            paths[1] = new GraphicsPath();
            paths[1].AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            paths[1].AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90 - gapAngle);
            int w = rect.Width / 4;
            int h = rect.Height / 4;
            if (w > 1 && h > 1)
            {
                var arrow = new Rectangle(new Point(rect.X - w, rect.Y + h * 2), new Size(w * 2, h));
                paths[2] = new GraphicsPath();
                paths[2].AddLine(arrow.X, arrow.Y, arrow.Right, arrow.Y);
                paths[2].AddLine(arrow.Right, arrow.Y, (arrow.X + arrow.Right) / 2, arrow.Bottom);
                paths[2].AddLine((arrow.X + arrow.Right) / 2, arrow.Bottom, arrow.X, arrow.Y);
                arrow = new Rectangle(new Point(rect.Right - w, rect.Y + h + 1), new Size(w * 2, h));
                paths[3] = new GraphicsPath();
                paths[3].AddLine(arrow.X, arrow.Bottom, arrow.Right, arrow.Bottom);
                paths[3].AddLine(arrow.Right, arrow.Bottom, (arrow.X + arrow.Right) / 2, arrow.Y);
                paths[3].AddLine((arrow.X + arrow.Right) / 2, arrow.Y, arrow.X, arrow.Bottom);
            }
            return paths;
        }

        public static IEnumerable<KeyValuePair<Color, GraphicsPath>> Shadow(this Rectangle rect, int radius, int halos, Color shadowColor, Color backColor)
        {
            var or = backColor.R > shadowColor.R ? (backColor.R - shadowColor.R) / halos : 0;
            var og = backColor.G > shadowColor.G ? (backColor.G - shadowColor.G) / halos : 0;
            var ob = backColor.B > shadowColor.B ? (backColor.B - shadowColor.B) / halos : 0;
            yield return new KeyValuePair<Color, GraphicsPath>(Color.FromArgb(shadowColor.R, shadowColor.G, shadowColor.B), CreateRound(rect, radius));
            for (int i = 1; i < halos; i++)
            {
                var color = Color.FromArgb(shadowColor.R + or * i, shadowColor.G + og * i, shadowColor.B + ob * i);
                yield return new KeyValuePair<Color, GraphicsPath>(color, CreateRound(
                    new Rectangle(new Point(rect.Location.X - i, rect.Location.Y - i),
                    new Size(rect.Width + 2 * i, rect.Height + 2 * i)), radius + i));
                yield return new KeyValuePair<Color, GraphicsPath>(color, CreateRound(
                    new Rectangle(new Point(rect.Location.X - i, rect.Location.Y - i),
                    new Size(rect.Width + 2 * i, rect.Height + 2 * i)), radius + i + 1));
            }
        }

        public static IEnumerable<KeyValuePair<Color, GraphicsPath>> Shadow(this Rectangle rect, int radius, Color shadowColor, Color backColor)
            => rect.Shadow(radius, 8, shadowColor, backColor);

        public static IEnumerable<KeyValuePair<Color, GraphicsPath>> Shadow(this Rectangle rect, int radius, int halos, Color backColor)
            => rect.Shadow(radius, halos, Color.FromArgb(195, 195, 195), backColor);

        public static IEnumerable<KeyValuePair<Color, GraphicsPath>> Shadow(this Rectangle rect, int radius, Color backColor)
            => rect.Shadow(radius, 8, Color.FromArgb(195, 195, 195), backColor);
    }
}
