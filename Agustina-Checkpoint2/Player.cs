using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustina_Checkpoint2
{
    public class Player : Team
    {
        public int Number {  get; set; }

        public Player(string name, int number):base(name)
        {
            Number = number;
            
        }
    }
}
