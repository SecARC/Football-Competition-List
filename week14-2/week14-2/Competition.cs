using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14_2
{
    public class Competition
    {
        public int id { get; set; }
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public int? score1 { get; set; }
        public int? score2 { get; set; }
    }
}
