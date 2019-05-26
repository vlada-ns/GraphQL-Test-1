using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp5.Interfaces;
using WebApp5.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace WebApp5.Repository
{
    public class PersonRepository : IPersonRepository
    {
        //private Models.DbContext.AppContext db = new Models.DbContext.AppContext();
        private Models.DbContext.AppContext _db;
        public PersonRepository(Models.DbContext.AppContext db)
        {
            _db = db;
        }

        public Task<IList<Person>> GetAll()
        {
            return Task.FromResult<IList<Person>>(new List<Person>(_db.Persons));
        }
    }
}
