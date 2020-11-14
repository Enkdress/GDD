namespace GDD.VISTA
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarGDD = new System.Windows.Forms.Button();
            this.pnlDocumentos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAgregarGDD
            // 
            this.btnAgregarGDD.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.btnAgregarGDD, "btnAgregarGDD");
            this.btnAgregarGDD.ForeColor = System.Drawing.Color.White;
            this.btnAgregarGDD.Name = "btnAgregarGDD";
            this.btnAgregarGDD.UseVisualStyleBackColor = false;
            this.btnAgregarGDD.Click += new System.EventHandler(this.btnAgregarGDD_Click);
            // 
            // pnlDocumentos
            // 
            this.pnlDocumentos.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.pnlDocumentos, "pnlDocumentos");
            this.pnlDocumentos.Name = "pnlDocumentos";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnlDocumentos);
            this.Controls.Add(this.btnAgregarGDD);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarGDD;
        private System.Windows.Forms.Panel pnlDocumentos;
    }
}

