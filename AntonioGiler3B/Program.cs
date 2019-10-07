using System;

namespace AntonioGiler3B
{
    class Program
    {
            static void Main(string[] args)
            {
                Boolean seguir = true;
                int seleccion;

                do
                {
                    Console.WriteLine("TAREA");
                    Console.WriteLine("Seleccione el ejercicio escribiendo su numero");
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine("Ejercicio " + i);
                    }
                    Console.WriteLine("Salir 11");
                    seleccion = int.Parse(Console.ReadLine());
                    switch (seleccion)
                    {
                        case 1:
                            new Program().ej1();
                            break;
                        case 2:
                            new Program().ej2();
                            break;
                        case 3:
                            new Program().ej3();
                            break;
                        case 4:
                            new Program().ej4();
                            break;
                        case 5:
                            new Program().ej5();
                            break;
                        case 6:
                            new Program().ej6();
                            break;
                        case 7:
                            new Program().ej7();
                            break;
                        case 8:
                            new Program().ej8();
                            break;
                        case 9:
                            new Program().ej9();
                            break;
                        case 10:
                            new Program().ej10();
                            break;

                        case 11:
                            seguir = false;
                            break;
                    }

                } while (seguir);
            }
            public void sumatorio()
            {
                int valor, total;
                Console.WriteLine("Ingrese un numero para realizar el sumatorio");
                valor = int.Parse(Console.ReadLine());
                total = (valor * (valor + 1)) / 2;
                Console.WriteLine("El resultado del sumatorio es: " + total);

            }
            public void factorial()
            {
                int valor, total = 1;
                Console.WriteLine("Ingrese un numero para realizar el factorial");
                valor = int.Parse(Console.ReadLine());
                for (int i = 1; i <= valor; i++)
                {
                    total = total * i;
                }
                Console.WriteLine("El resultado del factorial es: " + total);


            }
            public void ej1()
            {
                int numero;
                string respuesta;
                Console.WriteLine("Programa para determinar el numero mayor");
                Console.WriteLine("Ingrese un numero");
                respuesta = Console.ReadLine();
                numero = int.Parse(respuesta);
                while (respuesta != "salir")
                {

                    if (int.Parse(respuesta) > numero)
                    {
                        numero = int.Parse(respuesta);
                    }


                    Console.WriteLine("Escriba salir si desea cerrar el programa, caso contrario escriba otro numero");
                    respuesta = Console.ReadLine();
                }
                Console.WriteLine("El numero mayor es: " + numero);
                Console.ReadKey();
            }

