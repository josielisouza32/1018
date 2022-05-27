using System;

namespace _1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //leia um valor

            int cem=0, cinquenta=0, vinte=0, dez=0, cinco=0, dois=0, um=0, N;
            
            int.TryParse(Console.ReadLine(), out N);


            

           
     
            Console.WriteLine(N);
            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{um} nota(s) de R$ 100,00");


        }
        }
    }

