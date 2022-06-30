using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmVerGeneral : Form
    {
        public frmVerGeneral()
        {
            InitializeComponent();
        }

        Ver gen = new Ver();
        private void frmVerGeneral_Load(object sender, EventArgs e)
        {
            dgvGeneral.DataSource = gen.verGeneral();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
