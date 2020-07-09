namespace ferramentas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(614, 12);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(161, 23);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP/URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(71, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(537, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Validated += new System.EventHandler(this.txtUrl_Validated);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(21, 103);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(0, 13);
            this.lblResultado2.TabIndex = 3;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(21, 68);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(0, 13);
            this.lblResultado1.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 350);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label lblResultado1;
    }
}

