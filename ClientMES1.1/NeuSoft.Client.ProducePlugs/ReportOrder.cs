using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuSoft.Client.Contract;

namespace NeuSoft.Client.ProducePlugs
{
    [Plugin("a9a36d17-85bc-4b0d-b743-45e4a501ce2d", "生产报工", AsVisual = true, GroupId = 1, Power = 0, Weight = 1)]
    public partial class ReportOrder : UserControl, IPlugin
    {
        public ReportOrder()
        {
            InitializeComponent();
        }

        public bool Block(PluginMessage message)
        {
            return false;
        }
    }
}
