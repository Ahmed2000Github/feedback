using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class ProductGetVM
    {
        public Product Product { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
