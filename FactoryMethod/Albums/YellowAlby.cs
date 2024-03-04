using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.BL;

namespace FactoryMethod.Albums
{
    internal class YellowAlby : Album
    {
        public override string Name { get { return "Yellow Alby"; } }
        public override string BandName { get { return "Yello"; } }

        public override string[] TrackList
        {
            get
            {
                return new string[] { "Mokka coffee", "Yellow stream", "Brown brown" };
            }
        }
    }
}
