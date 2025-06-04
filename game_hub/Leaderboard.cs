using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_hub
{
    public partial class Leaderboard : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public Leaderboard()
        {
            InitializeComponent();


        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Session.Connect_String);

            cn.Open();
            firstPlace();
            getnames();




        }

        private void firstPlace()
        {
            cmd = new SqlCommand(@"SELECT TOP 3 username, total FROM data_hub ORDER BY total DESC ", cn);

            cmd.Parameters.AddWithValue("@username", Session.LoggedUsername);

            using (dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    string topUsername = dr["username"].ToString();
                    int topScore = Convert.ToInt32(dr["total"]);

                    first_place.Text = $"1st: {topUsername} - {topScore} pts";
                }
                if (dr.Read()) 
                {
                    string secondUsername = dr["username"].ToString();
                    int secondTotal = Convert.ToInt32(dr["total"]);
                    second_place.Text = $"2nd: {secondUsername} - {secondTotal} pts";
                }

                if (dr.Read()) 
                {
                    string thirdUsername = dr["username"].ToString();
                    int thirdTotal = Convert.ToInt32(dr["total"]);
                    third_place.Text = $"3rd: {thirdUsername} - {thirdTotal} pts";
                }

            }
        }
        private void getnames()
        {
            cmd = new SqlCommand("Select username, game1 , game2, game3, game4, total from data_hub order by total DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select username, game1 from data_hub order by game1 DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select username, game2 from data_hub order by game2 DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select username, game3 from data_hub order by game3 DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select username,game4 from data_hub order by game4 DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select username, game1 , game2, game3, game4, total from data_hub order by total DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
