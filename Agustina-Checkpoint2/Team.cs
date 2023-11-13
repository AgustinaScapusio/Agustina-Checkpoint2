using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Agustina_Checkpoint2
{
    public class Team
    {
        public string Name { get; set; }

        public List<Team> Players {  get; set; }

        public Team(string name)
        {
            Name = name;
        }
    }
}
