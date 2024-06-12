using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Interfaces.Repositories.Commands
{
    public interface IBlogCommandRepository
    {
        Task Add(Blog blog);
        Task Update(Blog blog);
        Task Delete(Blog blog);

    }
}
