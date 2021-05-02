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
using Auxiliar;




namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCotizacionDolar.Text = "1";
            txtCotizacionEuro.Text = Euros.getCotizacionDolar().ToString();
            txtCotizacionPeso.Text = Pesos.GetCotizacionDolar().ToString();

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

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            if (txtCotizacionDolar.Text != "1")
            {
                txtCotizacionDolar.Text = "1";
            }
        }
        private void ParsearDouble(TextBox textBox)
        {
            double result;

            if (double.TryParse(textBox.Text, out result))
            {
                textBox.Text = result.ToString();
            }
            else
            {
                textBox.Text = "0";
                textBox.SelectAll();
                textBox.Focus();
            }
        }
       
        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            ParsearDouble(txtCotizacionEuro);
            Euros.SetCotizacionDolar(double.Parse(txtCotizacionEuro.Text));
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            ParsearDouble(txtCotizacionPeso);
            Pesos.SetCotizacionDolar(double.Parse(txtCotizacionPeso.Text));
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            ParsearDouble(txtDolar);
        }
        private void txtEuro_Leave(object sender, EventArgs e)
        {
            ParsearDouble(txtEuro);
        }
        private void txtPeso_Leave(object sender, EventArgs e)
        {
            ParsearDouble(txtPeso);
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            Dolares dolares = new Dolares(double.Parse(txtDolar.Text));
            Euros euros = (Euros)dolares;
            Pesos pesos = (Pesos)dolares;


            txtDolarADolar.Text = txtDolar.Text;
            txtDolarAEuro.Text = euros.getCantidad().ToString(); 
            txtDolarAPeso.Text = pesos.getCantidad().ToString();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            Euros euros = new Euros(double.Parse(txtEuro.Text));
            Dolares dolares = (Dolares)euros;
            Pesos pesos = (Pesos)euros;


            txtEuroADolar.Text =  dolares.getCantidad().ToString();
            txtEuroAEuro.Text = txtEuro.Text;
            txtEuroAPeso.Text = pesos.getCantidad().ToString();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            Pesos pesos= new Pesos(double.Parse(txtPeso.Text));
            Dolares dolares = (Dolares)pesos;
            Euros euros = (Euros)pesos;


            txtPesosAPesos.Text = txtPeso.Text;
            txtPesoADolar.Text = dolares.getCantidad().ToString();
            txtPesoAEuro.Text = euros.getCantidad().ToString();
        }
    }
}
