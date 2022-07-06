using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nt, p1, p2, media;

            Console.WriteLine("Escreva seu nome");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Escreva a nota do seu trabalho");
            nt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota da sua primeira prova");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota da sua segunda prova");
            p2 = Convert.ToDouble(Console.ReadLine());
            media = ((nt + p1 + p2) / 3);

            Console.Clear();

            if (media >= 8.5)
            {
                Console.WriteLine("Sua nota foi " + media + " Seu conceito foi A!");
            }
            if (media >= 7 && media < 8.5)
            {
                Console.WriteLine("Sua nota foi " + media + " Seu conceito foi B!");
            }
            if (media >= 6 && media < 7)
            {
                Console.WriteLine("Sua nota foi " + media + " Seu conceito foi C!");
            }
            if (media > 0 && media < 6)
            {
                Console.WriteLine("Sua nota foi " + media + " Seu conceito foi D!");
            }
            if (media == 0)
            {
                Console.WriteLine("Sua nota final foi igual a 0! Seu conceito é E.");
            }
            Console.ReadKey();
        }
    }
}
