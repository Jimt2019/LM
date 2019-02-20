﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM_CORE.Models
{
    public class Content
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int status { get; set; }
        public DateTime add_time { get; set; }
        public DateTime modify_time { get; set; }
    }
}
