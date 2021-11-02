using DockerWithMVC.Entities;
using DockerWithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWithMVC.Repository
{
    public class SqlRepository : IPersonRepository
    {
        private readonly ApplcaitionDBContext _applcaitionDBContext;

        public SqlRepository(ApplcaitionDBContext applcaitionDBContext) =>
            _applcaitionDBContext = applcaitionDBContext;

        public async Task<Person> CreateAsync(Person model)
        {
            _applcaitionDBContext.Add(model);
            await _applcaitionDBContext.SaveChangesAsync();
            return model;
        }

        public async Task Delete(Person id)
        {
            _applcaitionDBContext.Remove(id);
            await _applcaitionDBContext.SaveChangesAsync();
        }

        public Task<Person> GetPersonAsync(int id) =>
            Task.FromResult(_applcaitionDBContext.People.FirstOrDefault(a => a.Id == id));

        public IQueryable<Person> GetPersonsAsync() =>
            _applcaitionDBContext.People.AsQueryable();

        public Task<Person> UpdateAsync(int id, Person model)
        {
            throw new NotImplementedException();
        }
    }
}
