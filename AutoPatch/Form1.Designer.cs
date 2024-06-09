namespace AutoPatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BrowserLocation = new Panel();
            btnJogar = new Custom.RJButton();
            picIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            btnClose = new Custom.RJButton();
            btnMinimize = new Custom.RJButton();
            lblCheckUpdate = new Custom.LabelMJS();
            btnSetting = new Custom.RJButton();
            BrowserLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BrowserLocation
            // 
            BrowserLocation.Controls.Add(btnJogar);
            BrowserLocation.Location = new Point(1, 45);
            BrowserLocation.Name = "BrowserLocation";
            BrowserLocation.Size = new Size(1020, 610);
            BrowserLocation.TabIndex = 0;
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.FromArgb(255, 128, 0);
            btnJogar.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnJogar.BorderColor = Color.PaleVioletRed;
            btnJogar.BorderRadius = 8;
            btnJogar.BorderSize = 0;
            btnJogar.Enabled = false;
            btnJogar.FlatAppearance.BorderSize = 0;
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnJogar.ForeColor = Color.White;
            btnJogar.Location = new Point(797, 549);
            btnJogar.Margin = new Padding(0);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(200, 38);
            btnJogar.TabIndex = 0;
            btnJogar.Text = "JOGAR";
            btnJogar.TextColor = Color.White;
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Visible = false;
            // 
            // picIcon
            // 
            picIcon.Image = Properties.Resources._0239a484_3710_4da8_869c_1acfa2dbd4f2_1;
            picIcon.Location = new Point(6, 6);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(33, 35);
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BorderColor = SystemColors.AppWorkspace;
            btnClose.BorderRadius = 0;
            btnClose.BorderSize = 1;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Britannic Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(974, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 26);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundColor = Color.Transparent;
            btnMinimize.BorderColor = SystemColors.AppWorkspace;
            btnMinimize.BorderRadius = 0;
            btnMinimize.BorderSize = 1;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Britannic Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(930, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(38, 26);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.TextColor = Color.White;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblCheckUpdate
            // 
            lblCheckUpdate.AutoSize = true;
            lblCheckUpdate.DrawingDirection = Custom.LabelMJS.Angles.LeftToRight;
            lblCheckUpdate.EnableGradient = true;
            lblCheckUpdate.EnableShadow = false;
            lblCheckUpdate.EndColor = Color.FromArgb(255, 128, 0);
            lblCheckUpdate.EndColorAlpha = 255;
            lblCheckUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckUpdate.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            lblCheckUpdate.Location = new Point(405, 11);
            lblCheckUpdate.Name = "lblCheckUpdate";
            lblCheckUpdate.ShadowColor = Color.FromArgb(255, 128, 0);
            lblCheckUpdate.ShadowOffset = 1;
            lblCheckUpdate.Size = new Size(169, 21);
            lblCheckUpdate.StartColor = Color.FromArgb(255, 128, 0);
            lblCheckUpdate.StartColorAlpha = 255;
            lblCheckUpdate.TabIndex = 1;
            lblCheckUpdate.Text = "Buscando Atualização...";
            lblCheckUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.BackgroundColor = Color.Transparent;
            btnSetting.BorderColor = SystemColors.AppWorkspace;
            btnSetting.BorderRadius = 0;
            btnSetting.BorderSize = 1;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Britannic Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.White;
            btnSetting.Location = new Point(886, 6);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(38, 26);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "*";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextColor = Color.White;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1022, 658);
            Controls.Add(btnSetting);
            Controls.Add(lblCheckUpdate);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(picIcon);
            Controls.Add(BrowserLocation);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoPatch";
            Load += Form1_Load;
            BrowserLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BrowserLocation;
        private Label label1;
        private PictureBox picIcon;
        private Custom.RJButton btnJogar;
        private PictureBox pictureBox1;
        private Custom.RJButton btnClose;
        private Custom.RJButton btnMinimize;
        private Custom.LabelMJS lblCheckUpdate;
        private Custom.RJButton btnSetting;
    }
}
