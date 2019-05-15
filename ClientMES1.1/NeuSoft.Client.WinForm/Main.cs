using NeuSoft.Client.Common.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuSoft.Client.WinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Entries = new List<CountButton>();
        }

        internal List<CountButton> Entries
        {
            get;
        }

        protected override void OnLoad(EventArgs e)
        {
            PluginDriver.Initialize(null);
            var visuals = new List<Control>();
            string module = null;
            foreach (var plugin in PluginDriver.GetVisuals())
            {
                var control = FromHandle(plugin.Value.Handle);
                control.Dock = DockStyle.Fill;
                layout.SetRow(control, 1);
                visuals.Add(control);
                var button = new CountButton { Parent = flow, Width = 160, Height = 80, Text = plugin.Key.Name, Count = 10 };
                Entries.Add(button);
                button.Click += delegate
                {
                    foreach (var visual in visuals)
                    {
                        if (visual == control)
                        {
                            continue;
                        }
                        visual.Parent = null;
                    }
                    control.Parent = layout;
                    title.Text = button.Text;
                };
                if (module == null)
                {
                    module = button.Text;
                }
            }
            if (module != null)
            {
                visuals[0].Parent = layout;
                title.Text = module;
            }
        }
    }
}
