using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Repositories
{
    internal interface IBlogRepository
    {
        Task Add(Blog blog);
        Task Update(Blog blog);
        Task<Blog> Find(int id);
        Task Delete(Blog blog);
    }
}
