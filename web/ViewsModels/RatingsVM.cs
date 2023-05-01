using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class RatingsVM
    {
        public Rating Rating { get; set; }
        public Rater Rater { get; set; }
    }
}
