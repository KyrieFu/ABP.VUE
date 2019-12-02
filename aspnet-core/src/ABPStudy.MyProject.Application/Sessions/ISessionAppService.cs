using System.Threading.Tasks;
using Abp.Application.Services;
using ABPStudy.MyProject.Sessions.Dto;

namespace ABPStudy.MyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
