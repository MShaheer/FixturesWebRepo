﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Models
{
    public class Reference
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public string PostedBy { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
