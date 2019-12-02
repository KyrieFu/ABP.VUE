using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPStudy.MyProject.MultiTenancy.Dto;

namespace ABPStudy.MyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

