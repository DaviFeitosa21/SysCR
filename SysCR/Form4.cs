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
    public partial class Form4 : Form
    {
        private MySqlConnection ConexaoVendas;
        private string dados_banco = "datasource = localhost; username = root; password = 1234; database = db_sistema";

        public Form4()
        {
            InitializeComponent();
        }

        //Botão de buscar cliente / Vendas e Orçamentos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoVendas = new MySqlConnection(dados_banco);

                ConexaoVendas.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ConexaoVendas;

                carregar_clientes();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexaoVendas.Close();
            }
        }

        //Botão de gravar venda / Vendas e Orçamentos
        private void btnGravarVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda gravada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparTextBoxVendas();
        }

        //Método para limpar TextBox ao gravar venda / Vendas e Orçamentos
        private void LimparTextBoxVendas()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtQuantProduto.Text = string.Empty;
            txtValorProduto.Text = string.Empty;
        }

        //Método para buscar cliente e mostrar na TextBox / Vendas e Orçamentos
        private void carregar_clientes()
        {
            ConexaoVendas = new MySqlConnection(dados_banco);

            ConexaoVendas.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = ConexaoVendas;

            cmd.CommandText = "SELECT * FROM cadcliente WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", txtID.Text);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtNome.Text = reader["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
        }

    }
}
