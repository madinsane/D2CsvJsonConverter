using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class LvlSubModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Type"), NameIndex(0), JsonProperty]
        public string Type { get; set; } = "";
        
        [Name("File"), NameIndex(0), JsonProperty]
        public string File { get; set; } = "";
        
        [Name("Expansion"), NameIndex(0), JsonProperty]
        public string Expansion { get; set; } = "";
        
        [Name("CheckAll"), NameIndex(0), JsonProperty]
        public string Checkall { get; set; } = "";
        
        [Name("BordType"), NameIndex(0), JsonProperty]
        public string Bordtype { get; set; } = "";
        
        [Name("GridSize"), NameIndex(0), JsonProperty]
        public string Gridsize { get; set; } = "";
        
        [Name("Dt1Mask"), NameIndex(0), JsonProperty]
        public string Dt1mask { get; set; } = "";
        
        [Name("Prob0"), NameIndex(0), JsonProperty]
        public string Prob0 { get; set; } = "";
        
        [Name("Trials0"), NameIndex(0), JsonProperty]
        public string Trials0 { get; set; } = "";
        
        [Name("Max0"), NameIndex(0), JsonProperty]
        public string Max0 { get; set; } = "";
        
        [Name("Prob1"), NameIndex(0), JsonProperty]
        public string Prob1 { get; set; } = "";
        
        [Name("Trials1"), NameIndex(0), JsonProperty]
        public string Trials1 { get; set; } = "";
        
        [Name("Max1"), NameIndex(0), JsonProperty]
        public string Max1 { get; set; } = "";
        
        [Name("Prob2"), NameIndex(0), JsonProperty]
        public string Prob2 { get; set; } = "";
        
        [Name("Trials2"), NameIndex(0), JsonProperty]
        public string Trials2 { get; set; } = "";
        
        [Name("Max2"), NameIndex(0), JsonProperty]
        public string Max2 { get; set; } = "";
        
        [Name("Prob3"), NameIndex(0), JsonProperty]
        public string Prob3 { get; set; } = "";
        
        [Name("Trials3"), NameIndex(0), JsonProperty]
        public string Trials3 { get; set; } = "";
        
        [Name("Max3"), NameIndex(0), JsonProperty]
        public string Max3 { get; set; } = "";
        
        [Name("Prob4"), NameIndex(0), JsonProperty]
        public string Prob4 { get; set; } = "";
        
        [Name("Trials4"), NameIndex(0), JsonProperty]
        public string Trials4 { get; set; } = "";
        
        [Name("Max4"), NameIndex(0), JsonProperty]
        public string Max4 { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
    }
}
