using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciResearchHub.Models
{
    public class Research
    {
       /* public Research(string id, string title, string author, string domain, string imglink, string link, string dateCreated)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Domain = domain;
            this.Imglink = imglink;
            this.Link = link;
            this.DateCreated = dateCreated;

        }*/
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Domain { get; set; }
        public string Imglink { get; set; }
        public string Link { get; set; }
        public string DateCreated { get; set; }
    }
}
