using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
	public class IdValidation:ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			int _Id = Convert.ToInt32(value);

			if (_Id > 0)
			{
				return ValidationResult.Success;
			}
			else
			{
				return new ValidationResult("\r\nId cannot be negative.");
			}
		}
		public override bool IsValid(object? value) //iki farklı kullanımı mevcut. Aradaki farkları araştırın.
		{
			return base.IsValid(value);
		}
	}
}
