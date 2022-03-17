using Abp.Application.Services;
using react-dot-net.MultiTenancy.Dto;

namespace react-dot-net.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

