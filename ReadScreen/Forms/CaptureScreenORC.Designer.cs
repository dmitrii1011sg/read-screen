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
            this.closeBtnControl1 = new ReadScreen.CloseBtnControl();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.screenshotBox = new System.Windows.Forms.PictureBox();
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
            this.panel.Size = new System.Drawing.Size(800, 31);
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
            // closeBtnControl1
            // 
            this.closeBtnControl1.BackColor = System.Drawing.Color.Transparent;
            this.closeBtnControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtnControl1.Location = new System.Drawing.Point(770, 0);
            this.closeBtnControl1.Name = "closeBtnControl1";
            this.closeBtnControl1.Size = new System.Drawing.Size(30, 31);
            this.closeBtnControl1.TabIndex = 0;
            this.closeBtnControl1.CloseButtonClick += new System.EventHandler(this.closeBtnControl_Click);
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.panelImage);
            this.panelWorkspace.Controls.Add(this.panelResult);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 31);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(800, 376);
            this.panelWorkspace.TabIndex = 1;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.button5);
            this.panelResult.Controls.Add(this.button4);
            this.panelResult.Controls.Add(this.button3);
            this.panelResult.Controls.Add(this.button1);
            this.panelResult.Controls.Add(this.comboBox1);
            this.panelResult.Controls.Add(this.label1);
            this.panelResult.Controls.Add(this.textBox1);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(268, 376);
            this.panelResult.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(177, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "Done";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(96, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save img";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(177, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Copy text";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy img";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select lang:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(237, 296);
            this.textBox1.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.screenshotBox);
            this.panelImage.Location = new System.Drawing.Point(267, 6);
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
            // CaptureScreenORC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureScreenORC";
            this.Text = "CaptureScreenORCForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox screenshotBox;
    }
}