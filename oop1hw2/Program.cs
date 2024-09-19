using Italia;
using Romania;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukraine;

namespace Ukraine
{
    public class Kyiv
    {
        public string Name {  get; set; }
        public int Population {  get; set; }
        public Kyiv() 
        {
            Name = "Kyiv";
            Population = 31231233;
        }
    }
}
namespace Romania
{
    public class Bucharest
    {
        public string Name {  get; set; }
        public int population {  get; set; }
        public Bucharest() 
        {
            Name = "Bucharest";
            population = 12333;
        }
    }
}
namespace Italia
{
    public class Paris
    {
        public string Name {  get; set; }
        public int population {  get; set; }
        public Paris() 
        {
            Name = "Paris";
            population = 32222;
        }
    }
}
namespace oop1hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kyiv kyiv = new Kyiv();
            Bucharest bucharest = new Bucharest();
            Paris paris = new Paris();
            if(kyiv.Population>bucharest.population&&kyiv.Population>paris.population)
            {
                Console.WriteLine("max population in Kyiv");
            }
            else if(bucharest.population>kyiv.Population&&bucharest.population>paris.population)
            {
                Console.WriteLine("max population in Bucharest");
            }
            else
            {
                Console.WriteLine("max population in Paris");
            }
        }
    }
}
