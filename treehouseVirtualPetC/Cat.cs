using System;
using System.Collections.Generic;
using System.Text;

namespace treehouseVirtualPetC
{
    class Cat : IPets
    {
        public int Hunger { get; }  = 0;

        public int Affection { get; }  = 100;

        int Sleep = 100;
    }
}
