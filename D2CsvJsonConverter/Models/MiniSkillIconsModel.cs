using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MiniSkillIconsModel
    {
        [Name("#define name"), NameIndex(0), JsonProperty]
        public string DefineName { get; set; } = "";
        
        [Name("Skill ID"), NameIndex(0), JsonProperty]
        public string SkillID { get; set; } = "";
        
        [Name("DC6 Frame"), NameIndex(0), JsonProperty]
        public string DC6Frame { get; set; } = "";
        
        [Name("switch case"), NameIndex(0), JsonProperty]
        public string SwitchCase { get; set; } = "";
        
    }
}
