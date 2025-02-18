using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_FrameWork.Entities
{
    internal class Department
    {
        
        public int ID { get; set; }

        [MaxLength(15)]
        [Required]
        public string Name { get; set; }
        public int Ins_ID { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }
    }
}
