using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonTypeModel
    {
        [Name("type"), NameIndex(0), JsonProperty]
        public string Type { get; set; } = "";
        
        [Name("equiv1"), NameIndex(0), JsonProperty]
        public string Equiv1 { get; set; } = "";
        
        [Name("equiv2"), NameIndex(0), JsonProperty]
        public string Equiv2 { get; set; } = "";
        
        [Name("equiv3"), NameIndex(0), JsonProperty]
        public string Equiv3 { get; set; } = "";
        
        [Name("strsing"), NameIndex(0), JsonProperty]
        public string Strsing { get; set; } = "";
        
        [Name("strplur"), NameIndex(0), JsonProperty]
        public string Strplur { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
