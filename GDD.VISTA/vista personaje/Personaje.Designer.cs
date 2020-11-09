namespace GDD.VISTA.vista_pasajero
{
    partial class Personaje
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
            this.pnlPersonajes = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rbtnPrimary = new System.Windows.Forms.RadioButton();
            this.rbtnSecondary = new System.Windows.Forms.RadioButton();
            this.rbtnTernary = new System.Windows.Forms.RadioButton();
            this.cbxArquetipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlPersonajes
            // 
            this.pnlPersonajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonajes.AutoScroll = true;
            this.pnlPersonajes.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonajes.Name = "pnlPersonajes";
            this.pnlPersonajes.Size = new System.Drawing.Size(955, 159);
            this.pnlPersonajes.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(196, 491);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 62);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(431, 491);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 62);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(331, 219);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del personaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Participación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arquetipo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(667, 491);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 62);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rbtnPrimary
            // 
            this.rbtnPrimary.AutoSize = true;
            this.rbtnPrimary.Checked = true;
            this.rbtnPrimary.Location = new System.Drawing.Point(331, 321);
            this.rbtnPrimary.Name = "rbtnPrimary";
            this.rbtnPrimary.Size = new System.Drawing.Size(86, 24);
            this.rbtnPrimary.TabIndex = 2;
            this.rbtnPrimary.TabStop = true;
            this.rbtnPrimary.Text = "Primario";
            this.rbtnPrimary.UseVisualStyleBackColor = true;
            // 
            // rbtnSecondary
            // 
            this.rbtnSecondary.AutoSize = true;
            this.rbtnSecondary.Location = new System.Drawing.Point(431, 321);
            this.rbtnSecondary.Name = "rbtnSecondary";
            this.rbtnSecondary.Size = new System.Drawing.Size(104, 24);
            this.rbtnSecondary.TabIndex = 3;
            this.rbtnSecondary.Text = "Secundario";
            this.rbtnSecondary.UseVisualStyleBackColor = true;
            // 
            // rbtnTernary
            // 
            this.rbtnTernary.AutoSize = true;
            this.rbtnTernary.Location = new System.Drawing.Point(550, 321);
            this.rbtnTernary.Name = "rbtnTernary";
            this.rbtnTernary.Size = new System.Drawing.Size(91, 24);
            this.rbtnTernary.TabIndex = 4;
            this.rbtnTernary.Text = "Terceario";
            this.rbtnTernary.UseVisualStyleBackColor = true;
            // 
            // cbxArquetipo
            // 
            this.cbxArquetipo.FormattingEnabled = true;
            this.cbxArquetipo.Items.AddRange(new object[] {
            "EL INOCENTE",
            "EL AMIGO",
            "EL HEROE",
            "EL GOBERNANTE",
            "EL SABIO",
            "EL CREADOR",
            "EL CUIDADOR",
            "EL REBELDE",
            "EL AMANTE",
            "EL BROMISTA",
            "EL EXPLORADOR",
            "OTRO"});
            this.cbxArquetipo.Location = new System.Drawing.Point(331, 405);
            this.cbxArquetipo.Name = "cbxArquetipo";
            this.cbxArquetipo.Size = new System.Drawing.Size(323, 28);
            this.cbxArquetipo.TabIndex = 5;
            // 
            // Personaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 633);
            this.Controls.Add(this.cbxArquetipo);
            this.Controls.Add(this.rbtnTernary);
            this.Controls.Add(this.rbtnSecondary);
            this.Controls.Add(this.rbtnPrimary);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlPersonajes);
            this.Name = "Personaje";
            this.Text = "Personaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPersonajes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton rbtnPrimary;
        private System.Windows.Forms.RadioButton rbtnSecondary;
        private System.Windows.Forms.RadioButton rbtnTernary;
        private System.Windows.Forms.ComboBox cbxArquetipo;
    }
}