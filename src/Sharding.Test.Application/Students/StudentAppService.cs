using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using EFCore.Sharding;
using Sharding.Test.Students.Dtos;

namespace Sharding.Test.Students
{
    public class StudentAppService : TestAppServiceBase, IStudentAppService
    {
        private readonly IShardingDbAccessor _dbAccessor;

        public StudentAppService(IShardingDbAccessor dbAccessor)
        {
            _dbAccessor = dbAccessor;
        }

        public async Task<ListResultDto<StudentDto>> GetAllAsync()
        {
            return new ListResultDto<StudentDto>(ObjectMapper.Map<List<StudentDto>>(await _dbAccessor.GetIShardingQueryable<Student>().ToListAsync()));
        }

        public async Task<StudentDto> CreateAsync()
        {
            var student = new Student()
            {
                Name = "测试",
                Address = "贵阳市",
                Age = 18,
                Sex = 1,
                IsLess = true
            };
            await _dbAccessor.InsertAsync(student);

            return ObjectMapper.Map<StudentDto>(student);
        }
    }
}