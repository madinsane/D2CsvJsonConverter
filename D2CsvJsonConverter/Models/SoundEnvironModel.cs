using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SoundEnvironModel
    {
        [Name("Handle"), NameIndex(0), JsonProperty]
        public string Handle { get; set; } = "";
        
        [Name("Index"), NameIndex(0), JsonProperty]
        public string Index { get; set; } = "";
        
        [Name("Song"), NameIndex(0), JsonProperty]
        public string Song { get; set; } = "";
        
        [Name("Day Ambience"), NameIndex(0), JsonProperty]
        public string DayAmbience { get; set; } = "";
        
        [Name("Night Ambience"), NameIndex(0), JsonProperty]
        public string NightAmbience { get; set; } = "";
        
        [Name("Day Event"), NameIndex(0), JsonProperty]
        public string DayEvent { get; set; } = "";
        
        [Name("Night Event"), NameIndex(0), JsonProperty]
        public string NightEvent { get; set; } = "";
        
        [Name("Event Delay"), NameIndex(0), JsonProperty]
        public string EventDelay { get; set; } = "";
        
        [Name("Indoors"), NameIndex(0), JsonProperty]
        public string Indoors { get; set; } = "";
        
        [Name("Material 1"), NameIndex(0), JsonProperty]
        public string Material1 { get; set; } = "";
        
        [Name("Material 2"), NameIndex(0), JsonProperty]
        public string Material2 { get; set; } = "";
        
        [Name("EAX Environ"), NameIndex(0), JsonProperty]
        public string EAXEnviron { get; set; } = "";
        
        [Name("EAX Env Size"), NameIndex(0), JsonProperty]
        public string EAXEnvSize { get; set; } = "";
        
        [Name("EAX Env Diff"), NameIndex(0), JsonProperty]
        public string EAXEnvDiff { get; set; } = "";
        
        [Name("EAX Room Vol"), NameIndex(0), JsonProperty]
        public string EAXRoomVol { get; set; } = "";
        
        [Name("EAX Room HF"), NameIndex(0), JsonProperty]
        public string EAXRoomHF { get; set; } = "";
        
        [Name("EAX Decay Time"), NameIndex(0), JsonProperty]
        public string EAXDecayTime { get; set; } = "";
        
        [Name("EAX Decay HF"), NameIndex(0), JsonProperty]
        public string EAXDecayHF { get; set; } = "";
        
        [Name("EAX Reflect"), NameIndex(0), JsonProperty]
        public string EAXReflect { get; set; } = "";
        
        [Name("EAX Reflect Delay"), NameIndex(0), JsonProperty]
        public string EAXReflectDelay { get; set; } = "";
        
        [Name("EAX Reverb"), NameIndex(0), JsonProperty]
        public string EAXReverb { get; set; } = "";
        
        [Name("EAX Rev Delay"), NameIndex(0), JsonProperty]
        public string EAXRevDelay { get; set; } = "";
        
        [Name("EAX Room Roll"), NameIndex(0), JsonProperty]
        public string EAXRoomRoll { get; set; } = "";
        
        [Name("EAX Air Absorb"), NameIndex(0), JsonProperty]
        public string EAXAirAbsorb { get; set; } = "";
        
    }
}
