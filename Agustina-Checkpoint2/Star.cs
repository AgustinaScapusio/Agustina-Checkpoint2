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

        public Star(string namePlayer, int number, string description):base(namePlayer,number)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"Role: {this.GetType().Name} || Name: {NamePlayer} || #{Number} || Description: {Description}";
        }

    }
}
