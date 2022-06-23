using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SuperUniquesModel
    {
        [Name("Superunique"), NameIndex(0), JsonProperty]
        public string Superunique { get; set; } = "";
        
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("hcIdx"), NameIndex(0), JsonProperty]
        public string Hcidx { get; set; } = "";
        
        [Name("MonSound"), NameIndex(0), JsonProperty]
        public string Monsound { get; set; } = "";
        
        [Name("Mod1"), NameIndex(0), JsonProperty]
        public string Mod1 { get; set; } = "";
        
        [Name("Mod2"), NameIndex(0), JsonProperty]
        public string Mod2 { get; set; } = "";
        
        [Name("Mod3"), NameIndex(0), JsonProperty]
        public string Mod3 { get; set; } = "";
        
        [Name("MinGrp"), NameIndex(0), JsonProperty]
        public string Mingrp { get; set; } = "";
        
        [Name("MaxGrp"), NameIndex(0), JsonProperty]
        public string Maxgrp { get; set; } = "";
        
        [Name("EClass"), NameIndex(0), JsonProperty]
        public string Eclass { get; set; } = "";
        
        [Name("AutoPos"), NameIndex(0), JsonProperty]
        public string Autopos { get; set; } = "";
        
        [Name("Stacks"), NameIndex(0), JsonProperty]
        public string Stacks { get; set; } = "";
        
        [Name("Replaceable"), NameIndex(0), JsonProperty]
        public string Replaceable { get; set; } = "";
        
        [Name("Utrans"), NameIndex(0), JsonProperty]
        public string Utrans { get; set; } = "";
        
        [Name("Utrans(N)"), NameIndex(0), JsonProperty]
        public string UtransN { get; set; } = "";
        
        [Name("Utrans(H)"), NameIndex(0), JsonProperty]
        public string UtransH { get; set; } = "";
        
        [Name("TC"), NameIndex(0), JsonProperty]
        public string TC { get; set; } = "";
        
        [Name("TC(N)"), NameIndex(0), JsonProperty]
        public string TCN { get; set; } = "";
        
        [Name("TC(H)"), NameIndex(0), JsonProperty]
        public string TCH { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
