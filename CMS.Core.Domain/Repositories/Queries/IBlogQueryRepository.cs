using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Repositories.Queries
{
    public interface IBlogQueryRepository
    {
       
        Task<Blog> Find(int id);
    

    }
}
