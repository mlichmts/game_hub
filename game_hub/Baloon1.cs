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
    public partial class Baloon1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        int speed;
        int score;
        Random rand = new Random();
        bool gameOver;
        int oldscore;


        public Baloon1()
        {
            InitializeComponent();
            
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;

            if (gameOver == true)
            {
                score_result.Text = "";
                gameTimer.Stop();
                txtScore.Text = "Score: " + score + " Game over, press enter to restart!";
            }

            foreach(Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Top -= speed;

                    if (x.Top < -100)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 500);
                    }

                    if ((string)x.Tag == "balloon")
                    {

                        if (x.Top < -50)
                        {
                            gameOver = true;
                        }

                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = rand.Next(700, 1000);
                            x.Left = rand.Next(5, 500);
                        }
                    }
                }

            }


            if (score > 5)
            {
                speed = 8;
            }

            if (score > 15)
            {
                speed = 10;
            }
            if (score > 25)
            {
                speed = 12;
            }
            if (score > 33)
            {
                speed = 15;
            }


        }

        private void PopBalloon(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                var balloon = (PictureBox)sender;

                balloon.Top = rand.Next(750, 1000);
                balloon.Left = rand.Next(5, 500);

                score += 1;

            }


        }

        private void GoBoom(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                gameOver = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                new MainMenu().Show();
            }
        }

        private void RestartGame()
        {
            cn = new SqlConnection(Session.Connect_String);
            cn.Open();

            string query2 = "SELECT game2 FROM data_hub WHERE username = @username";
            cmd = new SqlCommand(query2, cn);
            cmd.Parameters.AddWithValue("@username", Session.LoggedUsername);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                oldscore = Convert.ToInt32(result);
            }
            else
            {
                oldscore = 0; // default if there's no previous score
            }

            score_result.Text += Environment.NewLine + "Staré skore: " + oldscore + Environment.NewLine + "Nové skore: " + score;

            // Update the database only if new score is higher
            if (score > oldscore)
            {
                string query = "UPDATE data_hub SET game2 = @score WHERE username = @username";
                SqlCommand updateCmd = new SqlCommand(query, cn);
                updateCmd.Parameters.AddWithValue("@score", score);
                updateCmd.Parameters.AddWithValue("@username", Session.LoggedUsername);
                updateCmd.ExecuteNonQuery();
            }

            cn.Close();

            speed = 5;
            score = 0;
            gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = rand.Next(750, 1000);
                    x.Left = rand.Next(5, 500);
                }
            }

            gameTimer.Start();
        }
        private void Baloon1_Load(object sender, EventArgs e)   
        {

        }
    }
}
