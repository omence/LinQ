using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace LinQ.Classes
{
    public class RootObject
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("features")]
        public List<Feature> features { get; set; }
    }
}
