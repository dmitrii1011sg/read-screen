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
            this.panel = new System.Windows.Forms.Panel();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.panelTabsContent = new System.Windows.Forms.Panel();
            this.panelTabsHeader = new System.Windows.Forms.Panel();
            this.tabSetting = new System.Windows.Forms.Button();
            this.tabAbout = new System.Windows.Forms.Button();
            this.settingsControl = new ReadScreen.SettingsControl();
            this.aboutControl = new ReadScreen.AboutControl();
            this.closeBtnControl = new ReadScreen.CloseBtnControl();
            this.panel.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.panelTabsContent.SuspendLayout();
            this.panelTabsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.closeBtnControl);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(376, 30);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.panelTabsContent);
            this.panelWorkspace.Controls.Add(this.panelTabsHeader);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 30);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(376, 243);
            this.panelWorkspace.TabIndex = 1;
            // 
            // panelTabsContent
            // 
            this.panelTabsContent.Controls.Add(this.settingsControl);
            this.panelTabsContent.Controls.Add(this.aboutControl);
            this.panelTabsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabsContent.Location = new System.Drawing.Point(103, 0);
            this.panelTabsContent.Name = "panelTabsContent";
            this.panelTabsContent.Size = new System.Drawing.Size(273, 243);
            this.panelTabsContent.TabIndex = 1;
            // 
            // panelTabsHeader
            // 
            this.panelTabsHeader.Controls.Add(this.tabAbout);
            this.panelTabsHeader.Controls.Add(this.tabSetting);
            this.panelTabsHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTabsHeader.Name = "panelTabsHeader";
            this.panelTabsHeader.Size = new System.Drawing.Size(103, 243);
            this.panelTabsHeader.TabIndex = 0;
            // 
            // tabSetting
            // 
            this.tabSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.tabSetting.FlatAppearance.BorderSize = 2;
            this.tabSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabSetting.ForeColor = System.Drawing.Color.White;
            this.tabSetting.Location = new System.Drawing.Point(0, 0);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(103, 32);
            this.tabSetting.TabIndex = 0;
            this.tabSetting.Text = "Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            this.tabSetting.Click += new System.EventHandler(this.tabSetting_Click);
            // 
            // tabAbout
            // 
            this.tabAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.tabAbout.FlatAppearance.BorderSize = 2;
            this.tabAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabAbout.ForeColor = System.Drawing.Color.White;
            this.tabAbout.Location = new System.Drawing.Point(0, 32);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(103, 32);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            this.tabAbout.Click += new System.EventHandler(this.tabAbout_Click);
            // 
            // settingsControl
            // 
            this.settingsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(273, 243);
            this.settingsControl.TabIndex = 1;
            // 
            // aboutControl
            // 
            this.aboutControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.aboutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutControl.Location = new System.Drawing.Point(0, 0);
            this.aboutControl.Name = "aboutControl";
            this.aboutControl.Size = new System.Drawing.Size(273, 243);
            this.aboutControl.TabIndex = 0;
            // 
            // closeBtnControl
            // 
            this.closeBtnControl.BackColor = System.Drawing.Color.Transparent;
            this.closeBtnControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtnControl.Location = new System.Drawing.Point(346, 0);
            this.closeBtnControl.Name = "closeBtnControl";
            this.closeBtnControl.Size = new System.Drawing.Size(30, 30);
            this.closeBtnControl.TabIndex = 0;
            this.closeBtnControl.CloseButtonClick += new System.EventHandler(this.closeBtnControl_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(376, 273);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "ReadScreen";
            this.panel.ResumeLayout(false);
            this.panelWorkspace.ResumeLayout(false);
            this.panelTabsContent.ResumeLayout(false);
            this.panelTabsHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.Panel panelTabsContent;
        private System.Windows.Forms.Panel panelTabsHeader;
        private CloseBtnControl closeBtnControl;
        private SettingsControl settingsControl;
        private AboutControl aboutControl;
        private System.Windows.Forms.Button tabAbout;
        private System.Windows.Forms.Button tabSetting;
    }
}