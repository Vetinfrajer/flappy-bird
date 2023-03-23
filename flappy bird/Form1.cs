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
            if (e.KeyCode == Keys.Space)
            {
                gravitace = 10;
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
            if (pipeDown.Right < 1)
            {
                pipeDown.Left = 700;
                pipeUP.Left = 700;
                skore++;

                Random poz = new Random();
                int poz2 = poz.Next(160, 300);
                int poz3 = 800 - poz2;

                pipeDown.Height = poz2;
                pipeUP.Height = poz3;



                //  řešení rychlosti
                if (skore < 3)
                    rychlost += (1 / 2);
                else if (skore > 5)
                    rychlost += 1;
            }
            if (pictureBox1.Right < 1)
            {
                pictureBox1.Left = 700;
                pictureBox2.Left = 700;
                skore++;

                //řešení výšek překážek
                Random poz = new Random();
                int poz2 = poz.Next(160, 300);
                int poz3 = 800 - poz2;

                pictureBox1.Height = poz2;
                pictureBox2.Height = poz3;

                //  řešení rychlosti
                if (skore < 3)
                    rychlost += 1;
                else if (skore > 5)
                    rychlost += (1 / 2);
            }


            //  kolize
            if (ptacek.Bounds.IntersectsWith(pipeUP.Bounds) ||
                ptacek.Bounds.IntersectsWith(pipeDown.Bounds) ||
                ptacek.Bounds.IntersectsWith(zem.Bounds) ||
                ptacek.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                ptacek.Bounds.IntersectsWith(pictureBox2.Bounds))
                konecHry();







        }
        private void konecHry()
        {
            timer1.Stop();

            // získání cesty k souboru
            string path = "../../skore.txt";

            // přečtení poslední řádky ze souboru
            string lastLine = File.ReadLines(path).Last();

            // konverze řetězce na číslo
            int lastScore = int.Parse(lastLine);

            // porovnání s hodnotou proměnné skore
            if (skore > lastScore)
            {
                // přepsání hodnoty v souboru hodnotou skore
                string[] lines = File.ReadAllLines(path);
                lines[lines.Length - 1] = skore.ToString();
                File.WriteAllLines(path, lines);
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

            if (lmao == 0)
            {
                timer2.Stop();
                timer1.Start();
                odpocet.Visible = false;
            }
        }

       
    }
}