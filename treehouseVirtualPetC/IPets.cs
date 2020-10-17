using System;
using System.Collections.Generic;
using System.Text;

namespace treehouseVirtualPetC
{
    interface IPets
    {
        int Hunger { get; }

        public int Affection
        {
            get { return Affection; }
            set { Affection = value; }
        }
        public int Sleep 
        { 
            get { return Sleep;  }
            set { Sleep = value; } 
        }
    }
}
