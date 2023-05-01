using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class EmailVM
    {
        public string From { get; set; }
        public string Subject { get; set; } = "Comment";
        public string Body { get; set; }
    }
}
