using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.BL;

namespace FactoryMethod.Albums
{
    internal class BrainvoyagerAlby : Album
    {
        public override string Name { get { return "History of the Universe"; } }
        public override string BandName { get { return "Brainvoyager"; } }

        public override string[] TrackList
        {
            get
            {
                return new string[] { "Roberto Sass & Indii Moon - Quantum Flux", "Tuuligan - Reionization Era 13.6 Ga", "Ivan Black - Quasar CFQS J2329" };
            }
        }
    }
}
