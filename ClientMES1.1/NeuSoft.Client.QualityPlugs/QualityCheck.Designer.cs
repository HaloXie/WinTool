namespace NeuSoft.Client.QualityPlugs
{
    partial class QualityCheck
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dispatchCardGroup1 = new NeuSoft.Client.Common.Controls.DispatchCardGroup();
            this.userViewer1 = new NeuSoft.Client.Common.Controls.UserViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dispatchCardGroup1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userViewer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dispatchCardGroup1
            // 
            this.dispatchCardGroup1.AutoUpdate = true;
            this.dispatchCardGroup1.CurrentIndex = -1;
            this.dispatchCardGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dispatchCardGroup1.Location = new System.Drawing.Point(3, 87);
            this.dispatchCardGroup1.MinimumSize = new System.Drawing.Size(200, 200);
            this.dispatchCardGroup1.Name = "dispatchCardGroup1";
            this.dispatchCardGroup1.Size = new System.Drawing.Size(994, 510);
            this.dispatchCardGroup1.TabIndex = 0;
            this.dispatchCardGroup1.Text = "dispatchCardGroup1";
            // 
            // userViewer1
            // 
            this.userViewer1.AutoUpdate = true;
            this.userViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userViewer1.Location = new System.Drawing.Point(3, 3);
            this.userViewer1.MinimumSize = new System.Drawing.Size(360, 60);
            this.userViewer1.Name = "userViewer1";
            this.userViewer1.Size = new System.Drawing.Size(994, 78);
            this.userViewer1.TabIndex = 1;
            this.userViewer1.Text = "userViewer1";
            this.userViewer1.User = null;
            // 
            // QualityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QualityCheck";
            this.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.DispatchCardGroup dispatchCardGroup1;
        private Common.Controls.UserViewer userViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
