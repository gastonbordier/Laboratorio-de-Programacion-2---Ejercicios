using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        Franja franjaHoraria;

        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja mifranja): base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = mifranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) 
        {


        }

    }

    public enum Franja
    {
        Franja1,
        Franja2,
        Franja3
    }
}
