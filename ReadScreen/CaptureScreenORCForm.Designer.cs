namespace ReadScreen.Forms
{
    partial class CaptureScreenORCForm
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
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.closeBtnControl1 = new ReadScreen.CloseBtnControl();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.textBoxORC = new System.Windows.Forms.TextBox();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.selectLangLabel = new System.Windows.Forms.Label();
            this.selectLangDoneBtn = new System.Windows.Forms.Button();
            this.copyImageBtn = new System.Windows.Forms.Button();
            this.copyTextBtn = new System.Windows.Forms.Button();
            this.saveImageBtn = new System.Windows.Forms.Button();
            this.comboBoxSelectLang = new System.Windows.Forms.ComboBox();
            this.screenshotBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.tableButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.closeBtnControl1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 31);
            this.panel.TabIndex = 0;
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.panelImage);
            this.panelWorkspace.Controls.Add(this.panelResult);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 31);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(800, 419);
            this.panelWorkspace.TabIndex = 1;
            // 
            // closeBtnControl1
            // 
            this.closeBtnControl1.BackColor = System.Drawing.Color.Transparent;
            this.closeBtnControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtnControl1.Location = new System.Drawing.Point(770, 0);
            this.closeBtnControl1.Name = "closeBtnControl1";
            this.closeBtnControl1.Size = new System.Drawing.Size(30, 31);
            this.closeBtnControl1.TabIndex = 0;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.tableButtons);
            this.panelResult.Controls.Add(this.textBoxORC);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(10);
            this.panelResult.Size = new System.Drawing.Size(285, 419);
            this.panelResult.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.screenshotBox);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(285, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(515, 419);
            this.panelImage.TabIndex = 1;
            // 
            // textBoxORC
            // 
            this.textBoxORC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxORC.Location = new System.Drawing.Point(10, 10);
            this.textBoxORC.Multiline = true;
            this.textBoxORC.Name = "textBoxORC";
            this.textBoxORC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxORC.Size = new System.Drawing.Size(265, 399);
            this.textBoxORC.TabIndex = 1;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 3;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.07547F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.33962F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtons.Controls.Add(this.selectLangDoneBtn, 2, 0);
            this.tableButtons.Controls.Add(this.copyImageBtn, 0, 1);
            this.tableButtons.Controls.Add(this.copyTextBtn, 1, 1);
            this.tableButtons.Controls.Add(this.saveImageBtn, 2, 1);
            this.tableButtons.Controls.Add(this.comboBoxSelectLang, 1, 0);
            this.tableButtons.Controls.Add(this.selectLangLabel, 0, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableButtons.ForeColor = System.Drawing.Color.White;
            this.tableButtons.Location = new System.Drawing.Point(10, 333);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 2;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(265, 76);
            this.tableButtons.TabIndex = 2;
            // 
            // selectLangLabel
            // 
            this.selectLangLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectLangLabel.AutoSize = true;
            this.selectLangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLangLabel.Location = new System.Drawing.Point(7, 10);
            this.selectLangLabel.Name = "selectLangLabel";
            this.selectLangLabel.Size = new System.Drawing.Size(71, 15);
            this.selectLangLabel.TabIndex = 0;
            this.selectLangLabel.Text = "Select lang:";
            // 
            // selectLangDoneBtn
            // 
            this.selectLangDoneBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectLangDoneBtn.BackColor = System.Drawing.Color.DimGray;
            this.selectLangDoneBtn.FlatAppearance.BorderSize = 0;
            this.selectLangDoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLangDoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLangDoneBtn.Location = new System.Drawing.Point(183, 4);
            this.selectLangDoneBtn.Name = "selectLangDoneBtn";
            this.selectLangDoneBtn.Size = new System.Drawing.Size(75, 26);
            this.selectLangDoneBtn.TabIndex = 1;
            this.selectLangDoneBtn.Text = "Done";
            this.selectLangDoneBtn.UseVisualStyleBackColor = false;
            // 
            // copyImageBtn
            // 
            this.copyImageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.copyImageBtn.FlatAppearance.BorderSize = 0;
            this.copyImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyImageBtn.Location = new System.Drawing.Point(5, 42);
            this.copyImageBtn.Name = "copyImageBtn";
            this.copyImageBtn.Size = new System.Drawing.Size(75, 26);
            this.copyImageBtn.TabIndex = 2;
            this.copyImageBtn.Text = "Copy Img";
            this.copyImageBtn.UseVisualStyleBackColor = false;
            // 
            // copyTextBtn
            // 
            this.copyTextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyTextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.copyTextBtn.FlatAppearance.BorderSize = 0;
            this.copyTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyTextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyTextBtn.Location = new System.Drawing.Point(93, 42);
            this.copyTextBtn.Name = "copyTextBtn";
            this.copyTextBtn.Size = new System.Drawing.Size(75, 26);
            this.copyTextBtn.TabIndex = 3;
            this.copyTextBtn.Text = "Copy Text";
            this.copyTextBtn.UseVisualStyleBackColor = false;
            // 
            // saveImageBtn
            // 
            this.saveImageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.saveImageBtn.FlatAppearance.BorderSize = 0;
            this.saveImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveImageBtn.Location = new System.Drawing.Point(183, 42);
            this.saveImageBtn.Name = "saveImageBtn";
            this.saveImageBtn.Size = new System.Drawing.Size(75, 26);
            this.saveImageBtn.TabIndex = 4;
            this.saveImageBtn.Text = "Save Img";
            this.saveImageBtn.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelectLang
            // 
            this.comboBoxSelectLang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSelectLang.FormattingEnabled = true;
            this.comboBoxSelectLang.Location = new System.Drawing.Point(93, 7);
            this.comboBoxSelectLang.Name = "comboBoxSelectLang";
            this.comboBoxSelectLang.Size = new System.Drawing.Size(75, 21);
            this.comboBoxSelectLang.TabIndex = 5;
            // 
            // screenshotBox
            // 
            this.screenshotBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenshotBox.Location = new System.Drawing.Point(0, 0);
            this.screenshotBox.Name = "screenshotBox";
            this.screenshotBox.Size = new System.Drawing.Size(515, 419);
            this.screenshotBox.TabIndex = 0;
            this.screenshotBox.TabStop = false;
            // 
            // CaptureScreenORCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureScreenORCForm";
            this.Text = "CaptureScreenORCForm";
            this.panel.ResumeLayout(false);
            this.panelWorkspace.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.tableButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelWorkspace;
        private CloseBtnControl closeBtnControl1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.TextBox textBoxORC;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button selectLangDoneBtn;
        private System.Windows.Forms.Button copyImageBtn;
        private System.Windows.Forms.Button copyTextBtn;
        private System.Windows.Forms.Button saveImageBtn;
        private System.Windows.Forms.ComboBox comboBoxSelectLang;
        private System.Windows.Forms.Label selectLangLabel;
        private System.Windows.Forms.PictureBox screenshotBox;
    }
}