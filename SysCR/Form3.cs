using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SysCR
{
    public partial class Form3 : Form
    {
        private MySqlConnection ConexaoFuncionario;
        private string dados_banco = "datasource = localhost; username = root; password = 1234; database = db_sistema";

        public Form3()
        {
            InitializeComponent();
        }

        //Botão para salvar cadastro de Funcionário / Cadastro de Funcionários
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                ConexaoFuncionario = new MySqlConnection(dados_banco);

                ConexaoFuncionario.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoFuncionario;

                cmd.CommandText = "INSERT INTO cadfuncionario(nome, cpf, rg, idade, salario, funcao, email, telefone1, telefone2, login, senha)" +
                                  "VALUES (@nome, @cpf, @rg, @idade, @salario, @funcao, @email, @telefone1, @telefone2, @login, @senha)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@rg", txtRG.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdade.Text);
                cmd.Parameters.AddWithValue("@salario", txtSalario.Text);
                cmd.Parameters.AddWithValue("@funcao", txtFuncao.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone1", txtTelefone1.Text);
                cmd.Parameters.AddWithValue("@telefone2", txtTelefone2.Text);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso! ", " Sucesso! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparTextBoxCadFuncionario();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexaoFuncionario.Close();
            }
        }

        //Método para limpar TextBox ao Salvar / Cadastro de Funcionários
        private void LimparTextBoxCadFuncionario()
        {
            txtNome.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtRG.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtSalario.Text = String.Empty;
            txtFuncao.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefone1.Text = String.Empty;
            txtTelefone2.Text = String.Empty;
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;
        }
    }
}
