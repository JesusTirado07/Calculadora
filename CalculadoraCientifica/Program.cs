using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Científica");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Exponenciación");
                Console.WriteLine("6. Raíz Cuadrada");
                Console.WriteLine("7. Seno");
                Console.WriteLine("8. Coseno");
                Console.WriteLine("9. Tangente");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opción:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer número:");
                        double sumando1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        double sumando2 = Convert.ToDouble(Console.ReadLine());
                        resultado = sumando1 + sumando2;
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el primer número:");
                        double minuendo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        double sustraendo = Convert.ToDouble(Console.ReadLine());
                        resultado = minuendo - sustraendo;
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el primer número:");
                        double factor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        double factor2 = Convert.ToDouble(Console.ReadLine());
                        resultado = factor1 * factor2;
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el dividendo:");
                        double dividendo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el divisor:");
                        double divisor = Convert.ToDouble(Console.ReadLine());
                        if (divisor != 0)
                        {
                            resultado = dividendo / divisor;
                        }
                        else
                        {
                            Console.WriteLine("¡Error! No se puede dividir por cero.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ingrese la base:");
                        double baseExponente = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el exponente:");
                        double exponente = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Pow(baseExponente, exponente);
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el número:");
                        double numeroRaiz = Convert.ToDouble(Console.ReadLine());
                        if (numeroRaiz >= 0)
                        {
                            resultado = Math.Sqrt(numeroRaiz);
                        }
                        else
                        {
                            Console.WriteLine("¡Error! No se puede calcular la raíz cuadrada de un número negativo.");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Ingrese el ángulo en radianes:");
                        double anguloSeno = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Sin(anguloSeno);
                        break;
                    case 8:
                        Console.WriteLine("Ingrese el ángulo en radianes:");
                        double anguloCoseno = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Cos(anguloCoseno);
                        break;
                    case 9:
                        Console.WriteLine("Ingrese el ángulo en radianes:");
                        double anguloTangente = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Tan(anguloTangente);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la calculadora...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
