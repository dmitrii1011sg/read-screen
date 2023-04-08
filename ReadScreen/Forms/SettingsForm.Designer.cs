namespace ReadScreen
{
    partial class SettingForm
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
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.copyClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.otherGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsBox.SuspendLayout();
            this.otherGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.doneBtn);
            this.settingsBox.Controls.Add(this.copyClipboardCheckBox);
            this.settingsBox.Location = new System.Drawing.Point(12, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(274, 122);
            this.settingsBox.TabIndex = 0;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(193, 93);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 1;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            // 
            // copyClipboardCheckBox
            // 
            this.copyClipboardCheckBox.AutoSize = true;
            this.copyClipboardCheckBox.Location = new System.Drawing.Point(6, 58);
            this.copyClipboardCheckBox.Name = "copyClipboardCheckBox";
            this.copyClipboardCheckBox.Size = new System.Drawing.Size(111, 17);
            this.copyClipboardCheckBox.TabIndex = 0;
            this.copyClipboardCheckBox.Text = "Copy on clipboard";
            this.copyClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // otherGroup
            // 
            this.otherGroup.Controls.Add(this.label1);
            this.otherGroup.Location = new System.Drawing.Point(12, 140);
            this.otherGroup.Name = "otherGroup";
            this.otherGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.otherGroup.Size = new System.Drawing.Size(274, 120);
            this.otherGroup.TabIndex = 1;
            this.otherGroup.TabStop = false;
            this.otherGroup.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "About prg";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 272);
            this.Controls.Add(this.otherGroup);
            this.Controls.Add(this.settingsBox);
            this.Name = "SettingForm";
            this.Text = "ReadScreen";
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.otherGroup.ResumeLayout(false);
            this.otherGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.GroupBox otherGroup;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.CheckBox copyClipboardCheckBox;
        private System.Windows.Forms.Label label1;
    }
}