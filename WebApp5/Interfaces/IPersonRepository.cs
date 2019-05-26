using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp5.Models;

namespace WebApp5.Interfaces
{
    public interface IPersonRepository
    {
        Task<IList<Person>> GetAll();
    }
}
