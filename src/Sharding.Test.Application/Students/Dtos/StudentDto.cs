using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Sharding.Test.Students.Dtos
{
    [AutoMap(typeof(Student))]
    public class StudentDto : FullAuditedEntityDto<long>
    {
        public string Name { get; set; }

        public int Sex { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public bool IsLess { get; set; }
    }
}