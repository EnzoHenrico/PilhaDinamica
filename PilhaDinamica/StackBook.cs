using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class StackBook
    {
        Book top;
        
        public StackBook()
        {
            this.top = null;
        }

        public StackBook(Book top)
        {
            this.top = top;
        }

        public void Push(Book current)
        {
            current.SetBefore(this.top);
            this.top = current;

        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("\nPilha vazia, impossível remover");
            }
            else
            {
                this.top = this.top.GetBefore();
            }
        }

        bool IsEmpty()
        {
            return this.top == null;
        }

        public void Print()
        {
            Book aux = this.top;
            
            if (IsEmpty())
            {
                Console.WriteLine("\nA pilha está vazia, impossível imprimir.");
                return;
            }

            while (aux != null)
            {
                Console.WriteLine(aux.ToString());
                aux = aux.GetBefore();
            }
        }

        public int CountBooksByTitle(string title)
        {
            Book aux = this.top;
            int count = 0;

            if (IsEmpty())
            {
                Console.WriteLine("\nA pilha está vazia, não possui livros.");
                return 0;
            }
            while (aux != null)
            {
                if (aux.GetTitle() == title)
                {
                    count++;
                }
                aux = aux.GetBefore();
            }

            return count;
        }

        public int CountBooks()
        {
            Book aux = this.top;
            int count = 0;

            if (IsEmpty())
            {
                Console.WriteLine("\nA pilha está vazia, não possui livros.");
                return 0;
            }
            while (aux != null)
            {
               count++;
               aux = aux.GetBefore();
            }

            return count;
        }
    }
}
