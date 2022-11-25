namespace flappy_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravitace = 10;
        int rychlost = 10;
        int skore = 0;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            { 
            gravitace= 20;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            gravitace = -20;
            
            else if (e.KeyCode == Keys.Enter)
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ptacek.Top += gravitace;
            pipeDown.Left -= rychlost;
            pipeUP.Left -= rychlost;
            labelskore.Text = "Skóre: " + skore;
            //poèítání skóre
            if (pipeDown.Left < -185)
            { 
                pipeDown.Left = rnd.Next(100, 600);
                skore++;
            }
            if(pipeUP.Left <- 185)
            {
                pipeUP.Left = rnd.Next(300, 850);
                skore++;
            }
            if(ptacek.Bounds.IntersectsWith(pipeUP.Bounds) || ptacek.Bounds.IntersectsWith(pipeDown.Bounds) || ptacek.Bounds.IntersectsWith(zem.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Konec hry!", "Prohrál/a jste",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            rychlost = 10 + skore;
            
                /*
                if(rychlost >30)
                    rychlost += 1;
                else if(rychlost > 50)
                    rychlost += 0,2;
                else if (rychlost > 100)
                    rychlost += 0,05;*/
            

        }
    }
}