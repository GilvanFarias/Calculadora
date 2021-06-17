using System.Globalization;
using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double res = 0;
            string operador;

            Console.Write("Digite um valor inteiro: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite um operador: ");
            operador = Console.ReadLine();

            
            if(operador == "*" ||operador == "/" ||operador == "+" ||operador == "-"){

                //multiplicar
                if(operador == "*"){
                    Console.Write("Digite um valor inteiro: ");
                    double valor2 = double.Parse(Console.ReadLine());
                    res = valor1 * valor2;
                    Console.Write("Resultado de: "+valor1 + " * " +valor2+ " = " + res);
                //dividir
                }if(operador == "/"){

                    Console.Write("Digite um valor inteiro: ");
                    double valor2 = double.Parse(Console.ReadLine());
                    res = valor1 / valor2;
                    Console.Write("Resultado de: "+valor1 + " / " +valor2+ " = " + res);
                //somar
                }if(operador == "+"){

                    Console.Write("Digite um valor inteiro: ");
                    double valor2 = double.Parse(Console.ReadLine());
                    res = valor1 + valor2;
                    Console.Write("Resultado de: "+valor1 + " + " +valor2+ " = " + res);

                //diminuir
                }if(operador == "-"){

                    Console.Write("Digite um valor inteiro: ");
                    double valor2 = double.Parse(Console.ReadLine());
                    res = valor1 - valor2;
                    Console.Write("Resultado de: "+valor1 + " - " +valor2+ " = " + res);
                }

            }else{

                    Console.WriteLine("Digite um operador Válido");
            }

                
            
        }
    }
}
