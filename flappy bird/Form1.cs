namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int lmao = 5;
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
            labelskore.Text = $"Skóre {skore}";


            //  počítání skóre
            if (pipeDown.Right<1) 
            { 
                pipeDown.Left = rnd.Next(400, 500);
                pipeDown.Height = rnd.Next(100, 200);
                skore++;
                
            }
            if(pipeUP.Right <1)
            {
                pipeUP.Left = rnd.Next(380, 550);
                skore++;
            }



            //  kolize
            if (ptacek.Bounds.IntersectsWith(pipeUP.Bounds) ||
                ptacek.Bounds.IntersectsWith(pipeDown.Bounds) || 
                ptacek.Bounds.IntersectsWith(zem.Bounds))
                konecHry();


            //  řešení rychlosti
            if(rychlost<15)
                rychlost +=(5/10);

            else if (rychlost > 15)
                rychlost += (7/10);
            else if(rychlost>20)
                rychlost -= (4/10);
            else if(rychlost>30)
                rychlost -= (1/10);

            

        }
        private void konecHry()
        {
           
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Konec hry!"
                    , "Prohrál/a jste", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                {
                
                Menu menu = new Menu();
                menu.Show();
                this.Hide();

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