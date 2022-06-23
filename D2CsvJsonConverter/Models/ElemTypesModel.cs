using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ElemTypesModel
    {
        [Name("Elemental Type"), NameIndex(0), JsonProperty]
        public string ElementalType { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("*EOL"), NameIndex(0), JsonProperty]
        public string EOL { get; set; } = "";
        
    }
}
