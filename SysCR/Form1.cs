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

        //Direcionamento para a tela Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Sobre = new Form5();
            Sobre.ShowDialog();
        }

        //Comando para mostrar horas dentro do sistema
        private void lblhoras_Paint(object sender, PaintEventArgs e)
        {
            lblhoras.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
        //Timer vinculado ao comando das horas
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhoras.Text = (DateTime.Now.ToString("hh:mm:ss"));
        }
        //Botão para chamar calculadora(Aplicação externa)
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string link = "https://github.com/DaviFeitosa21/SysCR";

            System.Diagnostics.Process.Start(link);
        }
    }
}
