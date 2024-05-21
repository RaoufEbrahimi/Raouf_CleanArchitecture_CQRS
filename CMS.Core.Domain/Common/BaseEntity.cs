using CMS.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Common
{
    public class BaseEntity: IEntity
    {
        public int Id { get; set; }
    }
}
