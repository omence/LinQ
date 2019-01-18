using System;
using System.IO;
using System.Collections.Generic;
using LinQ.Classes;
using Newtonsoft.Json;
using System.Linq;

namespace LinQ
{
    class Program
    {
        /// <summary>
        /// Calls methos from below
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string path = "../../../../../LinQ.JSON";
            Console.WriteLine("Hello World!");
            AllNeighborhoods(path);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            NeighborhoodsNoBlanks(path);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            AllNeighborhoodsLAMBDA(path);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            GetNeighborhoodsAll(path);
            Console.ReadLine();

            
        }

        /// <summary>
        /// Gets and prints all neighborhoods raw data
        /// </summary>
        /// <param name="path">Path to JSON file</param>
        public static void AllNeighborhoods(string path)
        {
            var data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }


            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);

            var neighbo = from hood in root.features
                          select hood.properties.neighborhood;

            foreach (var i in neighbo)
            {
                Console.WriteLine(i);
            }

        }

        /// <summary>
        /// Prints all neighborhoods without blanks in lambda
        /// </summary>
        /// <param name="path">JSON file path</param>
        public static void AllNeighborhoodsLAMBDA(string path)
        {
            var data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }


            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);

            var neighbo = root.features.Where(i => i.properties.neighborhood != "");

            foreach (var i in neighbo)
            {
                Console.WriteLine(i.properties.neighborhood);
            }

        }

        /// <summary>
        /// Reads JSON file and out puts list of neighborhoods without blanks.
        /// </summary>
        /// <param name="path">is path to JSON file</param>
        public static void NeighborhoodsNoBlanks(string path)
        {
            var data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }

            
            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);

            var neighbo = from hood in root.features
                          where hood.properties.neighborhood != ""
                                select hood;
                              
                foreach (var i in neighbo)
            {
                Console.WriteLine(i.properties.neighborhood);
            }
       
        }



        /// <summary>
        /// Get all neighborhoods with blanks or duplicates
        /// </summary>
        /// <param name="path">Path to JSON file</param>
        static void GetNeighborhoodsAll(string path)
        {
            var data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }

            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);

            var hoods = from hood in root.features
                          where (string)hood.properties.neighborhood != ""
                          group hood by hood.properties.neighborhood
                          into neighborhoods
                          select neighborhoods;
           
            foreach (var i in hoods)
            {
                Console.WriteLine(i.Key);
            }

        }
    }
}
