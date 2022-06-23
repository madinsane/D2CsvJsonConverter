using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class QualityItemsModel
    {
        [Name("nummods"), NameIndex(0), JsonProperty]
        public string Nummods { get; set; } = "";
        
        [Name("mod1code"), NameIndex(0), JsonProperty]
        public string Mod1code { get; set; } = "";
        
        [Name("mod1param"), NameIndex(0), JsonProperty]
        public string Mod1param { get; set; } = "";
        
        [Name("mod1min"), NameIndex(0), JsonProperty]
        public string Mod1min { get; set; } = "";
        
        [Name("mod1max"), NameIndex(0), JsonProperty]
        public string Mod1max { get; set; } = "";
        
        [Name("mod2code"), NameIndex(0), JsonProperty]
        public string Mod2code { get; set; } = "";
        
        [Name("mod2param"), NameIndex(0), JsonProperty]
        public string Mod2param { get; set; } = "";
        
        [Name("mod2min"), NameIndex(0), JsonProperty]
        public string Mod2min { get; set; } = "";
        
        [Name("mod2max"), NameIndex(0), JsonProperty]
        public string Mod2max { get; set; } = "";
        
        [Name("ToHitMin"), NameIndex(0), JsonProperty]
        public string Tohitmin { get; set; } = "";
        
        [Name("ToHitMax"), NameIndex(0), JsonProperty]
        public string Tohitmax { get; set; } = "";
        
        [Name("Dam%Min"), NameIndex(0), JsonProperty]
        public string DamMin { get; set; } = "";
        
        [Name("Dam%Max"), NameIndex(0), JsonProperty]
        public string DamMax { get; set; } = "";
        
        [Name("AC%Min"), NameIndex(0), JsonProperty]
        public string ACMin { get; set; } = "";
        
        [Name("AC%Max"), NameIndex(0), JsonProperty]
        public string ACMax { get; set; } = "";
        
        [Name("Dur%Min"), NameIndex(0), JsonProperty]
        public string DurMin { get; set; } = "";
        
        [Name("Dur%Max"), NameIndex(0), JsonProperty]
        public string DurMax { get; set; } = "";
        
        [Name("effect1"), NameIndex(0), JsonProperty]
        public string Effect1 { get; set; } = "";
        
        [Name("effect2"), NameIndex(0), JsonProperty]
        public string Effect2 { get; set; } = "";
        
        [Name("armor"), NameIndex(0), JsonProperty]
        public string Armor { get; set; } = "";
        
        [Name("weapon"), NameIndex(0), JsonProperty]
        public string Weapon { get; set; } = "";
        
        [Name("shield"), NameIndex(0), JsonProperty]
        public string Shield { get; set; } = "";
        
        [Name("thrown"), NameIndex(0), JsonProperty]
        public string Thrown { get; set; } = "";
        
        [Name("scepter"), NameIndex(0), JsonProperty]
        public string Scepter { get; set; } = "";
        
        [Name("wand"), NameIndex(0), JsonProperty]
        public string Wand { get; set; } = "";
        
        [Name("staff"), NameIndex(0), JsonProperty]
        public string Staff { get; set; } = "";
        
        [Name("bow"), NameIndex(0), JsonProperty]
        public string Bow { get; set; } = "";
        
        [Name("boots"), NameIndex(0), JsonProperty]
        public string Boots { get; set; } = "";
        
        [Name("gloves"), NameIndex(0), JsonProperty]
        public string Gloves { get; set; } = "";
        
        [Name("belt"), NameIndex(0), JsonProperty]
        public string Belt { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("multiply"), NameIndex(0), JsonProperty]
        public string Multiply { get; set; } = "";
        
        [Name("add"), NameIndex(0), JsonProperty]
        public string Add { get; set; } = "";
        
    }
}
