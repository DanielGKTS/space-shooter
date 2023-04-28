using static System.Formats.Asn1.AsnWriter; // Defining the namespace for the code

namespace Space_Shooter // Defining the namespace for the code
{
	public partial class Form1 : Form // Defining a class named Form1 that inherits from the Form class
	{
		public Form1() // Constructor for the Form1 class
		{
			InitializeComponent(); // Initializing the Form1 component
			lbl_over.Hide(); // Hiding the "Game Over" label at the start of the game

		}

		bool right, left, space; // Declaring boolean variables to keep track of key presses
		int score; // Declaring an integer variable to keep track of the player's score

		void Game_Result() // Defining a method to check the game's result
		{
			foreach (Control j in this.Controls) // Looping through all the controls on the form
			{
				foreach (Control i in this.Controls) 
				{
					if (j is PictureBox && j.Tag == "bullet") // Checking if the control is a bullet
					{
						if (i is PictureBox && i.Tag == "enemy") // Checking if the control is an enemy ship
						{
							if (j.Bounds.IntersectsWith(i.Bounds))
							{
								int x;
								Random rnd = new Random();
								x = rnd.Next(0, 350);
								i.Location = new Point(x, 0); // Moving the enemy ship to a new random position

								i.Top = -100;  // Moving the enemy ship off-screen
								((PictureBox)j).Image = Properties.Resources.explosion; // Displaying an explosion image at the bullet's location
								score++; // Increasing the player's score
								lbl_score.Text = "Score : " + score; // Updating the score label
							}
						}
					}
				}
			}
			if (player.Bounds.IntersectsWith(ship.Bounds) || player.Bounds.IntersectsWith(alien.Bounds)) // Checking if the player collides with an enemy ship
			{
				timer1.Stop(); // Stopping the game timer
				lbl_over.Show(); // Displaying the "Game Over" label
				lbl_over.BringToFront(); // Bringing the "Game Over" label to the front of the form
			}
		}

		void Star() // Defining a method to move the stars in the background
		{
			foreach (Control j in this.Controls) // Looping through all the controls on the form
			{
				if (j is PictureBox && j.Tag == "stars") // Checking if the control is a star
				{
					j.Top += 10; // Moving the star downwards
					if (j.Top > 400) // If the star goes off-screen
					{
						j.Top = 0; // Moving the star to the top of the screen
					}
				}
			}
		}

		void Add_Bullet() // Defining a method to add bullets to the form
		{
			PictureBox bullet = new PictureBox(); // Creating a new picture box for the bullet
			bullet.SizeMode = PictureBoxSizeMode.AutoSize; // Setting the size mode of the picture box to auto-size
			bullet.Image = Properties.Resources.bullet_img; // Setting the image of the picture box to the bullet image
			bullet.BackColor = System.Drawing.Color.Transparent; // Making the background of the picture box transparent
			bullet.Tag = "bullet"; // Assigning a tag to the picture box
			bullet.Left = player.Left + 15;
			bullet.Top = player.Top - 30;
			this.Controls.Add(bullet);
			bullet.BringToFront();
		}

		void Bullet_Movement()
		{
			foreach (Control x in this.Controls)
			{
				if (x is PictureBox && x.Tag == "bullet")
				{
					x.Top -= 10;
					if (x.Top < 100)
					{
						this.Controls.Remove(x);
					}
				}
			}
		}

		void Enemy_Movement()
		{
			Random rnd = new Random();
			int x, y;
			if (alien.Top >= 500)
			{
				x = rnd.Next(0, 300);
				alien.Location = new Point(x, 0);
			}
			if (ship.Top >= 500)
			{
				y = rnd.Next(0, 300);
				ship.Location = new Point(y, 0);
			}
			else
			{
				alien.Top += 15;
				ship.Top += 10;
			}
		}


		void Arrow_key_Movement()
		{
			if (right)
			{
				if (player.Left < 475)
				{
					player.Left += 20;
				}
			}
			if (left)
			{
				if (player.Left > 25)
				{
					player.Left -= 20;
				}
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right)
			{
				right = true;
			}
			if (e.KeyCode == Keys.Left)
			{
				left = true;
			}
			if (e.KeyCode == Keys.Space)
			{
				space = true;
				Add_Bullet();
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right)
			{
				right = false;
			}
			if (e.KeyCode == Keys.Left)
			{
				left = false;
			}
			if (e.KeyCode == Keys.Space)
			{
				space = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Arrow_key_Movement();
			Enemy_Movement();
			Bullet_Movement();
			Star();
			Game_Result();
		}

	}
}
