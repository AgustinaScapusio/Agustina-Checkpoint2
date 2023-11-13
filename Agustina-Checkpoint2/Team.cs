using System;
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

        public List<Player>? Players {  get; set; }

        string docPath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf(@"\bin") + 1);

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

        public void SaveToFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(docPath + fileName))
            {
                sw.WriteLine($"{Name}");
                foreach (var player in Players)
                {
                    sw.WriteLine(player);
                }
            };
        }
        public List<string> ReadFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(docPath + fileName))
            {
                string newAttendants = sr.ReadToEnd();
                List<string> result = newAttendants.Split("/n").ToList();
                foreach (var att in result)
                {
                    Console.WriteLine(att);
                }
                return result;
            };
        }
        // Tried to make a operator overload method, but keeps sending error in "==" not sure why :/
        //public static bool operator ==(List<Player> players,  List<Player>other)
        //{
        //    bool IsEqual;
        //    if(players.Count == other.Count) {
        //        IsEqual = true;
        //    }
        //    else { IsEqual = false; }
        //    return IsEqual;
            
        //}
    }
}
