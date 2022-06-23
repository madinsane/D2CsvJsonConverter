using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ObjGroupModel
    {
        [Name("GroupName"), NameIndex(0), JsonProperty]
        public string Groupname { get; set; } = "";
        
        [Name("Offset"), NameIndex(0), JsonProperty]
        public string Offset { get; set; } = "";
        
        [Name("ID0"), NameIndex(0), JsonProperty]
        public string ID0 { get; set; } = "";
        
        [Name("DENSITY0"), NameIndex(0), JsonProperty]
        public string DENSITY0 { get; set; } = "";
        
        [Name("PROB0"), NameIndex(0), JsonProperty]
        public string PROB0 { get; set; } = "";
        
        [Name("ID1"), NameIndex(0), JsonProperty]
        public string ID1 { get; set; } = "";
        
        [Name("DENSITY1"), NameIndex(0), JsonProperty]
        public string DENSITY1 { get; set; } = "";
        
        [Name("PROB1"), NameIndex(0), JsonProperty]
        public string PROB1 { get; set; } = "";
        
        [Name("ID2"), NameIndex(0), JsonProperty]
        public string ID2 { get; set; } = "";
        
        [Name("DENSITY2"), NameIndex(0), JsonProperty]
        public string DENSITY2 { get; set; } = "";
        
        [Name("PROB2"), NameIndex(0), JsonProperty]
        public string PROB2 { get; set; } = "";
        
        [Name("ID3"), NameIndex(0), JsonProperty]
        public string ID3 { get; set; } = "";
        
        [Name("DENSITY3"), NameIndex(0), JsonProperty]
        public string DENSITY3 { get; set; } = "";
        
        [Name("PROB3"), NameIndex(0), JsonProperty]
        public string PROB3 { get; set; } = "";
        
        [Name("ID4"), NameIndex(0), JsonProperty]
        public string ID4 { get; set; } = "";
        
        [Name("DENSITY4"), NameIndex(0), JsonProperty]
        public string DENSITY4 { get; set; } = "";
        
        [Name("PROB4"), NameIndex(0), JsonProperty]
        public string PROB4 { get; set; } = "";
        
        [Name("ID5"), NameIndex(0), JsonProperty]
        public string ID5 { get; set; } = "";
        
        [Name("DENSITY5"), NameIndex(0), JsonProperty]
        public string DENSITY5 { get; set; } = "";
        
        [Name("PROB5"), NameIndex(0), JsonProperty]
        public string PROB5 { get; set; } = "";
        
        [Name("ID6"), NameIndex(0), JsonProperty]
        public string ID6 { get; set; } = "";
        
        [Name("DENSITY6"), NameIndex(0), JsonProperty]
        public string DENSITY6 { get; set; } = "";
        
        [Name("PROB6"), NameIndex(0), JsonProperty]
        public string PROB6 { get; set; } = "";
        
        [Name("ID7"), NameIndex(0), JsonProperty]
        public string ID7 { get; set; } = "";
        
        [Name("DENSITY7"), NameIndex(0), JsonProperty]
        public string DENSITY7 { get; set; } = "";
        
        [Name("PROB7"), NameIndex(0), JsonProperty]
        public string PROB7 { get; set; } = "";
        
        [Name("SHRINES"), NameIndex(0), JsonProperty]
        public string SHRINES { get; set; } = "";
        
        [Name("WELLS"), NameIndex(0), JsonProperty]
        public string WELLS { get; set; } = "";
        
    }
}
