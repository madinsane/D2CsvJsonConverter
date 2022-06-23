using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class PetTypeModel
    {
        [Name("pet type"), NameIndex(0), JsonProperty]
        public string PetType { get; set; } = "";
        
        [Name("idx"), NameIndex(0), JsonProperty]
        public string Idx { get; set; } = "";
        
        [Name("group"), NameIndex(0), JsonProperty]
        public string Group { get; set; } = "";
        
        [Name("basemax"), NameIndex(0), JsonProperty]
        public string Basemax { get; set; } = "";
        
        [Name("warp"), NameIndex(0), JsonProperty]
        public string Warp { get; set; } = "";
        
        [Name("range"), NameIndex(0), JsonProperty]
        public string Range { get; set; } = "";
        
        [Name("partysend"), NameIndex(0), JsonProperty]
        public string Partysend { get; set; } = "";
        
        [Name("unsummon"), NameIndex(0), JsonProperty]
        public string Unsummon { get; set; } = "";
        
        [Name("automap"), NameIndex(0), JsonProperty]
        public string Automap { get; set; } = "";
        
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("drawhp"), NameIndex(0), JsonProperty]
        public string Drawhp { get; set; } = "";
        
        [Name("icontype"), NameIndex(0), JsonProperty]
        public string Icontype { get; set; } = "";
        
        [Name("baseicon"), NameIndex(0), JsonProperty]
        public string Baseicon { get; set; } = "";
        
        [Name("mclass1"), NameIndex(0), JsonProperty]
        public string Mclass1 { get; set; } = "";
        
        [Name("micon1"), NameIndex(0), JsonProperty]
        public string Micon1 { get; set; } = "";
        
        [Name("mclass2"), NameIndex(0), JsonProperty]
        public string Mclass2 { get; set; } = "";
        
        [Name("micon2"), NameIndex(0), JsonProperty]
        public string Micon2 { get; set; } = "";
        
        [Name("mclass3"), NameIndex(0), JsonProperty]
        public string Mclass3 { get; set; } = "";
        
        [Name("micon3"), NameIndex(0), JsonProperty]
        public string Micon3 { get; set; } = "";
        
        [Name("mclass4"), NameIndex(0), JsonProperty]
        public string Mclass4 { get; set; } = "";
        
        [Name("micon4"), NameIndex(0), JsonProperty]
        public string Micon4 { get; set; } = "";
        
        [Name("eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
