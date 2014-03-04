using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public class Collection
    {
        public Collection()
        {
            Links = new List<Link>();
            Items = new List<Item>();
            Queries = new List<Query>();
            Template = new Template();
        }

        public string Version { get; set; }

        public Uri Href { get; set; }

        public IList<Link> Links { get; set; }

        public IList<Item> Items { get; set; }

        public IList<Query> Queries { get; set; }

        public Template Template { get; set; }
    }

}
