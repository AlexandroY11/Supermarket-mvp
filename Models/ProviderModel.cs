using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProviderModel
    {
        [DisplayName("Provider Id")]
        public int Id { get; set; }

        [DisplayName("Provider Name")]
        [Required(ErrorMessage = "Provider name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provider name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Provider Address")]
        [Required(ErrorMessage = "Provider Address is required")]
        [StringLength(200, MinimumLength = 8, ErrorMessage = "Provider Address must be between 8 and 200 characters")]
        public string Address { get; set; }

        [DisplayName("Provider Phone")]
        [Required(ErrorMessage = "Provider Phone is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Provider Phone must be 10 characters")]
        public string Phone { get; set; }
    }
}
