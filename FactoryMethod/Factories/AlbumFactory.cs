using FactoryMethod.Albums;
using FactoryMethod.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class AlbumFactory
    {
        private Album[] albums;

        public AlbumFactory(Album[] albums)
        {
            this.albums = albums;
        }

        /// <summary>
        /// Decides which class to instantiate.
        /// </summary>
        public Album GetGenreAlbum(Genre genre)
        {
            switch (genre.ID)
            {
                case 1:
                    return new BauhausAlby();
                case 2:    // relax
                    return new YellowAlby();
                case 3:
                    return new BrainvoyagerAlby();
                case 4:
                    return new TheOrbAlby();
                case 5:
                    return new JimiAlby();
                default:
                    return new JimiAlby();
            }
        }
    }
}
