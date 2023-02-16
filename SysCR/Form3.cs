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

            lstBucarFuncionario.View = View.Details;
            lstBucarFuncionario.LabelEdit = true;
            lstBucarFuncionario.AllowColumnReorder = true;
            lstBucarFuncionario.FullRowSelect = true;
            lstBucarFuncionario.GridLines = true;

            lstBucarFuncionario.Columns.Add("id", 30, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("RG", 100, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Idade", 90, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Salário", 90, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Função", 100, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Telefone 1", 90, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Telefone 2", 90, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Login", 90, HorizontalAlignment.Left);
            lstBucarFuncionario.Columns.Add("Senha", 90, HorizontalAlignment.Left);

            carregar_funcionarios();
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

        //Botão para buscar funcionário e mostrar na ListView / Cadastro de Funcionários
        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoFuncionario = new MySqlConnection(dados_banco);

                ConexaoFuncionario.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoFuncionario;

                cmd.CommandText = "SELECT * FROM cadfuncionario WHERE nome LIKE @q";

                cmd.Parameters.AddWithValue("@q", "%" + txtBuscaFuncionario.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                lstBucarFuncionario.Items.Clear();

                while(reader.Read())
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
                        reader.GetString(8),
                        reader.GetString(9),
                        reader.GetString(10),
                        reader.GetString(11)
                    };

                    var funcionarios_listview = new ListViewItem(row);

                    lstBucarFuncionario.Items.Add(funcionarios_listview);
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
                ConexaoFuncionario.Close();
            }
            
        }

        private void lstBucarFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstBucarFuncionario.SelectedItems;

            foreach(ListViewItem item in itens_selecionados)
            {
                txtID.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtCPF.Text = item.SubItems[2].Text;
                txtRG.Text = item.SubItems[3].Text;
                txtIdade.Text = item.SubItems[4].Text;
                txtSalario.Text = item.SubItems[5].Text;
                txtFuncao.Text = item.SubItems[6].Text;
                txtEmail.Text = item.SubItems[7].Text;
                txtTelefone1.Text = item.SubItems[8].Text;
                txtTelefone2.Text = item.SubItems[9].Text;
                txtLogin.Text = item.SubItems[10].Text;
                txtSenha.Text = item.SubItems[11].Text;
            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            LimparTextBoxCadFuncionario();
        }

        //Método para limpar TextBox ao Salvar / Cadastro de Funcionários
        private void LimparTextBoxCadFuncionario()
        {
            txtID.Text = String.Empty;
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

        private void carregar_funcionarios()
        {
            try
            {
                ConexaoFuncionario = new MySqlConnection(dados_banco);

                ConexaoFuncionario.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoFuncionario;

                cmd.CommandText = "SELECT * FROM cadfuncionario ORDER BY id ASC";

                MySqlDataReader reader = cmd.ExecuteReader();

                lstBucarFuncionario.Items.Clear();

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
                        reader.GetString(8),
                        reader.GetString(9),
                        reader.GetString(10),
                        reader.GetString(11)
                    };

                    var funcionarios_listview2 = new ListViewItem(row);

                    lstBucarFuncionario.Items.Add(funcionarios_listview2);
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
                ConexaoFuncionario.Close();
            }
        }

       
    }
}
