using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Menu : Form
    {
        int pozice = 12;
        bool xd = true;
        public Menu()
        {

            InitializeComponent();
                timer1.Start();
            pictureBox1.Top = pozice;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (xd)
            {
                if (pictureBox1.Top == 56)
                    xd = false;

                pictureBox1.Top++;
            
            }
            else
            {

                if (pictureBox1.Top == 12)
                    xd = true;

                pictureBox1.Top--;
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Držením mezerníku se dostanete výš\n " +
                "ptáček začne padat jakmile pustíte mezerník", "Ovládání", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 hra = new Form1();
            hra.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string filePath = "../../skore.txt";
            string lastLine = "";

            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lastLine = line;
                }
            }
            bestskore.Text = lastLine;
        }
        }
    }

