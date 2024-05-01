using System.Reflection.Metadata;

namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackBook stack = new();

            int input;
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Pilha de livros");

                input = Menu();
                switch (input)
                {
                    case 1:
                        stack.Push(RegisterBook());
                        Console.WriteLine("\n-> Livro colocado na pilha!");
                        break;
                    case 2:
                        stack.Pop();
                        Console.WriteLine("\n-> Livro removido na pilha!");
                        break;
                    case 3:
                        Console.WriteLine("\n-> Lista da livros: ");
                        stack.Print();
                        break;
                    case 4:
                        int countAll = stack.CountBooks();
                        Console.WriteLine($"\nA pilha tem {countAll} livros.\n");
                        break;
                    case 5:
                        int countByTite = stack.CountBooksByTitle(RequestBookTitle());
                        Console.WriteLine($"\nFora encontrados {countByTite} livros.\n");
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.\n");
                        break;
                }

                Console.Write("\n\n    Aperte qualquer tecla para voltar ao menu");
                Console.ReadKey();
            }
            while (!exit);
        }

        static int Menu()
        {
            int input = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu\n");
                Console.WriteLine("(1) - Inserir Livro");
                Console.WriteLine("(2) - Remover Livro");
                Console.WriteLine("(3) - Imprimir Livros");
                Console.WriteLine("(4) - Encontrar Livros");
                Console.WriteLine("(5) - Quantidade Total");
                Console.WriteLine("(6) - Sair");
                Console.Write("\nInsira sua opção: ");
                input = int.Parse(Console.ReadLine());
                
                if (input < 1 || input > 6)
                {
                    Console.WriteLine("\nOpção inválida, pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            }
            while (input < 1 || input > 6);

            return input;
        }

        static Book RegisterBook()
        {
            Console.Write("\nQual titulo do livro a ser inserido: ");
            string title = Console.ReadLine();
            return new(title);
        }

        static string RequestBookTitle()
        {
            Console.Write("\nQual titulo do livro que deseja procurar? : ");
            return Console.ReadLine();
        }

    }
}
