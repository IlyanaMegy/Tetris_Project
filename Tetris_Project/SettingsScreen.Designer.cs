namespace Tetris_Project
{
    partial class SettingsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsScreen));
            this.TitleBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.rule1 = new System.Windows.Forms.Label();
            this.rule2 = new System.Windows.Forms.Label();
            this.rule3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.ResetHighscore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleBox.Location = new System.Drawing.Point(29, 96);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(518, 315);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("HP Simplified Hans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.TitleLabel.Location = new System.Drawing.Point(68, 38);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.TitleLabel.Size = new System.Drawing.Size(445, 43);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Welcome to the SETTINGS page";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rule1
            // 
            this.rule1.AutoSize = true;
            this.rule1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rule1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule1.ForeColor = System.Drawing.Color.Gold;
            this.rule1.Location = new System.Drawing.Point(104, 114);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(364, 38);
            this.rule1.TabIndex = 4;
            this.rule1.Text = "The aim in Tetris is simple, \r\nyou bring down blocks from the top of the screen. " +
    "\r\n";
            this.rule1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rule2
            // 
            this.rule2.AutoSize = true;
            this.rule2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rule2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule2.ForeColor = System.Drawing.Color.DarkOrange;
            this.rule2.Location = new System.Drawing.Point(113, 169);
            this.rule2.Name = "rule2";
            this.rule2.Size = new System.Drawing.Size(345, 38);
            this.rule2.TabIndex = 5;
            this.rule2.Text = "You can move the blocks around !\r\nFrom left to right but also you can rotate them" +
    ". ";
            this.rule2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rule3
            // 
            this.rule3.AutoSize = true;
            this.rule3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rule3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule3.ForeColor = System.Drawing.Color.OrangeRed;
            this.rule3.Location = new System.Drawing.Point(35, 310);
            this.rule3.Name = "rule3";
            this.rule3.Size = new System.Drawing.Size(499, 38);
            this.rule3.TabIndex = 6;
            this.rule3.Text = "The blocks fall at a certain rate...\r\n but you can make them fall faster if you a" +
    "re sure of your positioning. \r\n";
            this.rule3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(80, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your game is over if your pieces reach the top of the screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tetris_Project.Properties.Resources.controls;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(233, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 76);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(29, 417);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(518, 59);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(60, 430);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 31);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Go Back";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.LimeGreen;
            this.StartGame.Location = new System.Drawing.Point(408, 430);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(105, 31);
            this.StartGame.TabIndex = 11;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // ResetHighscore
            // 
            this.ResetHighscore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResetHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetHighscore.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetHighscore.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResetHighscore.Location = new System.Drawing.Point(207, 430);
            this.ResetHighscore.Name = "ResetHighscore";
            this.ResetHighscore.Size = new System.Drawing.Size(158, 31);
            this.ResetHighscore.TabIndex = 12;
            this.ResetHighscore.Text = "Reset Highscore";
            this.ResetHighscore.UseVisualStyleBackColor = false;
            this.ResetHighscore.Click += new System.EventHandler(this.ResetHighscore_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris_Project.Properties.Resources.menuescreenbg1;
            this.ClientSize = new System.Drawing.Size(578, 501);
            this.Controls.Add(this.ResetHighscore);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rule3);
            this.Controls.Add(this.rule2);
            this.Controls.Add(this.rule1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsScreen";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TitleBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label rule1;
        private System.Windows.Forms.Label rule2;
        private System.Windows.Forms.Label rule3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button ResetHighscore;
    }
}