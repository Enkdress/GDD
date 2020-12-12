namespace newGDD.Vista.Personaje
{
    partial class VPersonaje
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
            this.pnlPersonajesContainer = new System.Windows.Forms.Panel();
            this.pnlPersonajesItem = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTerciario = new System.Windows.Forms.RadioButton();
            this.rbtnSecundario = new System.Windows.Forms.RadioButton();
            this.rbtnPrimario = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContextura = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtArquetipo = new System.Windows.Forms.ComboBox();
            this.txtResumen = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPersonajesContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPersonajesContainer
            // 
            this.pnlPersonajesContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPersonajesContainer.Controls.Add(this.pnlPersonajesItem);
            this.pnlPersonajesContainer.Controls.Add(this.label2);
            this.pnlPersonajesContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPersonajesContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonajesContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPersonajesContainer.Name = "pnlPersonajesContainer";
            this.pnlPersonajesContainer.Size = new System.Drawing.Size(364, 762);
            this.pnlPersonajesContainer.TabIndex = 0;
            // 
            // pnlPersonajesItem
            // 
            this.pnlPersonajesItem.AutoScroll = true;
            this.pnlPersonajesItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPersonajesItem.Location = new System.Drawing.Point(0, 79);
            this.pnlPersonajesItem.Name = "pnlPersonajesItem";
            this.pnlPersonajesItem.Size = new System.Drawing.Size(364, 683);
            this.pnlPersonajesItem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciona un personaje";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtContextura);
            this.panel2.Controls.Add(this.txtEspecie);
            this.panel2.Controls.Add(this.txtArquetipo);
            this.panel2.Controls.Add(this.txtResumen);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(364, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 762);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(446, 464);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 46);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(446, 395);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 46);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(446, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 46);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTerciario);
            this.groupBox1.Controls.Add(this.rbtnSecundario);
            this.groupBox1.Controls.Add(this.rbtnPrimario);
            this.groupBox1.Location = new System.Drawing.Point(380, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participación";
            // 
            // rbtnTerciario
            // 
            this.rbtnTerciario.AutoSize = true;
            this.rbtnTerciario.Location = new System.Drawing.Point(78, 90);
            this.rbtnTerciario.Name = "rbtnTerciario";
            this.rbtnTerciario.Size = new System.Drawing.Size(99, 24);
            this.rbtnTerciario.TabIndex = 2;
            this.rbtnTerciario.TabStop = true;
            this.rbtnTerciario.Text = "Terciario";
            this.rbtnTerciario.UseVisualStyleBackColor = true;
            // 
            // rbtnSecundario
            // 
            this.rbtnSecundario.AutoSize = true;
            this.rbtnSecundario.Location = new System.Drawing.Point(78, 58);
            this.rbtnSecundario.Name = "rbtnSecundario";
            this.rbtnSecundario.Size = new System.Drawing.Size(116, 24);
            this.rbtnSecundario.TabIndex = 1;
            this.rbtnSecundario.TabStop = true;
            this.rbtnSecundario.Text = "Secundario";
            this.rbtnSecundario.UseVisualStyleBackColor = true;
            // 
            // rbtnPrimario
            // 
            this.rbtnPrimario.AutoSize = true;
            this.rbtnPrimario.Location = new System.Drawing.Point(78, 26);
            this.rbtnPrimario.Name = "rbtnPrimario";
            this.rbtnPrimario.Size = new System.Drawing.Size(97, 24);
            this.rbtnPrimario.TabIndex = 0;
            this.rbtnPrimario.TabStop = true;
            this.rbtnPrimario.Text = "Primario";
            this.rbtnPrimario.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Arquetipo";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(36, 404);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(320, 27);
            this.txtAltura.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contextura";
            // 
            // txtContextura
            // 
            this.txtContextura.Location = new System.Drawing.Point(36, 341);
            this.txtContextura.Name = "txtContextura";
            this.txtContextura.Size = new System.Drawing.Size(320, 27);
            this.txtContextura.TabIndex = 4;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(36, 279);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(320, 27);
            this.txtEspecie.TabIndex = 3;
            // 
            // txtArquetipo
            // 
            this.txtArquetipo.FormattingEnabled = true;
            this.txtArquetipo.Items.AddRange(new object[] {
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
            this.txtArquetipo.Location = new System.Drawing.Point(36, 466);
            this.txtArquetipo.Name = "txtArquetipo";
            this.txtArquetipo.Size = new System.Drawing.Size(320, 28);
            this.txtArquetipo.TabIndex = 6;
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(36, 190);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(320, 54);
            this.txtResumen.TabIndex = 2;
            this.txtResumen.Text = "";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(36, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crea/Modifica tu personaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // VPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPersonajesContainer);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VPersonaje";
            this.Text = "Personaje";
            this.pnlPersonajesContainer.ResumeLayout(false);
            this.pnlPersonajesContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPersonajesContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlPersonajesItem;
        public System.Windows.Forms.TextBox txtContextura;
        public System.Windows.Forms.TextBox txtEspecie;
        public System.Windows.Forms.ComboBox txtArquetipo;
        public System.Windows.Forms.RichTextBox txtResumen;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtAltura;
        public System.Windows.Forms.RadioButton rbtnTerciario;
        public System.Windows.Forms.RadioButton rbtnSecundario;
        public System.Windows.Forms.RadioButton rbtnPrimario;
        private System.Windows.Forms.Button btnEliminar;
    }
}