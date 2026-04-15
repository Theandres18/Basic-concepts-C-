namespace itm.csharp.basic

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Ingrese su nombre:");

            string nombre = Console.ReadLine();

            Console.WriteLine($"¡Hola, {nombre}! Por favor, elige un ejercicio del siguiente menú:");



            Menu.MostrarMenu();



            while (true)

            {

                string entrada = Console.ReadLine().ToLower();



                if (entrada == "q" || entrada == "exit")

                {

                    break; // Salir del bucle

                }



                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 30)

                {

                    switch (eleccion)

                    {



                        case 1:

                            var Challenge1 = new Challenge1();

                            Challenge1.Run();

                            break;

                        case 2:

                            var Challenge2 = new Challenge2();

                            Challenge2.Run();

                            break;

                        case 3:

                            var Challenge3 = new Challenge3();

                            Challenge3.Run();

                            break;

                        case 4:

                            var Challenge4 = new Challenge4();

                            Challenge4.Run();

                            break;

                        case 5:

                            var Challenge5 = new Challenge5();

                            Challenge5.Run();

                            break;

                        case 6:

                            var Challenge6 = new Challenge6();

                            Challenge6.Run();

                            break;

                        case 7:

                            var Challenge7 = new Challenge7();

                            Challenge7.Run();

                            break;

                        case 8:

                            var Challenge8 = new Challenge8();

                            Challenge8.Run();

                            break;

                        case 9:

                            var Challenge9 = new Challenge9();

                            Challenge9.Run();

                            break;

                        case 10:

                            var Challenge10 = new Challenge10();

                            Challenge10.Run();

                            break;

                        case 11:

                            var Challenge11 = new Challenge11();

                            Challenge11.Run();

                            break;

                        case 12:

                            var Challenge12 = new Challenge12();

                            Challenge12.Run();

                            break;

                        case 13:

                            var Challenge13 = new Challenge13();

                            Challenge13.Run();

                            break;

                        case 14:

                            var Challenge14 = new Challenge14();

                            Challenge14.Run();

                            break;

                        case 15:

                            var Challenge15 = new Challenge15();

                            Challenge15.Run();

                            break;


                        case 16:
                            EjerciciosReto.PositivePower();
                            break;
                        case 17:
                            EjerciciosReto.DoubleOrTriple();
                            break;
                        case 18:
                            EjerciciosReto.RootOrSquare();
                            break;
                        case 19:
                            EjerciciosReto.CirclePerimeter();
                            break;
                        case 20:
                            EjerciciosReto.MidweekDay();
                            break;
                        case 21:
                            EjerciciosReto.TaxCalculator();
                            break;
                        case 22:
                            EjerciciosReto.RemainderFinder();
                            break;
                        case 23:
                            EjerciciosReto.SumOfEvens();
                            break;
                        case 24:
                            EjerciciosReto.FractionDifference();
                            break;
                        case 25:
                            EjerciciosReto.StringLength();
                            break;
                        case 26:
                            EjerciciosReto.AverageOfFour();
                            break;
                        case 27:
                            EjerciciosReto.SmallestOfFive();
                            break;
                        case 28:
                            EjerciciosReto.VowelCounter();
                            break;
                        case 29:
                            EjerciciosReto.FactorialFinder();
                            break;
                        case 30:
                            EjerciciosReto.InRangeValidator();
                            break;


                            Console.WriteLine("Presiona una tecla para continuar...");

                            Console.ReadKey();

                            Console.Clear();

                            Menu.MostrarMenu();

                    }



                }

                else

                {

                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 30, o 'q' o 'exit' para salir.");

                }

            }



            Console.WriteLine("¡Hasta luego!");

        }

    }

}