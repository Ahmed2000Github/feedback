using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities
{
    public class Product : EntityBase
    {
        public string ProductName { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        [ForeignKey("Categorie")]
        public Guid CategorieId { get; set; }
    }
}
