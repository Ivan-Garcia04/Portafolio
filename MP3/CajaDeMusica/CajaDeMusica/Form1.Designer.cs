namespace CajaDeMusica
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTocando = new System.Windows.Forms.Label();
            this.lbTiempoCorre = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonMas = new System.Windows.Forms.Button();
            this.buttonSelecciona = new System.Windows.Forms.Button();
            this.lbTiempoTotal = new System.Windows.Forms.Label();
            this.listMusica = new System.Windows.Forms.ListBox();
            this.timerMusica = new System.Windows.Forms.Timer(this.components);
            this.lbTiempoCorrer = new System.Windows.Forms.Label();
            this.lbTiempoPagado = new System.Windows.Forms.Label();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd20 = new System.Windows.Forms.Button();
            this.cmd10 = new System.Windows.Forms.Button();
            this.cmd50 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.timerEjecuta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTocando
            // 
            this.lbTocando.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTocando.Location = new System.Drawing.Point(52, 24);
            this.lbTocando.Name = "lbTocando";
            this.lbTocando.Size = new System.Drawing.Size(629, 40);
            this.lbTocando.TabIndex = 0;
            this.lbTocando.Text = "REPRODUCIR";
            // 
            // lbTiempoCorre
            // 
            this.lbTiempoCorre.AutoSize = true;
            this.lbTiempoCorre.Location = new System.Drawing.Point(30, 81);
            this.lbTiempoCorre.Name = "lbTiempoCorre";
            this.lbTiempoCorre.Size = new System.Drawing.Size(34, 13);
            this.lbTiempoCorre.TabIndex = 1;
            this.lbTiempoCorre.Text = "00:00";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(59, 139);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenos.Location = new System.Drawing.Point(12, 173);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(75, 51);
            this.buttonMenos.TabIndex = 3;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonMas
            // 
            this.buttonMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMas.Location = new System.Drawing.Point(93, 173);
            this.buttonMas.Name = "buttonMas";
            this.buttonMas.Size = new System.Drawing.Size(75, 51);
            this.buttonMas.TabIndex = 4;
            this.buttonMas.Text = "+";
            this.buttonMas.UseVisualStyleBackColor = true;
            this.buttonMas.Click += new System.EventHandler(this.buttonMas_Click);
            // 
            // buttonSelecciona
            // 
            this.buttonSelecciona.Location = new System.Drawing.Point(41, 252);
            this.buttonSelecciona.Name = "buttonSelecciona";
            this.buttonSelecciona.Size = new System.Drawing.Size(93, 29);
            this.buttonSelecciona.TabIndex = 5;
            this.buttonSelecciona.Text = "SELECIONAR";
            this.buttonSelecciona.UseVisualStyleBackColor = true;
            this.buttonSelecciona.Click += new System.EventHandler(this.buttonSelecciona_Click);
            // 
            // lbTiempoTotal
            // 
            this.lbTiempoTotal.AutoSize = true;
            this.lbTiempoTotal.Location = new System.Drawing.Point(100, 81);
            this.lbTiempoTotal.Name = "lbTiempoTotal";
            this.lbTiempoTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTiempoTotal.TabIndex = 6;
            this.lbTiempoTotal.Text = "00:00";
            // 
            // listMusica
            // 
            this.listMusica.FormattingEnabled = true;
            this.listMusica.Location = new System.Drawing.Point(268, 89);
            this.listMusica.Name = "listMusica";
            this.listMusica.Size = new System.Drawing.Size(395, 238);
            this.listMusica.TabIndex = 7;
            // 
            // timerMusica
            // 
            this.timerMusica.Interval = 1000;
            this.timerMusica.Tick += new System.EventHandler(this.timerMusica_Tick);
            // 
            // lbTiempoCorrer
            // 
            this.lbTiempoCorrer.AutoSize = true;
            this.lbTiempoCorrer.Location = new System.Drawing.Point(29, 314);
            this.lbTiempoCorrer.Name = "lbTiempoCorrer";
            this.lbTiempoCorrer.Size = new System.Drawing.Size(34, 13);
            this.lbTiempoCorrer.TabIndex = 8;
            this.lbTiempoCorrer.Text = "00:00";
            this.lbTiempoCorrer.Click += new System.EventHandler(this.lbTiempoCorrer_Click);
            // 
            // lbTiempoPagado
            // 
            this.lbTiempoPagado.AutoSize = true;
            this.lbTiempoPagado.Location = new System.Drawing.Point(100, 314);
            this.lbTiempoPagado.Name = "lbTiempoPagado";
            this.lbTiempoPagado.Size = new System.Drawing.Size(34, 13);
            this.lbTiempoPagado.TabIndex = 9;
            this.lbTiempoPagado.Text = "00:00";
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(12, 353);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(52, 33);
            this.cmd1.TabIndex = 10;
            this.cmd1.Text = "$1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(70, 353);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(53, 33);
            this.cmd2.TabIndex = 11;
            this.cmd2.Text = "$2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd20
            // 
            this.cmd20.Location = new System.Drawing.Point(70, 392);
            this.cmd20.Name = "cmd20";
            this.cmd20.Size = new System.Drawing.Size(53, 33);
            this.cmd20.TabIndex = 13;
            this.cmd20.Text = "$20";
            this.cmd20.UseVisualStyleBackColor = true;
            this.cmd20.Click += new System.EventHandler(this.cmd20_Click);
            // 
            // cmd10
            // 
            this.cmd10.Location = new System.Drawing.Point(12, 392);
            this.cmd10.Name = "cmd10";
            this.cmd10.Size = new System.Drawing.Size(52, 33);
            this.cmd10.TabIndex = 12;
            this.cmd10.Text = "$10";
            this.cmd10.UseVisualStyleBackColor = true;
            this.cmd10.Click += new System.EventHandler(this.cmd10_Click);
            // 
            // cmd50
            // 
            this.cmd50.Location = new System.Drawing.Point(129, 392);
            this.cmd50.Name = "cmd50";
            this.cmd50.Size = new System.Drawing.Size(53, 33);
            this.cmd50.TabIndex = 15;
            this.cmd50.Text = "$50";
            this.cmd50.UseVisualStyleBackColor = true;
            this.cmd50.Click += new System.EventHandler(this.cmd50_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(129, 353);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(52, 33);
            this.cmd5.TabIndex = 14;
            this.cmd5.Text = "$5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // timerEjecuta
            // 
            this.timerEjecuta.Tick += new System.EventHandler(this.timerEjecuta_Tick);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd50);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd20);
            this.Controls.Add(this.cmd10);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.lbTiempoPagado);
            this.Controls.Add(this.lbTiempoCorrer);
            this.Controls.Add(this.listMusica);
            this.Controls.Add(this.lbTiempoTotal);
            this.Controls.Add(this.buttonSelecciona);
            this.Controls.Add(this.buttonMas);
            this.Controls.Add(this.buttonMenos);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.lbTiempoCorre);
            this.Controls.Add(this.lbTocando);
            this.Name = "FormInicio";
            this.Text = "Reproductor De Musica";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTocando;
        private System.Windows.Forms.Label lbTiempoCorre;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonMas;
        private System.Windows.Forms.Button buttonSelecciona;
        private System.Windows.Forms.Label lbTiempoTotal;
        private System.Windows.Forms.ListBox listMusica;
        private System.Windows.Forms.Timer timerMusica;
        private System.Windows.Forms.Label lbTiempoCorrer;
        private System.Windows.Forms.Label lbTiempoPagado;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd20;
        private System.Windows.Forms.Button cmd10;
        private System.Windows.Forms.Button cmd50;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Timer timerEjecuta;
    }
}