            public void ej2()
            {
                string[] numeros;
                int longitud;
                Console.WriteLine("Ingrese el tamaño para el cuadrado");
                longitud = Int32.Parse(Console.ReadLine());
                numeros = new string[longitud];
                for (int i = 0; i < longitud; i++)
                {
                    numeros[i] = "*";
                }
                for (int i = 0; i < longitud; i++)
                {
                    if (i == 0 || i == (longitud - 1))
                    {
                        for (int c = 0; c < longitud; c++)
                        {
                            Console.Write(numeros[c]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write("*");
                        for (int o = 0; o < ((longitud * 2) - 3); o++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
                    }

                };
                Console.ReadKey();
            }
            public void ej3()
            {
                int cantidad;
                double precio, total = 0;
                do
                {
                    Console.WriteLine("Introduzca la cantidad vendida; para terminar la factura escriba: 0");
                    cantidad = int.Parse(Console.ReadLine());
                    if (cantidad != 0)
                    {
                        Console.WriteLine("Introduzca el precio");
                        precio = double.Parse(Console.ReadLine());
                        total = total + (cantidad * precio);

                    }
                } while (cantidad != 0);
                Console.WriteLine("El total de la factura es: " + total);
                Console.ReadKey();

            }
            public void ej4()
            {
                int horas, extra, total;
                string confirmacion;
                do
                {
                    Console.WriteLine("Ingrese la cantidad de horas trabajadas");
                    horas = int.Parse(Console.ReadLine());
                    if (horas > 35)
                    {
                        extra = horas - 35;
                        total = (35 * 15) + (extra * 22);
                    }
                    else
                    {
                        total = horas * 15;
                    }
                    Console.WriteLine("El salario a pagar es de: $" + total);
                    Console.WriteLine("Desea calcular otro salario?\nEscriba (si) si lo desea");
                    confirmacion = Console.ReadLine();
                } while (confirmacion == "si");

            }
            public void ej5()
            {
                int x, total = -1, mitad, cantidad = 1;
                Console.WriteLine("Ingrese el tamaño para el triangulo");
                x = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    total = total + 2;
                }

                mitad = (total - 1) / 2;
                for (int i = 0; i < x; i++)
                {
                    for (int c = 0; c < mitad; c++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 0; c < cantidad; c++)
                    {
                        Console.Write("*");
                    }

                    for (int c = 0; c < mitad; c++)
                    {
                        Console.Write(" ");
                    }
                    mitad = mitad - 1;
                    cantidad = cantidad + 2;
                    Console.Write("\n");
                }
                Console.ReadKey();

            }
            public void ej6()
            {
                int x, total = -1, mitad, cantidad = 1, abajo;
                Console.WriteLine("Ingrese el tamaño para el rombo");
                x = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    total = total + 2;
                }
                abajo = total - 2;
                mitad = (total - 1) / 2;
                for (int i = 0; i < x; i++)
                {
                    for (int c = 0; c < mitad; c++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 0; c < cantidad; c++)
                    {
                        Console.Write("*");
                    }

                    for (int c = 0; c < mitad; c++)
                    {
                        Console.Write(" ");
                    }
                    mitad = mitad - 1;
                    cantidad = cantidad + 2;
                    Console.Write("\n");
                }
                cantidad = abajo;
                mitad = 1;
                for (int i = x; i > 0; i--)
                {
                    for (int c = 0; c < mitad; c++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 0; c < cantidad; c++)
                    {
                        Console.Write("*");
                    }

                    for (int c = 0; c < mitad; c++)
                    {
                        Console.Write(" ");
                    }
                    mitad = mitad + 1;
                    cantidad = cantidad - 2;
                    Console.Write("\n");
                }
                Console.ReadKey();

            }
            public void ej7()
            {
                int c = 100;
                for (int i = 1; i <= 100; i++)
                {
                    Console.Write(i + "   " + c + "\n");
                    c--;
                }
                Console.ReadKey();

            }
            public void ej8()
            {
                int num, segundo, tercero;

                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());
                segundo = num;
                while (segundo > 0)
                {
                    segundo = segundo - 2;
                }
                tercero = num;
                while (tercero > 0)
                {
                    tercero = tercero - 3;
                }
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(i + "  ");
                    if (segundo <= num)
                    {
                        Console.Write(segundo + "  ");
                        segundo = segundo + 2;
                    }
                    if (tercero <= num)
                    {
                        Console.Write(tercero + "\n");
                        tercero = tercero + 3;
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
                Console.ReadKey();
            }
            public void ej9()
            {
                for (int i = 1; i < 16; i++)
                {

                    for (int c = 0; c < 13; c++)
                    {
                        Console.WriteLine(i + "*" + c + "= " + (i * c));

                    }

                }
                Console.ReadKey();

            }
            public void ej10()
            {
                int opcion;
                Boolean condicion = true;

                do
                {

                    Console.WriteLine("Elija una opcion");
                    Console.WriteLine("1)Salir\n2)Sumatorio\n3)Factorial\n");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            condicion = false;
                            break;
                        case 2:
                            new Program().sumatorio();
                            break;
                        case 3:
                            new Program().factorial();
                            break;


                    }

                } while (condicion);

            }

    }
}



