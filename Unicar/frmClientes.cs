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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente dlgCadCliente = new frmCadCliente();
            if(dlgCadCliente.ShowDialog() == DialogResult.OK)
            {
                CadastroCliente oCad = new CadastroCliente();
                oCad.cnh = Convert.ToInt64(dlgCadCliente.txtCNH.Text);
                oCad.nome = dlgCadCliente.txtNome.Text;
                oCad.endereco = dlgCadCliente.txtEndereco.Text;
                oCad.cidade = dlgCadCliente.txtCidade.Text;
                oCad.estado = dlgCadCliente.cbxEstado.Text;
                oCad.cep = Convert.ToInt64(dlgCadCliente.txtCEP.Text);

                oCad.Gravar();
                Carregar();
                dlgCadCliente.Close();
            }
        }

        private void Carregar()
        {
            BindingSource dados = new BindingSource();
            dados.DataSource = new CadastroCliente().Listar();
            dgvClientes.DataSource = dados;
        }
    }
}
