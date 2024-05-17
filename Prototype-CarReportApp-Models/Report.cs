using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CarReportApp_Models
{
    public class Report
    {
        [Required]
        public int ReportId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Title needs to be between 3 and 20 characters")]
        public string ReportTitle { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Description needs to be between 3 and 50 characters")]
        public string ReportDescription { get; set; }
        [Required]
        public DateTime DateOfReport { get; set; }
        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; }


    }
}
