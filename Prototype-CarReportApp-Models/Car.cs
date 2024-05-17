using System.ComponentModel.DataAnnotations;

namespace Prototype_CarReportApp_Models
{
    public class Car
    {
        [Required(ErrorMessage = "CarId is required . . .")]
        public int CarId { get; set; }
        [Required(ErrorMessage = "Registration number is required . . .")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Registration number needs to be 6 characters")]
        public string CarRegNr { get; set; }
        [Required(ErrorMessage = "Brand is required . . .")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Brand should be between 3 and 12 characters")]
        public string CarBrand { get; set; }
        [Required(ErrorMessage = "Model is required . . .")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Model should be between 3 and 12 characters")]
        public string CarModel { get; set; }
        [Required(ErrorMessage = "Year is required . . .")]
        [Range(1900, 2024, ErrorMessage = "Year must be between 1900 and 2024 . . .")]
        public int CarYear { get; set; }
        public ICollection<Report> Reports { get; set; } = new List<Report>();


    }
}
