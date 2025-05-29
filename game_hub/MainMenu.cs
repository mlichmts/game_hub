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

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
            MessageBox.Show(Session.LoggedUsername);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Jet1().Show();
            this.Close();
        }
    }
}
