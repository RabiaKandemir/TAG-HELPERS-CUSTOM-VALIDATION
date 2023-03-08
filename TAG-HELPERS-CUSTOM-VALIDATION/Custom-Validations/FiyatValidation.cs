using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
	public class FiyatValidation:ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			decimal _fiyat = Convert.ToDecimal(value);

			if (_fiyat > 0)
			{
				return ValidationResult.Success;
			}
			else
			{
				return new ValidationResult("\r\nPrice is not valid.");
			}
		}
		public override bool IsValid(object? value)
		{
			return base.IsValid(value);
		}
	}
}
