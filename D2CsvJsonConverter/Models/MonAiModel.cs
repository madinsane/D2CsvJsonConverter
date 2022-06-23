using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonAiModel
    {
        [Name("AI"), NameIndex(0), JsonProperty]
        public string AI { get; set; } = "";
        
        [Name("*aip1"), NameIndex(0), JsonProperty]
        public string Aip1 { get; set; } = "";
        
        [Name("*aip2"), NameIndex(0), JsonProperty]
        public string Aip2 { get; set; } = "";
        
        [Name("*aip3"), NameIndex(0), JsonProperty]
        public string Aip3 { get; set; } = "";
        
        [Name("*aip4"), NameIndex(0), JsonProperty]
        public string Aip4 { get; set; } = "";
        
        [Name("*aip5"), NameIndex(0), JsonProperty]
        public string Aip5 { get; set; } = "";
        
        [Name("*aip6"), NameIndex(0), JsonProperty]
        public string Aip6 { get; set; } = "";
        
        [Name("*aip7"), NameIndex(0), JsonProperty]
        public string Aip7 { get; set; } = "";
        
        [Name("*aip8"), NameIndex(0), JsonProperty]
        public string Aip8 { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
