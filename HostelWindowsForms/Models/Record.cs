using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelWindowsForms.Models
{
    public class Record
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Address Address { get; set; }
        public Student Student { get; set; }
    }
}
