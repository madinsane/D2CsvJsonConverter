using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class CompCodeModel
    {
        [Name("component"), NameIndex(0), JsonProperty]
        public string Component { get; set; } = "";
        
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
    }
}
