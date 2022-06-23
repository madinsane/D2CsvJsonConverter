using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonItemPercentModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("HeartPercent"), NameIndex(0), JsonProperty]
        public string Heartpercent { get; set; } = "";
        
        [Name("BodyPartPercent"), NameIndex(0), JsonProperty]
        public string Bodypartpercent { get; set; } = "";
        
        [Name("TreasureClassPercent"), NameIndex(0), JsonProperty]
        public string Treasureclasspercent { get; set; } = "";
        
        [Name("ComponentPercent"), NameIndex(0), JsonProperty]
        public string Componentpercent { get; set; } = "";
        
    }
}
