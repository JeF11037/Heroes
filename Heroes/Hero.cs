using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class Hero
    {
        public string Name { get; private set; }
        public string Location { get; private set; }

        public Hero(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public int Rescue(int count)
        {
            return Convert.ToInt32(Math.Round(count * 0.95));
        }

        public string toString(int count)
        {
            return "Hero " + Name  + "has rescured " + Rescue(100) + "% people in" + Location + " city.";
        }
    }

    public class Superhero : Hero
    {
        private double Agility { get; set; }

        public Superhero(string name, string location) : base(name, location)
        {
            Agility = new Random().Next(1, 6);
        }

        public int Rescue(int count)
        {
            return Convert.ToInt32(Math.Round(count * (0.95 + Agility / 100)));
        }

        public string toString(int count)
        {
            return "Superhero " + Name.Split('*')[0] + " has rescured " + Rescue(count) + "% people in" + Location + " city.";
        }
    }
}
