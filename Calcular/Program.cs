using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            menu();
            double v1, v2;
            string oper;
            Console.WriteLine("Digite um número:");
            v1 = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            menu();
            oper = Console.ReadLine().ToUpper();

            while (oper != "X")
            {

                switch (oper)
                {
                    case "+":
                        Console.WriteLine("Digite outro número:");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        if (v1 != 0)
                        {
                            resultado += soma(v1, v2);
                            v1 = 0;

                        }
                        else
                        {
                            resultado = soma(resultado, v2);
                        }
                        break;

                    case "-":
                        Console.WriteLine("Digite outro número:");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        if (v1 != 0)
                        {
                            resultado = subtracao(v1, v2);
                            v1 = 0;

                        }
                        else
                        {
                            resultado = subtracao(resultado, v2);
                        }
                        break;

                    case "*":
                        Console.WriteLine("Digite outro número:");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        if (v1 != 0)
                        {
                            resultado = multiplicacao(v1, v2);
                            v1 = 0;

                        }
                        else
                        {
                            resultado = multiplicacao(resultado, v2);
                        }
                        break;

                    case "/":
                        Console.WriteLine("Digite outro número:");
                        v2 = Convert.ToDouble(Console.ReadLine());

                        if (v2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero");
                        }
                        else
                        if (v1 != 0)
                        {
                            resultado = divisao(v1, v2);
                            v1 = 0;
                        }
                        else
                        {
                            resultado = divisao(resultado, v2);
                        }
                        break;
                }
                Console.WriteLine(resultado);

                Console.WriteLine("Digite números e use esses operadores:");
                Console.WriteLine("+, -, *, / ou digite X para sair.");
                oper = Console.ReadLine().ToUpper();
                Console.Clear();
            }           
            
           
        }

        static void menu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Calculadora 2");
            Console.WriteLine("Digite números e use esses operadores:");
            Console.WriteLine("+, -, *, / ou digite X para sair.");

        }

         static double soma(double v1, double v2)
        {
            return v1 + v2;
        }
        static double subtracao(double v1, double v2)
        {
            return v1 - v2;
        }
        static double multiplicacao(double v1, double v2)
        {
            return v1 * v2;
        }
        static double divisao(double v1, double v2)
        {
            return v1 / v2;
        }
    }
}
