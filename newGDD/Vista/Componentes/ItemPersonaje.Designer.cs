namespace newGDD.Vista.Componentes
{
    partial class ItemPersonaje
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPersonaje = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResumen = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArquetipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContextura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPersonaje
            // 
            this.imgPersonaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgPersonaje.Location = new System.Drawing.Point(0, 0);
            this.imgPersonaje.Name = "imgPersonaje";
            this.imgPersonaje.Size = new System.Drawing.Size(328, 141);
            this.imgPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonaje.TabIndex = 0;
            this.imgPersonaje.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(131, 154);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resumen";
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(23, 208);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ReadOnly = true;
            this.txtResumen.Size = new System.Drawing.Size(280, 52);
            this.txtResumen.TabIndex = 3;
            this.txtResumen.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arquetipo: ";
            // 
            // lblArquetipo
            // 
            this.lblArquetipo.AutoSize = true;
            this.lblArquetipo.Location = new System.Drawing.Point(101, 276);
            this.lblArquetipo.Name = "lblArquetipo";
            this.lblArquetipo.Size = new System.Drawing.Size(43, 15);
            this.lblArquetipo.TabIndex = 5;
            this.lblArquetipo.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Especie: ";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(85, 298);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(43, 15);
            this.lblEspecie.TabIndex = 7;
            this.lblEspecie.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contextura: ";
            // 
            // lblContextura
            // 
            this.lblContextura.AutoSize = true;
            this.lblContextura.Location = new System.Drawing.Point(110, 320);
            this.lblContextura.Name = "lblContextura";
            this.lblContextura.Size = new System.Drawing.Size(42, 15);
            this.lblContextura.TabIndex = 9;
            this.lblContextura.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura: ";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(77, 363);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(43, 15);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Participación: ";
            // 
            // lblParticipacion
            // 
            this.lblParticipacion.AutoSize = true;
            this.lblParticipacion.Location = new System.Drawing.Point(120, 342);
            this.lblParticipacion.Name = "lblParticipacion";
            this.lblParticipacion.Size = new System.Drawing.Size(43, 15);
            this.lblParticipacion.TabIndex = 13;
            this.lblParticipacion.Text = "label7";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(221, 352);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(82, 29);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // ItemPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblParticipacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContextura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArquetipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.imgPersonaje);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ItemPersonaje";
            this.Size = new System.Drawing.Size(328, 400);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPersonaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.RichTextBox txtResumen;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblArquetipo;
        public System.Windows.Forms.Label lblEspecie;
        public System.Windows.Forms.Label lblContextura;
        public System.Windows.Forms.Label lblAltura;
        public System.Windows.Forms.Label lblParticipacion;
    }
}
