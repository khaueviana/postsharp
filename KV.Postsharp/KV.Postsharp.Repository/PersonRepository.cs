using KV.Postsharp.Domain;
using KV.Postsharp.Profile;

namespace KV.Postsharp.Repository
{
    public class PersonRepository
    {
        [InsertProfilerLog]
        public void Insert(Person person)
        {
            //INSERT PERSON
        }

        [UpdateProfilerLog]
        public void Update(Person person)
        {
            //UPDATE PERSON
        }

        [DeleteProfilerLog]
        public void Delete(long id)
        {
            //DELETE PERSON
        }

        [SearchProfilerLog]
        public void Search(string name, string surname)
        {
            //SEARCH PERSON
        }
    }
}
