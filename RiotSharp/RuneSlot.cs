﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RiotSharp
{
    public class RuneSlot : Thing
    {
        public RuneSlot(JToken json)
        {
            JsonConvert.PopulateObject(json.ToString(), this, RiotApi.JsonSerializerSettings);
        }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("rune")]
        [JsonConverter(typeof(RuneConverter))]
        public Rune Rune { get; set; }
    }
}
