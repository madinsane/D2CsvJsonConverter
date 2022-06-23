using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SoundsModel
    {
        [Name("Sound"), NameIndex(0), JsonProperty]
        public string Sound { get; set; } = "";
        
        [Name("Index"), NameIndex(0), JsonProperty]
        public string Index { get; set; } = "";
        
        [Name("FileName"), NameIndex(0), JsonProperty]
        public string Filename { get; set; } = "";
        
        [Name("Volume"), NameIndex(0), JsonProperty]
        public string Volume { get; set; } = "";
        
        [Name("Group Size"), NameIndex(0), JsonProperty]
        public string GroupSize { get; set; } = "";
        
        [Name("Loop"), NameIndex(0), JsonProperty]
        public string Loop { get; set; } = "";
        
        [Name("Fade In"), NameIndex(0), JsonProperty]
        public string FadeIn { get; set; } = "";
        
        [Name("Fade Out"), NameIndex(0), JsonProperty]
        public string FadeOut { get; set; } = "";
        
        [Name("Defer Inst"), NameIndex(0), JsonProperty]
        public string DeferInst { get; set; } = "";
        
        [Name("Stop Inst"), NameIndex(0), JsonProperty]
        public string StopInst { get; set; } = "";
        
        [Name("Duration"), NameIndex(0), JsonProperty]
        public string Duration { get; set; } = "";
        
        [Name("Compound"), NameIndex(0), JsonProperty]
        public string Compound { get; set; } = "";
        
        [Name("Reverb"), NameIndex(0), JsonProperty]
        public string Reverb { get; set; } = "";
        
        [Name("Falloff"), NameIndex(0), JsonProperty]
        public string Falloff { get; set; } = "";
        
        [Name("Cache"), NameIndex(0), JsonProperty]
        public string Cache { get; set; } = "";
        
        [Name("Async Only"), NameIndex(0), JsonProperty]
        public string AsyncOnly { get; set; } = "";
        
        [Name("Priority"), NameIndex(0), JsonProperty]
        public string Priority { get; set; } = "";
        
        [Name("Stream"), NameIndex(0), JsonProperty]
        public string Stream { get; set; } = "";
        
        [Name("Stereo"), NameIndex(0), JsonProperty]
        public string Stereo { get; set; } = "";
        
        [Name("Tracking"), NameIndex(0), JsonProperty]
        public string Tracking { get; set; } = "";
        
        [Name("Solo"), NameIndex(0), JsonProperty]
        public string Solo { get; set; } = "";
        
        [Name("Music Vol"), NameIndex(0), JsonProperty]
        public string MusicVol { get; set; } = "";
        
        [Name("Block 1"), NameIndex(0), JsonProperty]
        public string Block1 { get; set; } = "";
        
        [Name("Block 2"), NameIndex(0), JsonProperty]
        public string Block2 { get; set; } = "";
        
        [Name("Block 3"), NameIndex(0), JsonProperty]
        public string Block3 { get; set; } = "";
        
    }
}
