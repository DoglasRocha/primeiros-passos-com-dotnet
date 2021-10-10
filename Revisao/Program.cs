using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            int studentIndex = 0;

            GetUserOption(out string userOption);

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        AddStudent(students, studentIndex);
                        break;
                    case "2":
                        ListStudents(students);
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

        private static void ListStudents(Student[] students)
        {
            foreach(Student student in students)
            {
                if (!string.IsNullOrEmpty(student.Name)) 
                    WriteLine($"ALUNO: {student.Name} - NOTA: {student.Grade}");
            }
        }

        private static void AddStudent(Student[] students, int studentIndex)
        {
            Student student = new Student();
                        
            Write("Informe o nome do aluno: ");
            student.Name = Console.ReadLine();
        
            Write("Informe a nota do aluno: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal grade))
            {
                student.Grade = grade;
            }
            else
            {
                throw new ArgumentException("Valor da nota deve ser decimal");
            }

            students[studentIndex] = student;
            studentIndex++;
        }

        private static void GetUserOption(out string userOption)
        {
            WriteLine();
            WriteLine("Informe a opção desejada:");
            WriteLine("1 - Inserir novo aluno");
            WriteLine("2 - Listar alunos");
            WriteLine("3 - Calcular média geral");
            WriteLine("X - Sair");
            WriteLine();

            userOption = Console.ReadLine();
            WriteLine();
        }

        private static void WriteLine(string text = "") 
        {
            Console.WriteLine(text);
        }

        private static void Write(string text = "")
        {
            Console.Write(text);
        }
    }
}
