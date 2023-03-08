using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
	public class YearValidation:ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			int _Year = Convert.ToInt32(value);

			if (_Year <= 2050 && _Year >= 1900)
			{
				return ValidationResult.Success;
			}
			else
			{
				return new ValidationResult("Enter a value between 1900 and 2050 years.");
			}
		}
		public override bool IsValid(object? value) //iki farklı kullanımı mevcut. Aradaki farkları araştırın.
		{
			return base.IsValid(value);
		}
	}
}
