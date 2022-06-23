using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class BooksModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Namco"), NameIndex(0), JsonProperty]
        public string Namco { get; set; } = "";
        
        [Name("Completed"), NameIndex(0), JsonProperty]
        public string Completed { get; set; } = "";
        
        [Name("ScrollSpellCode"), NameIndex(0), JsonProperty]
        public string Scrollspellcode { get; set; } = "";
        
        [Name("BookSpellCode"), NameIndex(0), JsonProperty]
        public string Bookspellcode { get; set; } = "";
        
        [Name("pSpell"), NameIndex(0), JsonProperty]
        public string Pspell { get; set; } = "";
        
        [Name("SpellIcon"), NameIndex(0), JsonProperty]
        public string Spellicon { get; set; } = "";
        
        [Name("ScrollSkill"), NameIndex(0), JsonProperty]
        public string Scrollskill { get; set; } = "";
        
        [Name("BookSkill"), NameIndex(0), JsonProperty]
        public string Bookskill { get; set; } = "";
        
        [Name("BaseCost"), NameIndex(0), JsonProperty]
        public string Basecost { get; set; } = "";
        
        [Name("CostPerCharge"), NameIndex(0), JsonProperty]
        public string Costpercharge { get; set; } = "";
        
    }
}
