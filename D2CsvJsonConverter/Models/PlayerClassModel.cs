using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class PlayerClassModel
    {
        [Name("Player Class"), NameIndex(0), JsonProperty]
        public string PlayerClass { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
    }
}
