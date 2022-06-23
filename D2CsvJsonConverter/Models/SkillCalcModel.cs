using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SkillCalcModel
    {
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("*desc"), NameIndex(0), JsonProperty]
        public string Desc { get; set; } = "";
        
    }
}
