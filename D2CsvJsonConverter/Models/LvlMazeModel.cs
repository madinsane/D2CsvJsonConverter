using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class LvlMazeModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("Rooms"), NameIndex(0), JsonProperty]
        public string Rooms { get; set; } = "";
        
        [Name("Rooms(N)"), NameIndex(0), JsonProperty]
        public string RoomsN { get; set; } = "";
        
        [Name("Rooms(H)"), NameIndex(0), JsonProperty]
        public string RoomsH { get; set; } = "";
        
        [Name("SizeX"), NameIndex(0), JsonProperty]
        public string Sizex { get; set; } = "";
        
        [Name("SizeY"), NameIndex(0), JsonProperty]
        public string Sizey { get; set; } = "";
        
        [Name("Merge"), NameIndex(0), JsonProperty]
        public string Merge { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
    }
}
