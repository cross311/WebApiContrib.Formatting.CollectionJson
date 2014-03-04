﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public class Query 
    {
        public Query()
        {
            Data = new List<Data>();
        }

        public String Rt { get; set; }

        public String Rel { get; set; }

        public Uri Href { get; set; }

        public string Prompt { get; set; }

        public IList<Data> Data { get; set; }
    }
}
