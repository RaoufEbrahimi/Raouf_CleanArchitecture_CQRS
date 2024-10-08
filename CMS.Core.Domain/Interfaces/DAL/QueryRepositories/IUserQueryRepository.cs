﻿using CMS.Core.Domain.Common;
using CMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Interfaces.DAL.Queries
{
    public interface IUserQueryRepository
    {
        Task<User> Find(int id, CancellationToken cancellationToken);
        Task<bool> AnyAsync(Expression<Func<User, bool>> expression, CancellationToken cancellationToken);
        Task<IEnumerable<TResult>> GetListAsNoTrackingAsync<TResult>(Expression<Func<User, bool>> expression, Expression<Func<User, TResult>> selector, CancellationToken cancellationToken);
        Task<TResult> FirstOrDefaultAsyncAsNoTracking<TResult>(Expression<Func<User, bool>> expression, Expression<Func<User, TResult>> selector, CancellationToken cancellationToken);
    }
}
