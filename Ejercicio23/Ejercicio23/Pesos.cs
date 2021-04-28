using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auxiliar;

namespace Billetes

{
    class Pesos
    {
        double cantidad;
        static double cotizacionDolar = 66;

        public Pesos()
        {
            this.cantidad = 0;
        }

        public Pesos( double cantidad)
        {
            this.cantidad = cantidad;
            
        }

        // OPERADORES DE CONVERSION

        public static explicit operator Dolares(Pesos pesos)
        {
            return new Dolares(pesos.getCantidad() / Pesos.getCotizacionDolar());
        }

        public static explicit operator Euros(Pesos pesos)
        {
            return new Euros(pesos.getCantidad() * ( Euros.getCotizacionDolar()/Pesos.getCotizacionDolar()));
        }



        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }


        //OPERADORES DE SUMA
        public static Pesos operator +(Pesos pesos, Dolares dolares)
        {
            Pesos pesos2 = (Pesos)dolares;

            pesos.cantidad = pesos.getCantidad() + pesos2.getCantidad();


            return pesos;
        }
        public static Pesos operator +(Pesos pesos, Euros euros)
        {
            Pesos pesos2 = (Pesos)euros;

            pesos.cantidad = pesos.getCantidad() + pesos2.getCantidad();


            return pesos;
        }
        public static Pesos operator +(Pesos pesos, Pesos pesos2)
        {
            pesos.cantidad = pesos.cantidad + pesos2.getCantidad();


            return pesos;
        }
        public static Pesos operator -(Pesos pesos, Dolares dolares)
        {
            Pesos pesos2 = (Pesos)dolares;

            pesos.cantidad = pesos.getCantidad() - pesos2.getCantidad();


            return pesos;
        }
        public static Pesos operator -(Pesos pesos, Euros euros)
        {
            Pesos pesos2 = (Pesos)euros;

            pesos.cantidad = pesos.getCantidad() - pesos2.getCantidad();


            return pesos;
        }
        public static Pesos operator -(Pesos pesos, Pesos pesos2)
        {
            pesos.cantidad = pesos.cantidad - pesos2.getCantidad();


            return pesos;
        }

        public static bool operator ==(Pesos pesos, Pesos pesos2)
        {
            if (pesos.getCantidad() == pesos2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Pesos pesos, Pesos pesos2)
        {
            if (pesos.getCantidad() != pesos2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos pesos, Dolares dolares)
        {
            Pesos pesos2 = (Pesos)dolares;

            if (pesos.getCantidad() == pesos2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Pesos pesos, Dolares dolares)
        {
            Pesos pesos2 = (Pesos)dolares;

            if (pesos.getCantidad() != pesos2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos pesos, Euros euros)
        {
            Pesos pesos2 = (Pesos)euros;

            if (pesos.getCantidad() == pesos2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Pesos pesos, Euros euros)
        {
            Pesos pesos2 = (Pesos)euros;

            if (pesos.getCantidad() == pesos2.getCantidad())
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
        //GETTERS

        public double getCantidad()
        {
            return Auxiliares.TruncarEnDosDecimales(this.cantidad);
        }
        public static double getCotizacionDolar()
        {
            return Auxiliares.TruncarEnDosDecimales(cotizacionDolar);
        }
    }
}
