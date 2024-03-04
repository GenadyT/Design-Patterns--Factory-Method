using FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.BL
{
    internal class Test
    {
        public static (string, string[]) GetAlbumByMood(int mood)
        {            
            GenreFactory genreFactory = new GenreFactory(genres);
            AlbumFactory albumFactory = new AlbumFactory(genreFactory);

            Album album = albumFactory.GetAlbum(mood);
            return (album.Name, album.TrackList);
        }
    }
}
