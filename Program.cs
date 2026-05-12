using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol a = new Arbol();
            a.Insertar(50);
            a.Insertar(30);
            a.Insertar(70);
            a.Insertar(20);
            a.Insertar(40);
            a.Insertar(60);
            a.Insertar(80);

            Console.WriteLine("Recorrido en orden:");
            a.RecorrerEnOrden(a.Raiz);
            Console.WriteLine("");
            Console.WriteLine("Recorrido en pre:");
            a.RecorrerPreOrden(a.Raiz);
            Console.WriteLine("");
            Console.WriteLine("Recorrido en pos:");
            a.RecorrerPosOrden(a.Raiz);
        }
    }
}
