using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class AutoMapModel
    {
        [Name("LevelName"), NameIndex(0), JsonProperty]
        public string Levelname { get; set; } = "";
        
        [Name("TileName"), NameIndex(0), JsonProperty]
        public string Tilename { get; set; } = "";
        
        [Name("Style"), NameIndex(0), JsonProperty]
        public string Style { get; set; } = "";
        
        [Name("StartSequence"), NameIndex(0), JsonProperty]
        public string Startsequence { get; set; } = "";
        
        [Name("EndSequence"), NameIndex(0), JsonProperty]
        public string Endsequence { get; set; } = "";
        
        [Name("Type1"), NameIndex(0), JsonProperty]
        public string Type1 { get; set; } = "";
        
        [Name("Cel1"), NameIndex(0), JsonProperty]
        public string Cel1 { get; set; } = "";
        
        [Name("Type2"), NameIndex(0), JsonProperty]
        public string Type2 { get; set; } = "";
        
        [Name("Cel2"), NameIndex(0), JsonProperty]
        public string Cel2 { get; set; } = "";
        
        [Name("Type2"), NameIndex(1), JsonProperty]
        public string Type21 { get; set; } = "";
        
        [Name("Cel3"), NameIndex(0), JsonProperty]
        public string Cel3 { get; set; } = "";
        
        [Name("Type4"), NameIndex(0), JsonProperty]
        public string Type4 { get; set; } = "";
        
        [Name("Cel4"), NameIndex(0), JsonProperty]
        public string Cel4 { get; set; } = "";
        
    }
}
