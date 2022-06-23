using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class RareSuffixModel
    {
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("itype1"), NameIndex(0), JsonProperty]
        public string Itype1 { get; set; } = "";
        
        [Name("itype2"), NameIndex(0), JsonProperty]
        public string Itype2 { get; set; } = "";
        
        [Name("itype3"), NameIndex(0), JsonProperty]
        public string Itype3 { get; set; } = "";
        
        [Name("itype4"), NameIndex(0), JsonProperty]
        public string Itype4 { get; set; } = "";
        
        [Name("itype5"), NameIndex(0), JsonProperty]
        public string Itype5 { get; set; } = "";
        
        [Name("itype6"), NameIndex(0), JsonProperty]
        public string Itype6 { get; set; } = "";
        
        [Name("itype7"), NameIndex(0), JsonProperty]
        public string Itype7 { get; set; } = "";
        
        [Name("etype1"), NameIndex(0), JsonProperty]
        public string Etype1 { get; set; } = "";
        
        [Name("etype2"), NameIndex(0), JsonProperty]
        public string Etype2 { get; set; } = "";
        
        [Name("etype3"), NameIndex(0), JsonProperty]
        public string Etype3 { get; set; } = "";
        
        [Name("etype4"), NameIndex(0), JsonProperty]
        public string Etype4 { get; set; } = "";
        
        [Name("add"), NameIndex(0), JsonProperty]
        public string Add { get; set; } = "";
        
        [Name("multiply"), NameIndex(0), JsonProperty]
        public string Multiply { get; set; } = "";
        
        [Name("divide"), NameIndex(0), JsonProperty]
        public string Divide { get; set; } = "";
        
    }
}
