using Abp.AutoMapper;
using ABPStudy.MyProject.Authentication.External;

namespace ABPStudy.MyProject.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
