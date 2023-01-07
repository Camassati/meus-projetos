using System;
using System.Collections.Generic;

namespace ForList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nascimentos = new List<int>();
            List<string> nomes = new List<string>();
            List<int> meses = new List<int>();

            string repetir = "s";

            while (repetir.CompareTo("s")==0)
            {
                Console.WriteLine("Entre um nome");
                nomes.Add(Console.ReadLine());

                //Mes

                Console.WriteLine("Digite o mes de seu aniversário");
                string entrada = Console.ReadLine();
                int mes = int.Parse(entrada);
                meses.Add(mes);

                //Idade

                Console.WriteLine("Digite sua idade");
                entrada = Console.ReadLine();
                int idade = int.Parse(entrada);
                nascimentos.Add(idade);

                //Estrutura de repetição

                Console.WriteLine("Digite s, para repetir o programa");
                repetir = Console.ReadLine();
            }
            string mesMin1;
            Console.WriteLine("Digite mês minimo de comparação");
            mesMin1 = Console.ReadLine();
            int mesMin = int.Parse(mesMin1);

            string mesMax1;
            Console.WriteLine("Digite o mês máximo de comparãção");
            mesMax1 = Console.ReadLine();
            int mesMax = int.Parse(mesMax1);

            for (int idx = 0; idx < meses.Count; idx ++)
            {
                if (meses[idx] <= mesMax && meses[idx] >= mesMin)
                {
                    Console.WriteLine("Seu nome: " + nomes[idx] + ". \n Seu mes: " + meses[idx] + ".\n idade: " + nascimentos[idx]);
                }
            }
        }
    }
}
