using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    class DiccionarioConContador
    {
        Dictionary<string, int> Diccionario;
        public DiccionarioConContador()
        {
            Diccionario = new Dictionary<string, int>();

        }

        public DiccionarioConContador(string texto)
        {
            Diccionario = new Dictionary<string, int>();

            string[] textoSeparado = texto.Split(' ');

            for (int i = 0; i < textoSeparado.Length; i++)
            {

                AgregarPalabra(textoSeparado[i]);
            }

        }

        public void AgregarPalabra(string palabra)
        {
            int PosicionDePalabra = ChequearExistenciaDeValor(palabra);

            if (PosicionDePalabra == -1)
            {
                Diccionario.Add(palabra, 1);
            }
            else
            {
                ++Diccionario[Diccionario.ElementAt(PosicionDePalabra).Key.ToString()];
            }

        }

        /// <summary>
        /// Chequea si la palabra existe ya el Dictionary y devuelve su posicion en el indice, o -1 en caso de que no exista
        /// </summary>
        /// <param name="palabra">El valor a chequear</param>
        /// <returns>variable de tipo int</returns>
        private int ChequearExistenciaDeValor(string palabra)
        {
            int PosicionDePalabraExistente = -1;

            for (int i = 0; i < Diccionario.Count; i++)
            {

                if (Diccionario.ElementAt(i).Key.Equals(palabra))
                {
                    PosicionDePalabraExistente = i;
                    break;
                }
            }
            return PosicionDePalabraExistente;
        }

        public string Imprimir()
        {
            string linea = "";

            for (int i = 0; i < Diccionario.Count; i++)
            {
                linea += Diccionario.ElementAt(i).Key + "  " + Diccionario.ElementAt(i).Value + "\n";


            }

            return linea;
        }

        public void OrdenarPorContador()
        {
            if (Diccionario.Count > 1)
            {

                Dictionary<string, int> DiccionarioOrdenado = new Dictionary<string, int>();

                var listaOrdenada = from item in Diccionario
                                    orderby item.Value descending
                                    select item;

                foreach (KeyValuePair<string, int> item in listaOrdenada)
                {
                    DiccionarioOrdenado.Add(item.Key, item.Value);
                }

                Diccionario = DiccionarioOrdenado;
            }
        }
    }
}
