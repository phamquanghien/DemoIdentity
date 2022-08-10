using System.ComponentModel.DataAnnotations;

namespace DemoIdentity.ViewModel
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required (ErrorMessage = "PassWord is required!")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required (ErrorMessage = "Confirm passWord is required!")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "The PassWord and ConfirmPassWord fields do not match.")]
        public string ConfirmPassWord { get; set; }
    }
}