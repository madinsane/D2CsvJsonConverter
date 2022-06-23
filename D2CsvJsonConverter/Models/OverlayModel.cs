using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class OverlayModel
    {
        [Name("overlay"), NameIndex(0), JsonProperty]
        public string Overlay { get; set; } = "";
        
        [Name("Filename"), NameIndex(0), JsonProperty]
        public string Filename { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("Frames"), NameIndex(0), JsonProperty]
        public string Frames { get; set; } = "";
        
        [Name("Character"), NameIndex(0), JsonProperty]
        public string Character { get; set; } = "";
        
        [Name("PreDraw"), NameIndex(0), JsonProperty]
        public string Predraw { get; set; } = "";
        
        [Name("1ofN"), NameIndex(0), JsonProperty]
        public string _1Ofn { get; set; } = "";
        
        [Name("Dir"), NameIndex(0), JsonProperty]
        public string Dir { get; set; } = "";
        
        [Name("Open"), NameIndex(0), JsonProperty]
        public string Open { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
        [Name("Xoffset"), NameIndex(0), JsonProperty]
        public string Xoffset { get; set; } = "";
        
        [Name("Yoffset"), NameIndex(0), JsonProperty]
        public string Yoffset { get; set; } = "";
        
        [Name("Height1"), NameIndex(0), JsonProperty]
        public string Height1 { get; set; } = "";
        
        [Name("Height2"), NameIndex(0), JsonProperty]
        public string Height2 { get; set; } = "";
        
        [Name("Height3"), NameIndex(0), JsonProperty]
        public string Height3 { get; set; } = "";
        
        [Name("Height4"), NameIndex(0), JsonProperty]
        public string Height4 { get; set; } = "";
        
        [Name("AnimRate"), NameIndex(0), JsonProperty]
        public string Animrate { get; set; } = "";
        
        [Name("LoopWaitTime"), NameIndex(0), JsonProperty]
        public string Loopwaittime { get; set; } = "";
        
        [Name("Trans"), NameIndex(0), JsonProperty]
        public string Trans { get; set; } = "";
        
        [Name("InitRadius"), NameIndex(0), JsonProperty]
        public string Initradius { get; set; } = "";
        
        [Name("Radius"), NameIndex(0), JsonProperty]
        public string Radius { get; set; } = "";
        
        [Name("Red"), NameIndex(0), JsonProperty]
        public string Red { get; set; } = "";
        
        [Name("Green"), NameIndex(0), JsonProperty]
        public string Green { get; set; } = "";
        
        [Name("Blue"), NameIndex(0), JsonProperty]
        public string Blue { get; set; } = "";
        
        [Name("NumDirections"), NameIndex(0), JsonProperty]
        public string Numdirections { get; set; } = "";
        
        [Name("LocalBlood"), NameIndex(0), JsonProperty]
        public string Localblood { get; set; } = "";
        
    }
}
