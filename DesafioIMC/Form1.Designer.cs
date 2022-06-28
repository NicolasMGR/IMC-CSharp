namespace DesafioIMC
{
    partial class Form1
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
            this.tituloimc = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.txtsituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloimc
            // 
            this.tituloimc.AutoSize = true;
            this.tituloimc.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloimc.Location = new System.Drawing.Point(227, 9);
            this.tituloimc.Name = "tituloimc";
            this.tituloimc.Size = new System.Drawing.Size(424, 51);
            this.tituloimc.TabIndex = 0;
            this.tituloimc.Text = "CALCULE SEU IMC";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(12, 125);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(84, 30);
            this.lblpeso.TabIndex = 1;
            this.lblpeso.Text = "PESO:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(102, 135);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(172, 20);
            this.txtpeso.TabIndex = 2;
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(11, 174);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(113, 30);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "ALTURA:";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(131, 183);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(172, 20);
            this.txtaltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Red;
            this.btnCalcular.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(532, 135);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(270, 68);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular o peso do frango";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.Location = new System.Drawing.Point(16, 278);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(127, 33);
            this.lblimc.TabIndex = 6;
            this.lblimc.Text = "SEU IMC:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(149, 286);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 25);
            this.lblresultado.TabIndex = 7;
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituacao.Location = new System.Drawing.Point(16, 417);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(208, 33);
            this.lblsituacao.TabIndex = 8;
            this.lblsituacao.Text = "SUA SITUAÇÂO:";
            // 
            // txtsituacao
            // 
            this.txtsituacao.AutoSize = true;
            this.txtsituacao.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsituacao.Location = new System.Drawing.Point(244, 417);
            this.txtsituacao.Name = "txtsituacao";
            this.txtsituacao.Size = new System.Drawing.Size(0, 33);
            this.txtsituacao.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioIMC.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(814, 531);
            this.Controls.Add(this.txtsituacao);
            this.Controls.Add(this.lblsituacao);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.tituloimc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloimc;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.Label txtsituacao;
    }
}

