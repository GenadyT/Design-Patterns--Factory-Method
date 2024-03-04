using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.BL;

namespace FactoryMethod.Albums
{
    internal class JimiAlby : Album
    {
        public override string Name { get { return "Are You Experienced"; } }
        public override string BandName { get { return "Jimi Hendrix"; } }

        public override string[] TrackList
        {
            get
            {
                return new string[] { "Foxy Lady", "Manic Depression", "Red House" };
            }
        }
    }
}
