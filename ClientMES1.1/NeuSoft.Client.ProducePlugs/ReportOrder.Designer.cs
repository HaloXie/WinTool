namespace NeuSoft.Client.ProducePlugs
{
    partial class ReportOrder
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
            this.dispatchCard1 = new NeuSoft.Client.Common.Controls.DispatchCard();
            this.dispatchCard2 = new NeuSoft.Client.Common.Controls.DispatchCard();
            this.dispatchCard3 = new NeuSoft.Client.Common.Controls.DispatchCard();
            this.SuspendLayout();
            // 
            // dispatchCard1
            // 
            this.dispatchCard1.AutoUpdate = true;
            this.dispatchCard1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dispatchCard1.ForeColor = System.Drawing.Color.DimGray;
            this.dispatchCard1.HaloColor = System.Drawing.Color.DodgerBlue;
            this.dispatchCard1.Location = new System.Drawing.Point(268, 110);
            this.dispatchCard1.MinimumSize = new System.Drawing.Size(100, 100);
            this.dispatchCard1.Name = "dispatchCard1";
            this.dispatchCard1.Selected = false;
            this.dispatchCard1.Size = new System.Drawing.Size(317, 344);
            this.dispatchCard1.StateColor = System.Drawing.Color.Green;
            this.dispatchCard1.TabIndex = 0;
            this.dispatchCard1.Text = "dispatchCard1";
            this.dispatchCard1.Title = null;
            this.dispatchCard1.TitleColor = System.Drawing.Color.Black;
            // 
            // dispatchCard2
            // 
            this.dispatchCard2.AutoUpdate = true;
            this.dispatchCard2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dispatchCard2.ForeColor = System.Drawing.Color.DimGray;
            this.dispatchCard2.HaloColor = System.Drawing.Color.DodgerBlue;
            this.dispatchCard2.Location = new System.Drawing.Point(16, 145);
            this.dispatchCard2.MinimumSize = new System.Drawing.Size(100, 100);
            this.dispatchCard2.Name = "dispatchCard2";
            this.dispatchCard2.Selected = false;
            this.dispatchCard2.Size = new System.Drawing.Size(246, 287);
            this.dispatchCard2.StateColor = System.Drawing.Color.Green;
            this.dispatchCard2.TabIndex = 1;
            this.dispatchCard2.Text = "dispatchCard2";
            this.dispatchCard2.Title = null;
            this.dispatchCard2.TitleColor = System.Drawing.Color.Black;
            // 
            // dispatchCard3
            // 
            this.dispatchCard3.AutoUpdate = true;
            this.dispatchCard3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dispatchCard3.ForeColor = System.Drawing.Color.DimGray;
            this.dispatchCard3.HaloColor = System.Drawing.Color.DodgerBlue;
            this.dispatchCard3.Location = new System.Drawing.Point(604, 145);
            this.dispatchCard3.MinimumSize = new System.Drawing.Size(100, 100);
            this.dispatchCard3.Name = "dispatchCard3";
            this.dispatchCard3.Selected = false;
            this.dispatchCard3.Size = new System.Drawing.Size(246, 287);
            this.dispatchCard3.StateColor = System.Drawing.Color.Green;
            this.dispatchCard3.TabIndex = 2;
            this.dispatchCard3.Text = "dispatchCard3";
            this.dispatchCard3.Title = null;
            this.dispatchCard3.TitleColor = System.Drawing.Color.Black;
            // 
            // ReportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dispatchCard3);
            this.Controls.Add(this.dispatchCard2);
            this.Controls.Add(this.dispatchCard1);
            this.Name = "ReportOrder";
            this.Size = new System.Drawing.Size(878, 633);
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.DispatchCard dispatchCard1;
        private Common.Controls.DispatchCard dispatchCard2;
        private Common.Controls.DispatchCard dispatchCard3;
    }
}
