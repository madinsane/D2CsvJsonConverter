using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class LvlPrestModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Def"), NameIndex(0), JsonProperty]
        public string Def { get; set; } = "";
        
        [Name("LevelId"), NameIndex(0), JsonProperty]
        public string Levelid { get; set; } = "";
        
        [Name("Populate"), NameIndex(0), JsonProperty]
        public string Populate { get; set; } = "";
        
        [Name("Logicals"), NameIndex(0), JsonProperty]
        public string Logicals { get; set; } = "";
        
        [Name("Outdoors"), NameIndex(0), JsonProperty]
        public string Outdoors { get; set; } = "";
        
        [Name("Animate"), NameIndex(0), JsonProperty]
        public string Animate { get; set; } = "";
        
        [Name("KillEdge"), NameIndex(0), JsonProperty]
        public string Killedge { get; set; } = "";
        
        [Name("FillBlanks"), NameIndex(0), JsonProperty]
        public string Fillblanks { get; set; } = "";
        
        [Name("SizeX"), NameIndex(0), JsonProperty]
        public string Sizex { get; set; } = "";
        
        [Name("SizeY"), NameIndex(0), JsonProperty]
        public string Sizey { get; set; } = "";
        
        [Name("AutoMap"), NameIndex(0), JsonProperty]
        public string Automap { get; set; } = "";
        
        [Name("Scan"), NameIndex(0), JsonProperty]
        public string Scan { get; set; } = "";
        
        [Name("Pops"), NameIndex(0), JsonProperty]
        public string Pops { get; set; } = "";
        
        [Name("PopPad"), NameIndex(0), JsonProperty]
        public string Poppad { get; set; } = "";
        
        [Name("Files"), NameIndex(0), JsonProperty]
        public string Files { get; set; } = "";
        
        [Name("File1"), NameIndex(0), JsonProperty]
        public string File1 { get; set; } = "";
        
        [Name("File2"), NameIndex(0), JsonProperty]
        public string File2 { get; set; } = "";
        
        [Name("File3"), NameIndex(0), JsonProperty]
        public string File3 { get; set; } = "";
        
        [Name("File4"), NameIndex(0), JsonProperty]
        public string File4 { get; set; } = "";
        
        [Name("File5"), NameIndex(0), JsonProperty]
        public string File5 { get; set; } = "";
        
        [Name("File6"), NameIndex(0), JsonProperty]
        public string File6 { get; set; } = "";
        
        [Name("Dt1Mask"), NameIndex(0), JsonProperty]
        public string Dt1mask { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
        [Name("Expansion"), NameIndex(0), JsonProperty]
        public string Expansion { get; set; } = "";
        
    }
}
