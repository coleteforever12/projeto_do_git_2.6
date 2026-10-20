namespace progeto_do_git
{
    partial class FormRegistar
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
            this.lbltítulo = new System.Windows.Forms.Label();
            this.lblsubtítulo = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblNomeReal = new System.Windows.Forms.Label();
            this.txtNomeReal = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblConfirmarpass = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltítulo
            // 
            this.lbltítulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltítulo.Location = new System.Drawing.Point(35, 20);
            this.lbltítulo.Name = "lbltítulo";
            this.lbltítulo.Size = new System.Drawing.Size(450, 40);
            this.lbltítulo.TabIndex = 0;
            this.lbltítulo.Text = "Criar Conta";
            // 
            // lblsubtítulo
            // 
            this.lblsubtítulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblsubtítulo.Location = new System.Drawing.Point(35, 62);
            this.lblsubtítulo.Name = "lblsubtítulo";
            this.lblsubtítulo.Size = new System.Drawing.Size(450, 25);
            this.lblsubtítulo.TabIndex = 1;
            this.lblsubtítulo.Text = "Junta-te à nossa rede social!!!";
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblusername.Location = new System.Drawing.Point(35, 115);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(170, 25);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Nome de utlizador";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(210, 112);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(270, 20);
            this.txtusername.TabIndex = 3;
            // 
            // lblNomeReal
            // 
            this.lblNomeReal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNomeReal.Location = new System.Drawing.Point(35, 161);
            this.lblNomeReal.Name = "lblNomeReal";
            this.lblNomeReal.Size = new System.Drawing.Size(170, 25);
            this.lblNomeReal.TabIndex = 4;
            this.lblNomeReal.Text = "Nome Real";
            // 
            // txtNomeReal
            // 
            this.txtNomeReal.Location = new System.Drawing.Point(210, 158);
            this.txtNomeReal.Name = "txtNomeReal";
            this.txtNomeReal.Size = new System.Drawing.Size(270, 20);
            this.txtNomeReal.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblemail.Location = new System.Drawing.Point(35, 207);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(170, 25);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(210, 204);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(270, 20);
            this.txtemail.TabIndex = 7;
            // 
            // lblpassword
            // 
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblpassword.Location = new System.Drawing.Point(35, 253);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(170, 25);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "Palavra-passe";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(210, 250);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(270, 20);
            this.txtpassword.TabIndex = 9;
            // 
            // lblConfirmarpass
            // 
            this.lblConfirmarpass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmarpass.Location = new System.Drawing.Point(35, 299);
            this.lblConfirmarpass.Name = "lblConfirmarpass";
            this.lblConfirmarpass.Size = new System.Drawing.Size(170, 25);
            this.lblConfirmarpass.TabIndex = 10;
            this.lblConfirmarpass.Text = "Confirmar palavra-passe";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(210, 296);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(270, 20);
            this.txtConfirmar.TabIndex = 11;
            // 
            // FormRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 844);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.lblConfirmarpass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtNomeReal);
            this.Controls.Add(this.lblNomeReal);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblsubtítulo);
            this.Controls.Add(this.lbltítulo);
            this.Name = "FormRegistar";
            this.Text = " Página de registo";
            this.Load += new System.EventHandler(this.FormRegistar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltítulo;
        private System.Windows.Forms.Label lblsubtítulo;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblNomeReal;
        private System.Windows.Forms.TextBox txtNomeReal;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblConfirmarpass;
        private System.Windows.Forms.TextBox txtConfirmar;
    }
}

