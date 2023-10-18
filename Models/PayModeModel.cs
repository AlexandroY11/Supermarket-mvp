using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int IdPayMode { get; set; }
        
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode name must be between 3 and 50 characters")]
        public string NamePayMode { get; set; }

        [DisplayName("Pay Mode Observation")]
        [Required(ErrorMessage = "Pay Mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode observation must be between 3 and 200characters")]
        public string ObservationPayMode { get; set; }
    }
}
