namespace newGDD.Vista.Dashboard
{
    partial class CrearDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFicha = new System.Windows.Forms.Button();
            this.btnPersonajes = new System.Windows.Forms.Button();
            this.btnGuion = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Leave += new System.EventHandler(this.nombreDocumento_Load);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(606, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 61);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del documento";
            // 
            // btnFicha
            // 
            this.btnFicha.Location = new System.Drawing.Point(64, 143);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(354, 39);
            this.btnFicha.TabIndex = 3;
            this.btnFicha.Text = "Añadir FIcha";
            this.btnFicha.UseVisualStyleBackColor = true;
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // btnPersonajes
            // 
            this.btnPersonajes.Location = new System.Drawing.Point(64, 220);
            this.btnPersonajes.Name = "btnPersonajes";
            this.btnPersonajes.Size = new System.Drawing.Size(354, 44);
            this.btnPersonajes.TabIndex = 4;
            this.btnPersonajes.Text = "Crear Personajes";
            this.btnPersonajes.UseVisualStyleBackColor = true;
            this.btnPersonajes.Click += new System.EventHandler(this.btnPersonajes_Click);
            // 
            // btnGuion
            // 
            this.btnGuion.Location = new System.Drawing.Point(64, 293);
            this.btnGuion.Name = "btnGuion";
            this.btnGuion.Size = new System.Drawing.Size(354, 41);
            this.btnGuion.TabIndex = 5;
            this.btnGuion.Text = "Crear Guion";
            this.btnGuion.UseVisualStyleBackColor = true;
            this.btnGuion.Click += new System.EventHandler(this.btnGuion_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.Location = new System.Drawing.Point(64, 364);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(354, 49);
            this.btnRecursos.TabIndex = 6;
            this.btnRecursos.Text = "Agregar Recursos";
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // CrearDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnRecursos);
            this.Controls.Add(this.btnGuion);
            this.Controls.Add(this.btnPersonajes);
            this.Controls.Add(this.btnFicha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox1);
            this.Name = "CrearDocumento";
            this.Text = "CrearDocumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFicha;
        private System.Windows.Forms.Button btnPersonajes;
        private System.Windows.Forms.Button btnGuion;
        private System.Windows.Forms.Button btnRecursos;
    }
}