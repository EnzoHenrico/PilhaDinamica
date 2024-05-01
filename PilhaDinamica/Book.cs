using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Book
    {
        string title;
        Book before;

        public Book(string titulo) {
            this.title = titulo;
            this.before = null;
        }

        public void SetBefore(Book anterior)
        {
            this.before = anterior;
        }
        public Book GetBefore()
        {
            return this.before;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
