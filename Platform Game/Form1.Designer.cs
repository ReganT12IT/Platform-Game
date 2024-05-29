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
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
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
            this.player.Location = new System.Drawing.Point(519, 290);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 31);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // screen
            // 
            this.screen.Controls.Add(this.box3);
            this.screen.Controls.Add(this.box2);
            this.screen.Controls.Add(this.box1);
            this.screen.Controls.Add(this.player);
            this.screen.Location = new System.Drawing.Point(1, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1019, 551);
            this.screen.TabIndex = 1;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.CadetBlue;
            this.box1.Location = new System.Drawing.Point(503, 481);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(83, 67);
            this.box1.TabIndex = 1;
            this.box1.TabStop = false;
            this.box1.Click += new System.EventHandler(this.block1_Click);
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Chartreuse;
            this.box2.Location = new System.Drawing.Point(436, 512);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(205, 39);
            this.box2.TabIndex = 2;
            this.box2.TabStop = false;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.Chocolate;
            this.box3.Location = new System.Drawing.Point(368, 431);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(100, 50);
            this.box3.TabIndex = 3;
            this.box3.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box3;
    }
}

