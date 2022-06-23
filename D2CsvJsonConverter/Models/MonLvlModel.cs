using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonLvlModel
    {
        [Name("Level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("AC"), NameIndex(0), JsonProperty]
        public string AC { get; set; } = "";
        
        [Name("AC(N)"), NameIndex(0), JsonProperty]
        public string ACN { get; set; } = "";
        
        [Name("AC(H)"), NameIndex(0), JsonProperty]
        public string ACH { get; set; } = "";
        
        [Name("L-AC"), NameIndex(0), JsonProperty]
        public string LAC { get; set; } = "";
        
        [Name("L-AC(N)"), NameIndex(0), JsonProperty]
        public string LACN { get; set; } = "";
        
        [Name("L-AC(H)"), NameIndex(0), JsonProperty]
        public string LACH { get; set; } = "";
        
        [Name("TH"), NameIndex(0), JsonProperty]
        public string TH { get; set; } = "";
        
        [Name("TH(N)"), NameIndex(0), JsonProperty]
        public string THN { get; set; } = "";
        
        [Name("TH(H)"), NameIndex(0), JsonProperty]
        public string THH { get; set; } = "";
        
        [Name("L-TH"), NameIndex(0), JsonProperty]
        public string LTH { get; set; } = "";
        
        [Name("L-TH(N)"), NameIndex(0), JsonProperty]
        public string LTHN { get; set; } = "";
        
        [Name("L-TH(H)"), NameIndex(0), JsonProperty]
        public string LTHH { get; set; } = "";
        
        [Name("HP"), NameIndex(0), JsonProperty]
        public string HP { get; set; } = "";
        
        [Name("HP(N)"), NameIndex(0), JsonProperty]
        public string HPN { get; set; } = "";
        
        [Name("HP(H)"), NameIndex(0), JsonProperty]
        public string HPH { get; set; } = "";
        
        [Name("L-HP"), NameIndex(0), JsonProperty]
        public string LHP { get; set; } = "";
        
        [Name("L-HP(N)"), NameIndex(0), JsonProperty]
        public string LHPN { get; set; } = "";
        
        [Name("L-HP(H)"), NameIndex(0), JsonProperty]
        public string LHPH { get; set; } = "";
        
        [Name("DM"), NameIndex(0), JsonProperty]
        public string DM { get; set; } = "";
        
        [Name("DM(N)"), NameIndex(0), JsonProperty]
        public string DMN { get; set; } = "";
        
        [Name("DM(H)"), NameIndex(0), JsonProperty]
        public string DMH { get; set; } = "";
        
        [Name("L-DM"), NameIndex(0), JsonProperty]
        public string LDM { get; set; } = "";
        
        [Name("L-DM(N)"), NameIndex(0), JsonProperty]
        public string LDMN { get; set; } = "";
        
        [Name("L-DM(H)"), NameIndex(0), JsonProperty]
        public string LDMH { get; set; } = "";
        
        [Name("XP"), NameIndex(0), JsonProperty]
        public string XP { get; set; } = "";
        
        [Name("XP(N)"), NameIndex(0), JsonProperty]
        public string XPN { get; set; } = "";
        
        [Name("XP(H)"), NameIndex(0), JsonProperty]
        public string XPH { get; set; } = "";
        
        [Name("L-XP"), NameIndex(0), JsonProperty]
        public string LXP { get; set; } = "";
        
        [Name("L-XP(N)"), NameIndex(0), JsonProperty]
        public string LXPN { get; set; } = "";
        
        [Name("L-XP(H)"), NameIndex(0), JsonProperty]
        public string LXPH { get; set; } = "";
        
    }
}
