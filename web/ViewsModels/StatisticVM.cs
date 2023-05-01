using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class StatisticVM
    {
        public string Avg { get; set; }
        public string StarAvg { get; set; }
        public string[] BarAvg { get; set; }
        public string CommentNumber { get; set; }
    }
}
