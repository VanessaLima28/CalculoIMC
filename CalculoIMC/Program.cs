using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            
            Console.WriteLine("Calcule o seu IMC!");
            Console.WriteLine("Digite seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (Math.Pow(altura, 2));

            if (imc < 20)
            {
                Console.WriteLine("Você está abaixo do peso!");

            } 
            
            if (imc >= 20 || imc < 25) { 

                Console.WriteLine("Você está com o peso ideal!");
            }

            if (imc >= 25)
            {
                Console.WriteLine("Você está acima do peso!");
            }
        } 
        
    }
}
