using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }

        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public float GananciasProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float totalProvincial = 0;
            float totalLocal = 0;


            for (int i = 0; i < listaDeLlamadas.Count; i++)
            {
                switch (listaDeLlamadas[i])
                {
                    case Provincial:
                        totalProvincial += ((Provincial)listaDeLlamadas[i]).CostoLlamada;

                        break;
                    case Local:
                        totalLocal += ((Local)listaDeLlamadas[i]).CostoLlamada;
                        break;

                }


            }
            switch (tipo)
            {
                case TipoLlamada.Provincial:
                    return totalProvincial;
                case TipoLlamada.Local:
                    return totalLocal;
                case TipoLlamada.Todas:
                default:
                    return totalProvincial + totalLocal;

            }
        }
    
        public void OrdenarLlamadas()
        {

            listaDeLlamadas.Sort((a, b) => a.OrdenarPorDuracion(a, b));
        }

        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat("Central Telefonica  \"{0}\"\n\n", this.razonSocial);
            texto.AppendFormat("{0,43}\t$ {1,5:###0.00}\n", "Ganancias por Llamadas locales:", this.GananciasLocal);
            texto.AppendFormat("{0,43}\t$ {1,5:###0.00}\n", "Ganancias por Llamadas internacionales:", this.GananciasProvincial);
            texto.AppendFormat("{0,43}\t$ {1,5:###0.00}\n\n\n", "Ganancias totales por Llamadas:", this.GananciasPorTotal);
            texto.AppendFormat("Detalle de llamadas:\n\n");
            texto.AppendFormat("{0,-10}{1,-15}{2,-15}\n", "Duracion", "Destino", "Origen");
            
            for (int i = 0; i < listaDeLlamadas.Count; i++)
            {
                texto.AppendFormat(listaDeLlamadas[i].ToString());
            }


            return texto.ToString();
        }
    }
}
