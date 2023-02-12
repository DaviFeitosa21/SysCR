using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Direcionamento para tela de Cadastro de Clientes
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 CadastroCliente = new Form2();
            CadastroCliente.ShowDialog();
        }

        //Direcionamento para tela de Cadastro de Funcionários
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 CadastroFuncionario = new Form3();
            CadastroFuncionario.ShowDialog();
        }

        //Direcionamento para tela de Vendas/Orçamentos
        private void vendasOrçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Vendas = new Form4();
            Vendas.ShowDialog();
        }
    }
}
