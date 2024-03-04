using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using System.Reflection;

namespace FactoryMethod.DL
{
    public class JsonOperations
    {
        public static T Read<T>(string file)
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\" + file);
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        } 
    }
}
