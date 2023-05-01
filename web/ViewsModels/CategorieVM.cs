using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class CategorieVM
    {
        public Categorie Categorie { get; set; }
        public IEnumerable<ProductLevelVM> Products { get; set; }
    }
}
