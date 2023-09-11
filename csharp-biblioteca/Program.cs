namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User utente1 = new("Ferrari", "Marco", "paroleacaso@live.it", "password", "33344455566");
            User utente2 = new("Rapicetti", "Marielli", "blablabla@gmail.com", "password", " 33144455556");

            Book book1 = new("Clean code", 2008, "programmazione", "Robert C. Martin", 431);
            Book book2 = new("Lo spacciatore di parole", 2019, "Poesia", "Gaetano Frascolla", 124);

            Dvd dvd1 = new("Frankenstein Junior", 1974, "Comico, Fantascienza", "Mel Brooks", 105);
            Dvd dvd2 = new("The imitation game", 2014, "Biografico, Drammatico, Thriller", "Morten Tyldum", 114);

            List<Document> documents = new List<Document>();
            documents.Add(book1);
            documents.Add(book2);
            documents.Add(dvd1);
            documents.Add(dvd2);

            foreach(Document doc in documents)
            {
                doc.InfoPrint();
            }
            
            
        }
    }
}