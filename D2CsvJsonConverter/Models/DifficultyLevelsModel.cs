using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class DifficultyLevelsModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("ResistPenalty"), NameIndex(0), JsonProperty]
        public string Resistpenalty { get; set; } = "";
        
        [Name("DeathExpPenalty"), NameIndex(0), JsonProperty]
        public string Deathexppenalty { get; set; } = "";
        
        [Name("UberCodeOddsNormal"), NameIndex(0), JsonProperty]
        public string Ubercodeoddsnormal { get; set; } = "";
        
        [Name("UberCodeOddsGood"), NameIndex(0), JsonProperty]
        public string Ubercodeoddsgood { get; set; } = "";
        
        [Name("UltraCodeOddsNormal"), NameIndex(0), JsonProperty]
        public string Ultracodeoddsnormal { get; set; } = "";
        
        [Name("UltraCodeOddsGood"), NameIndex(0), JsonProperty]
        public string Ultracodeoddsgood { get; set; } = "";
        
        [Name("MonsterSkillBonus"), NameIndex(0), JsonProperty]
        public string Monsterskillbonus { get; set; } = "";
        
        [Name("MonsterFreezeDivisor"), NameIndex(0), JsonProperty]
        public string Monsterfreezedivisor { get; set; } = "";
        
        [Name("MonsterColdDivisor"), NameIndex(0), JsonProperty]
        public string Monstercolddivisor { get; set; } = "";
        
        [Name("AiCurseDivisor"), NameIndex(0), JsonProperty]
        public string Aicursedivisor { get; set; } = "";
        
        [Name("LifeStealDivisor"), NameIndex(0), JsonProperty]
        public string Lifestealdivisor { get; set; } = "";
        
        [Name("ManaStealDivisor"), NameIndex(0), JsonProperty]
        public string Manastealdivisor { get; set; } = "";
        
        [Name("UniqueDamageBonus"), NameIndex(0), JsonProperty]
        public string Uniquedamagebonus { get; set; } = "";
        
        [Name("ChampionDamageBonus"), NameIndex(0), JsonProperty]
        public string Championdamagebonus { get; set; } = "";
        
        [Name("HireableBossDamagePercent"), NameIndex(0), JsonProperty]
        public string Hireablebossdamagepercent { get; set; } = "";
        
        [Name("MonsterCEDamagePercent"), NameIndex(0), JsonProperty]
        public string Monstercedamagepercent { get; set; } = "";
        
        [Name("StaticFieldMin"), NameIndex(0), JsonProperty]
        public string Staticfieldmin { get; set; } = "";
        
        [Name("GambleRare"), NameIndex(0), JsonProperty]
        public string Gamblerare { get; set; } = "";
        
        [Name("GambleSet"), NameIndex(0), JsonProperty]
        public string Gambleset { get; set; } = "";
        
        [Name("GambleUnique"), NameIndex(0), JsonProperty]
        public string Gambleunique { get; set; } = "";
        
        [Name("GambleUber"), NameIndex(0), JsonProperty]
        public string Gambleuber { get; set; } = "";
        
        [Name("GambleUltra"), NameIndex(0), JsonProperty]
        public string Gambleultra { get; set; } = "";
        
    }
}
