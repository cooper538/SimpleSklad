using System.ComponentModel.DataAnnotations;

namespace SimpleSklad.ViewModels.Account
{
    public class UseRecoveryCodeViewModel
    {
        [Required]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }
    }
}
