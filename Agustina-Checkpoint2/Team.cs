﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Agustina_Checkpoint2
{
    public class Team 
    {
        public string? Name { get; set; }

        public List<Player> Players {  get; set; }

        public Team(string name)
        {
            Name = name;
        }

        public void PrintTeam(List<Player>players)
        {
            Console.WriteLine(Name);
            Console.WriteLine("__________________");
            foreach (Player p in players)
            {
                Console.WriteLine(p.ToString());
            }

        }
       
        public override string ToString()
        {
            return $"Role: {this.GetType().Name} || Name: {Name}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Team other) { return Equals(this, other); }
            else { return false; }
        }
    }
}
