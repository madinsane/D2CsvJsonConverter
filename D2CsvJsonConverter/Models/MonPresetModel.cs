using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonPresetModel
    {
        [Name("Act"), NameIndex(0), JsonProperty]
        public string Act { get; set; } = "";
        
        [Name("Place"), NameIndex(0), JsonProperty]
        public string Place { get; set; } = "";
        
    }
}
