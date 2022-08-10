using System.ComponentModel.DataAnnotations;

namespace DemoIdentity.ViewModel
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}