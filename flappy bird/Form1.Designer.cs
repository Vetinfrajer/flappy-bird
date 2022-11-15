namespace flappy_bird
{
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
            this.components = new System.ComponentModel.Container();
            this.ptacek = new System.Windows.Forms.PictureBox();
            this.groundimg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pipeUP = new System.Windows.Forms.PictureBox();
            this.labelskore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptacek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUP)).BeginInit();
            this.SuspendLayout();
            // 
            // ptacek
            // 
            this.ptacek.Image = global::flappy_bird.Properties.Resources.Flappy_Bird2;
            this.ptacek.Location = new System.Drawing.Point(61, 141);
            this.ptacek.Name = "ptacek";
            this.ptacek.Size = new System.Drawing.Size(85, 75);
            this.ptacek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptacek.TabIndex = 0;
            this.ptacek.TabStop = false;
            // 
            // groundimg
            // 
            this.groundimg.Image = global::flappy_bird.Properties.Resources.R;
            this.groundimg.Location = new System.Drawing.Point(-27, 497);
            this.groundimg.Name = "groundimg";
            this.groundimg.Size = new System.Drawing.Size(1033, 67);
            this.groundimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundimg.TabIndex = 1;
            this.groundimg.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::flappy_bird.Properties.Resources.pipe_down;
            this.pipeDown.Location = new System.Drawing.Point(735, 1);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 100);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::flappy_bird.Properties.Resources.WEATHER;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pipeUP
            // 
            this.pipeUP.Image = global::flappy_bird.Properties.Resources.pipe_up;
            this.pipeUP.Location = new System.Drawing.Point(467, 318);
            this.pipeUP.Name = "pipeUP";
            this.pipeUP.Size = new System.Drawing.Size(100, 180);
            this.pipeUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUP.TabIndex = 5;
            this.pipeUP.TabStop = false;
            // 
            // labelskore
            // 
            this.labelskore.AutoSize = true;
            this.labelskore.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelskore.Location = new System.Drawing.Point(98, 524);
            this.labelskore.Name = "labelskore";
            this.labelskore.Size = new System.Drawing.Size(48, 15);
            this.labelskore.TabIndex = 6;
            this.labelskore.Text = "Skóre: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(971, 559);
            this.Controls.Add(this.labelskore);
            this.Controls.Add(this.pipeUP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.groundimg);
            this.Controls.Add(this.ptacek);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy bird ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptacek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptacek;
        private PictureBox groundimg;
        private System.Windows.Forms.Timer timer1;
        //private Label skore;
        private PictureBox pipeDown;
        private PictureBox pictureBox2;
        private PictureBox pipeUP;
        private Label labelskore;
    }
}