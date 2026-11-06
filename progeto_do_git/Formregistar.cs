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

namespace progeto_do_git
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
                    throw new ValidaçãoEmailExeption(
                        "O email tem de conter um @ e um ponto (.)."
                    );
                }

                if (txtpassword.Text != txtConfirmar.Text)
                {
                    throw new ValidacaoConfirmarPalavrasPasseException(
                        "As senhas não condizem, insira corretamente!!"
                    );
                }
                int idade = DateTime.Now.Year - dtpDataNascimento.Value.Year;
                if (dtpDataNascimento.Value.Month > DateTime.Now.Month)
                {
                    idade--;
                }
                else if (dtpDataNascimento.Value.Month == DateTime.Now.Month && dtpDataNascimento.Value.Day > DateTime.Now.Day)
                {
                    idade--;
                }
                if (idade < 14)
                {
                    throw new ValidacaoIdadeException(
                        "O Utilizador deve ter 14 ou mais anos!"
                   );
                }
                Utilizador novoUtilizador = new Utilizador();
                novoUtilizador.NomeUtilizador = txtusername.Text;
                novoUtilizador.PalavraPasse = txtpassword.Text;
                novoUtilizador.NomeReal = txtNomeReal.Text;
                novoUtilizador.DataNascimento = dtpDataNascimento.Value;
                novoUtilizador.Email = txtemail.Text;
                foreach (Utilizador utilizador in DadosUtilizadores.Lista)
                {
                    if (txtusername.Text == utilizador.NomeUtilizador)
                    {
                        throw new ValidacaoUserNameException(
                            "Nome de Utilizador já registado tente outro!"
                        );
                    }
                }
                DadosUtilizadores.Lista.Add(novoUtilizador);
                MessageBox.Show("Conta criada com sucesso!");


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
            catch (ValidaçãoEmailExeption ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validação do email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (ValidacaoConfirmarPalavrasPasseException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validação das senhas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (ValidacaoIdadeException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validação da idade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (ValidacaoUserNameException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Username Em uso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }





        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }
    }
}


