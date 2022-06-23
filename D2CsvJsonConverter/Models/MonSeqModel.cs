using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonSeqModel
    {
        [Name("sequence"), NameIndex(0), JsonProperty]
        public string Sequence { get; set; } = "";
        
        [Name("mode"), NameIndex(0), JsonProperty]
        public string Mode { get; set; } = "";
        
        [Name("frame"), NameIndex(0), JsonProperty]
        public string Frame { get; set; } = "";
        
        [Name("dir"), NameIndex(0), JsonProperty]
        public string Dir { get; set; } = "";
        
        [Name("event"), NameIndex(0), JsonProperty]
        public string Event { get; set; } = "";
        
        [Name("eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
