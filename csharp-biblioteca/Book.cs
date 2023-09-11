using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        public uint PagesNumber { get; }

        public Book(string title, uint releaseyear, string category, string author, uint pagesnumber) : base(title, releaseyear, category, author)
        {
            this.PagesNumber = pagesnumber;
        }

        //METODI
        public override void InfoPrint()
        {
            base.InfoPrint();
            Console.WriteLine($"                                - Numero di pagine: {this.PagesNumber}");
        }
    }
}
