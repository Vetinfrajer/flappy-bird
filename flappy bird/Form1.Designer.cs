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
            this.zem = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pipeUP = new System.Windows.Forms.PictureBox();
            this.labelskore = new System.Windows.Forms.Label();
            this.odpocet = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptacek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUP)).BeginInit();
            this.SuspendLayout();
            // 
            // ptacek
            // 
            this.ptacek.Image = global::flappy_bird.Properties.Resources.Flappy_Bird2;
            this.ptacek.Location = new System.Drawing.Point(3, 157);
            this.ptacek.Name = "ptacek";
            this.ptacek.Size = new System.Drawing.Size(80, 80);
            this.ptacek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptacek.TabIndex = 0;
            this.ptacek.TabStop = false;
            // 
            // zem
            // 
            this.zem.Image = global::flappy_bird.Properties.Resources.R;
            this.zem.Location = new System.Drawing.Point(-27, 497);
            this.zem.Name = "zem";
            this.zem.Size = new System.Drawing.Size(650, 80);
            this.zem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zem.TabIndex = 1;
            this.zem.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::flappy_bird.Properties.Resources.pipe_down;
            this.pipeDown.Location = new System.Drawing.Point(366, -2);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(80, 146);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // pipeUP
            // 
            this.pipeUP.Image = global::flappy_bird.Properties.Resources.pipe_up;
            this.pipeUP.Location = new System.Drawing.Point(366, 290);
            this.pipeUP.Name = "pipeUP";
            this.pipeUP.Size = new System.Drawing.Size(80, 207);
            this.pipeUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUP.TabIndex = 5;
            this.pipeUP.TabStop = false;
            // 
            // labelskore
            // 
            this.labelskore.AutoSize = true;
            this.labelskore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.labelskore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelskore.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelskore.Location = new System.Drawing.Point(27, 515);
            this.labelskore.Name = "labelskore";
            this.labelskore.Size = new System.Drawing.Size(190, 52);
            this.labelskore.TabIndex = 6;
            this.labelskore.Text = "Skóre: 0";
            // 
            // odpocet
            // 
            this.odpocet.AutoSize = true;
            this.odpocet.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.odpocet.Location = new System.Drawing.Point(170, 157);
            this.odpocet.Name = "odpocet";
            this.odpocet.Size = new System.Drawing.Size(88, 86);
            this.odpocet.TabIndex = 7;
            this.odpocet.Text = "...";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(621, 571);
            this.Controls.Add(this.odpocet);
            this.Controls.Add(this.labelskore);
            this.Controls.Add(this.pipeUP);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.zem);
            this.Controls.Add(this.ptacek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy bird ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptacek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptacek;
        private PictureBox zem;
        private System.Windows.Forms.Timer timer1;
        //private Label skore;
        private PictureBox pipeDown;
        private PictureBox pipeUP;
        private Label labelskore;
        private Label odpocet;
        private System.Windows.Forms.Timer timer2;
    }
}