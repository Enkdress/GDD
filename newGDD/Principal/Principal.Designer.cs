namespace newGDD.Principal
{
    partial class Principal
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
            this.pnlDocumentos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnAgregarDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDocumentos
            // 
            this.pnlDocumentos.AutoScroll = true;
            this.pnlDocumentos.BackColor = System.Drawing.Color.LightGray;
            this.pnlDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDocumentos.Location = new System.Drawing.Point(321, 0);
            this.pnlDocumentos.Name = "pnlDocumentos";
            this.pnlDocumentos.Size = new System.Drawing.Size(891, 785);
            this.pnlDocumentos.TabIndex = 0;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnAgregarDoc);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(321, 785);
            this.pnlOpciones.TabIndex = 1;
            // 
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarDoc.FlatAppearance.BorderSize = 0;
            this.btnAgregarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarDoc.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDoc.Location = new System.Drawing.Point(32, 121);
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Size = new System.Drawing.Size(258, 64);
            this.btnAgregarDoc.TabIndex = 1;
            this.btnAgregarDoc.Text = "Agregar documento";
            this.btnAgregarDoc.UseVisualStyleBackColor = false;
            this.btnAgregarDoc.Click += new System.EventHandler(this.btnAgregarDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPCIONES";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 785);
            this.Controls.Add(this.pnlDocumentos);
            this.Controls.Add(this.pnlOpciones);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Principal";
            this.Text = "Principalcs";
            this.Activated += new System.EventHandler(this.pnlDocumentos_Enter);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Enter += new System.EventHandler(this.pnlDocumentos_Enter);
            this.Leave += new System.EventHandler(this.pnlDocumentos_Enter);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnAgregarDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlDocumentos;
    }
}