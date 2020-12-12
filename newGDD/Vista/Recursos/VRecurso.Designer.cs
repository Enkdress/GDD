
namespace newGDD.Vista.Recursos
{
    partial class VRecurso
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrir.Location = new System.Drawing.Point(48, 130);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(160, 48);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnadir.Location = new System.Drawing.Point(258, 130);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(160, 48);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recursos";
            // 
            // VRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.btnAbrir);
            this.Name = "VRecurso";
            this.Text = "Recurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label label1;
    }
}