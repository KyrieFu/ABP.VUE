using System.Threading.Tasks;
using Abp.Application.Services;
using ABPStudy.MyProject.Authorization.Accounts.Dto;

namespace ABPStudy.MyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
