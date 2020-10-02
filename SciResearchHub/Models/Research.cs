using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciResearchHub.Models
{
    public class Research
    {
        public string id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string creationDate { get; set; }
        public string domain { get; set; }
        public int[] ratings { get; set; }
        public string link { get; set; }
    }
}
