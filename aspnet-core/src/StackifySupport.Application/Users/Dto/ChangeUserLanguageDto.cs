using System.ComponentModel.DataAnnotations;

namespace StackifySupport.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}