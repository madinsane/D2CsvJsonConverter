using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class NpcModel
    {
        [Name("npc"), NameIndex(0), JsonProperty]
        public string Npc { get; set; } = "";
        
        [Name("buy mult"), NameIndex(0), JsonProperty]
        public string BuyMult { get; set; } = "";
        
        [Name("sell mult"), NameIndex(0), JsonProperty]
        public string SellMult { get; set; } = "";
        
        [Name("rep mult"), NameIndex(0), JsonProperty]
        public string RepMult { get; set; } = "";
        
        [Name("questflag A"), NameIndex(0), JsonProperty]
        public string QuestflagA { get; set; } = "";
        
        [Name("questbuymult A"), NameIndex(0), JsonProperty]
        public string QuestbuymultA { get; set; } = "";
        
        [Name("questsellmult A"), NameIndex(0), JsonProperty]
        public string QuestsellmultA { get; set; } = "";
        
        [Name("questrepmult A"), NameIndex(0), JsonProperty]
        public string QuestrepmultA { get; set; } = "";
        
        [Name("questflag B"), NameIndex(0), JsonProperty]
        public string QuestflagB { get; set; } = "";
        
        [Name("questbuymult B"), NameIndex(0), JsonProperty]
        public string QuestbuymultB { get; set; } = "";
        
        [Name("questsellmult B"), NameIndex(0), JsonProperty]
        public string QuestsellmultB { get; set; } = "";
        
        [Name("questrepmult B"), NameIndex(0), JsonProperty]
        public string QuestrepmultB { get; set; } = "";
        
        [Name("questflag C"), NameIndex(0), JsonProperty]
        public string QuestflagC { get; set; } = "";
        
        [Name("questbuymult C"), NameIndex(0), JsonProperty]
        public string QuestbuymultC { get; set; } = "";
        
        [Name("questsellmult C"), NameIndex(0), JsonProperty]
        public string QuestsellmultC { get; set; } = "";
        
        [Name("questrepmult C"), NameIndex(0), JsonProperty]
        public string QuestrepmultC { get; set; } = "";
        
        [Name("max buy"), NameIndex(0), JsonProperty]
        public string MaxBuy { get; set; } = "";
        
        [Name("max buy (N)"), NameIndex(0), JsonProperty]
        public string MaxBuyN { get; set; } = "";
        
        [Name("max buy (H)"), NameIndex(0), JsonProperty]
        public string MaxBuyH { get; set; } = "";
        
    }
}
