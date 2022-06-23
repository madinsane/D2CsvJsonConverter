using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class TreasureClassExModel
    {
        [Name("Treasure Class"), NameIndex(0), JsonProperty]
        public string TreasureClass { get; set; } = "";
        
        [Name("group"), NameIndex(0), JsonProperty]
        public string Group { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("Picks"), NameIndex(0), JsonProperty]
        public string Picks { get; set; } = "";
        
        [Name("Unique"), NameIndex(0), JsonProperty]
        public string Unique { get; set; } = "";
        
        [Name("Set"), NameIndex(0), JsonProperty]
        public string Set { get; set; } = "";
        
        [Name("Rare"), NameIndex(0), JsonProperty]
        public string Rare { get; set; } = "";
        
        [Name("Magic"), NameIndex(0), JsonProperty]
        public string Magic { get; set; } = "";
        
        [Name("NoDrop"), NameIndex(0), JsonProperty]
        public string Nodrop { get; set; } = "";
        
        [Name("Item1"), NameIndex(0), JsonProperty]
        public string Item1 { get; set; } = "";
        
        [Name("Prob1"), NameIndex(0), JsonProperty]
        public string Prob1 { get; set; } = "";
        
        [Name("Item2"), NameIndex(0), JsonProperty]
        public string Item2 { get; set; } = "";
        
        [Name("Prob2"), NameIndex(0), JsonProperty]
        public string Prob2 { get; set; } = "";
        
        [Name("Item3"), NameIndex(0), JsonProperty]
        public string Item3 { get; set; } = "";
        
        [Name("Prob3"), NameIndex(0), JsonProperty]
        public string Prob3 { get; set; } = "";
        
        [Name("Item4"), NameIndex(0), JsonProperty]
        public string Item4 { get; set; } = "";
        
        [Name("Prob4"), NameIndex(0), JsonProperty]
        public string Prob4 { get; set; } = "";
        
        [Name("Item5"), NameIndex(0), JsonProperty]
        public string Item5 { get; set; } = "";
        
        [Name("Prob5"), NameIndex(0), JsonProperty]
        public string Prob5 { get; set; } = "";
        
        [Name("Item6"), NameIndex(0), JsonProperty]
        public string Item6 { get; set; } = "";
        
        [Name("Prob6"), NameIndex(0), JsonProperty]
        public string Prob6 { get; set; } = "";
        
        [Name("Item7"), NameIndex(0), JsonProperty]
        public string Item7 { get; set; } = "";
        
        [Name("Prob7"), NameIndex(0), JsonProperty]
        public string Prob7 { get; set; } = "";
        
        [Name("Item8"), NameIndex(0), JsonProperty]
        public string Item8 { get; set; } = "";
        
        [Name("Prob8"), NameIndex(0), JsonProperty]
        public string Prob8 { get; set; } = "";
        
        [Name("Item9"), NameIndex(0), JsonProperty]
        public string Item9 { get; set; } = "";
        
        [Name("Prob9"), NameIndex(0), JsonProperty]
        public string Prob9 { get; set; } = "";
        
        [Name("Item10"), NameIndex(0), JsonProperty]
        public string Item10 { get; set; } = "";
        
        [Name("Prob10"), NameIndex(0), JsonProperty]
        public string Prob10 { get; set; } = "";
        
        [Name("SumItems"), NameIndex(0), JsonProperty]
        public string Sumitems { get; set; } = "";
        
        [Name("TotalProb"), NameIndex(0), JsonProperty]
        public string Totalprob { get; set; } = "";
        
        [Name("DropChance"), NameIndex(0), JsonProperty]
        public string Dropchance { get; set; } = "";
        
        [Name("Term"), NameIndex(0), JsonProperty]
        public string Term { get; set; } = "";
        
    }
}
