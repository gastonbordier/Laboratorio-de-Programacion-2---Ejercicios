using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            setTinta(tinta);
            this.color = color;
        }

        public short getTinta()
        {
            return tinta;
        }
        public ConsoleColor getColor()
        {
            return color;
        }

        private void setTinta(short tinta)
        {
            this.tinta += tinta;

            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            if (this.tinta > 100)
            {
                this.tinta = 100;
            }
        }
        public void Recargar()
        {
            setTinta(100);
            Console.WriteLine("El boligrafo " + getColor() + " se ha recargado\n");
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            short tintaInicial = this.tinta;

            if (this.tinta == 0)
            {
                Console.WriteLine("El boligrafo " + getColor() + " esta vacio\n");
                return false;
            }
            else
            {

                short contador = 0;

                while (getTinta() > 0 && gasto > 0)
                {
                    ++contador;

                    if (contador % 10 == 0)
                    {
                        dibujo = dibujo + "* ";
                    }
                    else
                    {
                        dibujo = dibujo + "*";

                    }
                    setTinta(short.Parse("-1"));
                    --gasto;
                }
                Console.ForegroundColor = this.color;
                Console.WriteLine(dibujo);
                Console.ResetColor();

                Console.WriteLine("Se ha gastado " + contador + " de tinta " + getColor() + "\n");


                return true;
            }
        }
    }
}