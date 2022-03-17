using System.ComponentModel.DataAnnotations;

namespace react-dot-net.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}