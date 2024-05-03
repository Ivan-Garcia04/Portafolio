using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;


namespace CajaDeMusica
{
    public partial class FormInicio : Form
    {
        OpenFileDialog Dir;
        WindowsMediaPlayer Reproduce;
        int volumen = 10;
        int nPlay = -1;
        int ciclo = 0;
        int minutos = 0;
        int segundos = 0;
        int tminutos = 0;
        int tsegundos = 0;

        int minutosPago = 0;
        int segundosEjecutar = 0;

        int tpMinutos = 0;
        int tpSegundos = 0;
        int ttminutos = 0;
        int ttsegundos = 0;

        private void LeerListaBox()
        {
            int ca = listMusica.Items.Count;
            nPlay++;
            if(nPlay < ca)
            {
                listMusica.SetSelected(nPlay, true);
                lbTocando.Text = listMusica.Text;
            }
        }



        private void AbrirDirectorios()
        {
            string ruta = " ";
            string llegada = Directory.GetCurrentDirectory() + @"\Musica";
            Dir = new OpenFileDialog();
            Dir.Filter = "ARCHIVOS MUSICA |*.MP*";
            Dir.Title = "SELECTIONAR MSUICA";
            if(Dir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ruta = Dir.FileName;
                String[] M = ruta.Split('\\');
                int t = M.Count();
                llegada = llegada + '\\' + M[t - 1];
                System.IO.File.Copy(ruta, llegada, true);
                listMusica.Items.Add(M[t-1]);

            }
        }

        private void AjustaTiempo()
        {
            lbTiempoPagado.Text = minutosPago.ToString("00") + ":00";
           
         
           

        }
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            Reproduce = new WindowsMediaPlayer();
        }

        private void buttonSelecciona_Click(object sender, EventArgs e)
        {
            AbrirDirectorios();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timerMusica.Start();
            timerEjecuta.Start();
        }

        private void timerMusica_Tick(object sender, EventArgs e)
        {
            if (ciclo == 0)
            {
                LeerListaBox();
                string Directorio = Directory.GetCurrentDirectory() + (@"\musica\") + lbTocando.Text;
                Reproduce.URL = (Directorio);
                lbTiempoTotal.Text = Reproduce.newMedia(Directorio).durationString;
                string cadena = lbTiempoTotal.Text;
                string[] pt = cadena.Split(':');
                tminutos = Convert.ToInt32(pt[0]);
                tsegundos = Convert.ToInt32(pt[1]);
                Reproduce.settings.volume = volumen;
                Reproduce.controls.play();
                ciclo = 1;
            }
            segundos++;
            lbTiempoCorre.Text = minutos.ToString() + ":" + segundos.ToString("00");
            if (segundos >= 60)
            {
                minutos++;
                segundos = 0;
            }
            if(tminutos == minutos && tsegundos == segundos)
            {
                ciclo = 0;
                segundos = minutos = 0;
            }
          
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            volumen -= 5;
            Reproduce.settings.volume = volumen;
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            volumen += 5;
            Reproduce.settings.volume = volumen;

        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            minutosPago += 1;
            segundosEjecutar += 60;
            AjustaTiempo(); 
            
        }


        private void cmd2_Click(object sender, EventArgs e)
        {
            minutosPago += 2;
            segundosEjecutar += 120;
            AjustaTiempo();
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            minutosPago += 5;
            segundosEjecutar += 300;
            AjustaTiempo();

        }

        private void timerEjecuta_Tick(object sender, EventArgs e)
        {
            
            tpSegundos++;
            lbTiempoCorrer.Text = tpMinutos.ToString("00") + ":" + tpSegundos.ToString("00");
            if (tpSegundos >= 60)
            {
                tpMinutos++;
                tpSegundos = 0;
            }

            if (lbTiempoCorrer.Text.Equals(lbTiempoPagado.Text))
            {
                timerMusica.Stop();
                timerEjecuta.Stop();
            }

        }

        private void lbTiempoCorrer_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd10_Click(object sender, EventArgs e)
        {
            minutosPago += 10;
            segundosEjecutar += 1000;
            AjustaTiempo();
        }

        private void cmd20_Click(object sender, EventArgs e)
        {
            minutosPago += 20;
            segundosEjecutar += 2000;
            AjustaTiempo();
        }

        private void cmd50_Click(object sender, EventArgs e)
        {
            minutosPago += 50;
            segundosEjecutar += 5000;
            AjustaTiempo();
        }
    }
}
