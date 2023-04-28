// The namespace organizes the code into a named group, preventing naming conflicts with other code.
namespace Space_Shooter
{
	// The partial class is a class that can be split into multiple files. In this case, the class is split into two files: Form1.cs and Form1.Designer.cs.
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// Initializes the form components.
			this.components = new System.ComponentModel.Container();
			this.player = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.alien = new System.Windows.Forms.PictureBox();
			this.ship = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_score = new System.Windows.Forms.Label();
			this.lbl_over = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// player
			// 
			// Initializes the player object and sets its properties.
			this.player.Image = global::Space_Shooter.Properties.Resources.player_img;
			this.player.Location = new System.Drawing.Point(223, 379);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(46, 45);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.player.TabIndex = 0;
			this.player.TabStop = false;
			// 
			// timer1
			// 
			// Initializes the timer object and sets its properties.
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// alien
			// 
			// Initializes the alien object and sets its properties.
			this.alien.Image = global::Space_Shooter.Properties.Resources.alien_gif;
			this.alien.Location = new System.Drawing.Point(101, 34);
			this.alien.Name = "alien";
			this.alien.Size = new System.Drawing.Size(60, 60);
			this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.alien.TabIndex = 1;
			this.alien.TabStop = false;
			this.alien.Tag = "enemy";
			// 
			// ship
			// 
			// Initializes the ship object and sets its properties.
			this.ship.Image = global::Space_Shooter.Properties.Resources.ship_gif;
			this.ship.Location = new System.Drawing.Point(330, 54);
			this.ship.Name = "ship";
			this.ship.Size = new System.Drawing.Size(50, 27);
			this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ship.TabIndex = 2;
			this.ship.TabStop = false;
			this.ship.Tag = "enemy";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Space_Shooter.Properties.Resources.Stars_img;
			this.pictureBox1.Location = new System.Drawing.Point(12, 260);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(460, 164);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "stars";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Space_Shooter.Properties.Resources.Stars_img;
			this.pictureBox2.Location = new System.Drawing.Point(12, 54);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(460, 164);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "stars";
			// 
			// lbl_score
			// 
			this.lbl_score.AutoSize = true;
			this.lbl_score.BackColor = System.Drawing.Color.Transparent;
			this.lbl_score.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_score.ForeColor = System.Drawing.Color.Cyan;
			this.lbl_score.Location = new System.Drawing.Point(0, -1);
			this.lbl_score.Name = "lbl_score";
			this.lbl_score.Size = new System.Drawing.Size(121, 32);
			this.lbl_score.TabIndex = 5;
			this.lbl_score.Text = "Score : 0";
			// 
			// lbl_over
			// 
			this.lbl_over.AutoSize = true;
			this.lbl_over.BackColor = System.Drawing.Color.Transparent;
			this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lbl_over.Location = new System.Drawing.Point(99, 190);
			this.lbl_over.Name = "lbl_over";
			this.lbl_over.Size = new System.Drawing.Size(279, 57);
			this.lbl_over.TabIndex = 6;
			this.lbl_over.Text = "Game-Over";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.lbl_over);
			this.Controls.Add(this.lbl_score);
			this.Controls.Add(this.ship);
			this.Controls.Add(this.alien);
			this.Controls.Add(this.player);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox player;
		private System.Windows.Forms.Timer timer1;
		private PictureBox alien;
		private PictureBox ship;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label lbl_score;
		private Label lbl_over;
	}
}
