namespace progeto_do_git
{
    partial class FormLogin
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
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.lblTítulologin = new System.Windows.Forms.Label();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIniciarSessão = new System.Windows.Forms.Button();
            this.lblRegistar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogin
            // 
            this.picLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogin.Location = new System.Drawing.Point(150, 25);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(120, 120);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // lblTítulologin
            // 
            this.lblTítulologin.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulologin.Location = new System.Drawing.Point(35, 160);
            this.lblTítulologin.Name = "lblTítulologin";
            this.lblTítulologin.Size = new System.Drawing.Size(350, 35);
            this.lblTítulologin.TabIndex = 1;
            this.lblTítulologin.Text = "Bem-vindo de volta!";
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitulo.Location = new System.Drawing.Point(35, 198);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(350, 25);
            this.LblSubtitulo.TabIndex = 2;
            this.LblSubtitulo.Text = "Iniciar sessão na tua conta";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(35, 245);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(350, 22);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Nome de utlizador";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(35, 270);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 25);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(35, 318);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(350, 22);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Palavra-passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // btnIniciarSessão
            // 
            this.btnIniciarSessão.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIniciarSessão.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSessão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSessão.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSessão.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSessão.Location = new System.Drawing.Point(35, 395);
            this.btnIniciarSessão.Name = "btnIniciarSessão";
            this.btnIniciarSessão.Size = new System.Drawing.Size(350, 42);
            this.btnIniciarSessão.TabIndex = 7;
            this.btnIniciarSessão.Text = "Iniciar Sessão";
            this.btnIniciarSessão.UseVisualStyleBackColor = false;
            // 
            // lblRegistar
            // 
            this.lblRegistar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistar.Location = new System.Drawing.Point(60, 448);
            this.lblRegistar.Name = "lblRegistar";
            this.lblRegistar.Size = new System.Drawing.Size(300, 32);
            this.lblRegistar.TabIndex = 8;
            this.lblRegistar.Text = "Não tens conta?\r\nRegista-te\r\n";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 590);
            this.Controls.Add(this.lblRegistar);
            this.Controls.Add(this.btnIniciarSessão);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.LblSubtitulo);
            this.Controls.Add(this.lblTítulologin);
            this.Controls.Add(this.picLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sessão";
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label lblTítulologin;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIniciarSessão;
        private System.Windows.Forms.Label lblRegistar;
    }
}