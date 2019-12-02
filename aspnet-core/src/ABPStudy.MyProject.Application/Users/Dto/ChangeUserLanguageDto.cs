using System.ComponentModel.DataAnnotations;

namespace ABPStudy.MyProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}