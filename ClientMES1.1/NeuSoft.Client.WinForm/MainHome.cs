using NeuSoft.Client.WinForm.Modular;
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
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MainHome : Form
    {
        AutoSizeFormClass autoSizeFormClass = new AutoSizeFormClass();
        WebBrowser webBrowser = new WebBrowser();
        public MainHome()
        {
            InitializeComponent();
            SetFormControlDefaltValue();
            SetFormStyle();
            autoSizeFormClass.controllInitializeSize(this);
            autoSizeFormClass.controlAutoSize(this);
            this.SizeChanged += MainHome_SizeChanged;

        }

        private void MainHome_SizeChanged(object sender, EventArgs e)
        {
            autoSizeFormClass.controlAutoSize(this);
        //    SetFormBusinessMessageByCountsStyle();
        }

        private void SetFormControlDefaltValue()
        {
            this.panelForTopBorder.Width = this.Width;
        }

        public void SetFormStyle()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.btnForExitLogin.Anchor = AnchorStyles.Right;
            this.panelForTopBorder.Dock = DockStyle.Top;
        }
        public void SetFormBusinessMessageByCountsStyle()
        {
            int top = (panelForLogoMainHomeImage.Height / 2 + panelForLogoMainHomeImage.Top) - (lableForFormTitle.Height / 2);
            lableForFormTitle.Location = new Point(this.lableForFormTitle.Left, top);
        }

        private void btnForExitLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

 
    }
}
