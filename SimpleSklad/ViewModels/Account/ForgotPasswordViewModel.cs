using System.ComponentModel.DataAnnotations;

namespace SimpleSklad.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
