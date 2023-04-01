﻿namespace ReadScreen
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.otherGroup = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyiconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsBox.SuspendLayout();
            this.otherGroup.SuspendLayout();
            this.contextMenuStripApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.doneBtn);
            this.settingsBox.Controls.Add(this.checkBox1);
            this.settingsBox.Location = new System.Drawing.Point(12, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(274, 122);
            this.settingsBox.TabIndex = 0;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Copy on clipboard";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "About prg";
            // 
            // notifyiconMain
            // 
            this.notifyiconMain.Text = "notifyiconMain";
            this.notifyiconMain.Visible = true;
            // 
            // contextMenuStripApp
            // 
            this.contextMenuStripApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStripApp.Name = "contextMenuStripApp";
            this.contextMenuStripApp.Size = new System.Drawing.Size(120, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.captureToolStripMenuItem.Text = "Capture ";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 272);
            this.Controls.Add(this.otherGroup);
            this.Controls.Add(this.settingsBox);
            this.Name = "MainForm";
            this.Text = "ReadScreen";
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.otherGroup.ResumeLayout(false);
            this.otherGroup.PerformLayout();
            this.contextMenuStripApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.GroupBox otherGroup;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyiconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripApp;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}