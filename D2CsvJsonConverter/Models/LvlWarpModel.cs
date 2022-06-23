using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class LvlWarpModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("SelectX"), NameIndex(0), JsonProperty]
        public string Selectx { get; set; } = "";
        
        [Name("SelectY"), NameIndex(0), JsonProperty]
        public string Selecty { get; set; } = "";
        
        [Name("SelectDX"), NameIndex(0), JsonProperty]
        public string Selectdx { get; set; } = "";
        
        [Name("SelectDY"), NameIndex(0), JsonProperty]
        public string Selectdy { get; set; } = "";
        
        [Name("ExitWalkX"), NameIndex(0), JsonProperty]
        public string Exitwalkx { get; set; } = "";
        
        [Name("ExitWalkY"), NameIndex(0), JsonProperty]
        public string Exitwalky { get; set; } = "";
        
        [Name("OffsetX"), NameIndex(0), JsonProperty]
        public string Offsetx { get; set; } = "";
        
        [Name("OffsetY"), NameIndex(0), JsonProperty]
        public string Offsety { get; set; } = "";
        
        [Name("LitVersion"), NameIndex(0), JsonProperty]
        public string Litversion { get; set; } = "";
        
        [Name("Tiles"), NameIndex(0), JsonProperty]
        public string Tiles { get; set; } = "";
        
        [Name("Direction"), NameIndex(0), JsonProperty]
        public string Direction { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
    }
}
