﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public class Link
    {
        public String Rel { get; set; }

        public Uri Href { get; set; }

        public String Prompt { get; set; }

        public String Render { get; set; }
    }
}
