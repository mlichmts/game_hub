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
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Collections.Specialized.BitVector32;

namespace game_hub
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr; 
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_input.Text.Trim();
            string password = password_input.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            string query = "SELECT * FROM data_hub WHERE username = @username AND password = @password";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Close();
                Session.LoggedUsername = username;
                MessageBox.Show("Logged in as " + username);
                new MainMenu().Show();
                this.Hide();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Invalid username or password.");
            }

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Session.Connect_String = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mlich\source\repos\game_hub\game_hub\data_hub.mdf;Integrated Security=True");
            
            cn = new SqlConnection(Session.Connect_String);
            
            cn.Open();
            Getnames();
            update();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = username_input.Text.Trim();
            string password = password_input.Text.Trim();
            Session.LoggedUsername = username;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            // Check if user already exists
            string checkQuery = "SELECT * FROM data_hub WHERE username = @username";
            cmd = new SqlCommand(checkQuery, cn);
            cmd.Parameters.AddWithValue("@username", username);

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                MessageBox.Show("Username already exists.");
                return;
            }
            dr.Close();

            // Register user
            string insertQuery = "INSERT INTO data_hub (username, password, game1, game2, game3, game4, total) VALUES (@username, @password, 0, 0, 0, 0, 0)";
            cmd = new SqlCommand(insertQuery, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registered successfully as " + username);
            new MainMenu().Show();
            this.Hide();
            Getnames();
        }

        private void Getnames()
        {
            
            cmd = new SqlCommand("Select * from data_hub", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void update()
        {
            
            cmd = new SqlCommand(@"UPDATE data_hub SET total = ISNULL(game1, 0) + ISNULL(game2, 0) + ISNULL(game3, 0) + ISNULL(game4, 0)", cn);
            
            cmd.ExecuteNonQuery();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
