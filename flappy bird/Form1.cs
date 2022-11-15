namespace flappy_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravitace = 10;
        int rychlost = 25;
        int skore = 0;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            { 
            gravitace= 15;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            gravitace = -15;
            
            else if (e.KeyCode == Keys.Enter)
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ptacek.Top += gravitace;
            pipeDown.Left -= rychlost;
            pipeUP.Left -= rychlost;
            labelskore.Text = "Skóre: " + skore;
        }
    }
}