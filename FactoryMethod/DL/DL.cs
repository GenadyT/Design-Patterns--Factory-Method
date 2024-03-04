using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.BL;

namespace FactoryMethod.DL
{
    public class DL
    {
        public static Mood[] GetMoods()
        {
            return JsonOperations.Read<MoodsDataScope>("Moods.json").data;
        }

        public static Genre[] GetGenres()
        {
            return JsonOperations.Read<GenresDataScope>("Genres.json").data;
        }
    }
}
