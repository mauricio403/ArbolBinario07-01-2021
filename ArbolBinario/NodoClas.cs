using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ArbolBinario
{
    public class NodoClas
    {
        public string Nombre { get; set; }

        public NodoClas(string nombre)
        {
            Nombre = nombre;
            Hijos = new List<NodoClas>;
        }
        public NodoClas()
        {

        }

        public object Contenido { get; set; }

        public List<NodoClas> Hijos { get; set; }

        public static int MetodoContarNodos(NodoClas nodo)
        {
            if (nodo == null) return 0;

            if (nodo.Hijos == null) return 1;

            int nietos = 0;

            for (int i=0; i < nodo.Hijos.Count(); i++)
            {
                nietos += MetodoContarNodos(nodo.Hijos[i]);
            }
            return nietos++;
        }
        public void ColocarValor(object obj)
        {
            this.Contenido = obj;
        }
        public static int MetodoContarHojas(NodoClas nodo)
        {
            if (nodo.Hijos.Count() == 0) return 1;

            int numeroDeHojas = 0;

            for (int i =0; i <nodo.Hijos.Count(); i++)
            {
                numeroDeHojas += MetodoContarHojas(nodo.Hijos[i]);
            }
            return numeroDeHojas;
        }
        public static int MetodoContarNiveles(NodoClas nodo)
        {
            if (nodo.Hijos.Count() == 0) return 0;

            int niveles = 0;

            for (int i = 0; i < nodo.Hijos.Count(); i++)
            {
                if (nodo.Hijos.Count() > 0)
                {
                    niveles = MetodoContarHojas(nodo.Hijos[i]);
                    niveles++;
                }
            }
            return niveles;
        }
        public void MetodoNavegarHorizontal(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            MetodoNavegarHorizontal(nodo.Derecho);
            MetodoNavegarHorizontal(nodo.Izquierdo);
            Console.WriteLine(nodo.Nombre);
        }
        public static void ImprmirArbol(NodoClas nodo)
        {
            Console.WriteLine(nodo.Nombre);
            if (nodo == null)
                Console.WriteLine("El arbol que quieres imprimrir.. se ha realizado con exito..xDD");
            if (nodo.Hijos == null)
                Console.WriteLine(nodo.Nombre);
            for (int i = 0; i < nodo.Hijos.Count(); i++)
            {
                ImprmirArbol(nodo.Hijos[i]);
            }
        }
    }
}
