using Logica;
using System;
using System.Collections;
using System.IO;

namespace PrimeraClase20211C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un nro:");
            //string num1 = Console.ReadLine();//1

            //Console.WriteLine("Ingrese otro nro:");
            //string num2 = Console.ReadLine();//2
            
            //int resultado = Calculadora.Sumar(num1, num2);
            //Console.WriteLine("La suma de ambos nros es: " + resultado);//12

            ArrayList nombres = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona N°{i+1}: ");
                nombres.Add(Console.ReadLine());
            }

            nombres.Sort();

            Console.WriteLine("Los nombres de las personas ingresadas son: ");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}