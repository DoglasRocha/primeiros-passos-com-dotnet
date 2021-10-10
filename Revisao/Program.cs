using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            Write("Insira o número de alunos a serem cadastrados. ");
            int studentsNumber = int.Parse(Console.ReadLine());

            Student[] students = new Student[studentsNumber];
            int studentIndex = 0;

            GetUserOption(out string userOption);

            while (userOption.ToUpper() != "X" || studentIndex == studentsNumber - 1)
            {
                switch (userOption)
                {
                    case "1":
                        AddStudent(students, studentIndex);
                        studentIndex++;
                        break;
                    case "2":
                        ListStudents(students);
                        break;
                    case "3":
                        CalculateMean(students);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Digite um número válido");
                }
                
                GetUserOption(out userOption);
            }
        }

        private static void CalculateMean(Student[] students)
        {
            decimal totalGrade = 0;
            int studentsNumber = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (!string.IsNullOrEmpty(students[i].Name))
                {
                    totalGrade += students[i].Grade;
                    studentsNumber++;
                }
            }

            decimal classMean = totalGrade / studentsNumber;
            EConcept classConcept;

            if (classMean < 2) 
            {
                classConcept = EConcept.E;
            }
            else if (classMean < 4)
            {
                classConcept = EConcept.D;
            }
            else if (classMean < 6)
            {
                classConcept = EConcept.C;
            }
            else if (classMean < 8)
            {
                classConcept = EConcept.B;
            }
            else
            {
                classConcept = EConcept.A;
            }

            WriteLine($"MÉDIA GERAL: {classMean} - CONCEITO: {classConcept}");
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
