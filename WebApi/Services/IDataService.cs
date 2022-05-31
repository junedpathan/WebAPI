using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IDataService<Tentity, in TPk> where Tentity : class 
    {
        IEnumerable<Tentity> Get();
        Tentity Get(TPk id);
        Tentity Create(Tentity entity);
        Tentity Update(TPk id, Tentity entity);
        Tentity Delete(TPk id);
    }
    

    
}
