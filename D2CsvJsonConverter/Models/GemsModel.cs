using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class GemsModel
    {
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("letter"), NameIndex(0), JsonProperty]
        public string Letter { get; set; } = "";
        
        [Name("transform"), NameIndex(0), JsonProperty]
        public string Transform { get; set; } = "";
        
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("nummods"), NameIndex(0), JsonProperty]
        public string Nummods { get; set; } = "";
        
        [Name("weaponMod1Code"), NameIndex(0), JsonProperty]
        public string Weaponmod1code { get; set; } = "";
        
        [Name("weaponMod1Param"), NameIndex(0), JsonProperty]
        public string Weaponmod1param { get; set; } = "";
        
        [Name("weaponMod1Min"), NameIndex(0), JsonProperty]
        public string Weaponmod1min { get; set; } = "";
        
        [Name("weaponMod1Max"), NameIndex(0), JsonProperty]
        public string Weaponmod1max { get; set; } = "";
        
        [Name("weaponMod2Code"), NameIndex(0), JsonProperty]
        public string Weaponmod2code { get; set; } = "";
        
        [Name("weaponMod2Param"), NameIndex(0), JsonProperty]
        public string Weaponmod2param { get; set; } = "";
        
        [Name("weaponMod2Min"), NameIndex(0), JsonProperty]
        public string Weaponmod2min { get; set; } = "";
        
        [Name("weaponMod2Max"), NameIndex(0), JsonProperty]
        public string Weaponmod2max { get; set; } = "";
        
        [Name("weaponMod3Code"), NameIndex(0), JsonProperty]
        public string Weaponmod3code { get; set; } = "";
        
        [Name("weaponMod3Param"), NameIndex(0), JsonProperty]
        public string Weaponmod3param { get; set; } = "";
        
        [Name("weaponMod3Min"), NameIndex(0), JsonProperty]
        public string Weaponmod3min { get; set; } = "";
        
        [Name("weaponMod3Max"), NameIndex(0), JsonProperty]
        public string Weaponmod3max { get; set; } = "";
        
        [Name("helmMod1Code"), NameIndex(0), JsonProperty]
        public string Helmmod1code { get; set; } = "";
        
        [Name("helmMod1Param"), NameIndex(0), JsonProperty]
        public string Helmmod1param { get; set; } = "";
        
        [Name("helmMod1Min"), NameIndex(0), JsonProperty]
        public string Helmmod1min { get; set; } = "";
        
        [Name("helmMod1Max"), NameIndex(0), JsonProperty]
        public string Helmmod1max { get; set; } = "";
        
        [Name("helmMod2Code"), NameIndex(0), JsonProperty]
        public string Helmmod2code { get; set; } = "";
        
        [Name("helmMod2Param"), NameIndex(0), JsonProperty]
        public string Helmmod2param { get; set; } = "";
        
        [Name("helmMod2Min"), NameIndex(0), JsonProperty]
        public string Helmmod2min { get; set; } = "";
        
        [Name("helmMod2Max"), NameIndex(0), JsonProperty]
        public string Helmmod2max { get; set; } = "";
        
        [Name("helmMod3Code"), NameIndex(0), JsonProperty]
        public string Helmmod3code { get; set; } = "";
        
        [Name("helmMod3Param"), NameIndex(0), JsonProperty]
        public string Helmmod3param { get; set; } = "";
        
        [Name("helmMod3Min"), NameIndex(0), JsonProperty]
        public string Helmmod3min { get; set; } = "";
        
        [Name("helmMod3Max"), NameIndex(0), JsonProperty]
        public string Helmmod3max { get; set; } = "";
        
        [Name("shieldMod1Code"), NameIndex(0), JsonProperty]
        public string Shieldmod1code { get; set; } = "";
        
        [Name("shieldMod1Param"), NameIndex(0), JsonProperty]
        public string Shieldmod1param { get; set; } = "";
        
        [Name("shieldMod1Min"), NameIndex(0), JsonProperty]
        public string Shieldmod1min { get; set; } = "";
        
        [Name("shieldMod1Max"), NameIndex(0), JsonProperty]
        public string Shieldmod1max { get; set; } = "";
        
        [Name("shieldMod2Code"), NameIndex(0), JsonProperty]
        public string Shieldmod2code { get; set; } = "";
        
        [Name("shieldMod2Param"), NameIndex(0), JsonProperty]
        public string Shieldmod2param { get; set; } = "";
        
        [Name("shieldMod2Min"), NameIndex(0), JsonProperty]
        public string Shieldmod2min { get; set; } = "";
        
        [Name("shieldMod2Max"), NameIndex(0), JsonProperty]
        public string Shieldmod2max { get; set; } = "";
        
        [Name("shieldMod3Code"), NameIndex(0), JsonProperty]
        public string Shieldmod3code { get; set; } = "";
        
        [Name("shieldMod3Param"), NameIndex(0), JsonProperty]
        public string Shieldmod3param { get; set; } = "";
        
        [Name("shieldMod3Min"), NameIndex(0), JsonProperty]
        public string Shieldmod3min { get; set; } = "";
        
        [Name("shieldMod3Max"), NameIndex(0), JsonProperty]
        public string Shieldmod3max { get; set; } = "";
        
    }
}
