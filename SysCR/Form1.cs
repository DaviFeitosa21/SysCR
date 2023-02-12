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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 CadastroCliente = new Form2();
            CadastroCliente.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 CadastroFuncionario = new Form3();
            CadastroFuncionario.ShowDialog();
        }

    }
}
