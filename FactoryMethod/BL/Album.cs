using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.BL
{
    internal abstract class Album
    {
        public abstract string Name { get; }
        public abstract string BandName { get; }

        public abstract string[] TrackList { get; }
    }
}
