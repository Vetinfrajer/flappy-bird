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
            ptacek.Location = new Point(93, 335);
            ptacek.Margin = new Padding(6);
            ptacek.Name = "ptacek";
            ptacek.Size = new Size(149, 171);
            ptacek.SizeMode = PictureBoxSizeMode.StretchImage;
            ptacek.TabIndex = 0;
            ptacek.TabStop = false;
            // 
            // zem
            // 
            zem.Image = Properties.Resources.R;
            zem.Location = new Point(-50, 1060);
            zem.Margin = new Padding(6);
            zem.Name = "zem";
            zem.Size = new Size(1207, 171);
            zem.SizeMode = PictureBoxSizeMode.StretchImage;
            zem.TabIndex = 1;
            zem.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 60;
            timer1.Tick += timer1_Tick;
            // 
            // pipeDown
            // 
            pipeDown.Anchor = AnchorStyles.Top;
            pipeDown.Image = Properties.Resources.pipe_down;
            pipeDown.Location = new Point(544, -6);
            pipeDown.Margin = new Padding(6);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(149, 309);
            pipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeDown.TabIndex = 3;
            pipeDown.TabStop = false;
            // 
            // pipeUP
            // 
            pipeUP.Anchor = AnchorStyles.Bottom;
            pipeUP.Image = Properties.Resources.pipe_up;
            pipeUP.Location = new Point(544, 623);
            pipeUP.Margin = new Padding(6);
            pipeUP.Name = "pipeUP";
            pipeUP.Size = new Size(149, 442);
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
            labelskore.Location = new Point(50, 1099);
            labelskore.Margin = new Padding(6, 0, 6, 0);
            labelskore.Name = "labelskore";
            labelskore.Size = new Size(377, 104);
            labelskore.TabIndex = 6;
            labelskore.Text = "Skóre: 0";
            // 
            // odpocet
            // 
            odpocet.AutoSize = true;
            odpocet.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            odpocet.Location = new Point(410, 335);
            odpocet.Margin = new Padding(6, 0, 6, 0);
            odpocet.Name = "odpocet";
            odpocet.Size = new Size(177, 170);
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
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.pipe_down;
            pictureBox1.Location = new Point(1075, -6);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.Image = Properties.Resources.pipe_up;
            pictureBox2.Location = new Point(1075, 834);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 230);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1153, 1225);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(odpocet);
            Controls.Add(labelskore);
            Controls.Add(pipeUP);
            Controls.Add(pipeDown);
            Controls.Add(zem);
            Controls.Add(ptacek);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
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