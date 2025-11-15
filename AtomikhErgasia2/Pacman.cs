using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace AtomikhErgasia2
{
    public partial class Pacman : Form
    {
        SoundPlayer eat_sound = new SoundPlayer("sounds/eaten.wav"); // Eat Cherry sound
        SoundPlayer finish_sound = new SoundPlayer("sounds/finish.wav"); // Game Over sound
        SoundPlayer lowtime_sound = new SoundPlayer("sounds/lowtime.wav"); // Low Time sound (ενεργοποιείται όταν απομένουν 10 δευτερόλεπτα)

        private Keys key; // Πλήκτρο από τα arrows
        private Image pacmanImage; // Εικόνα Pacman ανάλογα με την κατεύθυνση που επιλέγει ο χρήστης
        public string getDifficulty {  get; set; }
        public SQLiteConnection getConnection { get; set; }

        private Point pacmancenterPoint;
        private Point cherrycenterPoint;

        private bool gameEnded = false;
        private bool keyHeldDown = false;

        private int points = 0;
        private int countdown;

        PictureBox pictureBox2; // Για το Cherry
        Random random_cherry; // Για τυχαία αναπαραγωγή συντεταγμένων για το Cherry
        Random random_color; // Για τυχαία αναπαραγωγή χρώαματος στο background για το Hard Mode
        public Pacman()
        {
            InitializeComponent();
        }

        private void Pacman_Load(object sender, EventArgs e)
        {

            // Εφαρμογή χρόνου παιχνιδιού και respawn για το Cherry ανάλογα με την δυσκολία που έχει επιλέξει ο χρήστης
            if (getDifficulty.Equals("easy"))
            {
                cherry_timer.Interval = 3000;
                countdown = 100;
            }
            else
            {
                cherry_timer.Interval = 2000;
                countdown = 60;
                change_color_timer.Start();
            }
            timer_label.Text = "Time: " + countdown + "s";
            countdown_timer.Start();
            cherry_timer.Start();
            spawn_cherry();
        }

        private void Pacman_KeyDown(object sender, KeyEventArgs e) // Κίνηση Pacman και προσαρμογή ανάλογης εικόνας
        {
            if (keyHeldDown) return; // Για να μην επιτρέπει στον χρήστη να κρατήσει τα keys πατημένα, οδηγώντας σε crash του προγράμματος
            keyHeldDown = true;

            key = e.KeyCode;
            if (key == Keys.Right)
            {
                pacmanImage = Image.FromFile("photos/pacman_right.png");
            }
            else if (key == Keys.Left)
            {
                pacmanImage = Image.FromFile("photos/pacman_left.png");
            }
            else if (key == Keys.Up)
            {
                pacmanImage = Image.FromFile("photos/pacman_up.png");
            }
            else if (key == Keys.Down)
            {
                pacmanImage = Image.FromFile("photos/pacman_down.png");
            }
            pacman_picturebox.Image = pacmanImage;
            pacman_timer.Start();
        }

        private void Pacman_KeyUp(object sender, KeyEventArgs e)
        {
            keyHeldDown = false;
        }

        private void cherry_timer_Tick(object sender, EventArgs e) // Αναπαραγωγή Cherry αν δεν έχει φαγωθεί εντός χρόνου
        {
            Controls.Remove(pictureBox2);
            spawn_cherry();
        }

        private void pacman_timer_Tick(object sender, EventArgs e)
        {
            // Εύρεση του κεντρικού σημείου του Pacman
            pacmancenterPoint = new Point(pacman_picturebox.Location.X + pacman_picturebox.Width / 2, pacman_picturebox.Location.Y + pacman_picturebox.Height / 2);

            // Κίνηση του Pacman με ελέγχους για αποφυγή τροχιάς εκτός φόρμας
            if (key == Keys.Right)
            {
                if (pacmancenterPoint.X < ClientSize.Width)
                {
                    pacman_picturebox.Location = new Point(pacman_picturebox.Location.X + 7, pacman_picturebox.Location.Y);
                }
                else pacman_timer.Stop();
            }
            else if (key == Keys.Left)
            {
                if (pacmancenterPoint.X > 0)
                {
                    pacman_picturebox.Location = new Point(pacman_picturebox.Location.X - 7, pacman_picturebox.Location.Y);
                }
                else pacman_timer.Stop();
            }
            else if (key == Keys.Up)
            {
                if (pacmancenterPoint.Y > 15)
                {
                    pacman_picturebox.Location = new Point(pacman_picturebox.Location.X, pacman_picturebox.Location.Y - 7);
                }
                else pacman_timer.Stop();
            }
            else if (key == Keys.Down)
            {
                if (pacmancenterPoint.Y < ClientSize.Height)
                {
                    pacman_picturebox.Location = new Point(pacman_picturebox.Location.X, pacman_picturebox.Location.Y + 7);
                }
                else pacman_timer.Stop();
            }

            // Έλεγχος απόστασης μεταξύ Pacman και Cherry
            if (Math.Sqrt(Math.Pow(cherrycenterPoint.X - pacmancenterPoint.X, 2) + Math.Pow(cherrycenterPoint.Y - pacmancenterPoint.Y, 2)) < 40)
            {
                    eat_sound.Play();
                    Controls.Remove(pictureBox2);
                    cherry_timer.Stop();
                
                    if (getDifficulty.Equals("easy")) { points++; } else { points = points + 2; }
                    points_label.Text = "Points: " + points;

                    spawn_cherry();
                    cherry_timer.Start();                
            }
        }

        private void spawn_cherry()
        {
            random_cherry = new Random();
            int x = random_cherry.Next(5, 1250);
            int y = random_cherry.Next(15, 650);

            pictureBox2 = new PictureBox(); // Δημιουργία Cherry
            pictureBox2.Location = new Point(x, y);
            pictureBox2.Image = Image.FromFile("photos/cherry.png");
            if (getDifficulty.Equals("easy"))
            {
                pictureBox2.Size = new Size(30, 30);
            }
            else pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(pictureBox2);
            cherrycenterPoint = new Point(pictureBox2.Location.X + pictureBox2.Width / 2, pictureBox2.Location.Y + pictureBox2.Height / 2);
        }

        private void countdown_timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            timer_label.Text = "Time: " + countdown + "s";
            if (countdown == 10) 
            { 
                timer_label.ForeColor = Color.Red;
                lowtime_sound.Play();
            }
            if (countdown == 0) 
            {
                if (!gameEnded)
                { // Όταν μπούμε εδώ σημαίνει πως έχει τελειώσει ο γύρος

                    getConnection.Open(); // Ανοίγουμε το Database

                    gameEnded = true;
                    if (getDifficulty.Equals("hard")) { change_color_timer.Stop(); }
                    countdown_timer.Stop();
                    cherry_timer.Stop();
                    pacman_timer.Stop();

                    finish_sound.Play();
                    GameOver_Screen gameOver_Screen = new GameOver_Screen();
                    gameOver_Screen.gettotalPoints = points; // Πέρασμα πόντων στη φόρμα GameOver_Screen για εμφάνιση του τελικού σκορ
                    gameOver_Screen.ShowDialog();

                    // Πέρασμα πόντων στο Database
                    String insertSQL = "Insert into Scoreboard (score) " + "values(@score)";
                    SQLiteCommand insertCommand = new SQLiteCommand(insertSQL, getConnection);
                    insertCommand.Parameters.AddWithValue("score", points);
                    insertCommand.ExecuteNonQuery();

                    getConnection.Close(); // Κλείνουμε το Database
                    this.Close();
                }
            }
        }

        // Σε περίπτωση που ο χρήστης πατήσει Play και πριν τελειώσει ο χρόνος πατήσει Χ,
        // θα σταματήσει οποιαδήποτε διεργασία αφορά το gameplay εντός της Pacman και δεν θα μετρήσει σκορ
        private void Pacman_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameEnded = true;
            if (getDifficulty.Equals("hard")) { change_color_timer.Stop(); }
            countdown_timer.Stop();
            cherry_timer.Stop();
            pacman_timer.Stop();
        }

        private void change_color_timer_Tick(object sender, EventArgs e)
        {
            random_color = new Random();
            Color[] randomColors = new Color[20];
            for (int i = 0; i < randomColors.Length; i++)
            {
                randomColors[i] = Color.FromArgb(random_color.Next(256), random_color.Next(256), random_color.Next(256));
            }
            int random_index = random_color.Next(0, randomColors.Length);
            this.BackColor = randomColors[random_index];
        }
    }
}