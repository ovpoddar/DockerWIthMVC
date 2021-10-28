using DockerWithMVC.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWithMVC.Repository
{
    public class InMemoryCollectionRepository : IPersonRepository
    {

        private List<Person> _people => new List<Person>()
        {
            new Person
            {
                Id = 0,
                FirstName = "john",
                LastName = "smith",
                MobileNumber = "8764634905",
                Address = "surat, pune, india",
                EmailId = "johnsmith@gmail.com",
                Pincode = 700200
            },
            new Person
            {
                Id = 1,
                FirstName = "merry",
                LastName = "smith",
                MobileNumber = "8976603208",
                Address = "surat, pune, india",
                EmailId = "merrysmith@gmail.com",
                Pincode = 700200
            },
            new Person
            {
                Id = 2,
                FirstName = "joe",
                LastName = "smith",
                MobileNumber = "7526831920",
                Address = "surat, pune, india",
                EmailId = "joesmith@gmail.com",
                Pincode = 700200
            },
            new Person
            {
                Id = 3,
                FirstName = "martha",
                LastName = "smith",
                MobileNumber = "8362950415",
                Address = "surat, pune, india",
                EmailId = "marthasmith@gmail.com",
                Pincode = 700200
            },
            new Person
            {
                Id = 4,
                FirstName = "jordan",
                LastName = "smith",
                MobileNumber = "8764634905",
                Address = "surat, pune, india",
                EmailId = "jonerdansmith@gmail.com",
                Pincode = 700200
            },
        };

        public Task<Person> CreateAsync(Person model)
        {
            _people.Add(model);
            return Task.FromResult(_people.Find(m => m.FirstName == model.FirstName && m.LastName == model.LastName));
        }

        public Task Delete(Person id)
        {
            _people.Remove(id);
            return Task.CompletedTask;
        }

        public Task<Person> GetPersonAsync(int id)
        {
            return Task.FromResult(_people.Find(a => a.Id == id));
        }

        public IQueryable<Person> GetPersonsAsync()
        {
            return _people.AsQueryable();
        }

        public Task<Person> UpdateAsync(int id, Person model)
        {
            var oldItem = _people.Find(a => a.Id == id);

            _people.Remove(oldItem);
            _people.Add(model);

            return Task.FromResult(model);
        }
    }
}
