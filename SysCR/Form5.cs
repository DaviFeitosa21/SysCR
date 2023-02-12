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
    public partial class Form5 : Form
    {

        private MySqlConnection ConexaoPesquisaCliente;
        private string dados_banco = "datasource = localhost; username = root; password = 1234; database = db_sistema";

        public Form5()
        {
            InitializeComponent();

            lstClientes.View = View.Details;
            lstClientes.LabelEdit = true;
            lstClientes.AllowColumnReorder = true;
            lstClientes.FullRowSelect = true;
            lstClientes.GridLines = true;

            lstClientes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstClientes.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            lstClientes.Columns.Add("RG", 100, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Telefone 1", 150, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Telefone 2", 150, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Login", 150, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Senha", 150, HorizontalAlignment.Left);
        }

        //Botão de Buscar Clientes / Cadastro de Clientes
        private void btnPesquisaClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoPesquisaCliente = new MySqlConnection(dados_banco);

                ConexaoPesquisaCliente.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoPesquisaCliente;

                cmd.CommandText = "SELECT * FROM cadcliente WHERE nome LIKE @q OR email LIKE @q";

                cmd.Parameters.AddWithValue("@q", "%" + txtNomeCliente.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                lstClientes.Items.Clear();

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
                    };

                    var txtbox = new ListViewItem(row);

                    lstClientes.Items.Add(txtbox);
                }
                

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                ConexaoPesquisaCliente.Close();
            }
        }

        //Codigo incompleto, tentando fazer as colunas da tabela serem mostradas em outra janela
        private void lstClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection coluna_selecionada = lstClientes.SelectedItems;

            foreach(ListViewItem coluna in coluna_selecionada) 
            {
                Form2 txtvar = new Form2();


                txtNomeCliente.Text = coluna.SubItems[1].Text;
            }
        }

        //Método para carregar Clientes na tela de pesquisa clientes
        private void CarregarColunas()
        {
            ConexaoPesquisaCliente = new MySqlConnection(dados_banco);

            ConexaoPesquisaCliente.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = ConexaoPesquisaCliente;

            cmd.CommandText = "SELECT * FROM cadcliente ORDER BY id ASC";

            MySqlDataReader reader = cmd.ExecuteReader();

            lstClientes.Items.Clear();

            while (reader.Read())
            {
                string[] row = {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetString(6),
                                    reader.GetString(7),
                                    reader.GetString(8),
                };

                var lista = new ListViewItem(row);

                lstClientes.Items.Add(lista);

            }
        }
    }
}
