﻿using System;
using System.Drawing;
using System.Windows.Forms;


namespace game_hub
{   

    public partial class Game3 : Form
    {
        private const int WIDTH = 42;
        private const int HEIGHT = 24;
        private const int INITIAL_INTERVAL = 250;
        private const int MIN_INTERVAL = 80;
        private const int SPEED_INCREASE = 10;
        private const string SCORE_STRING = "Score: {0}";
        private readonly Color m_BackgroundColor = Color.CornflowerBlue;
        private readonly Game m_Game;
        private readonly Bitmap m_GameField;
        private readonly Graphics m_GameGraphics;

        public Game3()
        {

            InitializeComponent();
            m_GameField = new Bitmap(WIDTH * Piece.SIDE, HEIGHT * Piece.SIDE);
            m_GameGraphics = Graphics.FromImage(m_GameField); m_GameGraphics.PageUnit = GraphicsUnit.Pixel;
            ClientSize = new Size(m_GameField.Width, m_GameField.Height + m_RestartBtn.Height);
            m_Game = new Game(WIDTH, HEIGHT);
            m_Timer.Start();
        }

        private void UpdateScore()
        {
            scoreLbl.Text = string.Format(SCORE_STRING, m_Game.GetScore());
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (m_Game.SnakeHasGrown())
            {
                UpdateScore();
                UpdateSpeed();
            }
            if (m_Game.Lost())
            {
                m_Timer.Stop();
                m_RestartBtn.Enabled = true;
            }
            Invalidate();
        }

        private void UpdateSpeed()
        {
            int newInterval = INITIAL_INTERVAL - (m_Game.GetScore() * SPEED_INCREASE);
            newInterval = Math.Max(newInterval, MIN_INTERVAL); 
            m_Timer.Interval = newInterval;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    m_Game.ChangeSnakeDIrection(Direction.Left);
                    break;
                case Keys.Right:
                    m_Game.ChangeSnakeDIrection(Direction.Right);
                    break;
                case Keys.Up:
                    m_Game.ChangeSnakeDIrection(Direction.Up);
                    break;
                case Keys.Down:
                    m_Game.ChangeSnakeDIrection(Direction.Down);
                    break;
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            m_GameGraphics.Clear(m_BackgroundColor);
            m_Game.Draw(m_GameGraphics);
            e.Graphics.DrawImage(m_GameField, 0, m_RestartBtn.Height);
        }

        private void OnRestartBtnClick(object sender, EventArgs e)
        {
            m_RestartBtn.Enabled = false;
            m_Game.Restart();
            UpdateScore();
            m_Timer.Interval = INITIAL_INTERVAL; 
            m_Timer.Start();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}

