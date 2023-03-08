using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;
using TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations;
using System.Text.RegularExpressions;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Models
{
    public class Araba
    {
        [Display(Name = "ID")]
        [IdValidation]
        public int Id { get; set; }
        [DisplayName("Arabanın Markası")]
        [Required(ErrorMessage = "You have to enter the make of the car!")]
        public string Marka { get; set; }
        [Required(ErrorMessage = "\r\nYou have to enter the series of the car!")]
        public string Seri { get; set; }
        [Required(ErrorMessage = "\r\nYou have to enter the model of the car!")]
        public string Model { get; set; }
        [DisplayName("Yıl")]
        [YearValidation]
        [Required(ErrorMessage = "You have to enter the year of the car!")]
        public int Yil { get; set; }
        [DisplayName("Yakıt")]
        public string Yakit { get; set; }
        [DisplayName("Araç Durumu")]
        [EnumDataType(typeof(AracDurumu), ErrorMessage = "Vehicle type is not valid.")]
        public AracDurumu AracDurumu { get; set; }
        public string Renk { get; set; }
        public double Kilometre { get; set; }
        [Required]
        [FiyatValidation(ErrorMessage = "The price cannot be below zero.")]
        public decimal Fiyat { get; set; }
        [Display(Name = "Vites Tipi")]
        [EnumDataType(typeof(VitesType), ErrorMessage = "Vites type is not valid.")]
        public VitesType VitesType { get; set; }
        public decimal MotorPower { get; set; }
        [RegularExpression(@"^(0[1-9]|[1-7][0-9]|8[01])(([A-Z])(\d{4})|([A-Z]{2})(\d{3,4})|([A-Z]{3})(\d{2}))$", ErrorMessage = "You entered the wrong license plate.")]
        public string Plaka { get; set; }

    }
    public enum AracDurumu
    {
        Sıfır = 1,
        İkinci
    }
    public enum VitesType
    {
        Otomatik = 1,
        Manuel
    }
}

