using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbolBinario
{
    public class Administrador
    {
        public void CrearArbol(Nodo nodo, string expresionMatematica)
        {
            if (expresionMatematica.Length == 1)
            {
                nodo.Nombre = expresionMatematica.Substring(0, 1);

            }
            else
            {
                int indiceOperador = BuscarOperador(expresionMatematica);
                Console.WriteLine("El indice operador es: " + indiceOperador);

                var operadorIzquierdo = expresionMatematica.Substring(0, indiceOperador);
                Console.WriteLine("El operando izquierdo es: " + operadorIzquierdo);

                nodo.Nombre = expresionMatematica.Substring(indiceOperador, 0);
                nodo.Izquierdo = new Nodo(operadorIzquierdo);

                nodo.Derecho = new Nodo();
                Console.WriteLine("El indice operador mas " + expresionMatematica.Substring(indiceOperador + 1));

                CrearArbol(nodo.Derecho, expresionMatematica.Substring(indiceOperador + 1));

            }
        }
        private int BuscarOperador(string expresionMatematica)
        {
            char[] expresionMatematicaC = expresionMatematica.ToCharArray();

            int contador;
            int posicion = 0;

            for ( contador = 0; contador < expresionMatematicaC.Length; contador++) 
            {
                if (expresionMatematica[contador] == '+' || expresionMatematica[contador] == '-') 
                {
                    posicion = contador;
                    return posicion;
                }
            }
            return posicion;
        }
        public void RecorrerArbol(Nodo nodo)
        {
            if (nodo == null) return;

            Console.WriteLine(nodo.Nombre);
            RecorrerArbol(nodo.Izquierdo);
            RecorrerArbol(nodo.Derecho);
        }
        public bool VerificarSiEsNumero(string nombre)
        {
            if (nombre != "+") return true;
            
            else
                return false;
        }
        public int ConvertirNumero(string numero)
        {
            return int.Parse(numero);
        }

        public int SumarArbol(Nodo nodo)
        {
            if(!VerificarSiEsNumero(nodo.Nombre) || nodo == null)
            {
                int izquierdo = SumarArbol(nodo.Derecho);
                int derecho = SumarArbol(nodo.Izquierdo);
                return (izquierdo + derecho);
            } else
            {
                return (ConvertirNumero(nodo.Nombre));
            }
        }
    }
    
}
