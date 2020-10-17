using System;
using System.Collections.Generic;
using System.Text;

namespace treehouseVirtualPetC
{
    class WellnessQoutient
    {
        private int _startingWellness;

        public int StartingWellness
        {
            get { return _startingWellness; }
            set { _startingWellness = value; }
        }


        public WellnessQoutient(int startingWellness)
        {
            _startingWellness = startingWellness;
        }
    }
}
