using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caballos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int tiempo = 0;
        public int x1 = 623;
        public int x2 = 623;
        public int x3 = 623; 
        public int t1 = 0;
        public int t2 = 0;
        public int t3 = 0;
        public int[] lugar = new int[3];
        public int indice = 0;

        public void TiempoCaballo1()
        {
            tiempo = 0;
            lbTiempo1.Text = "Tiempo: " + tiempo.ToString();
            timerRojo.Start();
        }
        public void TiempoCaballo2()
        {
            tiempo = 0;
            lbTiempo2.Text = "Tiempo: " + tiempo.ToString();
            timerVerde.Start();
        }
        public void TiempoCaballo3()
        {
            tiempo = 0;
            lbTiempo1.Text = "Tiempo: " + tiempo.ToString();
            timerAzul.Start();
        }


        public void Inserta_lugar(int y)
        {
            lugar[indice]=y;
            indice++;
        }

        public void tiempoAlto1()
        {
           
            
           
        }
        public void tiempoAlto2()
        {

        }
        public void tiempoAlto3()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerRojo_Tick(object sender, EventArgs e)
        {
            int x = 0;

            t1++;
            lbTiempo1.Text = "Tiempo: " + t1.ToString();

            Random pulso1 = new Random();
            x = pulso1.Next(1, 10);
            x1 = x1 - x;
            pictureBox1.Location = new Point(x1, 60);
            if (x1 <= 50) { 
                timerRojo.Stop();
                Inserta_lugar (1);

                }


        }

        private void timerVerde_Tick(object sender, EventArgs e)
        {
            int x = 0;
            t2++;
            lbTiempo2.Text = "Tiempo: " + t2.ToString();
            Random pulso2 = new Random();
            x = pulso2.Next(1, 10);
            x2 = x2 - x;
            pictureBox2.Location = new Point(x2, 180);
            if (x2 <= 50) { 
                timerVerde.Stop();
                Inserta_lugar(2);

            }


        }

        private void timerAzul_Tick(object sender, EventArgs e)
        {

            int x = 0;
            t3++;
            lbTiempo3.Text = "Tiempo: " + t3.ToString();
            Random pulso3 = new Random();
            x = pulso3.Next(1, 10);
            x3 = x3 - x;
            pictureBox3.Location = new Point(x3, 289);
            if (x3 <= 50) { 
                timerAzul.Stop();
                Inserta_lugar(3);

            }

        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            TiempoCaballo1();
            TiempoCaballo2();
            TiempoCaballo3();
            timerLugares.Start();
        }

        private void timerLugares_Tick(object sender, EventArgs e)
        {
            
                  switch(lugar[0])
            {
                case 1:{ 
                    label1.Text = "1"; break;
                    }

                case 2:{ label2.Text = "1"; break; 
                    }

                case 3: { label3.Text = "1"; break; 
                    }
            }


            switch (lugar[1])
            {
                case 1:
                    {
                        label1.Text = "2"; break;
                    }

                case 2:
                    {
                        label2.Text = "2"; break;
                    }

                case 3:
                    {
                        label3.Text = "2"; break;
                    }
            }


            switch (lugar[2])
            {
                case 1:
                    {
                        label1.Text = "3"; break;
                    }

                case 2:
                    {
                        label2.Text = "3"; break;
                    }

                case 3:
                    {
                        label3.Text = "3"; break;
                    }
            }

        }

        private void cmdReiniciar_Click(object sender, EventArgs e)
        {

            
            label1.Text = "Lugar";
            label2.Text = "Lugar";
            label3.Text = "Lugar";

            pictureBox1.Location = new Point(623, 60);
            pictureBox2.Location = new Point(623, 180);
            pictureBox3.Location = new Point(623, 289);

            x1= x2= x3= 623;
            t1 = t2 = t3 = 0;
            lugar[0] = '\0';
            lugar[1] = '\0';
            lugar[2] = '\0';
            indice = 0;


            lbTiempo1.Text = "Tiempo: 0";
            lbTiempo2.Text = "Tiempo: 0";
            lbTiempo3.Text = "Tiempo: 0";




        }
    }
}
