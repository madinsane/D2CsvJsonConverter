using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ShrinesModel
    {
        [Name("Shrine Type"), NameIndex(0), JsonProperty]
        public string ShrineType { get; set; } = "";
        
        [Name("Shrine name"), NameIndex(0), JsonProperty]
        public string ShrineName { get; set; } = "";
        
        [Name("Effect"), NameIndex(0), JsonProperty]
        public string Effect { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("Arg0"), NameIndex(0), JsonProperty]
        public string Arg0 { get; set; } = "";
        
        [Name("Arg1"), NameIndex(0), JsonProperty]
        public string Arg1 { get; set; } = "";
        
        [Name("Duration in frames"), NameIndex(0), JsonProperty]
        public string DurationInFrames { get; set; } = "";
        
        [Name("reset time in minutes"), NameIndex(0), JsonProperty]
        public string ResetTimeInMinutes { get; set; } = "";
        
        [Name("rarity"), NameIndex(0), JsonProperty]
        public string Rarity { get; set; } = "";
        
        [Name("view name"), NameIndex(0), JsonProperty]
        public string ViewName { get; set; } = "";
        
        [Name("niftyphrase"), NameIndex(0), JsonProperty]
        public string Niftyphrase { get; set; } = "";
        
        [Name("effectclass"), NameIndex(0), JsonProperty]
        public string Effectclass { get; set; } = "";
        
        [Name("LevelMin"), NameIndex(0), JsonProperty]
        public string Levelmin { get; set; } = "";
        
    }
}
