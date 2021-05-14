using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {

        Franja franjaHoraria;

        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja mifranja) : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = mifranja;
        }

        public Provincial(Llamada llamada1, Franja miFranja): this( llamada1.Duracion, llamada1.NroDestino, llamada1.NroOrigen, miFranja)
        {

        }


        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.AppendFormat("{0,-15}{1,-15:###0.00}", this.franjaHoraria, this.CostoLlamada);

            return datos.ToString();
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }

        }

        private float CalcularCosto()
        {

            float costoPorminuto = 0;

            switch (franjaHoraria)
            {
                case Franja.Franja1:
                    costoPorminuto = 0.99f;
                    break;
                case Franja.Franja2:
                    costoPorminuto = 1.25f;
                    break;
                case Franja.Franja3:
                    costoPorminuto = 0.66f;
                    break;

            }


            return costoPorminuto * Duracion;
        }
        public enum Franja
        {
            Franja1,
            Franja2,
            Franja3
        }
    }

    
}
