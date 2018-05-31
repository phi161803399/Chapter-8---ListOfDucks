using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___ListOfDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 14},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13},
            };
            //ducks.Sort(); //works when class Duck implements IComparable<Duck> which has CompareTo() method which makes Sort() work
            //DuckComparerBySize sizeComparer = new DuckComparerBySize();
            //ducks.Sort(sizeComparer);

            DuckComparerByKind kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);

            PrintDucks(ducks);
            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                //Console.WriteLine($"{duck.Size}-inch {duck.Kind}");
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            }
            Console.WriteLine("End of ducks");
        }
    }
}
