using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ArenaModel
    {
        [Name("Arena"), NameIndex(0), JsonProperty]
        public string Arena { get; set; } = "";
        
        [Name("Suicide"), NameIndex(0), JsonProperty]
        public string Suicide { get; set; } = "";
        
        [Name("PlayerKill"), NameIndex(0), JsonProperty]
        public string Playerkill { get; set; } = "";
        
        [Name("PlayerKillPercent"), NameIndex(0), JsonProperty]
        public string Playerkillpercent { get; set; } = "";
        
        [Name("MonsterKill"), NameIndex(0), JsonProperty]
        public string Monsterkill { get; set; } = "";
        
        [Name("PlayerDeath"), NameIndex(0), JsonProperty]
        public string Playerdeath { get; set; } = "";
        
        [Name("PlayerDeathPercent"), NameIndex(0), JsonProperty]
        public string Playerdeathpercent { get; set; } = "";
        
        [Name("MonsterDeath"), NameIndex(0), JsonProperty]
        public string Monsterdeath { get; set; } = "";
        
    }
}
