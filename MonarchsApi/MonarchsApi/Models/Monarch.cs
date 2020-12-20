using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonarchsApi.Models
{
    public class Monarch
    {
        public int id { get; set; }
        public String nm { get; set; }
        public String cty { get; set; }
        public String hse { get; set; }
        public String yrs { get; set; }
    }
}
