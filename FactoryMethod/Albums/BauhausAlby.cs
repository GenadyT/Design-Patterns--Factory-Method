using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.BL;

namespace FactoryMethod.Albums
{
    internal class BauhausAlby : Album
    {
        public override string Name { get { return "The Sky's Gone Out"; } }
        public override string BandName { get { return "Bauhaus"; } }

        public override string[] TrackList
        {
            get
            {
                return new string[] { "Third Uncle", "Silent Hedges", "In the Night" };
            }
        }
    }
}
