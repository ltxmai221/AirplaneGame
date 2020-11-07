namespace CarRacing
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbScore = new System.Windows.Forms.Label();
			this.lbGameOver = new System.Windows.Forms.Label();
			this.btnReplay = new System.Windows.Forms.Button();
			this.coin3 = new System.Windows.Forms.PictureBox();
			this.coin4 = new System.Windows.Forms.PictureBox();
			this.coin2 = new System.Windows.Forms.PictureBox();
			this.coin1 = new System.Windows.Forms.PictureBox();
			this.picCloud2 = new System.Windows.Forms.PictureBox();
			this.picCloud1 = new System.Windows.Forms.PictureBox();
			this.picCloud4 = new System.Windows.Forms.PictureBox();
			this.picCloud3 = new System.Windows.Forms.PictureBox();
			this.enemy3 = new System.Windows.Forms.PictureBox();
			this.enemy1 = new System.Windows.Forms.PictureBox();
			this.enemy2 = new System.Windows.Forms.PictureBox();
			this.enemy4 = new System.Windows.Forms.PictureBox();
			this.plane = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbScore
			// 
			this.lbScore.AutoSize = true;
			this.lbScore.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.ForeColor = System.Drawing.Color.Red;
			this.lbScore.Location = new System.Drawing.Point(2, 9);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(116, 31);
			this.lbScore.TabIndex = 4;
			this.lbScore.Text = "Score:";
			// 
			// lbGameOver
			// 
			this.lbGameOver.AutoSize = true;
			this.lbGameOver.BackColor = System.Drawing.Color.Gray;
			this.lbGameOver.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGameOver.ForeColor = System.Drawing.Color.Coral;
			this.lbGameOver.Location = new System.Drawing.Point(295, 213);
			this.lbGameOver.Name = "lbGameOver";
			this.lbGameOver.Size = new System.Drawing.Size(470, 90);
			this.lbGameOver.TabIndex = 5;
			this.lbGameOver.Text = "GAME OVER";
			// 
			// btnReplay
			// 
			this.btnReplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnReplay.ForeColor = System.Drawing.Color.Transparent;
			this.btnReplay.Image = global::AirPlane.Properties.Resources.play;
			this.btnReplay.Location = new System.Drawing.Point(443, 306);
			this.btnReplay.Name = "btnReplay";
			this.btnReplay.Size = new System.Drawing.Size(143, 134);
			this.btnReplay.TabIndex = 7;
			this.btnReplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReplay.UseVisualStyleBackColor = false;
			this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
			// 
			// coin3
			// 
			this.coin3.BackColor = System.Drawing.Color.Transparent;
			this.coin3.Image = global::AirPlane.Properties.Resources.coin;
			this.coin3.Location = new System.Drawing.Point(912, 365);
			this.coin3.Name = "coin3";
			this.coin3.Size = new System.Drawing.Size(50, 50);
			this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin3.TabIndex = 6;
			this.coin3.TabStop = false;
			// 
			// coin4
			// 
			this.coin4.BackColor = System.Drawing.Color.Transparent;
			this.coin4.Image = global::AirPlane.Properties.Resources.coin;
			this.coin4.Location = new System.Drawing.Point(391, 544);
			this.coin4.Name = "coin4";
			this.coin4.Size = new System.Drawing.Size(50, 50);
			this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin4.TabIndex = 6;
			this.coin4.TabStop = false;
			// 
			// coin2
			// 
			this.coin2.BackColor = System.Drawing.Color.Transparent;
			this.coin2.Image = global::AirPlane.Properties.Resources.coin;
			this.coin2.Location = new System.Drawing.Point(771, 190);
			this.coin2.Name = "coin2";
			this.coin2.Size = new System.Drawing.Size(50, 50);
			this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin2.TabIndex = 6;
			this.coin2.TabStop = false;
			// 
			// coin1
			// 
			this.coin1.BackColor = System.Drawing.Color.Transparent;
			this.coin1.Image = global::AirPlane.Properties.Resources.coin;
			this.coin1.Location = new System.Drawing.Point(310, 120);
			this.coin1.Name = "coin1";
			this.coin1.Size = new System.Drawing.Size(50, 50);
			this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin1.TabIndex = 6;
			this.coin1.TabStop = false;
			// 
			// picCloud2
			// 
			this.picCloud2.BackColor = System.Drawing.Color.Transparent;
			this.picCloud2.Image = global::AirPlane.Properties.Resources.cloud1;
			this.picCloud2.Location = new System.Drawing.Point(26, 477);
			this.picCloud2.Name = "picCloud2";
			this.picCloud2.Size = new System.Drawing.Size(185, 80);
			this.picCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloud2.TabIndex = 3;
			this.picCloud2.TabStop = false;
			// 
			// picCloud1
			// 
			this.picCloud1.BackColor = System.Drawing.Color.Transparent;
			this.picCloud1.Image = global::AirPlane.Properties.Resources.cloud1;
			this.picCloud1.Location = new System.Drawing.Point(85, 69);
			this.picCloud1.Name = "picCloud1";
			this.picCloud1.Size = new System.Drawing.Size(185, 80);
			this.picCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloud1.TabIndex = 3;
			this.picCloud1.TabStop = false;
			// 
			// picCloud4
			// 
			this.picCloud4.BackColor = System.Drawing.Color.Transparent;
			this.picCloud4.Image = global::AirPlane.Properties.Resources.cloud1;
			this.picCloud4.Location = new System.Drawing.Point(885, 561);
			this.picCloud4.Name = "picCloud4";
			this.picCloud4.Size = new System.Drawing.Size(185, 80);
			this.picCloud4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloud4.TabIndex = 3;
			this.picCloud4.TabStop = false;
			// 
			// picCloud3
			// 
			this.picCloud3.BackColor = System.Drawing.Color.Transparent;
			this.picCloud3.Image = global::AirPlane.Properties.Resources.cloud1;
			this.picCloud3.Location = new System.Drawing.Point(640, 12);
			this.picCloud3.Name = "picCloud3";
			this.picCloud3.Size = new System.Drawing.Size(171, 74);
			this.picCloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloud3.TabIndex = 3;
			this.picCloud3.TabStop = false;
			// 
			// enemy3
			// 
			this.enemy3.BackColor = System.Drawing.Color.Transparent;
			this.enemy3.Image = global::AirPlane.Properties.Resources.plane;
			this.enemy3.Location = new System.Drawing.Point(605, 407);
			this.enemy3.Name = "enemy3";
			this.enemy3.Size = new System.Drawing.Size(133, 79);
			this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.enemy3.TabIndex = 1;
			this.enemy3.TabStop = false;
			// 
			// enemy1
			// 
			this.enemy1.BackColor = System.Drawing.Color.Transparent;
			this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
			this.enemy1.Location = new System.Drawing.Point(310, 39);
			this.enemy1.Name = "enemy1";
			this.enemy1.Size = new System.Drawing.Size(131, 75);
			this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy1.TabIndex = 1;
			this.enemy1.TabStop = false;
			// 
			// enemy2
			// 
			this.enemy2.BackColor = System.Drawing.Color.Transparent;
			this.enemy2.Image = global::AirPlane.Properties.Resources.plane;
			this.enemy2.Location = new System.Drawing.Point(893, 163);
			this.enemy2.Name = "enemy2";
			this.enemy2.Size = new System.Drawing.Size(128, 77);
			this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.enemy2.TabIndex = 1;
			this.enemy2.TabStop = false;
			// 
			// enemy4
			// 
			this.enemy4.BackColor = System.Drawing.Color.Transparent;
			this.enemy4.Image = global::AirPlane.Properties.Resources.plane;
			this.enemy4.Location = new System.Drawing.Point(217, 558);
			this.enemy4.Name = "enemy4";
			this.enemy4.Size = new System.Drawing.Size(149, 80);
			this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.enemy4.TabIndex = 1;
			this.enemy4.TabStop = false;
			// 
			// plane
			// 
			this.plane.BackColor = System.Drawing.Color.Transparent;
			this.plane.Image = global::AirPlane.Properties.Resources.plane2;
			this.plane.Location = new System.Drawing.Point(8, 252);
			this.plane.Name = "plane";
			this.plane.Size = new System.Drawing.Size(173, 93);
			this.plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.plane.TabIndex = 1;
			this.plane.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1082, 653);
			this.Controls.Add(this.btnReplay);
			this.Controls.Add(this.coin3);
			this.Controls.Add(this.coin4);
			this.Controls.Add(this.coin2);
			this.Controls.Add(this.coin1);
			this.Controls.Add(this.lbGameOver);
			this.Controls.Add(this.lbScore);
			this.Controls.Add(this.picCloud2);
			this.Controls.Add(this.picCloud1);
			this.Controls.Add(this.picCloud4);
			this.Controls.Add(this.picCloud3);
			this.Controls.Add(this.enemy3);
			this.Controls.Add(this.enemy1);
			this.Controls.Add(this.enemy2);
			this.Controls.Add(this.enemy4);
			this.Controls.Add(this.plane);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCloud3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox plane;
		private System.Windows.Forms.PictureBox enemy4;
		private System.Windows.Forms.PictureBox enemy2;
		private System.Windows.Forms.PictureBox picCloud3;
		private System.Windows.Forms.PictureBox picCloud4;
		private System.Windows.Forms.PictureBox enemy3;
		private System.Windows.Forms.PictureBox picCloud2;
		private System.Windows.Forms.PictureBox picCloud1;
		private System.Windows.Forms.PictureBox enemy1;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label lbGameOver;
		private System.Windows.Forms.PictureBox coin1;
		private System.Windows.Forms.PictureBox coin2;
		private System.Windows.Forms.PictureBox coin4;
		private System.Windows.Forms.PictureBox coin3;
		private System.Windows.Forms.Button btnReplay;
	}
}

