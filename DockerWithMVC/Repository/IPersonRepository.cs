using DockerWithMVC.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWithMVC.Repository
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetPersonsAsync();
        Task<Person> GetPersonAsync(int id);
        Task<Person> UpdateAsync(int id, Person model);
        Task<Person> CreateAsync(Person model);
        Task Delete(Person id);
    }
}
