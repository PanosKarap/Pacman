using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtomikhErgasia2
{
    public partial class GameOver_Screen : Form
    {
        public int gettotalPoints { get; set; }
        public GameOver_Screen()
        {
            InitializeComponent();
        }

        private void GameOver_Screen_Load(object sender, EventArgs e) // Εμφάνιση τελικού σκορ
        {
            total_label.Text = "Total Points: " + gettotalPoints; 
        }
    }
}
