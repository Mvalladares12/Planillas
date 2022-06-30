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
    public partial class frmVerAfp : Form
    {
        public frmVerAfp()
        {
            InitializeComponent();
        }

        Ver af = new Ver();
        private void frmVerAfp_Load(object sender, EventArgs e)
        {
            dgvAFP.DataSource = af.verAFP();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
