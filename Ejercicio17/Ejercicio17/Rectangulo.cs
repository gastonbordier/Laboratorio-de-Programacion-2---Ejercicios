using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {

        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        private float area;
        private float perimetro;


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            this.vertice2 = new Punto(vertice3.getX(), vertice1.getY());
            this.vertice4 = new Punto(vertice1.getX(), vertice3.getY());

            area = getArea();
            perimetro = getPerimetro();

        }

        private float getArea()
        {
            return Math.Abs((vertice3.getX() - vertice1.getX()) * (vertice3.getY() - vertice1.getY()));
        }
        private float getPerimetro()
        {
            return (Math.Abs(vertice3.getX() - vertice1.getX()) + Math.Abs(vertice3.getY() - vertice1.getY())) * 2;
        }
        public float Area()
        {
            return area;
        }
        public float Perimetro()
        {
            return perimetro;
        }

        public static void ImprimirDatos( Rectangulo rectangulo)
        {
            Console.WriteLine("Vertice 1 = ( " + rectangulo.vertice1.getX() + " , " + rectangulo.vertice1.getY() + " ).");
            Console.WriteLine("Vertice 2 = ( " + rectangulo.vertice2.getX() + " , " + rectangulo.vertice2.getY() + " ).");
            Console.WriteLine("Vertice 3 = ( " + rectangulo.vertice3.getX() + " , " + rectangulo.vertice3.getY() + " ).");
            Console.WriteLine("Vertice 4 = ( " + rectangulo.vertice4.getX() + " , " + rectangulo.vertice4.getY() + " ).\n");


            Console.WriteLine("El area del rectangulo ingresado es " + rectangulo.Area());

            Console.WriteLine("El perimetro del rectangulo ingresado es " + rectangulo.Perimetro());
        }


       
    }
}
