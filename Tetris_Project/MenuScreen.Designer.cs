namespace Tetris_Project
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.Title = new System.Windows.Forms.Label();
            this.GoToPlay = new System.Windows.Forms.Button();
            this.GoToSettings = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Title.Location = new System.Drawing.Point(219, 109);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(222, 90);
            this.Title.TabIndex = 0;
            this.Title.Text = "TETRIS";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToPlay
            // 
            this.GoToPlay.AutoSize = true;
            this.GoToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GoToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToPlay.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoToPlay.Location = new System.Drawing.Point(264, 240);
            this.GoToPlay.Name = "GoToPlay";
            this.GoToPlay.Size = new System.Drawing.Size(132, 39);
            this.GoToPlay.TabIndex = 1;
            this.GoToPlay.Text = "PLAY NOW";
            this.GoToPlay.UseVisualStyleBackColor = false;
            this.GoToPlay.Click += new System.EventHandler(this.GoToPlay_Click);
            // 
            // GoToSettings
            // 
            this.GoToSettings.AutoSize = true;
            this.GoToSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GoToSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToSettings.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoToSettings.Location = new System.Drawing.Point(264, 297);
            this.GoToSettings.Name = "GoToSettings";
            this.GoToSettings.Size = new System.Drawing.Size(132, 39);
            this.GoToSettings.TabIndex = 2;
            this.GoToSettings.Text = "SETTINGS";
            this.GoToSettings.UseVisualStyleBackColor = false;
            this.GoToSettings.Click += new System.EventHandler(this.GoToSettings_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.AutoSize = true;
            this.ExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitGame.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitGame.Location = new System.Drawing.Point(264, 355);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(132, 39);
            this.ExitGame.TabIndex = 3;
            this.ExitGame.Text = "QUIT";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris_Project.Properties.Resources.menuescreenbg2;
            this.ClientSize = new System.Drawing.Size(665, 521);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.GoToSettings);
            this.Controls.Add(this.GoToPlay);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuScreen";
            this.Text = "Menu Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button GoToPlay;
        private System.Windows.Forms.Button GoToSettings;
        private System.Windows.Forms.Button ExitGame;
    }
}

