namespace GDD.VISTA
{
    partial class MenuPrincipal
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
            if ( disposing && (components != null) )
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirFichaTecnicaForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME-design-DOCUMENT";
            // 
            // btnAbrirFichaTecnicaForm
            // 
            this.btnAbrirFichaTecnicaForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAbrirFichaTecnicaForm.FlatAppearance.BorderSize = 0;
            this.btnAbrirFichaTecnicaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFichaTecnicaForm.Location = new System.Drawing.Point(109, 180);
            this.btnAbrirFichaTecnicaForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirFichaTecnicaForm.Name = "btnAbrirFichaTecnicaForm";
            this.btnAbrirFichaTecnicaForm.Size = new System.Drawing.Size(359, 58);
            this.btnAbrirFichaTecnicaForm.TabIndex = 1;
            this.btnAbrirFichaTecnicaForm.Text = "Crear ficha técnica";
            this.btnAbrirFichaTecnicaForm.UseVisualStyleBackColor = false;
            this.btnAbrirFichaTecnicaForm.Click += new System.EventHandler(this.btnAbrirFichaTecnicaForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desarrollado por Sergio Correa y Carlos Ortigoza";
            // 
            // btnPersonajes
            // 
            this.btnPersonajes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPersonajes.FlatAppearance.BorderSize = 0;
            this.btnPersonajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonajes.Location = new System.Drawing.Point(109, 267);
            this.btnPersonajes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonajes.Name = "btnPersonajes";
            this.btnPersonajes.Size = new System.Drawing.Size(359, 58);
            this.btnPersonajes.TabIndex = 1;
            this.btnPersonajes.Text = "Personajes";
            this.btnPersonajes.UseVisualStyleBackColor = false;
            this.btnPersonajes.Click += new System.EventHandler(this.btnPersonajes_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 509);
            this.Controls.Add(this.btnPersonajes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbrirFichaTecnicaForm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirFichaTecnicaForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonajes;
    }
}