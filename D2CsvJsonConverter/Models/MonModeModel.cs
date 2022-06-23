using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonModeModel
    {
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("token"), NameIndex(0), JsonProperty]
        public string Token { get; set; } = "";
        
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
    }
}
