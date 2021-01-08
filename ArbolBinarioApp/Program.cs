using System;
using ArbolBinario;
namespace ArbolBinarioApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcionElejir = 0;
            do
            {
                Console.WriteLine("Programa de Arboles en C#");

                Console.WriteLine("Seleccione una opción del menú: ");
                
                Console.WriteLine("1) Metodo arbol Binario");
                Console.WriteLine("2) Metodo arbol Multiples Hijos");
                Console.WriteLine("3) Metodo para contar Niveles");
                Console.WriteLine("4) Metodo para contar Hojas");
                Console.WriteLine("5) Metodo para contar Nodos");
                Console.WriteLine("6)  Metodo de navegación Horizontal");
                Console.WriteLine("7) Calcular expresión matemática con + - * / ");
                Console.WriteLine("8) Salir del programa");
               
                opcionElejir = int.Parse(Console.ReadLine());
                

                switch (opcionElejir)
                {   
                   case 1:
                        Console.WriteLine("Elegiste contruir Arbol binario");
                        Program.construirArbolB();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Elegiste contruir Arbol multiples Hijos");
                        Program.construirArbol();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Elegiste contar niveles Arbol Mutiples Hijos");
                        Program.contarNiveles();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Elegiste contar hoijas Arbol Mutiples Hijos");
                        Program.MetodocontarHojas();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Elegiste contar nodos Arbol Mutiples Hijos");
                        Program.contarNodos();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Elegiste navegación horizontal POSTORDEN");
                        Program.MetodoNavegarHorizontal();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Elegiste operar mediante expresión matematica");
                        Program.MetodoOperarExpresion();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Muchas gracias por usar este programita");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        opcionElejir = 8;
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcionElejir != 8);


        }
       
        public static void construirArbol()
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

            NodoClas.RecorrerArbol(nodo1);
        }
        public static void contarNiveles()
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

            NodoClas.ImprmirArbol(nodo1);

            Console.WriteLine("El arbol tiene {0} niveles ", NodoClas.MetodoContarNiveles(nodo1));
        }
        public static void MetodocontarHojas()
        {
            NodoClas nodo1 = new NodoClas("Mauricio");
            NodoClas nodo2 = new NodoClas("Josselyn");
            NodoClas nodo3 = new NodoClas("Viviana");
            NodoClas nodo4 = new NodoClas("Wendy");
            NodoClas nodo5 = new NodoClas("Paola");
            NodoClas nodo6 = new NodoClas("Jhoanna");
            NodoClas nodo7 = new NodoClas("Evelyn");

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

            NodoClas.ImprmirArbol(nodo1);
            Console.WriteLine("El arbol tiene {0} hojas", NodoClas.MetodoContarHojas(nodo1));

        }
        public static void contarNodos()
        {
            NodoClas nodo1 = new NodoClas("Mauricio");
            NodoClas nodo2 = new NodoClas("Josselyn");
            NodoClas nodo3 = new NodoClas("Viviana");
            NodoClas nodo4 = new NodoClas("Wendy");
            NodoClas nodo5 = new NodoClas("Paola");
            NodoClas nodo6 = new NodoClas("Jhoanna");
            NodoClas nodo7 = new NodoClas("Evelyn");

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

            NodoClas.ImprmirArbol(nodo1);
            Console.WriteLine("El arbol tiene {0} nodos", NodoClas.MetodoContarNodos(nodo1));
        }
        public static void MetodoNavegarHorizontal()
        {
            var raiz = new Nodo("*",
            new Nodo("1",
                new Nodo("1.1",
                    new Nodo("1.1.2"),
                    new Nodo("1.1.3")),
                new Nodo("1.2",
                    new Nodo("1.2.1"),
                    new Nodo("1.2.2"))),
            new Nodo("2",
                new Nodo("2.1",
                    new Nodo("2.1.1"),
                    new Nodo("2.1.2")),
                new Nodo("2.2",
                    new Nodo("2.2.1"),
                    new Nodo("2.2.2"))));


            Administrador ad = new Administrador();
            ad.MetodoNavegarHorizontal(raiz);
        }
        public static void MetodoOperarExpresion()
        {

            Administrador ad = new Administrador();

            //Crear arbol manual 
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            Console.WriteLine("La suma del arbol es: " + ad.SumarArbol(arbolOperaciones));
            

            //Crear arbol apartir de un string
            Nodo nodoOperacion = new Nodo();
            ad.CrearArbol(nodoOperacion, "5+6+2+1");
            ad.RecorrerArbol(nodoOperacion);

            //fin del programa..xD
        }
    }
}
