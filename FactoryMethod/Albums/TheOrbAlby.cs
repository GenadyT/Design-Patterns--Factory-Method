using FactoryMethod.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Albums
{
    internal class TheOrbAlby : Album
    {
        public override string Name { get { return "Orblivion"; } }
        public override string BandName { get { return "The Orb"; } }

        public override string[] TrackList
        {
            get
            {
                return new string[] { "Delta MKII", "Ubiquity", "Bedouin" };
            }
        }
    }
}
