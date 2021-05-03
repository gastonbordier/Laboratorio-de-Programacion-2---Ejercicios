using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {
        string nombre;
         int cantidadDeJugadoresPermitida;
         List<Jugador> jugadores;


        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadPermitida, string nombre) : this()
        {
            this.cantidadDeJugadoresPermitida = cantidadPermitida;
            this.nombre = nombre;
        }

        public string MostrarDatos()
        {
            string texto = "";

            texto += "Nombre del Equipo: " + this.nombre + ".  Cantidad de jugadores maxima = " + this.cantidadDeJugadoresPermitida+"\n";
            texto += "dni\t\tnombre\t\tPartidos\t\tGoles\tPromedio de Goles\n";

            for (int i = 0; i < jugadores.Count; i++)
            {
                texto += jugadores[i].MostrarDatos() + "\n";
            }

            return texto;
        }


        public static bool operator +(Equipo equipo, Jugador jugadorEntrante)
        {
            bool YaFiguraElDniEnPlantilla = false;
            bool CapacidadMaximaAlcanzada = false;

            if (equipo.jugadores.Count >= equipo.cantidadDeJugadoresPermitida)
            {
                CapacidadMaximaAlcanzada = true;
            }
            for (int i = 0; i < equipo.jugadores.Count; i++)
            {
                if (jugadorEntrante == equipo.jugadores[i])
                {
                    YaFiguraElDniEnPlantilla = true;
                    break;
                }

            }

            if(YaFiguraElDniEnPlantilla == true)
            {
                Console.WriteLine("Ya figura el dni ");
                return false;
            }else if (CapacidadMaximaAlcanzada == true)
            {
                Console.WriteLine("Se llego a la capacidad maxima");

                return false;
            }
            else
            {
                equipo.jugadores.Add(jugadorEntrante);
                Console.WriteLine("Se agrego un nuevo jugador");

                return true;
            }


        }

    }
}
