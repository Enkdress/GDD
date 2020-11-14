namespace GDD.VISTA.DashboardItem
{
    partial class DocumentItem
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreDocumento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(490, 215);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            this.imageBox.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCreador);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblFechaCreacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNombreDocumento);
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 113);
            this.panel1.TabIndex = 1;
            // 
            // lblNombreDocumento
            // 
            this.lblNombreDocumento.AutoSize = true;
            this.lblNombreDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDocumento.Location = new System.Drawing.Point(131, 6);
            this.lblNombreDocumento.Name = "lblNombreDocumento";
            this.lblNombreDocumento.Size = new System.Drawing.Size(237, 28);
            this.lblNombreDocumento.TabIndex = 0;
            this.lblNombreDocumento.Text = "Nombre del documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de creación: ";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaCreacion.Location = new System.Drawing.Point(172, 43);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(147, 23);
            this.lblFechaCreacion.TabIndex = 0;
            this.lblFechaCreacion.Text = "Fecha de creación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Creador del documento: ";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreador.Location = new System.Drawing.Point(230, 77);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(201, 23);
            this.lblCreador.TabIndex = 0;
            this.lblCreador.Text = "Creador del documento: ";
            // 
            // DocumentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox);
            this.Name = "DocumentItem";
            this.Size = new System.Drawing.Size(490, 325);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreDocumento;
    }
}
