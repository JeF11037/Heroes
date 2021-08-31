using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroesSeperation(@"C:\Users\opilane\Source\Repos\Heroes\Heroes\Heroes.txt");
            Console.WriteLine("- - - - -");
            foreach (var el in HeroesList)
            {
                Console.WriteLine("Name : " + el[0] + "\nLocation : " + el[1] + "\n- - - - -");
            }
            Superhero superhero = new Superhero(HeroesList[0][0], HeroesList[0][1]);
            Console.WriteLine(superhero.toString(100));
            Hero hero = new Hero(HeroesList[1][0], HeroesList[1][1]);
            Console.WriteLine(hero.toString(50));
            Console.ReadLine();
        }

        static private List<string[]> HeroesList = new List<string[]>();
        static private void HeroesSeperation(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] seperated = line.Split('/');
                    string name;
                    string location;


                    if (line.Contains("*"))
                    {
                        Superhero superhero = new Superhero(seperated[0], seperated[1]);
                        name = superhero.Name.Replace('*', ' ');
                        location = superhero.Location;
                    }
                    else
                    {
                        Hero hero = new Hero(seperated[0], seperated[1]);
                        name = hero.Name;
                        location = hero.Location;
                    }
                    HeroesList.Add(new string[] { name, location });
                }
            }
        }
    }
}
