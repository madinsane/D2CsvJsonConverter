using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class RunesModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Rune Name"), NameIndex(0), JsonProperty]
        public string RuneName { get; set; } = "";
        
        [Name("complete"), NameIndex(0), JsonProperty]
        public string Complete { get; set; } = "";
        
        [Name("server"), NameIndex(0), JsonProperty]
        public string Server { get; set; } = "";
        
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
        
        [Name("etype1"), NameIndex(0), JsonProperty]
        public string Etype1 { get; set; } = "";
        
        [Name("etype2"), NameIndex(0), JsonProperty]
        public string Etype2 { get; set; } = "";
        
        [Name("etype3"), NameIndex(0), JsonProperty]
        public string Etype3 { get; set; } = "";
        
        [Name("*runes"), NameIndex(0), JsonProperty]
        public string Runes { get; set; } = "";
        
        [Name("Rune1"), NameIndex(0), JsonProperty]
        public string Rune1 { get; set; } = "";
        
        [Name("Rune2"), NameIndex(0), JsonProperty]
        public string Rune2 { get; set; } = "";
        
        [Name("Rune3"), NameIndex(0), JsonProperty]
        public string Rune3 { get; set; } = "";
        
        [Name("Rune4"), NameIndex(0), JsonProperty]
        public string Rune4 { get; set; } = "";
        
        [Name("Rune5"), NameIndex(0), JsonProperty]
        public string Rune5 { get; set; } = "";
        
        [Name("Rune6"), NameIndex(0), JsonProperty]
        public string Rune6 { get; set; } = "";
        
        [Name("T1Code1"), NameIndex(0), JsonProperty]
        public string T1code1 { get; set; } = "";
        
        [Name("T1Param1"), NameIndex(0), JsonProperty]
        public string T1param1 { get; set; } = "";
        
        [Name("T1Min1"), NameIndex(0), JsonProperty]
        public string T1min1 { get; set; } = "";
        
        [Name("T1Max1"), NameIndex(0), JsonProperty]
        public string T1max1 { get; set; } = "";
        
        [Name("T1Code2"), NameIndex(0), JsonProperty]
        public string T1code2 { get; set; } = "";
        
        [Name("T1Param2"), NameIndex(0), JsonProperty]
        public string T1param2 { get; set; } = "";
        
        [Name("T1Min2"), NameIndex(0), JsonProperty]
        public string T1min2 { get; set; } = "";
        
        [Name("T1Max2"), NameIndex(0), JsonProperty]
        public string T1max2 { get; set; } = "";
        
        [Name("T1Code3"), NameIndex(0), JsonProperty]
        public string T1code3 { get; set; } = "";
        
        [Name("T1Param3"), NameIndex(0), JsonProperty]
        public string T1param3 { get; set; } = "";
        
        [Name("T1Min3"), NameIndex(0), JsonProperty]
        public string T1min3 { get; set; } = "";
        
        [Name("T1Max3"), NameIndex(0), JsonProperty]
        public string T1max3 { get; set; } = "";
        
        [Name("T1Code4"), NameIndex(0), JsonProperty]
        public string T1code4 { get; set; } = "";
        
        [Name("T1Param4"), NameIndex(0), JsonProperty]
        public string T1param4 { get; set; } = "";
        
        [Name("T1Min4"), NameIndex(0), JsonProperty]
        public string T1min4 { get; set; } = "";
        
        [Name("T1Max4"), NameIndex(0), JsonProperty]
        public string T1max4 { get; set; } = "";
        
        [Name("T1Code5"), NameIndex(0), JsonProperty]
        public string T1code5 { get; set; } = "";
        
        [Name("T1Param5"), NameIndex(0), JsonProperty]
        public string T1param5 { get; set; } = "";
        
        [Name("T1Min5"), NameIndex(0), JsonProperty]
        public string T1min5 { get; set; } = "";
        
        [Name("T1Max5"), NameIndex(0), JsonProperty]
        public string T1max5 { get; set; } = "";
        
        [Name("T1Code6"), NameIndex(0), JsonProperty]
        public string T1code6 { get; set; } = "";
        
        [Name("T1Param6"), NameIndex(0), JsonProperty]
        public string T1param6 { get; set; } = "";
        
        [Name("T1Min6"), NameIndex(0), JsonProperty]
        public string T1min6 { get; set; } = "";
        
        [Name("T1Max6"), NameIndex(0), JsonProperty]
        public string T1max6 { get; set; } = "";
        
        [Name("T1Code7"), NameIndex(0), JsonProperty]
        public string T1code7 { get; set; } = "";
        
        [Name("T1Param7"), NameIndex(0), JsonProperty]
        public string T1param7 { get; set; } = "";
        
        [Name("T1Min7"), NameIndex(0), JsonProperty]
        public string T1min7 { get; set; } = "";
        
        [Name("T1Max7"), NameIndex(0), JsonProperty]
        public string T1max7 { get; set; } = "";
        
        [Name("eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
