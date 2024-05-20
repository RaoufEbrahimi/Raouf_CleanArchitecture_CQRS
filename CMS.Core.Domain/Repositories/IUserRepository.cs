﻿using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Repositories
{
    public interface IUserRepository
    {
         Task Add(User user);
         Task Update(User user);
         Task Find(int id);
    }
}
