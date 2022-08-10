using System.ComponentModel.DataAnnotations;

namespace DemoIdentity.ViewModel
{
    public class DeleteUserViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string UserName { get; set; }
    }
}