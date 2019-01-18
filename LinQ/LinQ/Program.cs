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
            string path = "../../../../../LinQ.JSON";
            Console.WriteLine("Hello World!");
            FeaturesJS(path);
        }

        public static void FeaturesJS(string path)
        {
            var data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }

            
            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);

            Console.WriteLine(root.features[1].properties.neighborhood);

            var Neighborhoods = from n in root
                              select n;
                              

        }
    }
}
