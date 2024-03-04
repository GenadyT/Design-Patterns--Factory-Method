using FactoryMethod.Albums;
using FactoryMethod.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.BL
{
    internal class BL
    {
        public static Mood[] GetMoods()
        {
            Mood[] moods = DL.JsonOperations.Read<MoodsDataScope>("Moods.json").data;
            return moods;
        }

        public static Genre[] GetGenres()
        {
            Genre[] genres = DL.JsonOperations.Read<GenresDataScope>("Genres.json").data;
            return genres;
        }

        public static Album[] GetAlbums()
        {
            Album[] albums = new Album[5];

            albums[0] = new BauhausAlby();
            albums[1] = new BrainvoyagerAlby();
            albums[2] = new JimiAlby();
            albums[3] = new TheOrbAlby();
            albums[4] = new YellowAlby();

            return albums;
        }
    }
}
