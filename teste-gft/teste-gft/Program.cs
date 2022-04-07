using System;

namespace teste_gft
{
    class Program
    {
        class Pessoa
        {
            private DateTime dataNasc;
            public DateTime DataNasc
            {
                get { return dataNasc; }
                set { dataNasc = value; }

            }

            public int CalculaIdade(DateTime dataNascimento)
            {
                int idade = DateTime.Now.Year - dataNascimento.Year;
                if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                {
                    idade = idade - 1;
                }
                return idade;
            }

        }

        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            int difere, p1idadeDias, p2idadeDias;
            Console.WriteLine("Data de nascimento pessoa 1: ");
            p1.DataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data de nascimento pessoa 2: ");
            p2.DataNasc = DateTime.Parse(Console.ReadLine());

            p1idadeDias = p1.CalculaIdade(p1.DataNasc) * 365;
            p2idadeDias = p2.CalculaIdade(p2.DataNasc) * 365;


            if (p1idadeDias == p2idadeDias)
            {
                Console.WriteLine("Viveram a mesma quantidade de dias.");
            }
            else 

            if (p1idadeDias > p2idadeDias)
            {
                difere = p1idadeDias - p2idadeDias;
                Console.WriteLine("A primeira pessoa viveu {0} dias a mais que a segunda.", difere);
            }

            else 
            {
                difere = p2idadeDias - p1idadeDias;
                Console.WriteLine("A segunda pessoa viveu {0} dias a mais que a primeira.", difere);
            } 
            Console.ReadKey();
        }
    }
}
