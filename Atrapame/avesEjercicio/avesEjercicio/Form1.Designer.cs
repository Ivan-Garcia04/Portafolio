namespace avesEjercicio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbPuntos = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.picBoxAve1 = new System.Windows.Forms.PictureBox();
            this.picBoxAve2 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tiempoEjecucion = new System.Windows.Forms.Timer(this.components);
            this.lbPuntosImagen1 = new System.Windows.Forms.Label();
            this.lbPuntosImagen2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAve1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAve2)).BeginInit();
            this.SuspendLayout();
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 900;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos.Location = new System.Drawing.Point(12, 32);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(188, 29);
            this.lbPuntos.TabIndex = 0;
            this.lbPuntos.Text = "Total Puntos: 0";
            this.lbPuntos.Click += new System.EventHandler(this.lbPuntos_Click);
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.Location = new System.Drawing.Point(29, 87);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(131, 29);
            this.lbTiempo.TabIndex = 1;
            this.lbTiempo.Text = "Tiempo: 0";
            this.lbTiempo.Click += new System.EventHandler(this.lbTiempo_Click);
            // 
            // picBoxAve1
            // 
            this.picBoxAve1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxAve1.BackgroundImage")));
            this.picBoxAve1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAve1.Location = new System.Drawing.Point(187, 134);
            this.picBoxAve1.Name = "picBoxAve1";
            this.picBoxAve1.Size = new System.Drawing.Size(107, 66);
            this.picBoxAve1.TabIndex = 2;
            this.picBoxAve1.TabStop = false;
            this.picBoxAve1.Click += new System.EventHandler(this.picBoxAve1_Click);
            // 
            // picBoxAve2
            // 
            this.picBoxAve2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxAve2.BackgroundImage")));
            this.picBoxAve2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAve2.Location = new System.Drawing.Point(476, 150);
            this.picBoxAve2.Name = "picBoxAve2";
            this.picBoxAve2.Size = new System.Drawing.Size(55, 66);
            this.picBoxAve2.TabIndex = 3;
            this.picBoxAve2.TabStop = false;
            this.picBoxAve2.Visible = false;
            this.picBoxAve2.Click += new System.EventHandler(this.picBoxAve2_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(303, 46);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(121, 53);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // tiempoEjecucion
            // 
            this.tiempoEjecucion.Interval = 1000;
            this.tiempoEjecucion.Tick += new System.EventHandler(this.tiempoEjecucion_Tick);
            // 
            // lbPuntosImagen1
            // 
            this.lbPuntosImagen1.AutoSize = true;
            this.lbPuntosImagen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntosImagen1.Location = new System.Drawing.Point(36, 297);
            this.lbPuntosImagen1.Name = "lbPuntosImagen1";
            this.lbPuntosImagen1.Size = new System.Drawing.Size(241, 25);
            this.lbPuntosImagen1.TabIndex = 5;
            this.lbPuntosImagen1.Text = "PUNTOS IMAGEN 1:  ";
            this.lbPuntosImagen1.Visible = false;
            // 
            // lbPuntosImagen2
            // 
            this.lbPuntosImagen2.AutoSize = true;
            this.lbPuntosImagen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntosImagen2.Location = new System.Drawing.Point(449, 297);
            this.lbPuntosImagen2.Name = "lbPuntosImagen2";
            this.lbPuntosImagen2.Size = new System.Drawing.Size(234, 25);
            this.lbPuntosImagen2.TabIndex = 6;
            this.lbPuntosImagen2.Text = "PUNTOS IMAGEN 2: ";
            this.lbPuntosImagen2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPuntosImagen2);
            this.Controls.Add(this.lbPuntosImagen1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.picBoxAve2);
            this.Controls.Add(this.picBoxAve1);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbPuntos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAve1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAve2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.PictureBox picBoxAve1;
        private System.Windows.Forms.PictureBox picBoxAve2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer tiempoEjecucion;
        private System.Windows.Forms.Label lbPuntosImagen1;
        private System.Windows.Forms.Label lbPuntosImagen2;
    }
}

