using Abp.Application.Services.Dto;

namespace ABPStudy.MyProject.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

