using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class CharStatsModel
    {
        [Name("class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("str"), NameIndex(0), JsonProperty]
        public string Str { get; set; } = "";
        
        [Name("dex"), NameIndex(0), JsonProperty]
        public string Dex { get; set; } = "";
        
        [Name("int"), NameIndex(0), JsonProperty]
        public string Int { get; set; } = "";
        
        [Name("vit"), NameIndex(0), JsonProperty]
        public string Vit { get; set; } = "";
        
        [Name("tot"), NameIndex(0), JsonProperty]
        public string Tot { get; set; } = "";
        
        [Name("stamina"), NameIndex(0), JsonProperty]
        public string Stamina { get; set; } = "";
        
        [Name("hpadd"), NameIndex(0), JsonProperty]
        public string Hpadd { get; set; } = "";
        
        [Name("PercentStr"), NameIndex(0), JsonProperty]
        public string Percentstr { get; set; } = "";
        
        [Name("PercentDex"), NameIndex(0), JsonProperty]
        public string Percentdex { get; set; } = "";
        
        [Name("PercentInt"), NameIndex(0), JsonProperty]
        public string Percentint { get; set; } = "";
        
        [Name("PercentVit"), NameIndex(0), JsonProperty]
        public string Percentvit { get; set; } = "";
        
        [Name("ManaRegen"), NameIndex(0), JsonProperty]
        public string Manaregen { get; set; } = "";
        
        [Name("ToHitFactor"), NameIndex(0), JsonProperty]
        public string Tohitfactor { get; set; } = "";
        
        [Name("WalkVelocity"), NameIndex(0), JsonProperty]
        public string Walkvelocity { get; set; } = "";
        
        [Name("RunVelocity"), NameIndex(0), JsonProperty]
        public string Runvelocity { get; set; } = "";
        
        [Name("RunDrain"), NameIndex(0), JsonProperty]
        public string Rundrain { get; set; } = "";
        
        [Name("Comment"), NameIndex(0), JsonProperty]
        public string Comment { get; set; } = "";
        
        [Name("LifePerLevel"), NameIndex(0), JsonProperty]
        public string Lifeperlevel { get; set; } = "";
        
        [Name("StaminaPerLevel"), NameIndex(0), JsonProperty]
        public string Staminaperlevel { get; set; } = "";
        
        [Name("ManaPerLevel"), NameIndex(0), JsonProperty]
        public string Manaperlevel { get; set; } = "";
        
        [Name("LifePerVitality"), NameIndex(0), JsonProperty]
        public string Lifepervitality { get; set; } = "";
        
        [Name("StaminaPerVitality"), NameIndex(0), JsonProperty]
        public string Staminapervitality { get; set; } = "";
        
        [Name("ManaPerMagic"), NameIndex(0), JsonProperty]
        public string Manapermagic { get; set; } = "";
        
        [Name("StatPerLevel"), NameIndex(0), JsonProperty]
        public string Statperlevel { get; set; } = "";
        
        [Name("#walk"), NameIndex(0), JsonProperty]
        public string Walk { get; set; } = "";
        
        [Name("#run"), NameIndex(0), JsonProperty]
        public string Run { get; set; } = "";
        
        [Name("#swing"), NameIndex(0), JsonProperty]
        public string Swing { get; set; } = "";
        
        [Name("#spell"), NameIndex(0), JsonProperty]
        public string Spell { get; set; } = "";
        
        [Name("#gethit"), NameIndex(0), JsonProperty]
        public string Gethit { get; set; } = "";
        
        [Name("#bow"), NameIndex(0), JsonProperty]
        public string Bow { get; set; } = "";
        
        [Name("BlockFactor"), NameIndex(0), JsonProperty]
        public string Blockfactor { get; set; } = "";
        
        [Name("StartSkill"), NameIndex(0), JsonProperty]
        public string Startskill { get; set; } = "";
        
        [Name("Skill 1"), NameIndex(0), JsonProperty]
        public string Skill1 { get; set; } = "";
        
        [Name("Skill 2"), NameIndex(0), JsonProperty]
        public string Skill2 { get; set; } = "";
        
        [Name("Skill 3"), NameIndex(0), JsonProperty]
        public string Skill3 { get; set; } = "";
        
        [Name("Skill 4"), NameIndex(0), JsonProperty]
        public string Skill4 { get; set; } = "";
        
        [Name("Skill 5"), NameIndex(0), JsonProperty]
        public string Skill5 { get; set; } = "";
        
        [Name("Skill 6"), NameIndex(0), JsonProperty]
        public string Skill6 { get; set; } = "";
        
        [Name("Skill 7"), NameIndex(0), JsonProperty]
        public string Skill7 { get; set; } = "";
        
        [Name("Skill 8"), NameIndex(0), JsonProperty]
        public string Skill8 { get; set; } = "";
        
        [Name("Skill 9"), NameIndex(0), JsonProperty]
        public string Skill9 { get; set; } = "";
        
        [Name("Skill 10"), NameIndex(0), JsonProperty]
        public string Skill10 { get; set; } = "";
        
        [Name("StrAllSkills"), NameIndex(0), JsonProperty]
        public string Strallskills { get; set; } = "";
        
        [Name("StrSkillTab1"), NameIndex(0), JsonProperty]
        public string Strskilltab1 { get; set; } = "";
        
        [Name("StrSkillTab2"), NameIndex(0), JsonProperty]
        public string Strskilltab2 { get; set; } = "";
        
        [Name("StrSkillTab3"), NameIndex(0), JsonProperty]
        public string Strskilltab3 { get; set; } = "";
        
        [Name("StrClassOnly"), NameIndex(0), JsonProperty]
        public string Strclassonly { get; set; } = "";
        
        [Name("baseWClass"), NameIndex(0), JsonProperty]
        public string Basewclass { get; set; } = "";
        
        [Name("item1"), NameIndex(0), JsonProperty]
        public string Item1 { get; set; } = "";
        
        [Name("item1loc"), NameIndex(0), JsonProperty]
        public string Item1loc { get; set; } = "";
        
        [Name("item1count"), NameIndex(0), JsonProperty]
        public string Item1count { get; set; } = "";
        
        [Name("item2"), NameIndex(0), JsonProperty]
        public string Item2 { get; set; } = "";
        
        [Name("item2loc"), NameIndex(0), JsonProperty]
        public string Item2loc { get; set; } = "";
        
        [Name("item2count"), NameIndex(0), JsonProperty]
        public string Item2count { get; set; } = "";
        
        [Name("item3"), NameIndex(0), JsonProperty]
        public string Item3 { get; set; } = "";
        
        [Name("item3loc"), NameIndex(0), JsonProperty]
        public string Item3loc { get; set; } = "";
        
        [Name("item3count"), NameIndex(0), JsonProperty]
        public string Item3count { get; set; } = "";
        
        [Name("item4"), NameIndex(0), JsonProperty]
        public string Item4 { get; set; } = "";
        
        [Name("item4loc"), NameIndex(0), JsonProperty]
        public string Item4loc { get; set; } = "";
        
        [Name("item4count"), NameIndex(0), JsonProperty]
        public string Item4count { get; set; } = "";
        
        [Name("item5"), NameIndex(0), JsonProperty]
        public string Item5 { get; set; } = "";
        
        [Name("item5loc"), NameIndex(0), JsonProperty]
        public string Item5loc { get; set; } = "";
        
        [Name("item5count"), NameIndex(0), JsonProperty]
        public string Item5count { get; set; } = "";
        
        [Name("item6"), NameIndex(0), JsonProperty]
        public string Item6 { get; set; } = "";
        
        [Name("item6loc"), NameIndex(0), JsonProperty]
        public string Item6loc { get; set; } = "";
        
        [Name("item6count"), NameIndex(0), JsonProperty]
        public string Item6count { get; set; } = "";
        
        [Name("item7"), NameIndex(0), JsonProperty]
        public string Item7 { get; set; } = "";
        
        [Name("item7loc"), NameIndex(0), JsonProperty]
        public string Item7loc { get; set; } = "";
        
        [Name("item7count"), NameIndex(0), JsonProperty]
        public string Item7count { get; set; } = "";
        
        [Name("item8"), NameIndex(0), JsonProperty]
        public string Item8 { get; set; } = "";
        
        [Name("item8loc"), NameIndex(0), JsonProperty]
        public string Item8loc { get; set; } = "";
        
        [Name("item8count"), NameIndex(0), JsonProperty]
        public string Item8count { get; set; } = "";
        
        [Name("item9"), NameIndex(0), JsonProperty]
        public string Item9 { get; set; } = "";
        
        [Name("item9loc"), NameIndex(0), JsonProperty]
        public string Item9loc { get; set; } = "";
        
        [Name("item9count"), NameIndex(0), JsonProperty]
        public string Item9count { get; set; } = "";
        
        [Name("item10"), NameIndex(0), JsonProperty]
        public string Item10 { get; set; } = "";
        
        [Name("item10loc"), NameIndex(0), JsonProperty]
        public string Item10loc { get; set; } = "";
        
        [Name("item10count"), NameIndex(0), JsonProperty]
        public string Item10count { get; set; } = "";
        
    }
}
