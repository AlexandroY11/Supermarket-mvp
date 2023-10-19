using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoryModel
    {
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        [Required(ErrorMessage = "Category Description is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Category Description must be between 3 and 200 characters")]
        public string Description { get; set; }
    }
}
