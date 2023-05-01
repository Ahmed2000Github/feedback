using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewsModels
{
    public class ErrorVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<string> Advices { get; set; }
    }
}
