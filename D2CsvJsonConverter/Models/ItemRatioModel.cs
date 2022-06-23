using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ItemRatioModel
    {
        [Name("Function"), NameIndex(0), JsonProperty]
        public string Function { get; set; } = "";
        
        [Name("Version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("Uber"), NameIndex(0), JsonProperty]
        public string Uber { get; set; } = "";
        
        [Name("Class Specific"), NameIndex(0), JsonProperty]
        public string ClassSpecific { get; set; } = "";
        
        [Name("Unique"), NameIndex(0), JsonProperty]
        public string Unique { get; set; } = "";
        
        [Name("UniqueDivisor"), NameIndex(0), JsonProperty]
        public string Uniquedivisor { get; set; } = "";
        
        [Name("UniqueMin"), NameIndex(0), JsonProperty]
        public string Uniquemin { get; set; } = "";
        
        [Name("Rare"), NameIndex(0), JsonProperty]
        public string Rare { get; set; } = "";
        
        [Name("RareDivisor"), NameIndex(0), JsonProperty]
        public string Raredivisor { get; set; } = "";
        
        [Name("RareMin"), NameIndex(0), JsonProperty]
        public string Raremin { get; set; } = "";
        
        [Name("Set"), NameIndex(0), JsonProperty]
        public string Set { get; set; } = "";
        
        [Name("SetDivisor"), NameIndex(0), JsonProperty]
        public string Setdivisor { get; set; } = "";
        
        [Name("SetMin"), NameIndex(0), JsonProperty]
        public string Setmin { get; set; } = "";
        
        [Name("Magic"), NameIndex(0), JsonProperty]
        public string Magic { get; set; } = "";
        
        [Name("MagicDivisor"), NameIndex(0), JsonProperty]
        public string Magicdivisor { get; set; } = "";
        
        [Name("MagicMin"), NameIndex(0), JsonProperty]
        public string Magicmin { get; set; } = "";
        
        [Name("HiQuality"), NameIndex(0), JsonProperty]
        public string Hiquality { get; set; } = "";
        
        [Name("HiQualityDivisor"), NameIndex(0), JsonProperty]
        public string Hiqualitydivisor { get; set; } = "";
        
        [Name("Normal"), NameIndex(0), JsonProperty]
        public string Normal { get; set; } = "";
        
        [Name("NormalDivisor"), NameIndex(0), JsonProperty]
        public string Normaldivisor { get; set; } = "";
        
    }
}
