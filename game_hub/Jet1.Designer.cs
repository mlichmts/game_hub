﻿namespace game_hub
{
    partial class Jet1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.score_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(0, 277);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(798, 150);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // player
            // 
            this.player.BackgroundImage = global::game_hub.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(334, 564);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackgroundImage = global::game_hub.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(473, 304);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 0;
            this.bullet.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.BackgroundImage = global::game_hub.Properties.Resources.enemy;
            this.enemyThree.Location = new System.Drawing.Point(664, 62);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 85);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyThree.TabIndex = 0;
            this.enemyThree.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackgroundImage = global::game_hub.Properties.Resources.enemy;
            this.enemyTwo.InitialImage = global::game_hub.Properties.Resources.enemy;
            this.enemyTwo.Location = new System.Drawing.Point(334, 62);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(100, 85);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyTwo.TabIndex = 0;
            this.enemyTwo.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.BackgroundImage = global::game_hub.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(26, 62);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 85);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // score_result
            // 
            this.score_result.Location = new System.Drawing.Point(550, 17);
            this.score_result.Name = "score_result";
            this.score_result.Size = new System.Drawing.Size(238, 80);
            this.score_result.TabIndex = 2;
            // 
            // Jet1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.score_result);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.txtScore);
            this.Name = "Jet1";
            this.Text = "Fighet Jet Shooting Game MOOI CT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label score_result;
    }
}

