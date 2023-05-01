using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class RatingVM
    {
        public DateTime Date { get; set; }
        public int Level { get; set; }
        [Required]
        [MaxLength(500)]
        [MinLength(10)]
        public string Description { get; set; }
        public Guid ProductId { get; set; }
        public Guid RaterId { get; set; }
    }
}
