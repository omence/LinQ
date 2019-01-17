using System;
using System.IO;
using System.Collections.Generic;
using LinQ.Classes;
using Newtonsoft.Json;

namespace LinQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            //C: \Users\jason\Source\Repos\LinQ\LinQ.JSON

            string path = "../../../../../LinQ.JSON";
            Console.WriteLine("Hello World!");
            FeaturesJS(path);
        }

        public static void FeaturesJS(string path)
        {
            string data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }
            Feature feature = JsonConvert.DeserializeObject<Feature>(data);



            //IEnumerable<string> neighborhoods = from n in feature.properties
            //                                    where n.Contains(neighborhood)
            //                                    select n;

        }
    }
}
