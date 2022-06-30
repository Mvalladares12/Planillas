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
    public partial class frmGeneral : Form
    {
        SqlConnection conect = new SqlConnection("Data source=DESKTOP-FUKI3JG;Initial Catalog=PLANILLA;Integrated security=True");
        public frmGeneral()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, TDeduccion, Total, IL, IP, AL, AP;
            try
            {
                salario = Convert.ToDouble(txtSueldo.Text);

                if (salario < 1000)
                {
                    IL = salario * 0.03;
                    IP = salario * 0.075;
                }
                else
                {
                    IL = 30;
                    IP = 75;
                }
                if (salario < 7045.06)
                {
                    AL = salario * 0.0725;
                    AP = salario * 0.0775;
                }
                else
                {
                    AL = 510.77;
                    AP = 545.99;
                }
                TDeduccion = IL + AL ;
                Total = salario - TDeduccion;

                txtISSSL.Text = IL.ToString();
                txtISSSP.Text = IP.ToString();
                txtAFPL.Text = AL.ToString();
                txtAFPP.Text = AP.ToString();
                txtDeduccion.Text = TDeduccion.ToString();
                txtTotal.Text = Total.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, dato no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.gpb1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox texto = c as TextBox;
                    texto.Text = "";
                }
            }
            cmbDepa.Text = "Seleccione...";
            txtNombre.Focus();
            mtbNIT.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO PlanillaG(NombreEmpleado,NIT,Departamento, SueldoBase, HorasNormales, HorasExtra, ISSS_Laboral, ISSS_Patronal,AFP_Laboral,AFP_Patronal,Total_Deduccion, SalarioNeto)VALUES('"+this.txtNombre.Text+"','"+this.mtbNIT.Text+"','"+this.cmbDepa.Text+"','"+this.txtSueldo.Text+"','"+this.txtHN.Text+"','"+this.txtHE.Text+"','"+this.txtISSSL.Text+"','"+this.txtISSSP.Text+"','"+this.txtAFPL.Text+"','"+this.txtAFPP.Text+"','"+this.txtDeduccion.Text+"','"+this.txtTotal.Text+"')",conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro guardado con exito.");
            conect.Close();
        }
    }
}
