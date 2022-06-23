using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ColorsModel
    {
        [Name("Transform Color"), NameIndex(0), JsonProperty]
        public string TransformColor { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
    }
}
