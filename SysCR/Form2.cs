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
    public partial class Form2 : Form
    {

        private MySqlConnection ConexaoCliente;
        private string dados_banco = "datasource = localhost; username = root; password = 1234; database = db_sistema";

        public Form2()
        {
            InitializeComponent();
        }

        //Botão para salvar cadastro de Clientes / Cadastro de Clientes
        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoCliente = new MySqlConnection(dados_banco);

                ConexaoCliente.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoCliente;

                cmd.CommandText = "INSERT INTO cadcliente (nome, cpf, rg, email, telefone1, telefone2, login, senha)" +
                                  "VALUES (@nome, @cpf, @rg, @email, @telefone1, @telefone2, @login, @senha)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@rg", txtRG.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone1", txtTelefone1.Text);
                cmd.Parameters.AddWithValue("@telefone2", txtTelefone2.Text);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparTextBoxCadCliente();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message , " Erro! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, " Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexaoCliente.Close();
            }
        }

        //Método para limpar TextBox ao Salvar / Cadastro de Clientes
        private void LimparTextBoxCadCliente()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone1.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
    }
}
