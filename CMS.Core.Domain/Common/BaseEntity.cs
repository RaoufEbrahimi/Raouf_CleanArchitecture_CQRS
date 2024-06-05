using CMS.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Common
{
    public class BaseEntity: IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
