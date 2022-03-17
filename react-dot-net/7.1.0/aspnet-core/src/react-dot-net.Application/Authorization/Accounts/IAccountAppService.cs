using System.Threading.Tasks;
using Abp.Application.Services;
using react-dot-net.Authorization.Accounts.Dto;

namespace react-dot-net.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
