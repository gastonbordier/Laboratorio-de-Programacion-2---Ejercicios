using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int totalPartidos;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.totalPartidos = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.totalPartidos = totalPartidos;
        }

        public string MostrarDatos()
        {
            return dni + "\t" + nombre + "\t" + totalPartidos + "\t" + totalGoles+ "\t" + GetPromedioGoles();
        }

        public float GetPromedioGoles()
        {
            if( totalPartidos == 0)
            {
                return 0;
            }
            else
            {
                return (float)totalGoles / (float)totalPartidos;
            }


        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
