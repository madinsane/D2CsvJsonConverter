using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonEquipModel
    {
        [Name("monster"), NameIndex(0), JsonProperty]
        public string Monster { get; set; } = "";
        
        [Name("oninit"), NameIndex(0), JsonProperty]
        public string Oninit { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("item1"), NameIndex(0), JsonProperty]
        public string Item1 { get; set; } = "";
        
        [Name("loc1"), NameIndex(0), JsonProperty]
        public string Loc1 { get; set; } = "";
        
        [Name("mod1"), NameIndex(0), JsonProperty]
        public string Mod1 { get; set; } = "";
        
        [Name("item2"), NameIndex(0), JsonProperty]
        public string Item2 { get; set; } = "";
        
        [Name("loc2"), NameIndex(0), JsonProperty]
        public string Loc2 { get; set; } = "";
        
        [Name("mod2"), NameIndex(0), JsonProperty]
        public string Mod2 { get; set; } = "";
        
        [Name("item3"), NameIndex(0), JsonProperty]
        public string Item3 { get; set; } = "";
        
        [Name("loc3"), NameIndex(0), JsonProperty]
        public string Loc3 { get; set; } = "";
        
        [Name("mod3"), NameIndex(0), JsonProperty]
        public string Mod3 { get; set; } = "";
        
        [Name("eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
