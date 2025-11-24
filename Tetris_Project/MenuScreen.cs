using System;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris_Project
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();

            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Anchor = AnchorStyles.Top;

            CenterButtons();
            this.Text = "Tetris Game - Home";
        }

        private void CenterButtons()
        {
            GoToPlay.Location = new Point((this.ClientSize.Width - GoToPlay.Width) / 2, GoToPlay.Location.Y);
            GoToSettings.Location = new Point((this.ClientSize.Width - GoToSettings.Width) / 2, GoToSettings.Location.Y);
            ExitGame.Location = new Point((this.ClientSize.Width - ExitGame.Width) / 2, ExitGame.Location.Y);
        }

        private void GoToSettings_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsWin = new SettingsScreen();
            this.Hide();
            settingsWin.Show();
        }

        private void GoToPlay_Click(object sender, EventArgs e)
        {
            GameScreen gameWin = new GameScreen();
            this.Hide();
            gameWin.Show();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
