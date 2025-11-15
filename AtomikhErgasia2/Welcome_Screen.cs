using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AtomikhErgasia2
{
    public partial class Welcome_Screen : Form
    {
        String connectionString = "Data source=scoreboard.db;Version=3";
        SQLiteConnection connection;

        private string difficulty;

        public Welcome_Screen()
        {
            InitializeComponent();
        }

        private void Welcome_Screen_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();

            String createTableSQL = "Create table if not exists Scoreboard(" +
                "Score integer)";
            SQLiteCommand command = new SQLiteCommand(createTableSQL, connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }

        private void easy_button_CheckedChanged(object sender, EventArgs e)
        {
            rules_label.Text = "(Time: 100s / Respawn: 3s / Cherry Points: 1)";
        }

        private void hard_button_CheckedChanged(object sender, EventArgs e)
        {
            rules_label.Text = "(Time: 60s / Respawn: 2s / Cherry Points: 2)";
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            SoundPlayer select_sound = new SoundPlayer("sounds/select.wav");
            select_sound.Play();

            Pacman pacman = new Pacman();
            pacman.getConnection = connection; // Πέρασμα connection του database στο Pacman

            if (easy_button.Checked)
            {
                difficulty = "easy";
            }
            else { difficulty = "hard"; }
            pacman.getDifficulty = difficulty; // Πέρασμα δυσκολίας στη φόρμα Pacman

            pacman.ShowDialog();
        }

        private void scoreboard_button_Click(object sender, EventArgs e)
        {
            SoundPlayer select_sound = new SoundPlayer("sounds/select.wav");
            select_sound.Play();

            Scoreboard scoreboard = new Scoreboard();
            scoreboard.getConnection = connection; // Πέρασμα connection του database στο Scoreboard

            scoreboard.ShowDialog();
        }
    }
}
