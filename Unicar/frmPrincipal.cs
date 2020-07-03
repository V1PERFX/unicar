using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recurso não implementado, Aguarde atualização.");
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recurso não implementado, Aguarde atualização.");
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios dlgFuncionarios = new frmFuncionarios();
            dlgFuncionarios.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes dlgClientes = new frmClientes();
            dlgClientes.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}
