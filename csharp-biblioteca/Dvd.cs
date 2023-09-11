using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public uint Duration { get; }

        public Dvd(string title, uint releaseyear, string category, string author, uint duration) : base(title, releaseyear, category, author)
        {
            this.Duration = duration;
        }

        //METODI
        public override void InfoPrint()
        {
            base.InfoPrint();
            Console.WriteLine($"                                - Durata: {this.Duration} min");
        }
    }
}
