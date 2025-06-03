using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_hub
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // back to log in button
        {
            new Form1().Show();
            this.Close();
            MessageBox.Show(Session.LoggedUsername);
        }

        private void button2_Click(object sender, EventArgs e) // jet game button
        {
            new Jet1().Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) // baloon game button
        {
            new Baloon1().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) //leaderboard button
        {
            new Leaderboard().Show();
            this.Close();
        }
    }
}
