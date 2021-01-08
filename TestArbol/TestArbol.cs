using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArbolBinario;
using System.Collections.Generic;

namespace TestArbol
{
    [TestClass]
    public class TestArbol
    {
        [TestMethod]
        public void TestSumaArbol()
        {
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                   new Nodo("6"),
                   new Nodo("+",
                     new Nodo("-2"),
                       new Nodo("-1"))));
            var ad = new Administrador();
            var resultadoEsperado = 8;

            var resultado = ad.SumarArbol(arbolOperaciones);
            Assert.AreEqual(resultado, resultadoEsperado);
        }
        [TestMethod]

        public void TestMetodoContarNodos()
        {
            NodoClas nodo = new NodoClas();
            int resultadoEsperado = 1;
            int resultado = NodoClas.MetodoContarNodos(nodo);
        }

        [TestMethod]

        public void TestMetodoContarNodosHijos()
        {
            NodoClas nodo = new NodoClas();

            nodo.Hijos = new List<NodoClas>();
            nodo.Hijos.Add(new NodoClas());

            int resultadoEsperado = 2;
            int resultado = NodoClas.MetodoContarNodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void TestMetodoContarHojas()
        {
            NodoClas nodo1 = new NodoClas("Mauricio");
            NodoClas nodo2 = new NodoClas("Josselyn");
            NodoClas nodo3 = new NodoClas("Viviana");
            NodoClas nodo4 = new NodoClas("Wendy");
            NodoClas nodo5 = new NodoClas("Paola");
            NodoClas nodo6 = new NodoClas("Jhoanna");
            NodoClas nodo7 = new NodoClas("Evelyn");

            //raiz..xD

            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            nodo2.Hijos.Add(nodo4);
            nodo2.Hijos.Add(nodo5);

            nodo3.Hijos.Add(nodo6);
            nodo3.Hijos.Add(nodo7);


            nodo4.Hijos.Add(new NodoClas("Maria"));
            nodo4.Hijos.Add(new NodoClas("Odin"));
            nodo5.Hijos.Add(new NodoClas("Thor"));
            nodo5.Hijos.Add(new NodoClas("Zeus"));

            nodo6.Hijos.Add(new NodoClas("Loki"));
            nodo6.Hijos.Add(new NodoClas("Hades"));
            nodo7.Hijos.Add(new NodoClas("Poseidon"));
            nodo7.Hijos.Add(new NodoClas("Athena"));

            int resultadoEsperado = 8;
            int resultado = NodoClas.MetodoContarHojas(nodo1);
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]

        public void TesMetodoContarNiveles()
        {
            NodoClas nodo1 = new NodoClas("Mauricio");
            NodoClas nodo2 = new NodoClas("Josselyn");
            NodoClas nodo3 = new NodoClas("Viviana");
            NodoClas nodo4 = new NodoClas("Wendy");
            NodoClas nodo5 = new NodoClas("Paola");
            NodoClas nodo6 = new NodoClas("Jhoanna");
            NodoClas nodo7 = new NodoClas("Evelyn");
            NodoClas nodo8 = new NodoClas("Argol de Perseo");
            NodoClas nodo9 = new NodoClas("Orfeo de Lira");

            //Raiz
            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            nodo2.Hijos.Add(nodo4);
            nodo2.Hijos.Add(nodo5);

            nodo3.Hijos.Add(nodo6);
            nodo3.Hijos.Add(nodo7);


            nodo4.Hijos.Add(new NodoClas("Maria"));
            nodo4.Hijos.Add(new NodoClas("Odin"));
            nodo5.Hijos.Add(new NodoClas("Thor"));
            nodo5.Hijos.Add(new NodoClas("Zeus"));

            nodo6.Hijos.Add(new NodoClas("Loki"));
            nodo6.Hijos.Add(new NodoClas("Hades"));
            nodo7.Hijos.Add(new NodoClas("Poseidon"));
            nodo7.Hijos.Add(new NodoClas("Athena"));

            nodo8.Hijos.Add(nodo9);

            int resultadoEsperado = 5;

            int resultadoObtenido = NodoClas.MetodoContarNiveles(nodo1);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);

        }
    }
}
