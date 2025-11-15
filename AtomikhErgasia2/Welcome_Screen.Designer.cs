using System.Drawing;

namespace AtomikhErgasia2
{
    partial class Welcome_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Screen));
            this.easy_button = new System.Windows.Forms.RadioButton();
            this.hard_button = new System.Windows.Forms.RadioButton();
            this.mode_label = new System.Windows.Forms.Label();
            this.easy_label = new System.Windows.Forms.Label();
            this.hard_label = new System.Windows.Forms.Label();
            this.rules_label = new System.Windows.Forms.Label();
            this.scoreboard_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.instraction_label = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // easy_button
            // 
            this.easy_button.AutoSize = true;
            this.easy_button.Location = new System.Drawing.Point(432, 223);
            this.easy_button.Name = "easy_button";
            this.easy_button.Size = new System.Drawing.Size(14, 13);
            this.easy_button.TabIndex = 1;
            this.easy_button.TabStop = true;
            this.easy_button.UseVisualStyleBackColor = true;
            this.easy_button.CheckedChanged += new System.EventHandler(this.easy_button_CheckedChanged);
            // 
            // hard_button
            // 
            this.hard_button.AutoSize = true;
            this.hard_button.Location = new System.Drawing.Point(516, 223);
            this.hard_button.Name = "hard_button";
            this.hard_button.Size = new System.Drawing.Size(14, 13);
            this.hard_button.TabIndex = 2;
            this.hard_button.TabStop = true;
            this.hard_button.UseVisualStyleBackColor = true;
            this.hard_button.CheckedChanged += new System.EventHandler(this.hard_button_CheckedChanged);
            // 
            // mode_label
            // 
            this.mode_label.AutoSize = true;
            this.mode_label.BackColor = System.Drawing.Color.Transparent;
            this.mode_label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mode_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.mode_label.Location = new System.Drawing.Point(291, 218);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(75, 21);
            this.mode_label.TabIndex = 3;
            this.mode_label.Text = "MODE:";
            // 
            // easy_label
            // 
            this.easy_label.AutoSize = true;
            this.easy_label.BackColor = System.Drawing.Color.Transparent;
            this.easy_label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.easy_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(131)))), ((int)(((byte)(33)))));
            this.easy_label.Location = new System.Drawing.Point(366, 218);
            this.easy_label.Name = "easy_label";
            this.easy_label.Size = new System.Drawing.Size(62, 21);
            this.easy_label.TabIndex = 4;
            this.easy_label.Text = "Easy";
            // 
            // hard_label
            // 
            this.hard_label.AutoSize = true;
            this.hard_label.BackColor = System.Drawing.Color.Transparent;
            this.hard_label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.hard_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(7)))));
            this.hard_label.Location = new System.Drawing.Point(452, 218);
            this.hard_label.Name = "hard_label";
            this.hard_label.Size = new System.Drawing.Size(62, 21);
            this.hard_label.TabIndex = 5;
            this.hard_label.Text = "Hard";
            // 
            // rules_label
            // 
            this.rules_label.AutoSize = true;
            this.rules_label.BackColor = System.Drawing.Color.Transparent;
            this.rules_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rules_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(46)))), ((int)(((byte)(132)))));
            this.rules_label.Location = new System.Drawing.Point(249, 303);
            this.rules_label.Name = "rules_label";
            this.rules_label.Size = new System.Drawing.Size(0, 20);
            this.rules_label.TabIndex = 6;
            // 
            // scoreboard_button
            // 
            this.scoreboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(131)))), ((int)(((byte)(33)))));
            this.scoreboard_button.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.scoreboard_button.Location = new System.Drawing.Point(313, 167);
            this.scoreboard_button.Name = "scoreboard_button";
            this.scoreboard_button.Size = new System.Drawing.Size(190, 40);
            this.scoreboard_button.TabIndex = 7;
            this.scoreboard_button.Text = "SCOREBOARD";
            this.scoreboard_button.UseVisualStyleBackColor = false;
            this.scoreboard_button.Click += new System.EventHandler(this.scoreboard_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(131)))), ((int)(((byte)(33)))));
            this.play_button.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.play_button.Location = new System.Drawing.Point(313, 248);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(190, 40);
            this.play_button.TabIndex = 8;
            this.play_button.Text = "PLAY";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // instraction_label
            // 
            this.instraction_label.BackColor = System.Drawing.Color.Transparent;
            this.instraction_label.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.instraction_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(131)))), ((int)(((byte)(33)))));
            this.instraction_label.Location = new System.Drawing.Point(334, 327);
            this.instraction_label.Name = "instraction_label";
            this.instraction_label.Size = new System.Drawing.Size(155, 50);
            this.instraction_label.TabIndex = 17;
            this.instraction_label.Text = "Use your arrow keys to move";
            this.instraction_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AtomikhErgasia2.Properties.Resources.cherry1;
            this.pictureBox9.Location = new System.Drawing.Point(696, 318);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 27);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(649, 115);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(112, 78);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(59, 287);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(75, 291);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(661, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(661, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtomikhErgasia2.Properties.Resources.pacman_logo;
            this.pictureBox1.Location = new System.Drawing.Point(222, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instraction_label);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.scoreboard_button);
            this.Controls.Add(this.rules_label);
            this.Controls.Add(this.hard_label);
            this.Controls.Add(this.easy_label);
            this.Controls.Add(this.mode_label);
            this.Controls.Add(this.hard_button);
            this.Controls.Add(this.easy_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Welcome_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton easy_button;
        private System.Windows.Forms.RadioButton hard_button;
        private System.Windows.Forms.Label mode_label;
        private System.Windows.Forms.Label easy_label;
        private System.Windows.Forms.Label hard_label;
        private System.Windows.Forms.Label rules_label;
        private System.Windows.Forms.Button scoreboard_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label instraction_label;
    }
}