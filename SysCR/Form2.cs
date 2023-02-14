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

            lstBuscarContato.View = View.Details;
            lstBuscarContato.LabelEdit = true;
            lstBuscarContato.AllowColumnReorder = true;
            lstBuscarContato.FullRowSelect = true;
            lstBuscarContato.GridLines = true;

            lstBuscarContato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("RG", 100, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("Telefone 1", 90, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("Telefone 2", 90, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("Login", 90, HorizontalAlignment.Left);
            lstBuscarContato.Columns.Add("Senha", 90,HorizontalAlignment.Left);

            CarregarClientes();
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

        //Botão para buscar cliente e mostrar na ListView / Cadastro de Clientes
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoCliente = new MySqlConnection(dados_banco);

                ConexaoCliente.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoCliente;

                cmd.CommandText = "SELECT * FROM cadcliente WHERE nome LIKE @q OR email LIKE @q";

                cmd.Parameters.AddWithValue("@q", "%" + txtBuscarCliente.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                lstBuscarContato.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),

                    };

                    var clientes_listview = new ListViewItem(row);

                    lstBuscarContato.Items.Add(clientes_listview);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexaoCliente.Close();
            }
        }

        //Botão para limpar TextBox / Cadastro de Clientes
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            LimparTextBoxCadCliente();
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

        //Método para Carregar clientes na ListView / Cadastro de Clientes
        private void CarregarClientes()
        {
            try
            {
                ConexaoCliente = new MySqlConnection(dados_banco);

                ConexaoCliente.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoCliente;

                cmd.CommandText = "SELECT * FROM cadcliente ORDER BY id ASC";

                MySqlDataReader reader = cmd.ExecuteReader();

                lstBuscarContato.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
                        
                    };

                    var clientes_listview = new ListViewItem(row);

                    lstBuscarContato.Items.Add(clientes_listview);
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexaoCliente.Close();
            }
        }

        
    }
}
