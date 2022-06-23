using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class HirelingModel
    {
        [Name("Hireling"), NameIndex(0), JsonProperty]
        public string Hireling { get; set; } = "";
        
        [Name("SubType"), NameIndex(0), JsonProperty]
        public string Subtype { get; set; } = "";
        
        [Name("Version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("Class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("Act"), NameIndex(0), JsonProperty]
        public string Act { get; set; } = "";
        
        [Name("Difficulty"), NameIndex(0), JsonProperty]
        public string Difficulty { get; set; } = "";
        
        [Name("Level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("Seller"), NameIndex(0), JsonProperty]
        public string Seller { get; set; } = "";
        
        [Name("NameFirst"), NameIndex(0), JsonProperty]
        public string Namefirst { get; set; } = "";
        
        [Name("NameLast"), NameIndex(0), JsonProperty]
        public string Namelast { get; set; } = "";
        
        [Name("Gold"), NameIndex(0), JsonProperty]
        public string Gold { get; set; } = "";
        
        [Name("Exp/Lvl"), NameIndex(0), JsonProperty]
        public string ExpLvl { get; set; } = "";
        
        [Name("HP"), NameIndex(0), JsonProperty]
        public string HP { get; set; } = "";
        
        [Name("HP/Lvl"), NameIndex(0), JsonProperty]
        public string HPLvl { get; set; } = "";
        
        [Name("Defense"), NameIndex(0), JsonProperty]
        public string Defense { get; set; } = "";
        
        [Name("Def/Lvl"), NameIndex(0), JsonProperty]
        public string DefLvl { get; set; } = "";
        
        [Name("Str"), NameIndex(0), JsonProperty]
        public string Str { get; set; } = "";
        
        [Name("Str/Lvl"), NameIndex(0), JsonProperty]
        public string StrLvl { get; set; } = "";
        
        [Name("Dex"), NameIndex(0), JsonProperty]
        public string Dex { get; set; } = "";
        
        [Name("Dex/Lvl"), NameIndex(0), JsonProperty]
        public string DexLvl { get; set; } = "";
        
        [Name("AR"), NameIndex(0), JsonProperty]
        public string AR { get; set; } = "";
        
        [Name("AR/Lvl"), NameIndex(0), JsonProperty]
        public string ARLvl { get; set; } = "";
        
        [Name("Share"), NameIndex(0), JsonProperty]
        public string Share { get; set; } = "";
        
        [Name("Dmg-Min"), NameIndex(0), JsonProperty]
        public string DmgMin { get; set; } = "";
        
        [Name("Dmg-Max"), NameIndex(0), JsonProperty]
        public string DmgMax { get; set; } = "";
        
        [Name("Dmg/Lvl"), NameIndex(0), JsonProperty]
        public string DmgLvl { get; set; } = "";
        
        [Name("Resist"), NameIndex(0), JsonProperty]
        public string Resist { get; set; } = "";
        
        [Name("Resist/Lvl"), NameIndex(0), JsonProperty]
        public string ResistLvl { get; set; } = "";
        
        [Name("WType1"), NameIndex(0), JsonProperty]
        public string Wtype1 { get; set; } = "";
        
        [Name("WType2"), NameIndex(0), JsonProperty]
        public string Wtype2 { get; set; } = "";
        
        [Name("HireDesc"), NameIndex(0), JsonProperty]
        public string Hiredesc { get; set; } = "";
        
        [Name("DefaultChance"), NameIndex(0), JsonProperty]
        public string Defaultchance { get; set; } = "";
        
        [Name("Skill1"), NameIndex(0), JsonProperty]
        public string Skill1 { get; set; } = "";
        
        [Name("Mode1"), NameIndex(0), JsonProperty]
        public string Mode1 { get; set; } = "";
        
        [Name("Chance1"), NameIndex(0), JsonProperty]
        public string Chance1 { get; set; } = "";
        
        [Name("ChancePerLvl1"), NameIndex(0), JsonProperty]
        public string Chanceperlvl1 { get; set; } = "";
        
        [Name("Level1"), NameIndex(0), JsonProperty]
        public string Level1 { get; set; } = "";
        
        [Name("LvlPerLvl1"), NameIndex(0), JsonProperty]
        public string Lvlperlvl1 { get; set; } = "";
        
        [Name("Skill2"), NameIndex(0), JsonProperty]
        public string Skill2 { get; set; } = "";
        
        [Name("Mode2"), NameIndex(0), JsonProperty]
        public string Mode2 { get; set; } = "";
        
        [Name("Chance2"), NameIndex(0), JsonProperty]
        public string Chance2 { get; set; } = "";
        
        [Name("ChancePerLvl2"), NameIndex(0), JsonProperty]
        public string Chanceperlvl2 { get; set; } = "";
        
        [Name("Level2"), NameIndex(0), JsonProperty]
        public string Level2 { get; set; } = "";
        
        [Name("LvlPerLvl2"), NameIndex(0), JsonProperty]
        public string Lvlperlvl2 { get; set; } = "";
        
        [Name("Skill3"), NameIndex(0), JsonProperty]
        public string Skill3 { get; set; } = "";
        
        [Name("Mode3"), NameIndex(0), JsonProperty]
        public string Mode3 { get; set; } = "";
        
        [Name("Chance3"), NameIndex(0), JsonProperty]
        public string Chance3 { get; set; } = "";
        
        [Name("ChancePerLvl3"), NameIndex(0), JsonProperty]
        public string Chanceperlvl3 { get; set; } = "";
        
        [Name("Level3"), NameIndex(0), JsonProperty]
        public string Level3 { get; set; } = "";
        
        [Name("LvlPerLvl3"), NameIndex(0), JsonProperty]
        public string Lvlperlvl3 { get; set; } = "";
        
        [Name("Skill4"), NameIndex(0), JsonProperty]
        public string Skill4 { get; set; } = "";
        
        [Name("Mode4"), NameIndex(0), JsonProperty]
        public string Mode4 { get; set; } = "";
        
        [Name("Chance4"), NameIndex(0), JsonProperty]
        public string Chance4 { get; set; } = "";
        
        [Name("ChancePerLvl4"), NameIndex(0), JsonProperty]
        public string Chanceperlvl4 { get; set; } = "";
        
        [Name("Level4"), NameIndex(0), JsonProperty]
        public string Level4 { get; set; } = "";
        
        [Name("LvlPerLvl4"), NameIndex(0), JsonProperty]
        public string Lvlperlvl4 { get; set; } = "";
        
        [Name("Skill5"), NameIndex(0), JsonProperty]
        public string Skill5 { get; set; } = "";
        
        [Name("Mode5"), NameIndex(0), JsonProperty]
        public string Mode5 { get; set; } = "";
        
        [Name("Chance5"), NameIndex(0), JsonProperty]
        public string Chance5 { get; set; } = "";
        
        [Name("ChancePerLvl5"), NameIndex(0), JsonProperty]
        public string Chanceperlvl5 { get; set; } = "";
        
        [Name("Level5"), NameIndex(0), JsonProperty]
        public string Level5 { get; set; } = "";
        
        [Name("LvlPerLvl5"), NameIndex(0), JsonProperty]
        public string Lvlperlvl5 { get; set; } = "";
        
        [Name("Skill6"), NameIndex(0), JsonProperty]
        public string Skill6 { get; set; } = "";
        
        [Name("Mode6"), NameIndex(0), JsonProperty]
        public string Mode6 { get; set; } = "";
        
        [Name("Chance6"), NameIndex(0), JsonProperty]
        public string Chance6 { get; set; } = "";
        
        [Name("ChancePerLvl6"), NameIndex(0), JsonProperty]
        public string Chanceperlvl6 { get; set; } = "";
        
        [Name("Level6"), NameIndex(0), JsonProperty]
        public string Level6 { get; set; } = "";
        
        [Name("LvlPerLvl6"), NameIndex(0), JsonProperty]
        public string Lvlperlvl6 { get; set; } = "";
        
        [Name("Head"), NameIndex(0), JsonProperty]
        public string Head { get; set; } = "";
        
        [Name("Torso"), NameIndex(0), JsonProperty]
        public string Torso { get; set; } = "";
        
        [Name("Weapon"), NameIndex(0), JsonProperty]
        public string Weapon { get; set; } = "";
        
        [Name("Shield"), NameIndex(0), JsonProperty]
        public string Shield { get; set; } = "";
        
    }
}
