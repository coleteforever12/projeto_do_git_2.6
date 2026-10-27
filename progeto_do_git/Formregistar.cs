using progeto_do_git;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_do_git
{
    public partial class FormRegistar : Form
    {
        public FormRegistar()
        {
            InitializeComponent();
        }



        private void FormRegistar_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarsessão_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == "" ||
                    txtNomeReal.Text == "" ||
                    txtemail.Text == "" ||
                    txtpassword.Text == "" ||
                    txtConfirmar.Text == "")
                {
                    throw new ValidacaoCamposVaziosException(
                        "Preenche todos os campos!"
                    );
                }
                if (!txtemail.Text.Contains("@") ||
                !txtemail.Text.Contains("."))
                {
                    throw new ValidacaoEmailException(
                        "O email tem de conter um @ e um ponto (.)."
                    );

                }
                if (txtpassword.Text 
                 != txtConfirmar.Text)
                {
                    throw new ValidacaoConfirmarPalavrasPasses("" +
                        "As senhas não condizem, insira corretamente!! ");
                }
            }
            catch (ValidacaoCamposVaziosException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validação de campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

            }

            catch (ValidacaoEmailException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validação do email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch(ValidacaoConfirmarPalavrasPasses ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validação das senhas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }











        }
    }

}
