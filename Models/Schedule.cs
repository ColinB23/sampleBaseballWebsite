using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BrodnikProject.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public string Opponent { get; set; }
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Time { get; set; }

    
    }
}
