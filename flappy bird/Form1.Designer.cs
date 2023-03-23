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
            components = new System.ComponentModel.Container();
            ptacek = new PictureBox();
            zem = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pipeDown = new PictureBox();
            pipeUP = new PictureBox();
            labelskore = new Label();
            odpocet = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptacek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeUP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ptacek
            // 
            ptacek.Image = Properties.Resources.Flappy_Bird2;
            ptacek.Location = new Point(12, 228);
            ptacek.Name = "ptacek";
            ptacek.Size = new Size(80, 80);
            ptacek.SizeMode = PictureBoxSizeMode.StretchImage;
            ptacek.TabIndex = 0;
            ptacek.TabStop = false;
            // 
            // zem
            // 
            zem.Image = Properties.Resources.R;
            zem.Location = new Point(-17, 601);
            zem.Name = "zem";
            zem.Size = new Size(647, 80);
            zem.SizeMode = PictureBoxSizeMode.StretchImage;
            zem.TabIndex = 1;
            zem.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 55;
            timer1.Tick += timer1_Tick;
            // 
            // pipeDown
            // 
            pipeDown.Image = Properties.Resources.pipe_down;
            pipeDown.Location = new Point(315, -3);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(67, 145);
            pipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeDown.TabIndex = 3;
            pipeDown.TabStop = false;
            // 
            // pipeUP
            // 
            pipeUP.Image = Properties.Resources.pipe_up;
            pipeUP.Location = new Point(315, 414);
            pipeUP.Name = "pipeUP";
            pipeUP.Size = new Size(67, 203);
            pipeUP.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeUP.TabIndex = 5;
            pipeUP.TabStop = false;
            // 
            // labelskore
            // 
            labelskore.AutoSize = true;
            labelskore.BackColor = Color.FromArgb(224, 217, 173);
            labelskore.FlatStyle = FlatStyle.Popup;
            labelskore.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelskore.Location = new Point(12, 620);
            labelskore.Name = "labelskore";
            labelskore.Size = new Size(190, 52);
            labelskore.TabIndex = 6;
            labelskore.Text = "Skóre: 0";
            // 
            // odpocet
            // 
            odpocet.AutoSize = true;
            odpocet.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            odpocet.Location = new Point(294, 242);
            odpocet.Name = "odpocet";
            odpocet.Size = new Size(88, 86);
            odpocet.TabIndex = 7;
            odpocet.Text = "...";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pipe_down;
            pictureBox1.Location = new Point(601, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pipe_up;
            pictureBox2.Location = new Point(601, 497);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(622, 681);
            Controls.Add(labelskore);
            Controls.Add(zem);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(odpocet);
            Controls.Add(pipeUP);
            Controls.Add(pipeDown);
            Controls.Add(ptacek);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy bird ";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)ptacek).EndInit();
            ((System.ComponentModel.ISupportInitialize)zem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeUP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}