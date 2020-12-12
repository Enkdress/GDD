
namespace newGDD.Vista.Guion
{
    partial class VGuion
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlpGuardarGuion = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpNegrita = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpSubrayar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpTachado = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpCursiva = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpAlinearCentro = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtBuscarPalabra = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.textRemplaza = new System.Windows.Forms.TextBox();
            this.tlpAlinearDerecha = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpAlinearIzquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(728, 551);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpGuardarGuion,
            this.tlpNegrita,
            this.tlpSubrayar,
            this.tlpTachado,
            this.tlpCursiva,
            this.tlpAlinearCentro,
            this.tlpAlinearDerecha,
            this.tlpAlinearIzquierda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tlpGuardarGuion
            // 
            this.tlpGuardarGuion.CheckOnClick = true;
            this.tlpGuardarGuion.Name = "tlpGuardarGuion";
            this.tlpGuardarGuion.Size = new System.Drawing.Size(76, 24);
            this.tlpGuardarGuion.Text = "&Guardar";
            // 
            // tlpNegrita
            // 
            this.tlpNegrita.Name = "tlpNegrita";
            this.tlpNegrita.Size = new System.Drawing.Size(73, 24);
            this.tlpNegrita.Text = "Negrita";
            // 
            // tlpSubrayar
            // 
            this.tlpSubrayar.Name = "tlpSubrayar";
            this.tlpSubrayar.Size = new System.Drawing.Size(81, 24);
            this.tlpSubrayar.Text = "Subrayar";
            // 
            // tlpTachado
            // 
            this.tlpTachado.Name = "tlpTachado";
            this.tlpTachado.Size = new System.Drawing.Size(78, 24);
            this.tlpTachado.Text = "Tachado";
            // 
            // tlpCursiva
            // 
            this.tlpCursiva.Name = "tlpCursiva";
            this.tlpCursiva.Size = new System.Drawing.Size(70, 24);
            this.tlpCursiva.Text = "Cursiva";
            // 
            // tlpAlinearCentro
            // 
            this.tlpAlinearCentro.Name = "tlpAlinearCentro";
            this.tlpAlinearCentro.Size = new System.Drawing.Size(116, 24);
            this.tlpAlinearCentro.Text = "Alinear centro";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBuscarPalabra
            // 
            this.txtBuscarPalabra.Location = new System.Drawing.Point(53, 52);
            this.txtBuscarPalabra.Name = "txtBuscarPalabra";
            this.txtBuscarPalabra.PlaceholderText = "Ingrese  Palabra";
            this.txtBuscarPalabra.Size = new System.Drawing.Size(125, 27);
            this.txtBuscarPalabra.TabIndex = 14;
            this.txtBuscarPalabra.Leave += new System.EventHandler(this.buscar_Load);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(318, 50);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(116, 29);
            this.btnCambiar.TabIndex = 16;
            this.btnCambiar.Text = "Hacer Cambio";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // textRemplaza
            // 
            this.textRemplaza.Location = new System.Drawing.Point(184, 52);
            this.textRemplaza.Name = "textRemplaza";
            this.textRemplaza.PlaceholderText = "Palabra remplazar";
            this.textRemplaza.Size = new System.Drawing.Size(128, 27);
            this.textRemplaza.TabIndex = 17;
            // 
            // tlpAlinearDerecha
            // 
            this.tlpAlinearDerecha.Name = "tlpAlinearDerecha";
            this.tlpAlinearDerecha.Size = new System.Drawing.Size(129, 24);
            this.tlpAlinearDerecha.Text = "Alinear Derecha";
            // 
            // tlpAlinearIzquierda
            // 
            this.tlpAlinearIzquierda.Name = "tlpAlinearIzquierda";
            this.tlpAlinearIzquierda.Size = new System.Drawing.Size(136, 24);
            this.tlpAlinearIzquierda.Text = "Alinear Izquierda";
            // 
            // VGuion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.textRemplaza);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtBuscarPalabra);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VGuion";
            this.Text = "VGuion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlpGuardarGuion;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBuscarPalabra;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox textRemplaza;
        private System.Windows.Forms.ToolStripMenuItem tlpNegrita;
        private System.Windows.Forms.ToolStripMenuItem tlpSubrayar;
        private System.Windows.Forms.ToolStripMenuItem tlpTachado;
        private System.Windows.Forms.ToolStripMenuItem tlpCursiva;
        private System.Windows.Forms.ToolStripMenuItem tlpAlinearCentro;
        private System.Windows.Forms.ToolStripMenuItem tlpAlinearDerecha;
        private System.Windows.Forms.ToolStripMenuItem tlpAlinearIzquierda;
    }
}