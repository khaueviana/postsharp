using KV.Postsharp.Domain;
using KV.Postsharp.Repository;

namespace KV.Postsharp.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new PersonRepository();

            repository.Insert(new Person
            {
                PersonId = 1,
                Name = "Chico",
                Surname = "Buarque"
            });

            repository.Update(new Person
            {
                PersonId = 1,
                Name = "MC",
                Surname = "DaLeste"
            });

            repository.Search("MC", "DaLeste");

            repository.Delete(1);            
        }
    }
}
