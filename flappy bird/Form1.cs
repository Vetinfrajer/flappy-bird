using System.Security;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int lmao = 5;

        Menu menu = new Menu();
        public Form1()
        {
            InitializeComponent();
            timer2.Start();
            odpocet.Text = "";
        }

        int gravitace = 10;
        int rychlost = 10;
        int skore = 0;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            { 
            gravitace= 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            gravitace = -15;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            //  inicializace
            Random rnd = new Random();
            ptacek.Top += gravitace;
            pipeDown.Left -= rychlost;
            pipeUP.Left -= rychlost;
            pictureBox1.Left -= rychlost;
            pictureBox2.Left -= rychlost;
            labelskore.Text = $"Skóre {skore}";

            //  počítání skóre & generování pozic překážkám
            if (pipeDown.Right<1) 
            {
                pipeDown.Left = 1000;
                pipeUP.Left = 1000;
                skore++;
            }
            if(pictureBox1.Right<1)
            {
                pictureBox1.Left = 1000;
                pictureBox2.Left = 1000;
                skore++;
            }


            //  kolize
            if (ptacek.Bounds.IntersectsWith(pipeUP.Bounds) ||
                ptacek.Bounds.IntersectsWith(pipeDown.Bounds) || 
                ptacek.Bounds.IntersectsWith(zem.Bounds) || 
                ptacek.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                ptacek.Bounds.IntersectsWith(pictureBox2.Bounds))
                konecHry();


            //  řešení rychlosti
            if(skore<3)
                rychlost +=(1/2);
            else if (skore > 5)
                rychlost += (7/10);
            else if(skore>15)
                rychlost -= (4/10);
            else if(skore>21)
                rychlost -= (1/10);




        }
        private void konecHry()
        {
            timer1.Stop();
            int best;

            using (FileStream fs = new FileStream("../../skore.txt",FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    best = Convert.ToInt32(sr.ReadLine());
                    if(best < skore)
                    {
                        best = skore;
                        using (StreamWriter sw = new StreamWriter(fs))
                            sw.WriteLine(best);
                    }
                }
            }
                DialogResult dr = MessageBox.Show("Konec hry!"
                    , "Prohrál/a jste", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            
            
                if (dr == DialogResult.OK)
                {
                
                menu.Show();

                Close();

                }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            odpocet.Text = $"{lmao}...";
            lmao--;

            if(lmao==0)
            {
                timer2.Stop();
                timer1.Start();
                odpocet.Visible = false;
            }
        }
    }
}