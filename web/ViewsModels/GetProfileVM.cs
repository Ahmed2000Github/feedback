using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class GetProfileVM 
    {
        public Rater rater { get; set; }
        public int CommentsCount { get; set; }
    }
}
