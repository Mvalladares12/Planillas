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
    public partial class frmISSS : Form
    {
        SqlConnection conect = new SqlConnection("Data source=DESKTOP-FUKI3JG;Initial Catalog=PLANILLA;Integrated security=True");
        public frmISSS()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int HE,H;
            double aguinaldo, salario, vacaciones, total, ap, ae, precioH;
            try
            {
                salario = Convert.ToDouble(txtSalario.Text);
                aguinaldo = Convert.ToDouble(txtAg.Text);
                vacaciones = Convert.ToDouble(txtVacaciones.Text);
                HE = Convert.ToInt32(txtHorasE.Text);
                H = Convert.ToInt32(txtHorasJ.Text);

                precioH = (salario / 30 / H);
                ae = (salario + vacaciones + aguinaldo) + (HE * precioH*2);
                if (ae < 1000)
                    ae=ae* 0.03;
                else           
                    ae = 30;

                ap = (salario + vacaciones + aguinaldo) * 0.075;
                total = ae + ap;
                txtAporteL.Text = ae.ToString();
                txtAporteP.Text = ap.ToString();
                txtTotal.Text = total.ToString();
            }
            catch(FormatException)
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
            foreach (Control c in this.gpb2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox texto = c as TextBox;
                    texto.Text = "";
                }
            }
            cmbAE.Text = "Seleccione...";
            mtbNA.Clear();
            mtbNIT.Clear();
            mtbNP.Clear();
            mtbTel.Clear();
            txtNomP.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ISSS(Nombre_Empresa, NIT, Localizacion, Numero_patronal, Telefono, Fecha_emision, Periodo_pago, Numero_afiliacion, Nombre_segun_tarjeta, Salario_Bruto, Aguinaldo, Pago_Vacaciones, Horas_extra, Horas_Jornada, AporteLaboral, AportePatronal, Total)VALUES('"+this.txtNomE.Text+"','"+this.mtbNIT.Text+"','"+this.txtDM.Text+"','"+this.mtbNP.Text+"','"+this.mtbTel.Text+"','"+this.txtFecha.Text+"','"+this.txtPerio.Text+"','"+this.mtbNA.Text+"','"+this.txtNombre.Text+"','"+this.txtSalario.Text+"','"+this.txtAg.Text+"','"+this.txtVacaciones.Text+"','"+this.txtHorasE.Text+"','"+this.txtHorasJ.Text+"','"+this.txtAporteL.Text+"','"+this.txtAporteP.Text+"','"+this.txtTotal.Text+"')",conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro guardado con exito");
            conect.Close();
        }
    }
}
