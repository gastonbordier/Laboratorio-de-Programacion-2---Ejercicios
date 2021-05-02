using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auxiliar;

namespace Billetes
{
    class Dolares
    {
        double cantidad;
        static double cotizacionDolar = 1;

        public Dolares()
        {
            this.cantidad = 0;

        }

        public Dolares(double cantidad)
        {
            this.cantidad = Auxiliares.TruncarEnDosDecimales(cantidad);

        }

        //OPERADORES DE CONVERSION

        public static explicit operator Pesos(Dolares dolares)
        {


            return new Pesos(dolares.getCantidad() * Pesos.GetCotizacionDolar());
        }

        public static explicit operator Euros(Dolares dolares)
        {
            return new Euros(dolares.getCantidad() * Euros.getCotizacionDolar());
        }

        public static implicit operator Dolares(double d)
        {
            return new Dolares(d);
        }

        public static Dolares operator +(Dolares dolares, Dolares dolares2)
        {
            dolares.cantidad = dolares.cantidad + dolares2.cantidad;


            return dolares;
        }
        public static Dolares operator +(Dolares dolares, Pesos pesos)
        {
            dolares.cantidad = dolares.cantidad + pesos.getCantidad() / Pesos.GetCotizacionDolar();


            return dolares;
        }
        public static Dolares operator +(Dolares dolares, Euros euros)
        {
            dolares.cantidad = dolares.cantidad + euros.getCantidad() / Euros.getCotizacionDolar();


            return dolares;
        }
        public static Dolares operator -(Dolares dolares, Dolares dolares2)
        {
            dolares.cantidad = dolares.cantidad - dolares2.cantidad;


            return dolares;
        }
        public static Dolares operator -(Dolares dolares, Pesos pesos)
        {
            dolares.cantidad = dolares.cantidad - pesos.getCantidad() / Pesos.GetCotizacionDolar();


            return dolares;
        }
        public static Dolares operator -(Dolares dolares, Euros euros)
        {
            dolares.cantidad = dolares.cantidad - euros.getCantidad() / Euros.getCotizacionDolar();


            return dolares;
        }

        public static bool operator ==(Dolares dolares, Dolares dolares2)
        {

            if (dolares.getCantidad() == dolares2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolares dolares, Dolares dolares2)
        {

            if (dolares.getCantidad() != dolares2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Dolares dolares, Euros euros)
        {
            Dolares dolares2 = (Dolares)euros;


            if (dolares.getCantidad() == dolares2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolares dolares, Euros euros)
        {
            Dolares dolares2 = (Dolares)euros;


            if (dolares.getCantidad() != dolares2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Dolares dolares, Pesos pesos)
        {
            Dolares dolares2 = (Dolares)pesos;


            if (dolares.getCantidad() == dolares2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolares dolares, Pesos pesos)
        {
            Dolares dolares2 = (Dolares)pesos;


            if (dolares.getCantidad() != dolares2.getCantidad())
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


        public double getCantidad()
        {
            return Auxiliares.TruncarEnDosDecimales(this.cantidad);
        }
        public static double getCotizacion()
        {
            return Auxiliares.TruncarEnDosDecimales(cotizacionDolar);
        }

        public static void SetCotizacionDolar(double nuevaCotizacion)
        {
            cotizacionDolar = Auxiliares.TruncarEnDosDecimales(nuevaCotizacion);
        }
    }
}
