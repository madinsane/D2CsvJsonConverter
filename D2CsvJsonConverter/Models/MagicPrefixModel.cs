using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MagicPrefixModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("*comment"), NameIndex(0), JsonProperty]
        public string Comment { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("spawnable"), NameIndex(0), JsonProperty]
        public string Spawnable { get; set; } = "";
        
        [Name("rare"), NameIndex(0), JsonProperty]
        public string Rare { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("maxlevel"), NameIndex(0), JsonProperty]
        public string Maxlevel { get; set; } = "";
        
        [Name("levelreq"), NameIndex(0), JsonProperty]
        public string Levelreq { get; set; } = "";
        
        [Name("classspecific"), NameIndex(0), JsonProperty]
        public string Classspecific { get; set; } = "";
        
        [Name("class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("classlevelreq"), NameIndex(0), JsonProperty]
        public string Classlevelreq { get; set; } = "";
        
        [Name("frequency"), NameIndex(0), JsonProperty]
        public string Frequency { get; set; } = "";
        
        [Name("group"), NameIndex(0), JsonProperty]
        public string Group { get; set; } = "";
        
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
        
        [Name("mod3code"), NameIndex(0), JsonProperty]
        public string Mod3code { get; set; } = "";
        
        [Name("mod3param"), NameIndex(0), JsonProperty]
        public string Mod3param { get; set; } = "";
        
        [Name("mod3min"), NameIndex(0), JsonProperty]
        public string Mod3min { get; set; } = "";
        
        [Name("mod3max"), NameIndex(0), JsonProperty]
        public string Mod3max { get; set; } = "";
        
        [Name("transform"), NameIndex(0), JsonProperty]
        public string Transform { get; set; } = "";
        
        [Name("transformcolor"), NameIndex(0), JsonProperty]
        public string Transformcolor { get; set; } = "";
        
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
        
        [Name("etype5"), NameIndex(0), JsonProperty]
        public string Etype5 { get; set; } = "";
        
        [Name("divide"), NameIndex(0), JsonProperty]
        public string Divide { get; set; } = "";
        
        [Name("multiply"), NameIndex(0), JsonProperty]
        public string Multiply { get; set; } = "";
        
        [Name("add"), NameIndex(0), JsonProperty]
        public string Add { get; set; } = "";
        
    }
}
