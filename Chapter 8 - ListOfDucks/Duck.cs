using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___ListOfDucks
{
    class Duck//: IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public void Quack()
        {

        }
        public void Swim()
        {

        }
        public void Eat()
        {

        }
        public void Walk()
        {

        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
}
