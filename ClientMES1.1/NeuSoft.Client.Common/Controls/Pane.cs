using System.Windows.Forms;

namespace NeuSoft.Client.Common.Controls
{
    public abstract class Pane : Control
    {
        bool autoUpdate;

        public Pane() : base() => Initialize();

        public Pane(Control parent) : base(parent, null) => Initialize();

        public Pane(Control parent, int left, int top, int width, int height) : base(parent, null, left, top, width, height) => Initialize();

        void Initialize()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.Selectable
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint,
                true);
            UpdateStyles();
            DoubleBuffered = true;
            autoUpdate = true;
        }

        public bool AutoUpdate
        {
            get
            {
                return autoUpdate;
            }
            set
            {
                if (autoUpdate == value)
                {
                    return;
                }
                if (autoUpdate = value)
                {
                    Invalidate();
                }
            }
        }
    }
}
