using System.ComponentModel.DataAnnotations;

namespace DemoIdentity.ViewModel
{
    public class CreateRoleViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Role name is required.")]
        public string RoleName { get; set; }
    }
}