using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SetItemsModel
    {
        [Name("index"), NameIndex(0), JsonProperty]
        public string Index { get; set; } = "";
        
        [Name("set"), NameIndex(0), JsonProperty]
        public string Set { get; set; } = "";
        
        [Name("item"), NameIndex(0), JsonProperty]
        public string Item { get; set; } = "";
        
        [Name("*item"), NameIndex(0), JsonProperty]
        public string _Item { get; set; } = "";
        
        [Name("rarity"), NameIndex(0), JsonProperty]
        public string Rarity { get; set; } = "";
        
        [Name("lvl"), NameIndex(0), JsonProperty]
        public string Lvl { get; set; } = "";
        
        [Name("lvl req"), NameIndex(0), JsonProperty]
        public string LvlReq { get; set; } = "";
        
        [Name("chrtransform"), NameIndex(0), JsonProperty]
        public string Chrtransform { get; set; } = "";
        
        [Name("invtransform"), NameIndex(0), JsonProperty]
        public string Invtransform { get; set; } = "";
        
        [Name("invfile"), NameIndex(0), JsonProperty]
        public string Invfile { get; set; } = "";
        
        [Name("flippyfile"), NameIndex(0), JsonProperty]
        public string Flippyfile { get; set; } = "";
        
        [Name("dropsound"), NameIndex(0), JsonProperty]
        public string Dropsound { get; set; } = "";
        
        [Name("dropsfxframe"), NameIndex(0), JsonProperty]
        public string Dropsfxframe { get; set; } = "";
        
        [Name("usesound"), NameIndex(0), JsonProperty]
        public string Usesound { get; set; } = "";
        
        [Name("cost mult"), NameIndex(0), JsonProperty]
        public string CostMult { get; set; } = "";
        
        [Name("cost add"), NameIndex(0), JsonProperty]
        public string CostAdd { get; set; } = "";
        
        [Name("add func"), NameIndex(0), JsonProperty]
        public string AddFunc { get; set; } = "";
        
        [Name("prop1"), NameIndex(0), JsonProperty]
        public string Prop1 { get; set; } = "";
        
        [Name("par1"), NameIndex(0), JsonProperty]
        public string Par1 { get; set; } = "";
        
        [Name("min1"), NameIndex(0), JsonProperty]
        public string Min1 { get; set; } = "";
        
        [Name("max1"), NameIndex(0), JsonProperty]
        public string Max1 { get; set; } = "";
        
        [Name("prop2"), NameIndex(0), JsonProperty]
        public string Prop2 { get; set; } = "";
        
        [Name("par2"), NameIndex(0), JsonProperty]
        public string Par2 { get; set; } = "";
        
        [Name("min2"), NameIndex(0), JsonProperty]
        public string Min2 { get; set; } = "";
        
        [Name("max2"), NameIndex(0), JsonProperty]
        public string Max2 { get; set; } = "";
        
        [Name("prop3"), NameIndex(0), JsonProperty]
        public string Prop3 { get; set; } = "";
        
        [Name("par3"), NameIndex(0), JsonProperty]
        public string Par3 { get; set; } = "";
        
        [Name("min3"), NameIndex(0), JsonProperty]
        public string Min3 { get; set; } = "";
        
        [Name("max3"), NameIndex(0), JsonProperty]
        public string Max3 { get; set; } = "";
        
        [Name("prop4"), NameIndex(0), JsonProperty]
        public string Prop4 { get; set; } = "";
        
        [Name("par4"), NameIndex(0), JsonProperty]
        public string Par4 { get; set; } = "";
        
        [Name("min4"), NameIndex(0), JsonProperty]
        public string Min4 { get; set; } = "";
        
        [Name("max4"), NameIndex(0), JsonProperty]
        public string Max4 { get; set; } = "";
        
        [Name("prop5"), NameIndex(0), JsonProperty]
        public string Prop5 { get; set; } = "";
        
        [Name("par5"), NameIndex(0), JsonProperty]
        public string Par5 { get; set; } = "";
        
        [Name("min5"), NameIndex(0), JsonProperty]
        public string Min5 { get; set; } = "";
        
        [Name("max5"), NameIndex(0), JsonProperty]
        public string Max5 { get; set; } = "";
        
        [Name("prop6"), NameIndex(0), JsonProperty]
        public string Prop6 { get; set; } = "";
        
        [Name("par6"), NameIndex(0), JsonProperty]
        public string Par6 { get; set; } = "";
        
        [Name("min6"), NameIndex(0), JsonProperty]
        public string Min6 { get; set; } = "";
        
        [Name("max6"), NameIndex(0), JsonProperty]
        public string Max6 { get; set; } = "";
        
        [Name("prop7"), NameIndex(0), JsonProperty]
        public string Prop7 { get; set; } = "";
        
        [Name("par7"), NameIndex(0), JsonProperty]
        public string Par7 { get; set; } = "";
        
        [Name("min7"), NameIndex(0), JsonProperty]
        public string Min7 { get; set; } = "";
        
        [Name("max7"), NameIndex(0), JsonProperty]
        public string Max7 { get; set; } = "";
        
        [Name("prop8"), NameIndex(0), JsonProperty]
        public string Prop8 { get; set; } = "";
        
        [Name("par8"), NameIndex(0), JsonProperty]
        public string Par8 { get; set; } = "";
        
        [Name("min8"), NameIndex(0), JsonProperty]
        public string Min8 { get; set; } = "";
        
        [Name("max8"), NameIndex(0), JsonProperty]
        public string Max8 { get; set; } = "";
        
        [Name("prop9"), NameIndex(0), JsonProperty]
        public string Prop9 { get; set; } = "";
        
        [Name("par9"), NameIndex(0), JsonProperty]
        public string Par9 { get; set; } = "";
        
        [Name("min9"), NameIndex(0), JsonProperty]
        public string Min9 { get; set; } = "";
        
        [Name("max9"), NameIndex(0), JsonProperty]
        public string Max9 { get; set; } = "";
        
        [Name("aprop1a"), NameIndex(0), JsonProperty]
        public string Aprop1a { get; set; } = "";
        
        [Name("apar1a"), NameIndex(0), JsonProperty]
        public string Apar1a { get; set; } = "";
        
        [Name("amin1a"), NameIndex(0), JsonProperty]
        public string Amin1a { get; set; } = "";
        
        [Name("amax1a"), NameIndex(0), JsonProperty]
        public string Amax1a { get; set; } = "";
        
        [Name("aprop1b"), NameIndex(0), JsonProperty]
        public string Aprop1b { get; set; } = "";
        
        [Name("apar1b"), NameIndex(0), JsonProperty]
        public string Apar1b { get; set; } = "";
        
        [Name("amin1b"), NameIndex(0), JsonProperty]
        public string Amin1b { get; set; } = "";
        
        [Name("amax1b"), NameIndex(0), JsonProperty]
        public string Amax1b { get; set; } = "";
        
        [Name("aprop2a"), NameIndex(0), JsonProperty]
        public string Aprop2a { get; set; } = "";
        
        [Name("apar2a"), NameIndex(0), JsonProperty]
        public string Apar2a { get; set; } = "";
        
        [Name("amin2a"), NameIndex(0), JsonProperty]
        public string Amin2a { get; set; } = "";
        
        [Name("amax2a"), NameIndex(0), JsonProperty]
        public string Amax2a { get; set; } = "";
        
        [Name("aprop2b"), NameIndex(0), JsonProperty]
        public string Aprop2b { get; set; } = "";
        
        [Name("apar2b"), NameIndex(0), JsonProperty]
        public string Apar2b { get; set; } = "";
        
        [Name("amin2b"), NameIndex(0), JsonProperty]
        public string Amin2b { get; set; } = "";
        
        [Name("amax2b"), NameIndex(0), JsonProperty]
        public string Amax2b { get; set; } = "";
        
        [Name("aprop3a"), NameIndex(0), JsonProperty]
        public string Aprop3a { get; set; } = "";
        
        [Name("apar3a"), NameIndex(0), JsonProperty]
        public string Apar3a { get; set; } = "";
        
        [Name("amin3a"), NameIndex(0), JsonProperty]
        public string Amin3a { get; set; } = "";
        
        [Name("amax3a"), NameIndex(0), JsonProperty]
        public string Amax3a { get; set; } = "";
        
        [Name("aprop3b"), NameIndex(0), JsonProperty]
        public string Aprop3b { get; set; } = "";
        
        [Name("apar3b"), NameIndex(0), JsonProperty]
        public string Apar3b { get; set; } = "";
        
        [Name("amin3b"), NameIndex(0), JsonProperty]
        public string Amin3b { get; set; } = "";
        
        [Name("amax3b"), NameIndex(0), JsonProperty]
        public string Amax3b { get; set; } = "";
        
        [Name("aprop4a"), NameIndex(0), JsonProperty]
        public string Aprop4a { get; set; } = "";
        
        [Name("apar4a"), NameIndex(0), JsonProperty]
        public string Apar4a { get; set; } = "";
        
        [Name("amin4a"), NameIndex(0), JsonProperty]
        public string Amin4a { get; set; } = "";
        
        [Name("amax4a"), NameIndex(0), JsonProperty]
        public string Amax4a { get; set; } = "";
        
        [Name("aprop4b"), NameIndex(0), JsonProperty]
        public string Aprop4b { get; set; } = "";
        
        [Name("apar4b"), NameIndex(0), JsonProperty]
        public string Apar4b { get; set; } = "";
        
        [Name("amin4b"), NameIndex(0), JsonProperty]
        public string Amin4b { get; set; } = "";
        
        [Name("amax4b"), NameIndex(0), JsonProperty]
        public string Amax4b { get; set; } = "";
        
        [Name("aprop5a"), NameIndex(0), JsonProperty]
        public string Aprop5a { get; set; } = "";
        
        [Name("apar5a"), NameIndex(0), JsonProperty]
        public string Apar5a { get; set; } = "";
        
        [Name("amin5a"), NameIndex(0), JsonProperty]
        public string Amin5a { get; set; } = "";
        
        [Name("amax5a"), NameIndex(0), JsonProperty]
        public string Amax5a { get; set; } = "";
        
        [Name("aprop5b"), NameIndex(0), JsonProperty]
        public string Aprop5b { get; set; } = "";
        
        [Name("apar5b"), NameIndex(0), JsonProperty]
        public string Apar5b { get; set; } = "";
        
        [Name("amin5b"), NameIndex(0), JsonProperty]
        public string Amin5b { get; set; } = "";
        
        [Name("amax5b"), NameIndex(0), JsonProperty]
        public string Amax5b { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
