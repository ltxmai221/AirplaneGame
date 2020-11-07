using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lbGameOver.Visible = false;
			btnReplay.Visible = false;
		}

		int gamespeed = 20;
		int score = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			moveClouds(gamespeed);
			enemy(gamespeed);
			gameOver();
			coins(gamespeed);
			bonusCoins();
		}

		void moveClouds(int speed)
		{
			picCloud1.Left -= gamespeed;
			picCloud2.Left -= gamespeed;
			picCloud3.Left -= gamespeed;
			picCloud4.Left -= gamespeed;
			if (picCloud1.Left < 0)
				picCloud1.Left = 1100;
			if (picCloud2.Left < 0)
				picCloud2.Left = 1100;
			if (picCloud3.Left < 0)
				picCloud3.Left = 1100;
			if (picCloud4.Left < 0)
				picCloud4.Left = 1100;
		}

		Random r = new Random();
		int x, y;
		void enemy (int gamespeed)
		{
			if (enemy1.Right <= 0)
			{
				y = r.Next(0, 175);
				enemy1.Location = new Point(1100, y);
			}
			else { enemy1.Left -= gamespeed; }

			if (enemy2.Right <= 0)
			{
				y = r.Next(175, 350);
				enemy2.Location = new Point(1100, y);
			}
			else { enemy2.Left -= gamespeed; }

			if (enemy3.Right <= 0)
			{
				y = r.Next(350, 525);
				enemy3.Location = new Point(1100, y);
			}
			else { enemy3.Left -= gamespeed; }

			if (enemy4.Right <= 0)
			{
				y = r.Next(525, 700);
				enemy4.Location = new Point(1100, y);
			}
			else { enemy4.Left -= gamespeed; }
		}

		void coins(int gamespeed)
		{
			if (coin1.Right <= 0)
			{
				y = r.Next(0, 175);
				coin1.Location = new Point(1000, y);
			}
			else { coin1.Left -= gamespeed; }

			if (coin2.Right <= 0)
			{
				y = r.Next(175, 350);
				coin2.Location = new Point(1000, y);
			}
			else { coin2.Left -= gamespeed; }

			if (coin3.Right <= 0)
			{
				y = r.Next(350, 525);
				coin3.Location = new Point(1000, y);
			}
			else { coin3.Left -= gamespeed; }

			if (coin4.Right <= 0)
			{
				y = r.Next(525, 700);
				coin4.Location = new Point(1000, y);
			}
			else { coin4.Left -= gamespeed; }
		}

		void bonusCoins()
		{
			if (plane.Bounds.IntersectsWith(coin1.Bounds))
			{
				score++;
				lbScore.Text = "Score: " + score.ToString();
				y = r.Next(0, 175);
				coin1.Location = new Point(1000, y);
			}		
			
			if (plane.Bounds.IntersectsWith(coin2.Bounds))
			{
				score++;
				lbScore.Text = "Score: " + score.ToString();
				y = r.Next(175, 350);
				coin2.Location = new Point(1000, y);
			}	

			if (plane.Bounds.IntersectsWith(coin3.Bounds))
			{
				score++;
				lbScore.Text = "Score: " + score.ToString();
				y = r.Next(350, 525);
				coin3.Location = new Point(1000, y);
			}

			if (plane.Bounds.IntersectsWith(coin4.Bounds))
			{
				score++;
				lbScore.Text = "Score: " + score.ToString();
				y = r.Next(525, 700);
				coin4.Location = new Point(1000, y);
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left && plane.Left > 0)
				plane.Left -= gamespeed;

			if (e.KeyCode == Keys.Right && plane.Right < 820)
				plane.Left += gamespeed;
				
			if (e.KeyCode == Keys.Up && plane.Top > 0)
				plane.Top += -gamespeed;

			if (e.KeyCode == Keys.Down && plane.Bottom < 520)
				plane.Top += gamespeed;
		}

		private void btnReplay_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();
		}

		void gameOver()
		{
			if(plane.Bounds.IntersectsWith(enemy1.Bounds) || 
				plane.Bounds.IntersectsWith(enemy2.Bounds) ||
				plane.Bounds.IntersectsWith(enemy3.Bounds) ||
				plane.Bounds.IntersectsWith(enemy4.Bounds))
			{
				timer1.Enabled = false;
				lbGameOver.Visible = true;
				btnReplay.Visible = true;
			}	
		}
	}
}
