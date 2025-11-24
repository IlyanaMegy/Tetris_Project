using System;
using System.Windows.Forms;

namespace Tetris_Project
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
            this.Text = "Tetris Game - Settings";
        }

        private void SettingsScreen_Load(object sender, EventArgs e)
        {

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuScreen)
                {
                    form.Show();
                    form.BringToFront();
                    return;
                }
            }
            MenuScreen menuWin = new MenuScreen();
            menuWin.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            this.Close();
            GameScreen gameWin = new GameScreen();
            gameWin.Show();
        }

        private void ResetHighscore_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.highscore = "0";
        }
    }
}
