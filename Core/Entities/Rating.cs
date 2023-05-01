using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Rating : EntityBase
    {
        public DateTime Date { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        [ForeignKey("Rater")]
        public Guid RaterId { get; set; }
    }
}
