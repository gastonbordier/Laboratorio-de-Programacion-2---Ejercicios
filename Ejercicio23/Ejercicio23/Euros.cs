using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auxiliar;


namespace Billetes
{
    class Euros
    {
        double cantidad;
        static double cotizacionDolar = 1 / 1.08;

        public Euros()
        {
            this.cantidad = 0;

        }
        public Euros(double cantidad)
        {
            this.cantidad = cantidad;

        }
        //OPERADORES DE CONVERSION
        public static explicit operator Dolares(Euros euros)
        {
            return new Dolares(euros.getCantidad() / Euros.getCotizacionDolar());
        }
        public static explicit operator Pesos(Euros euros)
        {
            return new Pesos(euros.getCantidad() * (Pesos.getCotizacionDolar() / Euros.getCotizacionDolar()));
        }

        public static implicit operator Euros(double d)
        {
            return new Euros(d);
        }
        //OPERADORES DE SUMA
        public static Euros operator +(Euros euros, Dolares dolares)
        {
            euros.cantidad = euros.cantidad + dolares.getCantidad();


            return euros;
        }
        public static Euros operator +(Euros euros, Pesos pesos)
        {
            euros.cantidad = euros.cantidad + pesos.getCantidad();


            return euros;
        }
        public static Euros operator +(Euros euros, Euros euros2)
        {
            euros.cantidad = euros.cantidad + euros2.getCantidad();


            return euros;
        }

        public static bool operator ==(Euros euros, Euros euros2)
        {

            if (euros.getCantidad() == euros2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euros euros, Euros euros2)
        {

            if (euros.getCantidad() != euros2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Euros euros, Dolares dolares)
        {
            Euros euros2 = (Euros)dolares;

            if (euros.getCantidad() == euros2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euros euros, Dolares dolares)
        {
            Euros euros2 = (Euros)dolares;

            if (euros.getCantidad() != euros2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euros euros, Pesos pesos)
        {
            Euros euros2 = (Euros)pesos;

            if (euros.getCantidad() == euros2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euros euros, Pesos pesos)
        {
            Euros euros2 = (Euros)pesos;

            if (euros.getCantidad() != euros2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }



        //OPERADORES DE RESTA
        public static Euros operator -(Euros euros, Dolares dolares)
        {
            euros.cantidad = euros.cantidad - dolares.getCantidad() * Euros.getCotizacionDolar();


            return euros;
        }
        public static Euros operator -(Euros euros, Pesos pesos)
        {



            return euros;
        }

        public static Euros operator -(Euros euros, Euros euros2)
        {
            euros.cantidad = euros.cantidad - euros2.getCantidad();


            return euros;
        }




        //GETTERS
        public double getCantidad()
        {

            return Auxiliares.TruncarEnDosDecimales(this.cantidad);
        }
        public static double getCotizacionDolar()
        {
            return Auxiliares.TruncarEnDosDecimales(cotizacionDolar);
        }

        public static void SetCotizacionDolar(double nuevaCotizacion)
        {
            cotizacionDolar = Auxiliares.TruncarEnDosDecimales(nuevaCotizacion);
        }
    }
}
