using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progeto_do_git
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lblRegistar_Click(object sender, EventArgs e)
        {
            FormRegistar form = new FormRegistar();
            form.Show();
            this.Hide();
        }

        private void btnIniciarSessão_Click(object sender, EventArgs e)
        {
            bool loginVálido = false;
            Utilizador Utilizadorencontrado = new Utilizador();
            foreach (Utilizador user in DadosUtilizadores.Lista)
            {
                if(txtUsername.Text == user.NomeUtilizador && txtpassword.Text == user.PalavraPasse)
                {
                    loginVálido = true;
                    Utilizadorencontrado = user;
                }
            }
            if(loginVálido == true)
            {
                FormPerfil form = new FormPerfil();
                form.Show();
            }
            else
            {
                MessageBox.Show("O Nome do utilizador ou a palavra passe estão incorretos!");

            }
        }
    }
}
