using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Interfaces.DAL.Commands
{
    public interface IUserCommandRepository
    {
        Task Add(User user);
        Task Update(User user);

    }
}
