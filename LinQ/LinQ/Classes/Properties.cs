﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace LinQ.Classes
{
    public class Properties
    {
        internal object neighborhoods;

        [JsonProperty("zip")]
        public string zip { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("state")]
        public string state { get; set; }
        [JsonProperty("address")]
        public string address { get; set; }
        [JsonProperty("borough")]
        public string borough { get; set; }
        [JsonProperty("neighborhood")]
        public string neighborhood { get; set; }
        [JsonProperty("county")]
        public string county { get; set; }
    }
}
