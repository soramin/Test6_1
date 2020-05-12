using System;
using System.Collections.Generic;
using System.Text;

namespace Test6_1
{
    class TripMembers
    {
        public int TripCount { get; set }

        public override ShowMemberData()
        {

        }
    }

    abstract class  Animal
    {
        public abstract void Bark();
    }
    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("ワンワン");
        }
    }
}
