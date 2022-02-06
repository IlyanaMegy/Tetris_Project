using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_Project
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}
