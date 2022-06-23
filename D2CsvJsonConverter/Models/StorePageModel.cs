using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class StorePageModel
    {
        [Name("Store Page"), NameIndex(0), JsonProperty]
        public string StorePage { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
    }
}
