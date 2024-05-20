using CMS.Core.Domain.Common;

namespace CMS.Core.Domain.ValueObjects
{
    public class Addres : ValueObject
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}