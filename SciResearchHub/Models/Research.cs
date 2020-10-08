using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciResearchHub.Models
{
    public class Research
    {
        public Research(object id, object title, object author, object domain, object imglink, object link, object dateCreated)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.domain = domain;
            this.imglink = imglink;
            this.link = link;
            this.dateCreated = dateCreated;

        }
        public object id { get; set; }
        public object title { get; set; }
        public object author { get; set; }
        public object domain { get; set; }
        public object imglink { get; set; }
        public object link { get; set; }
        public object dateCreated { get; set; }
    }
}
