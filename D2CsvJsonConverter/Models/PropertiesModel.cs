using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class PropertiesModel
    {
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("*done"), NameIndex(0), JsonProperty]
        public string Done { get; set; } = "";
        
        [Name("set1"), NameIndex(0), JsonProperty]
        public string Set1 { get; set; } = "";
        
        [Name("val1"), NameIndex(0), JsonProperty]
        public string Val1 { get; set; } = "";
        
        [Name("func1"), NameIndex(0), JsonProperty]
        public string Func1 { get; set; } = "";
        
        [Name("stat1"), NameIndex(0), JsonProperty]
        public string Stat1 { get; set; } = "";
        
        [Name("set2"), NameIndex(0), JsonProperty]
        public string Set2 { get; set; } = "";
        
        [Name("val2"), NameIndex(0), JsonProperty]
        public string Val2 { get; set; } = "";
        
        [Name("func2"), NameIndex(0), JsonProperty]
        public string Func2 { get; set; } = "";
        
        [Name("stat2"), NameIndex(0), JsonProperty]
        public string Stat2 { get; set; } = "";
        
        [Name("set3"), NameIndex(0), JsonProperty]
        public string Set3 { get; set; } = "";
        
        [Name("val3"), NameIndex(0), JsonProperty]
        public string Val3 { get; set; } = "";
        
        [Name("func3"), NameIndex(0), JsonProperty]
        public string Func3 { get; set; } = "";
        
        [Name("stat3"), NameIndex(0), JsonProperty]
        public string Stat3 { get; set; } = "";
        
        [Name("set4"), NameIndex(0), JsonProperty]
        public string Set4 { get; set; } = "";
        
        [Name("val4"), NameIndex(0), JsonProperty]
        public string Val4 { get; set; } = "";
        
        [Name("func4"), NameIndex(0), JsonProperty]
        public string Func4 { get; set; } = "";
        
        [Name("stat4"), NameIndex(0), JsonProperty]
        public string Stat4 { get; set; } = "";
        
        [Name("set5"), NameIndex(0), JsonProperty]
        public string Set5 { get; set; } = "";
        
        [Name("val5"), NameIndex(0), JsonProperty]
        public string Val5 { get; set; } = "";
        
        [Name("func5"), NameIndex(0), JsonProperty]
        public string Func5 { get; set; } = "";
        
        [Name("stat5"), NameIndex(0), JsonProperty]
        public string Stat5 { get; set; } = "";
        
        [Name("set6"), NameIndex(0), JsonProperty]
        public string Set6 { get; set; } = "";
        
        [Name("val6"), NameIndex(0), JsonProperty]
        public string Val6 { get; set; } = "";
        
        [Name("func6"), NameIndex(0), JsonProperty]
        public string Func6 { get; set; } = "";
        
        [Name("stat6"), NameIndex(0), JsonProperty]
        public string Stat6 { get; set; } = "";
        
        [Name("set7"), NameIndex(0), JsonProperty]
        public string Set7 { get; set; } = "";
        
        [Name("val7"), NameIndex(0), JsonProperty]
        public string Val7 { get; set; } = "";
        
        [Name("func7"), NameIndex(0), JsonProperty]
        public string Func7 { get; set; } = "";
        
        [Name("stat7"), NameIndex(0), JsonProperty]
        public string Stat7 { get; set; } = "";
        
        [Name("*desc"), NameIndex(0), JsonProperty]
        public string Desc { get; set; } = "";
        
        [Name("*param"), NameIndex(0), JsonProperty]
        public string Param { get; set; } = "";
        
        [Name("*min"), NameIndex(0), JsonProperty]
        public string Min { get; set; } = "";
        
        [Name("*max"), NameIndex(0), JsonProperty]
        public string Max { get; set; } = "";
        
        [Name("*notes"), NameIndex(0), JsonProperty]
        public string Notes { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
