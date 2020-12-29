using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("O numero digitado foi " + n);


            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine("Ola mundo.");
            }


            Console.WriteLine("Jogar um negocio no final.");

            
        }
    }
}
