using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm
{
    public class League
    {
        public IEnumerable<Division> Divisions { get; set; }
        private string name;
        public League()
        {
            name = GetName();

            var d1 = new Division()
            {
                Name = name.Substring(0, 2) + "-" + "Division A"
            };
            d1.Teams.Add(new Team("Team A1"));
            d1.Teams.Add(new Team("Team A2"));
            d1.Teams.Add(new Team("Team A3"));

            var d2 = new Division()
            {
                Name = name.Substring(0, 2) + "-" + "Division B"
            };
            d2.Teams.Add(new Team("Team B1"));
            d2.Teams.Add(new Team("Team B2"));

            var d3 = new Division()
            {
                Name = name.Substring(0, 2) + "-" + "Division C"
            };
            d3.Teams.Add(new Team("Team C1"));
            d3.Teams.Add(new Team("Team C2"));
            d3.Teams.Add(new Team("Team C3"));
            d3.Teams.Add(new Team("Team C4"));

            Divisions = new List<Division> { d1, d2, d3 };
        }

        private string GetName()
        {
            string[] names = { "Mahesh", "Jeff Prosise", "Dave", "Allen O'neill", "Monica Rathbun", "Henry He", "Raj", "Mark Prime", "Tracey", "Mike Crown" };
            return names[new Random().Next(names.Length)];
        }

        public override string ToString()
        {
            return "League:" + name;
        }
    }

    public class Division
    {
        public string Name { get; set; }
        public IList<Team> Teams { get; set; } = new List<Team>();
    }

    public class Team
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Team(string name)
        {
            Name = name;
            Score = new Random().Next(100);
        }
    }
}
