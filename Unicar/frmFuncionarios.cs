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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            frmCadFuncionario dlgCadFuncionario = new frmCadFuncionario();
            if (dlgCadFuncionario.ShowDialog() == DialogResult.OK)
            {
                CadastroFuncionario oCad = new CadastroFuncionario();
                oCad.registro = dlgCadFuncionario.mskRegistro.Text;
                oCad.nome = dlgCadFuncionario.txtNome.Text;
                oCad.sobrenome = dlgCadFuncionario.txtSobrenome.Text;
                oCad.cpf = Convert.ToInt64(dlgCadFuncionario.txtCPF.Text);
                oCad.cargo = dlgCadFuncionario.cbxCargo.Text;

                oCad.Gravar();
                Carregar();
                dlgCadFuncionario.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void Carregar()
        {
            BindingSource dados = new BindingSource();
            dados.DataSource = new CadastroFuncionario().Listar();
            dgvFuncionarios.DataSource = dados;
        }
    }
}
