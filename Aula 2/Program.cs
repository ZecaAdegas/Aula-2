using System;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1(args);
            Ex2(args);
            Ex3(args);
            Ex4(args);
            Ex5(args);
        }

        private static void Ex1(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string x = Console.ReadLine();
            string x_maiusc = x.ToUpper();
            string x_primeira = x.Substring(0, 1);
            int x_length = x.Length;
            Console.WriteLine(x_maiusc);
            Console.WriteLine(x_primeira);
            Console.WriteLine(x_length);

        }
        private static void Ex2(string[] args)
        {
            string x = "Lorem Ipsum dolor sit amet sit";
            Console.WriteLine(x);
            int x_index = x.IndexOf("amet");
            Console.WriteLine("Indice da palavra amet: {0}", x_index);
            Console.WriteLine("Escreva uma frase para adicionar antes do amet:");
            string i = Console.ReadLine();
            x = x.Insert(x_index, i);
            Console.WriteLine("Nova frase: {0}", x);
        }
        private static void Ex3(string[] args)
        {
            string x = "Salvador. Benedita,, Vicente; Teresa";
            string[] separador = { ".", ",", ";" };
            Int32 count = 4;
            String[] x_separado = x.Split(separador, count, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in x_separado)
            {
                Console.WriteLine(s);
            }
        }

        private static void Ex4(string[] args)
        {
            int[] x = new int[] { 1, 3, 5, 7, 9 };
            Array.Reverse(x);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
        }
        private static void Ex5(string[] args)
        {
            int[] x = new int[5];
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Introduza a idade do {0}º aluno: ", i+1);
                int idade = int.Parse(Console.ReadLine());
                x[i] = idade;
            }
            Array.Sort(x);
            Console.WriteLine("O Aluno mais novo tem {0} anos de idade", x[0]);
            Console.WriteLine("O Aluno mais velho tem {0} anos de idade", x[4]-20);
            Console.WriteLine("Número de alunos: {0}", x.Length);
        }
    }
}