using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class Fecha
    {
        private int dia, mes, anio;
        int mesActual;
        int diaActual;
        int anioActual;
        public Fecha()
        {
            mesActual = int.Parse(DateTime.Now.ToString("MM"));
            diaActual = int.Parse(DateTime.Now.ToString("dd"));
            anioActual = int.Parse(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("Ingrese dia de nacimiento\n");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes de nacimiento\n");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese anio de nacimiento\n");
            anio = int.Parse(Console.ReadLine());

            Console.WriteLine("La cantidad de dias transcurridos desde el nacimiento es "+calcularDiasTotales());
        }

        public int calcularDiasTotales()
        {
            return calcularDiasAniosIntermedios() + calcularDiasRestantesDelAnioInicial() + calcularDiasAcumuladosAnioActual();
        }
        public int calcularDiasAniosIntermedios()
        {
            int contadorDias = 0;

            for (int i = (anio + 1); i < anioActual; i++)
            {
                if (esBisiesto(i))
                {
                    contadorDias += 366;
                }
                else
                {
                    contadorDias += 365;
                }
            }
            return contadorDias;
        }
        public int calcularDiasAcumuladosAnioActual()
        {
            int contadorDias = 0;

            int mesL = 1;
            int dia = 1;

            if (mesL == 1)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }
            if (mesL == 2)
            {
                if (mesL == mesActual)
                {

                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    if (esBisiesto(anioActual))
                    {
                        contadorDias += 29;

                    }
                    else
                    {
                        contadorDias += 28;
                    }
                    ++mesL;
                }
            }
            if (mesL == 3)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }
            if (mesL == 4)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 30;
                    ++mesL;
                }
            }
            if (mesL == 5)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }
            if (mesL == 6)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 30;
                    ++mesL;
                }
            }
            if (mesL == 7)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }
            if (mesL == 8)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }
            if (mesL == 9)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 30;
                    ++mesL;
                }
            }
            if (mesL == 10)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }
            if (mesL == 11)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 30;
                    ++mesL;
                }
            }
            if (mesL == 12)
            {
                if (mesL == mesActual)
                {
                    contadorDias += diaActual;
                    mesL = 0;
                }
                else
                {
                    contadorDias += 31;
                    ++mesL;
                }
            }





            return contadorDias;
        }
        public int calcularDiasRestantesDelAnioInicial()
        {
            int contadorDias = 0;
            int mesContador = mes;
            int diaContador = dia;

            if (mesContador == 1)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 2)
            {
                if (esBisiesto(anio))
                {
                    contadorDias += (29 - diaContador);
                }
                else
                {
                    contadorDias += (28 - diaContador);

                }
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 3)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 4)
            {
                contadorDias += (30 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 5)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 6)
            {
                contadorDias += (30 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 7)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 8)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 9)
            {
                contadorDias += (30 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 10)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 11)
            {
                contadorDias += (30 - diaContador);
                ++mesContador;
                diaContador = 0;
            }
            if (mesContador == 12)
            {
                contadorDias += (31 - diaContador);
                ++mesContador;
                diaContador = 0;
            }

            return contadorDias;


        }
        public bool esBisiesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if ((anio % 100 == 0) && !(anio % 400 == 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
