using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class CubeMainModel
    {
        [Name("description"), NameIndex(0), JsonProperty]
        public string Description { get; set; } = "";
        
        [Name("enabled"), NameIndex(0), JsonProperty]
        public string Enabled { get; set; } = "";
        
        [Name("ladder"), NameIndex(0), JsonProperty]
        public string Ladder { get; set; } = "";
        
        [Name("min diff"), NameIndex(0), JsonProperty]
        public string MinDiff { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("op"), NameIndex(0), JsonProperty]
        public string Op { get; set; } = "";
        
        [Name("param"), NameIndex(0), JsonProperty]
        public string Param { get; set; } = "";
        
        [Name("value"), NameIndex(0), JsonProperty]
        public string Value { get; set; } = "";
        
        [Name("class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("numinputs"), NameIndex(0), JsonProperty]
        public string Numinputs { get; set; } = "";
        
        [Name("input 1"), NameIndex(0), JsonProperty]
        public string Input1 { get; set; } = "";
        
        [Name("input 2"), NameIndex(0), JsonProperty]
        public string Input2 { get; set; } = "";
        
        [Name("input 3"), NameIndex(0), JsonProperty]
        public string Input3 { get; set; } = "";
        
        [Name("input 4"), NameIndex(0), JsonProperty]
        public string Input4 { get; set; } = "";
        
        [Name("input 5"), NameIndex(0), JsonProperty]
        public string Input5 { get; set; } = "";
        
        [Name("input 6"), NameIndex(0), JsonProperty]
        public string Input6 { get; set; } = "";
        
        [Name("input 7"), NameIndex(0), JsonProperty]
        public string Input7 { get; set; } = "";
        
        [Name("output"), NameIndex(0), JsonProperty]
        public string Output { get; set; } = "";
        
        [Name("lvl"), NameIndex(0), JsonProperty]
        public string Lvl { get; set; } = "";
        
        [Name("plvl"), NameIndex(0), JsonProperty]
        public string Plvl { get; set; } = "";
        
        [Name("ilvl"), NameIndex(0), JsonProperty]
        public string Ilvl { get; set; } = "";
        
        [Name("mod 1"), NameIndex(0), JsonProperty]
        public string Mod1 { get; set; } = "";
        
        [Name("mod 1 chance"), NameIndex(0), JsonProperty]
        public string Mod1Chance { get; set; } = "";
        
        [Name("mod 1 param"), NameIndex(0), JsonProperty]
        public string Mod1Param { get; set; } = "";
        
        [Name("mod 1 min"), NameIndex(0), JsonProperty]
        public string Mod1Min { get; set; } = "";
        
        [Name("mod 1 max"), NameIndex(0), JsonProperty]
        public string Mod1Max { get; set; } = "";
        
        [Name("mod 2"), NameIndex(0), JsonProperty]
        public string Mod2 { get; set; } = "";
        
        [Name("mod 2 chance"), NameIndex(0), JsonProperty]
        public string Mod2Chance { get; set; } = "";
        
        [Name("mod 2 param"), NameIndex(0), JsonProperty]
        public string Mod2Param { get; set; } = "";
        
        [Name("mod 2 min"), NameIndex(0), JsonProperty]
        public string Mod2Min { get; set; } = "";
        
        [Name("mod 2 max"), NameIndex(0), JsonProperty]
        public string Mod2Max { get; set; } = "";
        
        [Name("mod 3"), NameIndex(0), JsonProperty]
        public string Mod3 { get; set; } = "";
        
        [Name("mod 3 chance"), NameIndex(0), JsonProperty]
        public string Mod3Chance { get; set; } = "";
        
        [Name("mod 3 param"), NameIndex(0), JsonProperty]
        public string Mod3Param { get; set; } = "";
        
        [Name("mod 3 min"), NameIndex(0), JsonProperty]
        public string Mod3Min { get; set; } = "";
        
        [Name("mod 3 max"), NameIndex(0), JsonProperty]
        public string Mod3Max { get; set; } = "";
        
        [Name("mod 4"), NameIndex(0), JsonProperty]
        public string Mod4 { get; set; } = "";
        
        [Name("mod 4 chance"), NameIndex(0), JsonProperty]
        public string Mod4Chance { get; set; } = "";
        
        [Name("mod 4 param"), NameIndex(0), JsonProperty]
        public string Mod4Param { get; set; } = "";
        
        [Name("mod 4 min"), NameIndex(0), JsonProperty]
        public string Mod4Min { get; set; } = "";
        
        [Name("mod 4 max"), NameIndex(0), JsonProperty]
        public string Mod4Max { get; set; } = "";
        
        [Name("mod 5"), NameIndex(0), JsonProperty]
        public string Mod5 { get; set; } = "";
        
        [Name("mod 5 chance"), NameIndex(0), JsonProperty]
        public string Mod5Chance { get; set; } = "";
        
        [Name("mod 5 param"), NameIndex(0), JsonProperty]
        public string Mod5Param { get; set; } = "";
        
        [Name("mod 5 min"), NameIndex(0), JsonProperty]
        public string Mod5Min { get; set; } = "";
        
        [Name("mod 5 max"), NameIndex(0), JsonProperty]
        public string Mod5Max { get; set; } = "";
        
        [Name("output b"), NameIndex(0), JsonProperty]
        public string OutputB { get; set; } = "";
        
        [Name("b lvl"), NameIndex(0), JsonProperty]
        public string BLvl { get; set; } = "";
        
        [Name("b plvl"), NameIndex(0), JsonProperty]
        public string BPlvl { get; set; } = "";
        
        [Name("b ilvl"), NameIndex(0), JsonProperty]
        public string BIlvl { get; set; } = "";
        
        [Name("b mod 1"), NameIndex(0), JsonProperty]
        public string BMod1 { get; set; } = "";
        
        [Name("b mod 1 chance"), NameIndex(0), JsonProperty]
        public string BMod1Chance { get; set; } = "";
        
        [Name("b mod 1 param"), NameIndex(0), JsonProperty]
        public string BMod1Param { get; set; } = "";
        
        [Name("b mod 1 min"), NameIndex(0), JsonProperty]
        public string BMod1Min { get; set; } = "";
        
        [Name("b mod 1 max"), NameIndex(0), JsonProperty]
        public string BMod1Max { get; set; } = "";
        
        [Name("b mod 2"), NameIndex(0), JsonProperty]
        public string BMod2 { get; set; } = "";
        
        [Name("b mod 2 chance"), NameIndex(0), JsonProperty]
        public string BMod2Chance { get; set; } = "";
        
        [Name("b mod 2 param"), NameIndex(0), JsonProperty]
        public string BMod2Param { get; set; } = "";
        
        [Name("b mod 2 min"), NameIndex(0), JsonProperty]
        public string BMod2Min { get; set; } = "";
        
        [Name("b mod 2 max"), NameIndex(0), JsonProperty]
        public string BMod2Max { get; set; } = "";
        
        [Name("b mod 3"), NameIndex(0), JsonProperty]
        public string BMod3 { get; set; } = "";
        
        [Name("b mod 3 chance"), NameIndex(0), JsonProperty]
        public string BMod3Chance { get; set; } = "";
        
        [Name("b mod 3 param"), NameIndex(0), JsonProperty]
        public string BMod3Param { get; set; } = "";
        
        [Name("b mod 3 min"), NameIndex(0), JsonProperty]
        public string BMod3Min { get; set; } = "";
        
        [Name("b mod 3 max"), NameIndex(0), JsonProperty]
        public string BMod3Max { get; set; } = "";
        
        [Name("b mod 4"), NameIndex(0), JsonProperty]
        public string BMod4 { get; set; } = "";
        
        [Name("b mod 4 chance"), NameIndex(0), JsonProperty]
        public string BMod4Chance { get; set; } = "";
        
        [Name("b mod 4 param"), NameIndex(0), JsonProperty]
        public string BMod4Param { get; set; } = "";
        
        [Name("b mod 4 min"), NameIndex(0), JsonProperty]
        public string BMod4Min { get; set; } = "";
        
        [Name("b mod 4 max"), NameIndex(0), JsonProperty]
        public string BMod4Max { get; set; } = "";
        
        [Name("b mod 5"), NameIndex(0), JsonProperty]
        public string BMod5 { get; set; } = "";
        
        [Name("b mod 5 chance"), NameIndex(0), JsonProperty]
        public string BMod5Chance { get; set; } = "";
        
        [Name("b mod 5 param"), NameIndex(0), JsonProperty]
        public string BMod5Param { get; set; } = "";
        
        [Name("b mod 5 min"), NameIndex(0), JsonProperty]
        public string BMod5Min { get; set; } = "";
        
        [Name("b mod 5 max"), NameIndex(0), JsonProperty]
        public string BMod5Max { get; set; } = "";
        
        [Name("output c"), NameIndex(0), JsonProperty]
        public string OutputC { get; set; } = "";
        
        [Name("c lvl"), NameIndex(0), JsonProperty]
        public string CLvl { get; set; } = "";
        
        [Name("c plvl"), NameIndex(0), JsonProperty]
        public string CPlvl { get; set; } = "";
        
        [Name("c ilvl"), NameIndex(0), JsonProperty]
        public string CIlvl { get; set; } = "";
        
        [Name("c mod 1"), NameIndex(0), JsonProperty]
        public string CMod1 { get; set; } = "";
        
        [Name("c mod 1 chance"), NameIndex(0), JsonProperty]
        public string CMod1Chance { get; set; } = "";
        
        [Name("c mod 1 param"), NameIndex(0), JsonProperty]
        public string CMod1Param { get; set; } = "";
        
        [Name("c mod 1 min"), NameIndex(0), JsonProperty]
        public string CMod1Min { get; set; } = "";
        
        [Name("c mod 1 max"), NameIndex(0), JsonProperty]
        public string CMod1Max { get; set; } = "";
        
        [Name("c mod 2"), NameIndex(0), JsonProperty]
        public string CMod2 { get; set; } = "";
        
        [Name("c mod 2 chance"), NameIndex(0), JsonProperty]
        public string CMod2Chance { get; set; } = "";
        
        [Name("c mod 2 param"), NameIndex(0), JsonProperty]
        public string CMod2Param { get; set; } = "";
        
        [Name("c mod 2 min"), NameIndex(0), JsonProperty]
        public string CMod2Min { get; set; } = "";
        
        [Name("c mod 2 max"), NameIndex(0), JsonProperty]
        public string CMod2Max { get; set; } = "";
        
        [Name("c mod 3"), NameIndex(0), JsonProperty]
        public string CMod3 { get; set; } = "";
        
        [Name("c mod 3 chance"), NameIndex(0), JsonProperty]
        public string CMod3Chance { get; set; } = "";
        
        [Name("c mod 3 param"), NameIndex(0), JsonProperty]
        public string CMod3Param { get; set; } = "";
        
        [Name("c mod 3 min"), NameIndex(0), JsonProperty]
        public string CMod3Min { get; set; } = "";
        
        [Name("c mod 3 max"), NameIndex(0), JsonProperty]
        public string CMod3Max { get; set; } = "";
        
        [Name("c mod 4"), NameIndex(0), JsonProperty]
        public string CMod4 { get; set; } = "";
        
        [Name("c mod 4 chance"), NameIndex(0), JsonProperty]
        public string CMod4Chance { get; set; } = "";
        
        [Name("c mod 4 param"), NameIndex(0), JsonProperty]
        public string CMod4Param { get; set; } = "";
        
        [Name("c mod 4 min"), NameIndex(0), JsonProperty]
        public string CMod4Min { get; set; } = "";
        
        [Name("c mod 4 max"), NameIndex(0), JsonProperty]
        public string CMod4Max { get; set; } = "";
        
        [Name("c mod 5"), NameIndex(0), JsonProperty]
        public string CMod5 { get; set; } = "";
        
        [Name("c mod 5 chance"), NameIndex(0), JsonProperty]
        public string CMod5Chance { get; set; } = "";
        
        [Name("c mod 5 param"), NameIndex(0), JsonProperty]
        public string CMod5Param { get; set; } = "";
        
        [Name("c mod 5 min"), NameIndex(0), JsonProperty]
        public string CMod5Min { get; set; } = "";
        
        [Name("c mod 5 max"), NameIndex(0), JsonProperty]
        public string CMod5Max { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
