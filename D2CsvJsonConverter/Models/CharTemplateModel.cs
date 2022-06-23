using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class CharTemplateModel
    {
        [Name("Template"), NameIndex(0), JsonProperty]
        public string Template { get; set; } = "";
        
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("Act"), NameIndex(0), JsonProperty]
        public string Act { get; set; } = "";
        
        [Name("Class"), NameIndex(0), JsonProperty]
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
        
        [Name("LifePerLevel"), NameIndex(0), JsonProperty]
        public string Lifeperlevel { get; set; } = "";
        
        [Name("ManaPerLevel"), NameIndex(0), JsonProperty]
        public string Manaperlevel { get; set; } = "";
        
        [Name("LifePerVitality"), NameIndex(0), JsonProperty]
        public string Lifepervitality { get; set; } = "";
        
        [Name("ManaPerMagic"), NameIndex(0), JsonProperty]
        public string Manapermagic { get; set; } = "";
        
        [Name("Hitpoints"), NameIndex(0), JsonProperty]
        public string Hitpoints { get; set; } = "";
        
        [Name("Mana"), NameIndex(0), JsonProperty]
        public string Mana { get; set; } = "";
        
        [Name("ManaRegenBonus"), NameIndex(0), JsonProperty]
        public string Manaregenbonus { get; set; } = "";
        
        [Name("Velocity"), NameIndex(0), JsonProperty]
        public string Velocity { get; set; } = "";
        
        [Name("AttackRate"), NameIndex(0), JsonProperty]
        public string Attackrate { get; set; } = "";
        
        [Name("OtherRate"), NameIndex(0), JsonProperty]
        public string Otherrate { get; set; } = "";
        
        [Name("RightSkill"), NameIndex(0), JsonProperty]
        public string Rightskill { get; set; } = "";
        
        [Name("Total Skills"), NameIndex(0), JsonProperty]
        public string TotalSkills { get; set; } = "";
        
        [Name("SkillName"), NameIndex(0), JsonProperty]
        public string Skillname { get; set; } = "";
        
        [Name("Skill1"), NameIndex(0), JsonProperty]
        public string Skill1 { get; set; } = "";
        
        [Name("SkillLevel1"), NameIndex(0), JsonProperty]
        public string Skilllevel1 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(1), JsonProperty]
        public string Skillname1 { get; set; } = "";
        
        [Name("Skill2"), NameIndex(0), JsonProperty]
        public string Skill2 { get; set; } = "";
        
        [Name("SkillLevel2"), NameIndex(0), JsonProperty]
        public string Skilllevel2 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(2), JsonProperty]
        public string Skillname2 { get; set; } = "";
        
        [Name("Skill3"), NameIndex(0), JsonProperty]
        public string Skill3 { get; set; } = "";
        
        [Name("SkillLevel3"), NameIndex(0), JsonProperty]
        public string Skilllevel3 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(3), JsonProperty]
        public string Skillname3 { get; set; } = "";
        
        [Name("Skill4"), NameIndex(0), JsonProperty]
        public string Skill4 { get; set; } = "";
        
        [Name("SkillLevel4"), NameIndex(0), JsonProperty]
        public string Skilllevel4 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(4), JsonProperty]
        public string Skillname4 { get; set; } = "";
        
        [Name("Skill5"), NameIndex(0), JsonProperty]
        public string Skill5 { get; set; } = "";
        
        [Name("SkillLevel5"), NameIndex(0), JsonProperty]
        public string Skilllevel5 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(5), JsonProperty]
        public string Skillname5 { get; set; } = "";
        
        [Name("Skill6"), NameIndex(0), JsonProperty]
        public string Skill6 { get; set; } = "";
        
        [Name("SkillLevel6"), NameIndex(0), JsonProperty]
        public string Skilllevel6 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(6), JsonProperty]
        public string Skillname6 { get; set; } = "";
        
        [Name("Skill7"), NameIndex(0), JsonProperty]
        public string Skill7 { get; set; } = "";
        
        [Name("SkillLevel7"), NameIndex(0), JsonProperty]
        public string Skilllevel7 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(7), JsonProperty]
        public string Skillname7 { get; set; } = "";
        
        [Name("Skill8"), NameIndex(0), JsonProperty]
        public string Skill8 { get; set; } = "";
        
        [Name("SkillLevel8"), NameIndex(0), JsonProperty]
        public string Skilllevel8 { get; set; } = "";
        
        [Name("SkillName"), NameIndex(8), JsonProperty]
        public string Skillname8 { get; set; } = "";
        
        [Name("Skill9"), NameIndex(0), JsonProperty]
        public string Skill9 { get; set; } = "";
        
        [Name("SkillLevel9"), NameIndex(0), JsonProperty]
        public string Skilllevel9 { get; set; } = "";
        
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
        
        [Name("item11"), NameIndex(0), JsonProperty]
        public string Item11 { get; set; } = "";
        
        [Name("item11loc"), NameIndex(0), JsonProperty]
        public string Item11loc { get; set; } = "";
        
        [Name("item11count"), NameIndex(0), JsonProperty]
        public string Item11count { get; set; } = "";
        
        [Name("item12"), NameIndex(0), JsonProperty]
        public string Item12 { get; set; } = "";
        
        [Name("item12loc"), NameIndex(0), JsonProperty]
        public string Item12loc { get; set; } = "";
        
        [Name("item12count"), NameIndex(0), JsonProperty]
        public string Item12count { get; set; } = "";
        
        [Name("item13"), NameIndex(0), JsonProperty]
        public string Item13 { get; set; } = "";
        
        [Name("item13loc"), NameIndex(0), JsonProperty]
        public string Item13loc { get; set; } = "";
        
        [Name("item13count"), NameIndex(0), JsonProperty]
        public string Item13count { get; set; } = "";
        
        [Name("item14"), NameIndex(0), JsonProperty]
        public string Item14 { get; set; } = "";
        
        [Name("item14loc"), NameIndex(0), JsonProperty]
        public string Item14loc { get; set; } = "";
        
        [Name("item14count"), NameIndex(0), JsonProperty]
        public string Item14count { get; set; } = "";
        
        [Name("item15"), NameIndex(0), JsonProperty]
        public string Item15 { get; set; } = "";
        
        [Name("item15loc"), NameIndex(0), JsonProperty]
        public string Item15loc { get; set; } = "";
        
        [Name("item15count"), NameIndex(0), JsonProperty]
        public string Item15count { get; set; } = "";
        
    }
}
