using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costoPorMinuto;

        public Local(float duracion, string nroDestino, string nroOrigen, float costoPorMinuto) : base(duracion, nroDestino, nroOrigen)
        {
            this.costoPorMinuto= costoPorMinuto;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.AppendFormat("{0,-15:####.00}{1,-15:####.00}", this.costoPorMinuto, this.CostoLlamada);

            return datos.ToString();
        }

        public  float CostoLlamada
        {
            get
            {
                return CalcularCostoTotalLlamada();
            }
        }

        private float CalcularCostoTotalLlamada()
        {
            return this.costoPorMinuto * this.Duracion;
        }


    }
}
