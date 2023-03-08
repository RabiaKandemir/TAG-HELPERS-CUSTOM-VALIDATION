using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
	public class JoinDateValidation:ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			DateTime _JoinDate = Convert.ToDateTime(value);

			if (_JoinDate < DateTime.Now && _JoinDate.Year >= (DateTime.Now.Year - 10))
			{
				return ValidationResult.Success;
			}
			else if (_JoinDate.Year < (DateTime.Now.Year - 10))
			{
				return new ValidationResult("Cannot be an employee of 11 years.");
			}
			else
			{
				return new ValidationResult("\r\nYou cannot enter a value greater than the current date.");
			}
		}
		public override bool IsValid(object? value) //iki farklı kullanımı mevcut. Aradaki farkları araştırın.
		{
			return base.IsValid(value);
		}
	}
}
