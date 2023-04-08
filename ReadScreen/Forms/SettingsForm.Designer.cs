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
            this.tabControlPanel = new System.Windows.Forms.Panel();
            this.changeAboutBtn = new System.Windows.Forms.Button();
            this.changeSettingBtn = new System.Windows.Forms.Button();
            this.tabContentPanel = new System.Windows.Forms.Panel();
            this.settingsControl = new ReadScreen.SettingsControl();
            this.aboutControl1 = new ReadScreen.AboutControl();
            this.tabControlPanel.SuspendLayout();
            this.tabContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPanel
            // 
            this.tabControlPanel.Controls.Add(this.changeAboutBtn);
            this.tabControlPanel.Controls.Add(this.changeSettingBtn);
            this.tabControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlPanel.Location = new System.Drawing.Point(0, 0);
            this.tabControlPanel.Name = "tabControlPanel";
            this.tabControlPanel.Size = new System.Drawing.Size(160, 221);
            this.tabControlPanel.TabIndex = 0;
            // 
            // changeAboutBtn
            // 
            this.changeAboutBtn.Location = new System.Drawing.Point(12, 56);
            this.changeAboutBtn.Name = "changeAboutBtn";
            this.changeAboutBtn.Size = new System.Drawing.Size(142, 38);
            this.changeAboutBtn.TabIndex = 1;
            this.changeAboutBtn.Text = "About";
            this.changeAboutBtn.UseVisualStyleBackColor = true;
            this.changeAboutBtn.Click += new System.EventHandler(this.changeAboutBtn_Click);
            // 
            // changeSettingBtn
            // 
            this.changeSettingBtn.Location = new System.Drawing.Point(13, 13);
            this.changeSettingBtn.Name = "changeSettingBtn";
            this.changeSettingBtn.Size = new System.Drawing.Size(141, 37);
            this.changeSettingBtn.TabIndex = 0;
            this.changeSettingBtn.Text = "Settings";
            this.changeSettingBtn.UseVisualStyleBackColor = true;
            this.changeSettingBtn.Click += new System.EventHandler(this.changeSettingBtn_Click);
            // 
            // tabContentPanel
            // 
            this.tabContentPanel.Controls.Add(this.settingsControl);
            this.tabContentPanel.Controls.Add(this.aboutControl1);
            this.tabContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContentPanel.Location = new System.Drawing.Point(160, 0);
            this.tabContentPanel.Name = "tabContentPanel";
            this.tabContentPanel.Size = new System.Drawing.Size(250, 221);
            this.tabContentPanel.TabIndex = 1;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(250, 221);
            this.settingsControl.TabIndex = 0;
            // 
            // aboutControl1
            // 
            this.aboutControl1.Location = new System.Drawing.Point(3, 3);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(258, 200);
            this.aboutControl1.TabIndex = 1;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 221);
            this.Controls.Add(this.tabContentPanel);
            this.Controls.Add(this.tabControlPanel);
            this.Name = "SettingForm";
            this.Text = "ReadScreen";
            this.tabControlPanel.ResumeLayout(false);
            this.tabContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabControlPanel;
        private System.Windows.Forms.Button changeAboutBtn;
        private System.Windows.Forms.Button changeSettingBtn;
        private System.Windows.Forms.Panel tabContentPanel;
        private SettingsControl settingsControl;
        private AboutControl aboutControl1;
    }
}