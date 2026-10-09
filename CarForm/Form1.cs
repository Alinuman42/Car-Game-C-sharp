using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kazanilanpuan = 0; // point earned 
        int yolhizi = 5; // Road Speed
        int arabahizi = 5; // car Speed

        bool solYon = false; // left direction
        bool sagYon = false; // right direction 

        int digerArabahizlari = 5; // other cars Speed 

        Random rnd = new Random();
        Random arabarnd = new Random(); 



        public void startGame()
        {
            Btn_baslat.Enabled = false; // if you click the button you are not able to click while you play.
            carpma.Visible = false; // for animation 

            arabahizi = 5;
            digerArabahizlari = 5;

            kazanilanpuan = 0;


            // cars coordinate - for the car,which we use 
            bizimaraba.Left = 160;
            bizimaraba.Top = 300;


            // enemy cars
            araba1.Left = 30;
            araba1.Top = 50;

            araba2.Left = 320;
            araba2.Top = 50;


            // directions are false at the beginning 
            solYon = false;
            sagYon = false;

            timer1.Start();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();

        }

        private void SesiAc()
        {
            /* SoundPlayer ses = new SoundPlayer();
             string sesYOl = Application.StartupPath + "\\lostsky.wav"; */
                

        } // Open the Voice

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanpuan++;
            lbl_Puan.Text = kazanilanpuan.ToString();
           
            yol.Top += yolhizi;
            if(yol.Top > 400) { yol.Top = -100; }

            if (solYon) { bizimaraba.Left -= arabahizi;  }
            if (sagYon) { bizimaraba.Left += arabahizi; }

            if(bizimaraba.Left < 1) { solYon = false; }
            else if( bizimaraba.Left + bizimaraba.Width > 510) { sagYon =false; }



            araba1.Top += arabahizi;
            araba2.Top += arabahizi;

            if(araba1.Top > panel1.Height)
            {
                araba1.Left= arabarnd.Next(20, 400);
                araba1.Top = arabarnd.Next(40, 140) * -1;
                arabaDegistir();
                
            }


            if (araba2.Top > panel1.Height)
            {
                araba2.Left = rnd.Next(10, 370);
                araba2.Top = rnd.Next(40, 140) * -1;
                arabaDegistir2();
                
            }

            if(bizimaraba.Bounds.IntersectsWith(araba1.Bounds) || bizimaraba.Bounds.IntersectsWith(araba2.Bounds))
            {
                oyunuBitir();
            }

        }

        private void arabaDegistir() // chance Cars
        {
            int sira = rnd.Next(1, 7);



            switch (sira)
            {

                case 1:
                    araba1.Image = Properties.Resources.araba3;
                    break;
                case 2:
                    araba1.Image = Properties.Resources.araba2;
                    break;
                case 3:
                    araba1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba1.Image = Properties.Resources.araba7;
                    break;

                default:
                    break;





            }
        }
        private void arabaDegistir2() // chance Cars
        {
            int sira = arabarnd.Next(1, 7);



            switch (sira)
            {

                case 1:
                    araba2.Image = Properties.Resources.araba3;
                    break;
                case 2:
                    araba2.Image = Properties.Resources.araba2;
                    break;
                case 3:
                    araba2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba2.Image = Properties.Resources.araba7;
                    break;

                default:
                    break;





            }
        }

        private void oyunuBitir()
        {
            timer1.Stop();
            if(Convert.ToInt32(lbl_Puan.Text) > Convert.ToInt32(Settings1.Default.MainScore.ToString()))
            {
                Settings1.Default.MainScore = lbl_Puan.Text;
                lbl_mainScore.Text = Settings1.Default.MainScore.ToString();
            }

            Btn_baslat.Enabled = true;
            carpma.Visible = true;
            bizimaraba.Controls.Add(carpma);
            carpma.Location = new Point(7, -5);
            carpma.BringToFront();
            carpma.BackColor = Color.Transparent;
            MessageBox.Show("Earned Score : " + lbl_Puan.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);







        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && bizimaraba.Left > 0 ) 
            {
                solYon = true;
            }
           if(e.KeyCode == Keys.Right && bizimaraba.Left + bizimaraba.Width < panel1.Width) { sagYon = true; }  
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) { solYon = false; }
            if(e.KeyCode == Keys.Right) { sagYon = false; }
        }

        private void Btn_baslat_Click(object sender, EventArgs e)
        {
            
            startGame();

        }

        private void yol_Click(object sender, EventArgs e)
        {

        }
    }
}
