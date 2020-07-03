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
    public partial class frmCadVeiculos : Form
    {
        public frmCadVeiculos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e) => Close();
    }
}
