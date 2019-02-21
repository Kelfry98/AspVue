using Crud.Models;
using Crud.PersisteceData;
using Crud.Services.IterfaceServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Services
{
    public class PersonService : IPersonService
    {
        private readonly BusinesLogicDbContext _dbContext;

        public PersonService(BusinesLogicDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Add(Person model)
        {
            try
            {
                _dbContext.Add(model);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _dbContext.Entry(new Person { Id = id }).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public IEnumerable<Person> GetAll()
        {
            var all = new List<Person>();
            try
            {
                all = _dbContext.Persons.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return all;
        }

        public Person GetById(int id)
        {
            var person = new Person();
            try
            {
                person = _dbContext.Persons.Single(x => x.Id == id);
                    }
            catch (Exception)
            {

                throw;
            }
            return person;
        }

        public bool Update(Person model)
        {
            try
            {
                var originalModel = _dbContext.Persons.Single(x => x.Id == model.Id);
                originalModel.Name = model.Name;
                originalModel.LastName = model.LastName;
                _dbContext.Update(originalModel);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
