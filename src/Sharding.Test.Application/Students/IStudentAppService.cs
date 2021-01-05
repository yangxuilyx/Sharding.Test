using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sharding.Test.Students.Dtos;

namespace Sharding.Test.Students
{
    public interface IStudentAppService : IApplicationService
    {
        Task<ListResultDto<StudentDto>> GetAllAsync();

        Task<StudentDto> CreateAsync();
    }
}