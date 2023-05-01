using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class ProductAddVM 
    {
        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public string ProductName { get; set; }
        [Required]
        [Url]
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Guid CategorieId { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
