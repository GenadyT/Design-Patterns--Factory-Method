using FactoryMethod.Albums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.BL;

namespace FactoryMethod.Factories
{
    internal class GenreFactory
    {
        private Genre[] genres;

        public GenreFactory(Genre[] genres) 
        { 
            this.genres = genres;
        }
        
        public Genre GetMoodGenre(Mood mood, string addInfo = "")
        {   
            switch (mood.ID)
            {
                case 1:
                    return genres[0];
                case 2:
                    return genres[1];
                case 3:
                    return genres[2];
                case 4:
                    return genres[3];
                case 5:
                    return genres[4];
                default:
                    return genres[4];

                    /*case "romanticism":
                        return "Gothic rock";
                    case "ecstasy":
                        return "Electronic";
                    case "Calm":
                        return "Ambient house";
                    case "Crazy":
                        return "Psychedelic";
                    default:
                        return "Psychedelic";*/
            }
        }
    }
}
