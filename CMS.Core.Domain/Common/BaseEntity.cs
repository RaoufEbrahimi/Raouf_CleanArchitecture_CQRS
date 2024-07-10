using System.ComponentModel.DataAnnotations;

namespace CMS.Core.Domain.Common
{
    public class BaseEntity: IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
