using System.ComponentModel.DataAnnotations;

namespace BlackLight.Recruitment.MVC.Models
{
    public class ContactUsViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")] //No need for Regex to check for an @ since there's built-in email validation
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}