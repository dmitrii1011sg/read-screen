namespace ReadScreen
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.labelDefaultLang = new System.Windows.Forms.Label();
            this.comboBoxDefaultLang = new System.Windows.Forms.ComboBox();
            this.groupBoxCopy = new System.Windows.Forms.GroupBox();
            this.nothingCopyBtn = new System.Windows.Forms.RadioButton();
            this.autoCopyText = new System.Windows.Forms.RadioButton();
            this.autoCopyImage = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBoxCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(13, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(68, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Settings";
            // 
            // labelDefaultLang
            // 
            this.labelDefaultLang.AutoSize = true;
            this.labelDefaultLang.Location = new System.Drawing.Point(17, 51);
            this.labelDefaultLang.Name = "labelDefaultLang";
            this.labelDefaultLang.Size = new System.Drawing.Size(92, 13);
            this.labelDefaultLang.TabIndex = 1;
            this.labelDefaultLang.Text = "Default Language";
            // 
            // comboBoxDefaultLang
            // 
            this.comboBoxDefaultLang.FormattingEnabled = true;
            this.comboBoxDefaultLang.Location = new System.Drawing.Point(115, 48);
            this.comboBoxDefaultLang.Name = "comboBoxDefaultLang";
            this.comboBoxDefaultLang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDefaultLang.TabIndex = 2;
            // 
            // groupBoxCopy
            // 
            this.groupBoxCopy.Controls.Add(this.nothingCopyBtn);
            this.groupBoxCopy.Controls.Add(this.autoCopyText);
            this.groupBoxCopy.Controls.Add(this.autoCopyImage);
            this.groupBoxCopy.Location = new System.Drawing.Point(17, 75);
            this.groupBoxCopy.Name = "groupBoxCopy";
            this.groupBoxCopy.Size = new System.Drawing.Size(219, 89);
            this.groupBoxCopy.TabIndex = 3;
            this.groupBoxCopy.TabStop = false;
            this.groupBoxCopy.Text = "Auto copy";
            // 
            // nothingCopyBtn
            // 
            this.nothingCopyBtn.AutoSize = true;
            this.nothingCopyBtn.Location = new System.Drawing.Point(7, 66);
            this.nothingCopyBtn.Name = "nothingCopyBtn";
            this.nothingCopyBtn.Size = new System.Drawing.Size(62, 17);
            this.nothingCopyBtn.TabIndex = 2;
            this.nothingCopyBtn.TabStop = true;
            this.nothingCopyBtn.Text = "Nothing";
            this.nothingCopyBtn.UseVisualStyleBackColor = true;
            // 
            // autoCopyText
            // 
            this.autoCopyText.AutoSize = true;
            this.autoCopyText.Location = new System.Drawing.Point(7, 44);
            this.autoCopyText.Name = "autoCopyText";
            this.autoCopyText.Size = new System.Drawing.Size(93, 17);
            this.autoCopyText.TabIndex = 1;
            this.autoCopyText.TabStop = true;
            this.autoCopyText.Text = "Auto copy text";
            this.autoCopyText.UseVisualStyleBackColor = true;
            // 
            // autoCopyImage
            // 
            this.autoCopyImage.AutoSize = true;
            this.autoCopyImage.Location = new System.Drawing.Point(7, 20);
            this.autoCopyImage.Name = "autoCopyImage";
            this.autoCopyImage.Size = new System.Drawing.Size(104, 17);
            this.autoCopyImage.TabIndex = 0;
            this.autoCopyImage.TabStop = true;
            this.autoCopyImage.Text = "Auto copy image";
            this.autoCopyImage.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(161, 170);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBoxCopy);
            this.Controls.Add(this.comboBoxDefaultLang);
            this.Controls.Add(this.labelDefaultLang);
            this.Controls.Add(this.title);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(258, 200);
            this.groupBoxCopy.ResumeLayout(false);
            this.groupBoxCopy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelDefaultLang;
        private System.Windows.Forms.ComboBox comboBoxDefaultLang;
        private System.Windows.Forms.GroupBox groupBoxCopy;
        private System.Windows.Forms.RadioButton autoCopyText;
        private System.Windows.Forms.RadioButton autoCopyImage;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton nothingCopyBtn;
    }
}
