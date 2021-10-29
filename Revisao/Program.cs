using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.Writeline("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = console.ReadLine();

            while (opcaoUsuario.ToUpper() !+ "X")
            {
                 switch(opcaoUsuario)
                 {
                    case "1":
                            //TODO: adicionar aluno
                        break;
                            //TODO: listar alunos
                    case "2":
                            //TODO: calcular media geral
                        break;

                    case "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                 }
                 
                 Console.WriteLine("Informe a opção desejada:");
                 Console.Writeline("1 - Inserir novo aluno");
                 Console.WriteLine("2 - Listar alunos");
                 Console.WriteLine("3 - Calcular média geral");
                 Console.WriteLine("X - Sair");
                 Console.WriteLine();
                 
                 opcaoUsuario = console.ReadLine();
            }
        }
    }
}
