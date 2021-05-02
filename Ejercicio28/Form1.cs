using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        
    


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DiccionarioConContador Diccionario = new DiccionarioConContador(this.rtbTexto.Text);
            Diccionario.OrdenarPorContador();

            string textoSalida = "Estas son las tres palabras mas utilizadas:\n";

            string[] impresion = Diccionario.Imprimir().Split('\n');

            for (int i = 0; i < 3; i++)
            {
                textoSalida += impresion[i]+ "\n";
            }

            MessageBox.Show(textoSalida);
        }      
    }
}
