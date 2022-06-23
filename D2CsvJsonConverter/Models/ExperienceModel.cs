using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ExperienceModel
    {
        [Name("Level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("Amazon"), NameIndex(0), JsonProperty]
        public string Amazon { get; set; } = "";
        
        [Name("Sorceress"), NameIndex(0), JsonProperty]
        public string Sorceress { get; set; } = "";
        
        [Name("Necromancer"), NameIndex(0), JsonProperty]
        public string Necromancer { get; set; } = "";
        
        [Name("Paladin"), NameIndex(0), JsonProperty]
        public string Paladin { get; set; } = "";
        
        [Name("Barbarian"), NameIndex(0), JsonProperty]
        public string Barbarian { get; set; } = "";
        
        [Name("Druid"), NameIndex(0), JsonProperty]
        public string Druid { get; set; } = "";
        
        [Name("Assassin"), NameIndex(0), JsonProperty]
        public string Assassin { get; set; } = "";
        
        [Name("ExpRatio"), NameIndex(0), JsonProperty]
        public string Expratio { get; set; } = "";
        
    }
}
