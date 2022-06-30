using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Formulario
{
    public partial class frmAfp : Form
    {
        SqlConnection conect = new SqlConnection("Data source=DESKTOP-FUKI3JG;Initial Catalog=PLANILLA;Integrated security=True");
        public frmAfp()
        {
            InitializeComponent();
        }

        private void frmAfp_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Salario, volunt, total, ae, ap;
            try
            {
                Salario = Convert.ToDouble(txtSalario.Text);
                volunt = Convert.ToDouble(txtVolun.Text);

                if (Salario < 7045.06)
                {
                    ae = (Salario + volunt) * 0.0725;
                    ap = (Salario + volunt) * 0.0775;
                }
                else
                {
                    ae = 510.77;
                    ap = 545.99;
                }
                total = ae+ap;

                txtAP.Text = ap.ToString();
                txtAE.Text = ae.ToString();
                txtTotal.Text = total.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Error, dato no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mktNUP.Clear();
            mktDUI.Clear();
            mktTelefono.Clear();
            foreach (Control c in this.gpb1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox texto = c as TextBox;
                    texto.Text = "";
                }
            }
            foreach (Control c in this.gpb2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox texto = c as TextBox;
                    texto.Text = "";
                }
            }
            txtPeriodo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO AFP(ID_NT, Telefono, Banco, NUP, Nombre, Apellidos, Salario, Volunt, AportePatronal, AporteLaboral, Total, Fecha)VALUES('"+this.mtbNT.Text+"','"+this.mktTelefono.Text+"','"+this.txtBanc.Text+"','"+this.mktNUP.Text+"','"+this.txtNombre.Text+"','"+this.txtApellido.Text+"','"+this.txtSalario.Text+"','"+this.txtVolun.Text+"','"+this.txtAP.Text+"','"+this.txtAE.Text+"','"+this.txtTotal.Text+"','"+this.txtPeriodo.Text+"')",conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro guardado con exito.");
            conect.Close();
        }
    }
}
