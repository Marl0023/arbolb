using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolb
{
    internal class Arbol
    {
        public Nodo Raiz;

        public void Insertar(int v)
        {
            Raiz = InsertarRecursivo(Raiz, v);
        }
        private Nodo InsertarRecursivo(Nodo raiz, int valor)
        {
            if (raiz == null) return new Nodo(valor);

            if (valor < raiz.valor)
                raiz.izq = InsertarRecursivo(raiz.izq, valor);
            else
                raiz.der = InsertarRecursivo(raiz.der, valor);

            return raiz;
        }
        public void RecorrerEnOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                RecorrerEnOrden(raiz.izq);
                Console.Write(raiz.valor + " ");
                RecorrerEnOrden(raiz.der);
            }
        }

    }
}
