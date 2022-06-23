using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class UniqueItemsModel
    {
        [Name("index"), NameIndex(0), JsonProperty]
        public string Index { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("enabled"), NameIndex(0), JsonProperty]
        public string Enabled { get; set; } = "";
        
        [Name("ladder"), NameIndex(0), JsonProperty]
        public string Ladder { get; set; } = "";
        
        [Name("rarity"), NameIndex(0), JsonProperty]
        public string Rarity { get; set; } = "";
        
        [Name("nolimit"), NameIndex(0), JsonProperty]
        public string Nolimit { get; set; } = "";
        
        [Name("lvl"), NameIndex(0), JsonProperty]
        public string Lvl { get; set; } = "";
        
        [Name("lvl req"), NameIndex(0), JsonProperty]
        public string LvlReq { get; set; } = "";
        
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("*type"), NameIndex(0), JsonProperty]
        public string Type { get; set; } = "";
        
        [Name("*uber"), NameIndex(0), JsonProperty]
        public string Uber { get; set; } = "";
        
        [Name("carry1"), NameIndex(0), JsonProperty]
        public string Carry1 { get; set; } = "";
        
        [Name("cost mult"), NameIndex(0), JsonProperty]
        public string CostMult { get; set; } = "";
        
        [Name("cost add"), NameIndex(0), JsonProperty]
        public string CostAdd { get; set; } = "";
        
        [Name("chrtransform"), NameIndex(0), JsonProperty]
        public string Chrtransform { get; set; } = "";
        
        [Name("invtransform"), NameIndex(0), JsonProperty]
        public string Invtransform { get; set; } = "";
        
        [Name("flippyfile"), NameIndex(0), JsonProperty]
        public string Flippyfile { get; set; } = "";
        
        [Name("invfile"), NameIndex(0), JsonProperty]
        public string Invfile { get; set; } = "";
        
        [Name("dropsound"), NameIndex(0), JsonProperty]
        public string Dropsound { get; set; } = "";
        
        [Name("dropsfxframe"), NameIndex(0), JsonProperty]
        public string Dropsfxframe { get; set; } = "";
        
        [Name("usesound"), NameIndex(0), JsonProperty]
        public string Usesound { get; set; } = "";
        
        [Name("prop1"), NameIndex(0), JsonProperty]
        public string Prop1 { get; set; } = "";
        
        [Name("par1"), NameIndex(0), JsonProperty]
        public string Par1 { get; set; } = "";
        
        [Name("min1"), NameIndex(0), JsonProperty]
        public string Min1 { get; set; } = "";
        
        [Name("max1"), NameIndex(0), JsonProperty]
        public string Max1 { get; set; } = "";
        
        [Name("prop2"), NameIndex(0), JsonProperty]
        public string Prop2 { get; set; } = "";
        
        [Name("par2"), NameIndex(0), JsonProperty]
        public string Par2 { get; set; } = "";
        
        [Name("min2"), NameIndex(0), JsonProperty]
        public string Min2 { get; set; } = "";
        
        [Name("max2"), NameIndex(0), JsonProperty]
        public string Max2 { get; set; } = "";
        
        [Name("prop3"), NameIndex(0), JsonProperty]
        public string Prop3 { get; set; } = "";
        
        [Name("par3"), NameIndex(0), JsonProperty]
        public string Par3 { get; set; } = "";
        
        [Name("min3"), NameIndex(0), JsonProperty]
        public string Min3 { get; set; } = "";
        
        [Name("max3"), NameIndex(0), JsonProperty]
        public string Max3 { get; set; } = "";
        
        [Name("prop4"), NameIndex(0), JsonProperty]
        public string Prop4 { get; set; } = "";
        
        [Name("par4"), NameIndex(0), JsonProperty]
        public string Par4 { get; set; } = "";
        
        [Name("min4"), NameIndex(0), JsonProperty]
        public string Min4 { get; set; } = "";
        
        [Name("max4"), NameIndex(0), JsonProperty]
        public string Max4 { get; set; } = "";
        
        [Name("prop5"), NameIndex(0), JsonProperty]
        public string Prop5 { get; set; } = "";
        
        [Name("par5"), NameIndex(0), JsonProperty]
        public string Par5 { get; set; } = "";
        
        [Name("min5"), NameIndex(0), JsonProperty]
        public string Min5 { get; set; } = "";
        
        [Name("max5"), NameIndex(0), JsonProperty]
        public string Max5 { get; set; } = "";
        
        [Name("prop6"), NameIndex(0), JsonProperty]
        public string Prop6 { get; set; } = "";
        
        [Name("par6"), NameIndex(0), JsonProperty]
        public string Par6 { get; set; } = "";
        
        [Name("min6"), NameIndex(0), JsonProperty]
        public string Min6 { get; set; } = "";
        
        [Name("max6"), NameIndex(0), JsonProperty]
        public string Max6 { get; set; } = "";
        
        [Name("prop7"), NameIndex(0), JsonProperty]
        public string Prop7 { get; set; } = "";
        
        [Name("par7"), NameIndex(0), JsonProperty]
        public string Par7 { get; set; } = "";
        
        [Name("min7"), NameIndex(0), JsonProperty]
        public string Min7 { get; set; } = "";
        
        [Name("max7"), NameIndex(0), JsonProperty]
        public string Max7 { get; set; } = "";
        
        [Name("prop8"), NameIndex(0), JsonProperty]
        public string Prop8 { get; set; } = "";
        
        [Name("par8"), NameIndex(0), JsonProperty]
        public string Par8 { get; set; } = "";
        
        [Name("min8"), NameIndex(0), JsonProperty]
        public string Min8 { get; set; } = "";
        
        [Name("max8"), NameIndex(0), JsonProperty]
        public string Max8 { get; set; } = "";
        
        [Name("prop9"), NameIndex(0), JsonProperty]
        public string Prop9 { get; set; } = "";
        
        [Name("par9"), NameIndex(0), JsonProperty]
        public string Par9 { get; set; } = "";
        
        [Name("min9"), NameIndex(0), JsonProperty]
        public string Min9 { get; set; } = "";
        
        [Name("max9"), NameIndex(0), JsonProperty]
        public string Max9 { get; set; } = "";
        
        [Name("prop10"), NameIndex(0), JsonProperty]
        public string Prop10 { get; set; } = "";
        
        [Name("par10"), NameIndex(0), JsonProperty]
        public string Par10 { get; set; } = "";
        
        [Name("min10"), NameIndex(0), JsonProperty]
        public string Min10 { get; set; } = "";
        
        [Name("max10"), NameIndex(0), JsonProperty]
        public string Max10 { get; set; } = "";
        
        [Name("prop11"), NameIndex(0), JsonProperty]
        public string Prop11 { get; set; } = "";
        
        [Name("par11"), NameIndex(0), JsonProperty]
        public string Par11 { get; set; } = "";
        
        [Name("min11"), NameIndex(0), JsonProperty]
        public string Min11 { get; set; } = "";
        
        [Name("max11"), NameIndex(0), JsonProperty]
        public string Max11 { get; set; } = "";
        
        [Name("prop12"), NameIndex(0), JsonProperty]
        public string Prop12 { get; set; } = "";
        
        [Name("par12"), NameIndex(0), JsonProperty]
        public string Par12 { get; set; } = "";
        
        [Name("min12"), NameIndex(0), JsonProperty]
        public string Min12 { get; set; } = "";
        
        [Name("max12"), NameIndex(0), JsonProperty]
        public string Max12 { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
