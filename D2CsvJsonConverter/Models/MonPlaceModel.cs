using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonPlaceModel
    {
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
    }
}
