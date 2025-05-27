using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace game_hub
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("loged in as " + username);
                new MainMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("nieje v databaze");
            }

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;

            if (username != string.Empty && password != string.Empty)
            {
                MessageBox.Show("Registered in as "+ username);
                new MainMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("nieje v databaze");
            }
        }

       
    }
}
