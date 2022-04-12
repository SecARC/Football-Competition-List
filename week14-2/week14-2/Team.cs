using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14_2
{
    public class Team
    {
        public string name { get; set; }

        public Team(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        public override bool Equals(object obj)
        {
            var objectTeam = obj as Team;
            if (objectTeam == null)
                return false;

            return name == objectTeam.name;
        }

        public Team Self { get { return this; } }
    }
}
