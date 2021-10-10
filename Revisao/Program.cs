using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserOption(out string userOption);

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        // TODO: add student
                        break;
                    case "2":
                        // TODO: list students
                        break;
                    case "3":
                        // TODO: calculate mean
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Digite um número válido");
                }
                GetUserOption(out userOption);
            }
        }

        private static void GetUserOption(out string userOption)
        {
            WriteLine("Informe a opção desejada:");
            WriteLine("1 - Inserir novo aluno");
            WriteLine("2 - Listar alunos");
            WriteLine("3 - Calcular média geral");
            WriteLine("X - Sair");
            WriteLine("");

            userOption = Console.ReadLine();
        }

        static void WriteLine(string text) 
        {
            Console.WriteLine(text);
        }
    }
}
