using System.Threading.Tasks;
using Abp.Application.Services;
using Sharding.Test.Sessions.Dto;

namespace Sharding.Test.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
