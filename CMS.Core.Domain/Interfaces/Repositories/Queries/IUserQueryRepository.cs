using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Interfaces.Repositories.Queries
{
    public interface IUserQueryRepository
    {
        Task<User> Find(int id);
    }
}
