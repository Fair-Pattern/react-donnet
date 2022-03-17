using System.Threading.Tasks;
using Abp.Application.Services;
using react-dot-net.Sessions.Dto;

namespace react-dot-net.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
