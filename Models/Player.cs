using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrodnikProject.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LaststName { get; set; }
        public int Number { get; set; }

        public int PositionID { get; set; }
    }
}
