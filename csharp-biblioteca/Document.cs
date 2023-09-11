using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        //PROPRIETA' E STATO
        public string DocumentId { get; private set; }
        public string Title { get; }
        public uint ReleaseYear { get; }
        public string Category { get; }
        private uint ShelfNumber { get; set; }
        public string Author { get; }

        //COSTRUTTORE
        public Document(string title, uint releaseYear, string category, string author)
        {
            this.DocumentId = "DOC" + Random.Shared.Next(1000, 9999);
            this.Title = title;
            this.ReleaseYear = releaseYear;
            this.Category = category;
            this.ShelfNumber = (uint)Random.Shared.Next(1, 100);
            this.Author = author;
        }


        //GETTERS
        public string GetTitle()
        {
            return this.Title;
        }
        public uint GetShelfNumber()
        {
            return this.ShelfNumber;
        }

        //SETTERS
        public string SetDocumentId()
        {
            return this.DocumentId;
        }
        public uint SetGetShelfNumber()
        {
            return this.ShelfNumber;
        }

        //METODI PUBBLICI
        public virtual void InfoPrint()
        {
            Console.WriteLine($"Documento {this.DocumentId}:\r\n- Titolo: {this.Title}\r\n- Anno: {this.ReleaseYear}\r\n- Categoria: {this.Category}\r\n- Scaffale: {this.ShelfNumber}\r\n- Autore: {this.Author}");
        }

    }
}
