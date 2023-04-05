namespace ReadScreen
{
    partial class CaptureScreenResult
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
            this.screenshotBox = new System.Windows.Forms.PictureBox();
            this.saveImage = new System.Windows.Forms.Button();
            this.copyImage = new System.Windows.Forms.Button();
            this.copyText = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.doneLang = new System.Windows.Forms.Button();
            this.langLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenshotBox
            // 
            this.screenshotBox.Location = new System.Drawing.Point(265, 39);
            this.screenshotBox.Name = "screenshotBox";
            this.screenshotBox.Size = new System.Drawing.Size(477, 426);
            this.screenshotBox.TabIndex = 0;
            this.screenshotBox.TabStop = false;
            // 
            // saveImage
            // 
            this.saveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.saveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveImage.ForeColor = System.Drawing.Color.White;
            this.saveImage.Location = new System.Drawing.Point(5, 390);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(75, 23);
            this.saveImage.TabIndex = 1;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = false;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // copyImage
            // 
            this.copyImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.copyImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyImage.ForeColor = System.Drawing.Color.White;
            this.copyImage.Location = new System.Drawing.Point(86, 390);
            this.copyImage.Name = "copyImage";
            this.copyImage.Size = new System.Drawing.Size(75, 23);
            this.copyImage.TabIndex = 2;
            this.copyImage.Text = "Copy Image";
            this.copyImage.UseVisualStyleBackColor = false;
            this.copyImage.Click += new System.EventHandler(this.copyImage_Click);
            // 
            // copyText
            // 
            this.copyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(147)))), ((int)(((byte)(86)))));
            this.copyText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyText.ForeColor = System.Drawing.Color.White;
            this.copyText.Location = new System.Drawing.Point(167, 390);
            this.copyText.Name = "copyText";
            this.copyText.Size = new System.Drawing.Size(75, 23);
            this.copyText.TabIndex = 3;
            this.copyText.Text = "Copy Text";
            this.copyText.UseVisualStyleBackColor = false;
            this.copyText.Click += new System.EventHandler(this.copyText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.langLabel);
            this.groupBox1.Controls.Add(this.doneLang);
            this.groupBox1.Controls.Add(this.comboBoxLang);
            this.groupBox1.Controls.Add(this.resultText);
            this.groupBox1.Controls.Add(this.saveImage);
            this.groupBox1.Controls.Add(this.copyText);
            this.groupBox1.Controls.Add(this.copyImage);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 419);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Location = new System.Drawing.Point(86, 363);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(75, 23);
            this.comboBoxLang.TabIndex = 5;
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(6, 19);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(235, 338);
            this.resultText.TabIndex = 4;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(721, 3);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(26, 26);
            this.quitBtn.TabIndex = 5;
            this.quitBtn.Text = "X";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.quitBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 33);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // doneLang
            // 
            this.doneLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doneLang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneLang.Location = new System.Drawing.Point(168, 363);
            this.doneLang.Name = "doneLang";
            this.doneLang.Size = new System.Drawing.Size(75, 23);
            this.doneLang.TabIndex = 6;
            this.doneLang.Text = "Done";
            this.doneLang.UseVisualStyleBackColor = false;
            this.doneLang.Click += new System.EventHandler(this.doneLang_Click);
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.langLabel.Location = new System.Drawing.Point(6, 366);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(71, 15);
            this.langLabel.TabIndex = 7;
            this.langLabel.Text = "Select lang:";
            // 
            // CaptureScreenResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(750, 478);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.screenshotBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureScreenResult";
            this.Text = "CaptureScreenResult";
            this.Load += new System.EventHandler(this.CaptureScreenResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screenshotBox;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button copyImage;
        private System.Windows.Forms.Button copyText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Button doneLang;
        private System.Windows.Forms.Label langLabel;
    }
}