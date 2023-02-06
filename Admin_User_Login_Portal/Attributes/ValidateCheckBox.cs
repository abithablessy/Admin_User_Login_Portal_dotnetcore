using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Admin_User_Login_Portal.Attributes
{
    public class ValidateCheckBox:ValidationAttribute,IClientModelValidator
    {
       public void AddValidation(ClientModelValidationContext context)
       {
            context.Attributes.Add("data-val-validatecheckbox", ErrorMessage);
        }
        public override bool IsValid(object? value)
        {
            return Convert.ToBoolean(value);
        }
    }
}
