using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Sharding.Test.Students
{
    [Table(nameof(Student))]
    public class Student : FullAuditedEntity<long>
    {
        public string Name { get; set; }

        public int Sex { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public bool IsLess { get; set; }
    }
}