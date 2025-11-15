namespace AtomikhErgasia2
{
    partial class Pacman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacman));
            this.pacman_timer = new System.Windows.Forms.Timer(this.components);
            this.cherry_timer = new System.Windows.Forms.Timer(this.components);
            this.countdown_timer = new System.Windows.Forms.Timer(this.components);
            this.points_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.change_color_timer = new System.Windows.Forms.Timer(this.components);
            this.pacman_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacman_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pacman_timer
            // 
            this.pacman_timer.Interval = 15;
            this.pacman_timer.Tick += new System.EventHandler(this.pacman_timer_Tick);
            // 
            // cherry_timer
            // 
            this.cherry_timer.Interval = 3000;
            this.cherry_timer.Tick += new System.EventHandler(this.cherry_timer_Tick);
            // 
            // countdown_timer
            // 
            this.countdown_timer.Interval = 1000;
            this.countdown_timer.Tick += new System.EventHandler(this.countdown_timer_Tick);
            // 
            // points_label
            // 
            this.points_label.AutoSize = true;
            this.points_label.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_label.ForeColor = System.Drawing.Color.Lime;
            this.points_label.Location = new System.Drawing.Point(8, 9);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(108, 18);
            this.points_label.TabIndex = 1;
            this.points_label.Text = " Points: 0";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.Lime;
            this.timer_label.Location = new System.Drawing.Point(1178, 9);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(58, 18);
            this.timer_label.TabIndex = 2;
            this.timer_label.Text = "Time:";
            // 
            // change_color_timer
            // 
            this.change_color_timer.Interval = 1000;
            this.change_color_timer.Tick += new System.EventHandler(this.change_color_timer_Tick);
            // 
            // pacman_picturebox
            // 
            this.pacman_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.pacman_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("pacman_picturebox.Image")));
            this.pacman_picturebox.Location = new System.Drawing.Point(568, 320);
            this.pacman_picturebox.Name = "pacman_picturebox";
            this.pacman_picturebox.Size = new System.Drawing.Size(60, 50);
            this.pacman_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman_picturebox.TabIndex = 0;
            this.pacman_picturebox.TabStop = false;
            // 
            // Pacman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1276, 686);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.points_label);
            this.Controls.Add(this.pacman_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pacman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pacman_FormClosed);
            this.Load += new System.EventHandler(this.Pacman_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pacman_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pacman_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pacman_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman_picturebox;
        private System.Windows.Forms.Timer pacman_timer;
        private System.Windows.Forms.Timer cherry_timer;
        private System.Windows.Forms.Timer countdown_timer;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer change_color_timer;
    }
}

