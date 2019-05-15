using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuSoft.Client.Contract;

namespace NeuSoft.Client.QualityPlugs
{
    [Plugin("05f6a5dd-5549-4c1f-b8f6-6461628f0b2b", "质量检验", AsVisual = true, GroupId = 2, Power = 0, Weight = 2)]
    public partial class QualityCheck : UserControl, IPlugin
    {
        public QualityCheck()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public bool Block(PluginMessage message)
        {
            return false;
        }
    }
}
