namespace newGDD.Vista.Componentes
{
    partial class ItemDocumento
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
            this.imgDoc = new System.Windows.Forms.PictureBox();
            this.lblNombreDoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreadores = new System.Windows.Forms.Label();
            this.btnFichaTecnica = new System.Windows.Forms.Button();
            this.btnPersonajes = new System.Windows.Forms.Button();
            this.btnGuion = new System.Windows.Forms.Button();
            this.lnkRecursos = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDoc
            // 
            this.imgDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgDoc.Location = new System.Drawing.Point(0, 0);
            this.imgDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgDoc.Name = "imgDoc";
            this.imgDoc.Size = new System.Drawing.Size(417, 175);
            this.imgDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgDoc.TabIndex = 0;
            this.imgDoc.TabStop = false;
            // 
            // lblNombreDoc
            // 
            this.lblNombreDoc.AutoSize = true;
            this.lblNombreDoc.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDoc.Location = new System.Drawing.Point(160, 187);
            this.lblNombreDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDoc.Name = "lblNombreDoc";
            this.lblNombreDoc.Size = new System.Drawing.Size(86, 32);
            this.lblNombreDoc.TabIndex = 1;
            this.lblNombreDoc.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de creación: ";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(175, 233);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(56, 20);
            this.lblFechaCreacion.TabIndex = 3;
            this.lblFechaCreacion.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Creadores: ";
            // 
            // lblCreadores
            // 
            this.lblCreadores.AutoSize = true;
            this.lblCreadores.Location = new System.Drawing.Point(106, 272);
            this.lblCreadores.Name = "lblCreadores";
            this.lblCreadores.Size = new System.Drawing.Size(55, 20);
            this.lblCreadores.TabIndex = 5;
            this.lblCreadores.Text = "label3";
            // 
            // btnFichaTecnica
            // 
            this.btnFichaTecnica.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFichaTecnica.FlatAppearance.BorderSize = 0;
            this.btnFichaTecnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaTecnica.ForeColor = System.Drawing.Color.White;
            this.btnFichaTecnica.Location = new System.Drawing.Point(31, 346);
            this.btnFichaTecnica.Name = "btnFichaTecnica";
            this.btnFichaTecnica.Size = new System.Drawing.Size(101, 29);
            this.btnFichaTecnica.TabIndex = 6;
            this.btnFichaTecnica.Text = "Ficha técnica";
            this.btnFichaTecnica.UseVisualStyleBackColor = false;
            this.btnFichaTecnica.Click += new System.EventHandler(this.btnFichaTecnica_Click);
            // 
            // btnPersonajes
            // 
            this.btnPersonajes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersonajes.FlatAppearance.BorderSize = 0;
            this.btnPersonajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonajes.ForeColor = System.Drawing.Color.White;
            this.btnPersonajes.Location = new System.Drawing.Point(160, 346);
            this.btnPersonajes.Name = "btnPersonajes";
            this.btnPersonajes.Size = new System.Drawing.Size(101, 29);
            this.btnPersonajes.TabIndex = 7;
            this.btnPersonajes.Text = "Personajes";
            this.btnPersonajes.UseVisualStyleBackColor = false;
            this.btnPersonajes.Click += new System.EventHandler(this.btnPersonajes_Click);
            // 
            // btnGuion
            // 
            this.btnGuion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuion.FlatAppearance.BorderSize = 0;
            this.btnGuion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuion.ForeColor = System.Drawing.Color.White;
            this.btnGuion.Location = new System.Drawing.Point(289, 346);
            this.btnGuion.Name = "btnGuion";
            this.btnGuion.Size = new System.Drawing.Size(101, 29);
            this.btnGuion.TabIndex = 8;
            this.btnGuion.Text = "Guion";
            this.btnGuion.UseVisualStyleBackColor = false;
            // 
            // lnkRecursos
            // 
            this.lnkRecursos.ActiveLinkColor = System.Drawing.Color.Green;
            this.lnkRecursos.AutoSize = true;
            this.lnkRecursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRecursos.Location = new System.Drawing.Point(18, 304);
            this.lnkRecursos.Name = "lnkRecursos";
            this.lnkRecursos.Size = new System.Drawing.Size(77, 20);
            this.lnkRecursos.TabIndex = 9;
            this.lnkRecursos.TabStop = true;
            this.lnkRecursos.Text = "Recursos";
            this.lnkRecursos.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // ItemDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lnkRecursos);
            this.Controls.Add(this.btnGuion);
            this.Controls.Add(this.btnPersonajes);
            this.Controls.Add(this.btnFichaTecnica);
            this.Controls.Add(this.lblCreadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreDoc);
            this.Controls.Add(this.imgDoc);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ItemDocumento";
            this.Size = new System.Drawing.Size(417, 399);
            ((System.ComponentModel.ISupportInitialize)(this.imgDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDoc;
        private System.Windows.Forms.Label lblNombreDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreadores;
        private System.Windows.Forms.Button btnFichaTecnica;
        private System.Windows.Forms.Button btnPersonajes;
        private System.Windows.Forms.Button btnGuion;
        private System.Windows.Forms.LinkLabel lnkRecursos;
    }
}
