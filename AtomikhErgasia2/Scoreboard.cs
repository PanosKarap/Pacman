using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtomikhErgasia2
{


    public partial class Scoreboard : Form
    {
        int[] topScores = new int[10]; // Δημιουργία πίνακα 10 θέσεων για διαχείρηση των 10 σκορ σε όλες τις φόρμες
        public SQLiteConnection getConnection { get; set; }
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            getConnection.Open(); // Ανοίγουμε το Database

            string query = "Select Distinct Score From Scoreboard Order By Score Desc Limit 10"; // Εξασφαλίζουμε ότι θα πάρουμε τα 10 πρώτα κελιά του database με διαφορετικές τιμές
                                                                                                 // και σε φθίνουσα σειρά, άρα τα 10 καλύτερα σκορ

            string countQuery = "Select Count(*) From Scoreboard"; // Παίρνουμε το σύνολο των κελιών που υπάρχουν στο Database,
                                                                   // άρα και όλες τις προσπάθειες που έχουν γίνει από τον χρήστη

            SQLiteCommand countCommand = new SQLiteCommand(countQuery, getConnection);
            SQLiteCommand selectCommand = new SQLiteCommand(query, getConnection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();

            int totalScores = Convert.ToInt32(countCommand.ExecuteScalar());
            int index = 0;
            while (reader.Read() && index < topScores.Length)
            {
                if (reader.IsDBNull(0)) { topScores[index] = 0; }
                else topScores[index] = reader.GetInt32(0); // Γέμισμα πίνακα με τα 10 καλύτερα σκορ
                index++;
            }

            place1_label.Text = "1st place: " + (topScores[0].ToString());
            place2_label.Text = "2nd place: " + (topScores[1].ToString());
            place3_label.Text = "3rd place: " + (topScores[2].ToString());
            place4_label.Text = "4th place: " + (topScores[3].ToString());
            place5_label.Text = "5th place: " + (topScores[4].ToString());
            place6_label.Text = "6th place: " + (topScores[5].ToString());
            place7_label.Text = "7th place: " + (topScores[6].ToString());
            place8_label.Text = "8th place: " + (topScores[7].ToString());
            place9_label.Text = "9th place: " + (topScores[8].ToString());
            place10_label.Text = "10th place: " + (topScores[9].ToString());
            lifetimeattempts_label.Text = "Lifetime attempts: " + totalScores;

            getConnection.Close();
        }

    }
}
