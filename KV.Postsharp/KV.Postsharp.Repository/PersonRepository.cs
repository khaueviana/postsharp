using KV.Postsharp.Domain;
using KV.Postsharp.Profile;

namespace KV.Postsharp.Repository
{
    public class PersonRepository
    {
        [GenericProfiler(ActionLogEnum.Insert)]
        public void Insert(Person person)
        {
            //INSERT PERSON
        }

        [GenericProfiler(ActionLogEnum.Update)]
        public void Update(Person person)
        {
            //UPDATE PERSON
        }

        [GenericProfiler(ActionLogEnum.Delete)]
        public void Delete(long id)
        {
            //DELETE PERSON
        }

        [GenericProfiler(ActionLogEnum.Search)]
        public void Search(string name, string surname)
        {
            //SEARCH PERSON
        }
    }
}
