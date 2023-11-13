using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustina_Checkpoint2
{
    public class Player 
    {
        public string? NamePlayer { get; set; }
        public int Number {  get; set; }

        public Player(string namePlayer, int number)
        {
            NamePlayer= namePlayer;
            Number = number;
            
        }
        public override string ToString()
        {
            return $"Role: {this.GetType().Name} || Name: {NamePlayer} || #{Number}";
        }
    }
}
