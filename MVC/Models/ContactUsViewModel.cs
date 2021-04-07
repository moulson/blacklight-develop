using System.ComponentModel.DataAnnotations;

namespace BlackLight.Recruitment.MVC.Models
{
    public class ContactUsViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^(.+@.+)$", ErrorMessage = "Email must contain an @")]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}