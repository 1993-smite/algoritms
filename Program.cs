using System;
using Genetic;

namespace algoritms
{
    class Program
    {
        static void Main(string[] args)
        {

            var prop = new ArifmeticProperty();

            var generic = new Genetic<Arifmetic>(1000);
            generic.SetProperties(new Arifmetic(1,2,3,4),prop);
            Console.WriteLine("for first iteration {0}", generic.GetAge(1).GetMeasure);
            var res = generic.GetAge(100);
            Console.WriteLine("for result {0}",res.GetMeasure);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
