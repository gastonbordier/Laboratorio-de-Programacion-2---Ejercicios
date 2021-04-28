using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;




namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCotizacionDolar.Text = "1";
            txtCotizacionEuro.Text = Euros.getCotizacionDolar().ToString();
            txtCotizacionPeso.Text = Pesos.getCotizacionDolar().ToString();

        }

        private void BloquearCotizaciones()
        {
            txtCotizacionDolar.ReadOnly = true;
            txtCotizacionPeso.ReadOnly = true;
            txtCotizacionEuro.ReadOnly = true;
        }
        private void DesbloquearCotizaciones()
        {
            txtCotizacionDolar.ReadOnly = false;
            txtCotizacionPeso.ReadOnly = false;
            txtCotizacionEuro.ReadOnly = false;
        }

        private bool CotizacionesBloqueadas()
        {
            return txtCotizacionDolar.ReadOnly;
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            if (txtCotizacionDolar.Text != "1")
            {
                txtCotizacionDolar.Text = "1";
            }
        }
       
        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double result;

            if (double.TryParse(txtCotizacionEuro.Text, out result))
            {
                txtCotizacionEuro.Text = result.ToString();
            }
            else
            {
                txtCotizacionEuro.Text = "Ingresar numero";
                txtCotizacionEuro.SelectAll();
                txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double result;

            if (double.TryParse(txtCotizacionPeso.Text, out result))
            {
                txtCotizacionPeso.Text = result.ToString();
            }
            else
            {
                txtCotizacionPeso.Text = "Ingresar numero";
                txtCotizacionPeso.SelectAll();
                txtCotizacionPeso.Focus();
            }
        }


        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (CotizacionesBloqueadas() == true)
            {
                DesbloquearCotizaciones();
            }
            else
            {
                BloquearCotizaciones();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {

        }
    }
}
