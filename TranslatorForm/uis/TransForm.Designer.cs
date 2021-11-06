namespace TranslatorForm
{
    partial class TransForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uitbxSrc = new Sunny.UI.UITextBox();
            this.uitbxDst = new Sunny.UI.UITextBox();
            this.uicbxSrc = new Sunny.UI.UIComboBox();
            this.uicbxDst = new Sunny.UI.UIComboBox();
            this.uibtnSwap = new Sunny.UI.UIButton();
            this.uibtnClr = new Sunny.UI.UIButton();
            this.uilblCR = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uitbxSrc
            // 
            this.uitbxSrc.ButtonSymbol = 61761;
            this.uitbxSrc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxSrc.FillColor = System.Drawing.Color.White;
            this.uitbxSrc.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxSrc.ForeColor = System.Drawing.Color.DimGray;
            this.uitbxSrc.Location = new System.Drawing.Point(23, 94);
            this.uitbxSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxSrc.Maximum = 2147483647D;
            this.uitbxSrc.Minimum = -2147483648D;
            this.uitbxSrc.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxSrc.Multiline = true;
            this.uitbxSrc.Name = "uitbxSrc";
            this.uitbxSrc.ShowScrollBar = true;
            this.uitbxSrc.Size = new System.Drawing.Size(506, 361);
            this.uitbxSrc.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxSrc.TabIndex = 1;
            this.uitbxSrc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitbxSrc.Leave += new System.EventHandler(this.UITextBox_Leave);
            this.uitbxSrc.Enter += new System.EventHandler(this.UITextBox_Enter);
            // 
            // uitbxDst
            // 
            this.uitbxDst.ButtonSymbol = 61761;
            this.uitbxDst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxDst.FillColor = System.Drawing.Color.White;
            this.uitbxDst.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxDst.Location = new System.Drawing.Point(537, 94);
            this.uitbxDst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxDst.Maximum = 2147483647D;
            this.uitbxDst.Minimum = -2147483648D;
            this.uitbxDst.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxDst.Multiline = true;
            this.uitbxDst.Name = "uitbxDst";
            this.uitbxDst.ShowScrollBar = true;
            this.uitbxDst.Size = new System.Drawing.Size(506, 361);
            this.uitbxDst.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxDst.TabIndex = 3;
            this.uitbxDst.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicbxSrc
            // 
            this.uicbxSrc.DataSource = null;
            this.uicbxSrc.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uicbxSrc.FillColor = System.Drawing.Color.White;
            this.uicbxSrc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uicbxSrc.Location = new System.Drawing.Point(23, 40);
            this.uicbxSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicbxSrc.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicbxSrc.Name = "uicbxSrc";
            this.uicbxSrc.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uicbxSrc.Size = new System.Drawing.Size(150, 29);
            this.uicbxSrc.TabIndex = 4;
            this.uicbxSrc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicbxSrc.SelectedIndexChanged += new System.EventHandler(this.uicbxSrc_SelectedIndexChanged);
            // 
            // uicbxDst
            // 
            this.uicbxDst.DataSource = null;
            this.uicbxDst.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uicbxDst.FillColor = System.Drawing.Color.White;
            this.uicbxDst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uicbxDst.Location = new System.Drawing.Point(297, 40);
            this.uicbxDst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicbxDst.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicbxDst.Name = "uicbxDst";
            this.uicbxDst.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uicbxDst.Size = new System.Drawing.Size(150, 29);
            this.uicbxDst.TabIndex = 5;
            this.uicbxDst.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibtnSwap
            // 
            this.uibtnSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnSwap.Enabled = false;
            this.uibtnSwap.FillColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.FillDisableColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.FillHoverColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.FillPressColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.uibtnSwap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uibtnSwap.ForeDisableColor = System.Drawing.Color.Silver;
            this.uibtnSwap.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uibtnSwap.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uibtnSwap.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uibtnSwap.Location = new System.Drawing.Point(210, 40);
            this.uibtnSwap.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnSwap.Name = "uibtnSwap";
            this.uibtnSwap.RectColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.RectDisableColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.RectHoverColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.RectPressColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uibtnSwap.Size = new System.Drawing.Size(48, 29);
            this.uibtnSwap.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnSwap.TabIndex = 6;
            this.uibtnSwap.Text = "⇌";
            this.uibtnSwap.Click += new System.EventHandler(this.uibtnSwap_Click);
            // 
            // uibtnClr
            // 
            this.uibtnClr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnClr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnClr.Location = new System.Drawing.Point(943, 40);
            this.uibtnClr.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnClr.Name = "uibtnClr";
            this.uibtnClr.Size = new System.Drawing.Size(100, 29);
            this.uibtnClr.TabIndex = 7;
            this.uibtnClr.Text = "Clear";
            this.uibtnClr.Click += new System.EventHandler(this.uibtnClr_Click);
            // 
            // uilblCR
            // 
            this.uilblCR.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uilblCR.ForeColor = System.Drawing.Color.Silver;
            this.uilblCR.Location = new System.Drawing.Point(821, 509);
            this.uilblCR.Name = "uilblCR";
            this.uilblCR.Size = new System.Drawing.Size(231, 23);
            this.uilblCR.TabIndex = 8;
            this.uilblCR.Text = "Proudly presented by Suasy";
            this.uilblCR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1064, 553);
            this.Controls.Add(this.uilblCR);
            this.Controls.Add(this.uibtnClr);
            this.Controls.Add(this.uibtnSwap);
            this.Controls.Add(this.uicbxDst);
            this.Controls.Add(this.uicbxSrc);
            this.Controls.Add(this.uitbxDst);
            this.Controls.Add(this.uitbxSrc);
            this.Name = "TransForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uitbxSrc;
        private Sunny.UI.UITextBox uitbxDst;
        private Sunny.UI.UIComboBox uicbxSrc;
        private Sunny.UI.UIComboBox uicbxDst;
        private Sunny.UI.UIButton uibtnSwap;
        private Sunny.UI.UIButton uibtnClr;
        private Sunny.UI.UILabel uilblCR;
    }
}

