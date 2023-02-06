using Admin_User_Login_Portal.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Admin_User_Login_Portal.Models
{
    public class Userviewmodel
    {

        [Required(ErrorMessage="Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter email")]
        [RegularExpression("^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$")]
        public string Email { get; set; }
        [Required(ErrorMessage ="please enter password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
            ErrorMessage = "Password required (1 Uppercase, 1 Number, 1 Special Char and 1 Lowercase Char) " +
            "with Min Length 8 Chars")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please enter confirm password")]
        [Compare("Password",ErrorMessage ="Confirm password doesn't match.")]
        public string Confirmpassword { get; set; }
        [Required(ErrorMessage ="Please enter phone.")]
        [RegularExpression("^[6789]\\d{9}$", ErrorMessage ="Please enter valid phonenumber.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Gender is required.")]
        public string Gender { get; set; }
        [ValidateCheckBox(ErrorMessage ="Please accept terms and conditions")]
        public bool Terms { get; set; }

    }
}
