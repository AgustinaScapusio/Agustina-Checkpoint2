using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustina_Checkpoint2
{
    public class Star : Player
    {
        public string Description { get; set; }

        public Star(string name, int number, string description):base(name,number)
        {
            Description = description;
        }

    }
}
