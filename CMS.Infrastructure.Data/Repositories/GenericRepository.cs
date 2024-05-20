using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
       async Task Add(TEntity entity) { 
        
        }
        async Task UpDate(TEntity entity)
        {

        }
        async Task Delete(TEntity entity)
        {

        }
        async Task Finde(int id)
        {

        }
    }
}
