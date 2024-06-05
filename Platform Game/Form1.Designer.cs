namespace Platform_Game
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.screen = new System.Windows.Forms.Panel();
            this.box6 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(91, 397);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 27);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.screen.Controls.Add(this.pictureBox3);
            this.screen.Controls.Add(this.box6);
            this.screen.Controls.Add(this.box5);
            this.screen.Controls.Add(this.pictureBox2);
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.box7);
            this.screen.Controls.Add(this.box4);
            this.screen.Controls.Add(this.box3);
            this.screen.Controls.Add(this.box2);
            this.screen.Controls.Add(this.box1);
            this.screen.Controls.Add(this.player);
            this.screen.Location = new System.Drawing.Point(1, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1019, 551);
            this.screen.TabIndex = 1;
            // 
            // box6
            // 
            this.box6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box6.Location = new System.Drawing.Point(282, 242);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(32, 157);
            this.box6.TabIndex = 6;
            this.box6.TabStop = false;
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.SystemColors.Desktop;
            this.box5.Location = new System.Drawing.Point(219, 275);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(32, 124);
            this.box5.TabIndex = 5;
            this.box5.TabStop = false;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.SystemColors.Control;
            this.box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box4.Location = new System.Drawing.Point(186, 306);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(658, 292);
            this.box4.TabIndex = 4;
            this.box4.TabStop = false;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.box3.Location = new System.Drawing.Point(59, 430);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(100, 50);
            this.box3.TabIndex = 3;
            this.box3.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.box2.Location = new System.Drawing.Point(11, 326);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(79, 60);
            this.box2.TabIndex = 2;
            this.box2.TabStop = false;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.box1.Location = new System.Drawing.Point(146, 369);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(34, 40);
            this.box1.TabIndex = 1;
            this.box1.TabStop = false;
            this.box1.Click += new System.EventHandler(this.block1_Click);
            // 
            // box7
            // 
            this.box7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box7.Location = new System.Drawing.Point(378, 199);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(32, 169);
            this.box7.TabIndex = 7;
            this.box7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(231, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 167);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(293, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 167);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(338, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 250);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 548);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.PictureBox box5;
        private System.Windows.Forms.PictureBox box6;
        private System.Windows.Forms.PictureBox box7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

