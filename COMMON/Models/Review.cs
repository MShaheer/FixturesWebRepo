using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int PropertyId { get; set; }
        public string Body { get; set; }
        public DateTime DatePosted { get; set; }
        public string PostedBy { get; set; }
    }
}
