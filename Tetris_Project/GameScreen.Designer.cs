namespace Tetris_Project
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HighscoreTitle = new System.Windows.Forms.Label();
            this.Highscore_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 403);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Lime;
            this.Score.Location = new System.Drawing.Point(331, 50);
            this.Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(107, 25);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score : 0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Turquoise;
            this.Next.Location = new System.Drawing.Point(331, 160);
            this.Next.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(60, 25);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Level.Location = new System.Drawing.Point(331, 88);
            this.Level.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(103, 25);
            this.Level.TabIndex = 5;
            this.Level.Text = "Level : 0";
            this.Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(331, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 141);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // HighscoreTitle
            // 
            this.HighscoreTitle.AutoSize = true;
            this.HighscoreTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HighscoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighscoreTitle.ForeColor = System.Drawing.Color.HotPink;
            this.HighscoreTitle.Location = new System.Drawing.Point(331, 12);
            this.HighscoreTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HighscoreTitle.Name = "HighscoreTitle";
            this.HighscoreTitle.Size = new System.Drawing.Size(139, 25);
            this.HighscoreTitle.TabIndex = 9;
            this.HighscoreTitle.Text = "High score :";
            this.HighscoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Highscore_value
            // 
            this.Highscore_value.AutoSize = true;
            this.Highscore_value.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Highscore_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore_value.ForeColor = System.Drawing.Color.HotPink;
            this.Highscore_value.Location = new System.Drawing.Point(474, 12);
            this.Highscore_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Highscore_value.Name = "Highscore_value";
            this.Highscore_value.Size = new System.Drawing.Size(25, 25);
            this.Highscore_value.TabIndex = 10;
            this.Highscore_value.Text = "0";
            this.Highscore_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris_Project.Properties.Resources.menuescreenbg1;
            this.ClientSize = new System.Drawing.Size(517, 424);
            this.Controls.Add(this.Highscore_value);
            this.Controls.Add(this.HighscoreTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreen";
            this.Text = "In Game";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Next;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label HighscoreTitle;
        private System.Windows.Forms.Label Highscore_value;
    }
}