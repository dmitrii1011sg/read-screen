namespace ReadScreen
{
    partial class CaptureScreenORC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.selectLangBtn = new System.Windows.Forms.Button();
            this.saveImageBtn = new System.Windows.Forms.Button();
            this.copyTextBtn = new System.Windows.Forms.Button();
            this.copyImageBtn = new System.Windows.Forms.Button();
            this.comboBoxSelectLang = new System.Windows.Forms.ComboBox();
            this.labelSelectLang = new System.Windows.Forms.Label();
            this.textBoxORC = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.screenshotBox = new System.Windows.Forms.PictureBox();
            this.closeBtnControl1 = new ReadScreen.CloseBtnControl();
            this.panel.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.closeBtnControl1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(838, 31);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.panelImage);
            this.panelWorkspace.Controls.Add(this.panelResult);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 31);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(838, 376);
            this.panelWorkspace.TabIndex = 1;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.selectLangBtn);
            this.panelResult.Controls.Add(this.saveImageBtn);
            this.panelResult.Controls.Add(this.copyTextBtn);
            this.panelResult.Controls.Add(this.copyImageBtn);
            this.panelResult.Controls.Add(this.comboBoxSelectLang);
            this.panelResult.Controls.Add(this.labelSelectLang);
            this.panelResult.Controls.Add(this.textBoxORC);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(299, 376);
            this.panelResult.TabIndex = 0;
            // 
            // selectLangBtn
            // 
            this.selectLangBtn.BackColor = System.Drawing.Color.DimGray;
            this.selectLangBtn.FlatAppearance.BorderSize = 0;
            this.selectLangBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLangBtn.ForeColor = System.Drawing.Color.White;
            this.selectLangBtn.Location = new System.Drawing.Point(201, 308);
            this.selectLangBtn.Name = "selectLangBtn";
            this.selectLangBtn.Size = new System.Drawing.Size(85, 26);
            this.selectLangBtn.TabIndex = 7;
            this.selectLangBtn.Text = "Done";
            this.selectLangBtn.UseVisualStyleBackColor = false;
            this.selectLangBtn.Click += new System.EventHandler(this.selectLangBtn_Click);
            // 
            // saveImageBtn
            // 
            this.saveImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.saveImageBtn.FlatAppearance.BorderSize = 0;
            this.saveImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveImageBtn.ForeColor = System.Drawing.Color.White;
            this.saveImageBtn.Location = new System.Drawing.Point(107, 340);
            this.saveImageBtn.Name = "saveImageBtn";
            this.saveImageBtn.Size = new System.Drawing.Size(88, 26);
            this.saveImageBtn.TabIndex = 6;
            this.saveImageBtn.Text = "Save img";
            this.saveImageBtn.UseVisualStyleBackColor = false;
            this.saveImageBtn.Click += new System.EventHandler(this.saveImageBtn_Click);
            // 
            // copyTextBtn
            // 
            this.copyTextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.copyTextBtn.FlatAppearance.BorderSize = 0;
            this.copyTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyTextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyTextBtn.ForeColor = System.Drawing.Color.White;
            this.copyTextBtn.Location = new System.Drawing.Point(201, 340);
            this.copyTextBtn.Name = "copyTextBtn";
            this.copyTextBtn.Size = new System.Drawing.Size(85, 26);
            this.copyTextBtn.TabIndex = 5;
            this.copyTextBtn.Text = "Copy text";
            this.copyTextBtn.UseVisualStyleBackColor = false;
            this.copyTextBtn.Click += new System.EventHandler(this.copyTextBtn_Click);
            // 
            // copyImageBtn
            // 
            this.copyImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.copyImageBtn.FlatAppearance.BorderSize = 0;
            this.copyImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyImageBtn.ForeColor = System.Drawing.Color.White;
            this.copyImageBtn.Location = new System.Drawing.Point(15, 340);
            this.copyImageBtn.Name = "copyImageBtn";
            this.copyImageBtn.Size = new System.Drawing.Size(86, 26);
            this.copyImageBtn.TabIndex = 3;
            this.copyImageBtn.Text = "Copy img";
            this.copyImageBtn.UseVisualStyleBackColor = false;
            this.copyImageBtn.Click += new System.EventHandler(this.copyImageBtn_Click);
            // 
            // comboBoxSelectLang
            // 
            this.comboBoxSelectLang.FormattingEnabled = true;
            this.comboBoxSelectLang.Location = new System.Drawing.Point(107, 310);
            this.comboBoxSelectLang.Name = "comboBoxSelectLang";
            this.comboBoxSelectLang.Size = new System.Drawing.Size(88, 21);
            this.comboBoxSelectLang.TabIndex = 2;
            // 
            // labelSelectLang
            // 
            this.labelSelectLang.AutoSize = true;
            this.labelSelectLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectLang.ForeColor = System.Drawing.Color.White;
            this.labelSelectLang.Location = new System.Drawing.Point(22, 313);
            this.labelSelectLang.Name = "labelSelectLang";
            this.labelSelectLang.Size = new System.Drawing.Size(71, 15);
            this.labelSelectLang.TabIndex = 1;
            this.labelSelectLang.Text = "Select lang:";
            // 
            // textBoxORC
            // 
            this.textBoxORC.Location = new System.Drawing.Point(15, 6);
            this.textBoxORC.Multiline = true;
            this.textBoxORC.Name = "textBoxORC";
            this.textBoxORC.ReadOnly = true;
            this.textBoxORC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxORC.Size = new System.Drawing.Size(271, 296);
            this.textBoxORC.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.screenshotBox);
            this.panelImage.Location = new System.Drawing.Point(305, 6);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(530, 358);
            this.panelImage.TabIndex = 1;
            // 
            // screenshotBox
            // 
            this.screenshotBox.Location = new System.Drawing.Point(0, 0);
            this.screenshotBox.Name = "screenshotBox";
            this.screenshotBox.Size = new System.Drawing.Size(321, 210);
            this.screenshotBox.TabIndex = 0;
            this.screenshotBox.TabStop = false;
            // 
            // closeBtnControl1
            // 
            this.closeBtnControl1.BackColor = System.Drawing.Color.Transparent;
            this.closeBtnControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtnControl1.Location = new System.Drawing.Point(808, 0);
            this.closeBtnControl1.Name = "closeBtnControl1";
            this.closeBtnControl1.Size = new System.Drawing.Size(30, 31);
            this.closeBtnControl1.TabIndex = 0;
            this.closeBtnControl1.CloseButtonClick += new System.EventHandler(this.closeBtnControl_Click);
            // 
            // CaptureScreenORC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(838, 407);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureScreenORC";
            this.Text = "CaptureScreenORCForm";
            this.Load += new System.EventHandler(this.CaptureScreenORC_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelWorkspace.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelWorkspace;
        private CloseBtnControl closeBtnControl1;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelSelectLang;
        private System.Windows.Forms.TextBox textBoxORC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectLangBtn;
        private System.Windows.Forms.Button saveImageBtn;
        private System.Windows.Forms.Button copyTextBtn;
        private System.Windows.Forms.Button copyImageBtn;
        private System.Windows.Forms.ComboBox comboBoxSelectLang;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox screenshotBox;
    }
}