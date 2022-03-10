using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker
{
    public class Services
    {
        public Services() { }

        [Key]
        public int ServiceID { get; set; }

        public string ServiceTitle { get; set; }

        public string ServiceDesription { get; set; }   

        public int Id { get; set; } 
    }
}
