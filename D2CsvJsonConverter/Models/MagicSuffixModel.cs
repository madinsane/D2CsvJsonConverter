using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MagicSuffixModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("*comment"), NameIndex(0), JsonProperty]
        public string Comment { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("spawnable"), NameIndex(0), JsonProperty]
        public string Spawnable { get; set; } = "";
        
        [Name("rare"), NameIndex(0), JsonProperty]
        public string Rare { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("maxlevel"), NameIndex(0), JsonProperty]
        public string Maxlevel { get; set; } = "";
        
        [Name("levelreq"), NameIndex(0), JsonProperty]
        public string Levelreq { get; set; } = "";
        
        [Name("classspecific"), NameIndex(0), JsonProperty]
        public string Classspecific { get; set; } = "";
        
        [Name("class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("classlevelreq"), NameIndex(0), JsonProperty]
        public string Classlevelreq { get; set; } = "";
        
        [Name("frequency"), NameIndex(0), JsonProperty]
        public string Frequency { get; set; } = "";
        
        [Name("group"), NameIndex(0), JsonProperty]
        public string Group { get; set; } = "";
        
        [Name("mod1code"), NameIndex(0), JsonProperty]
        public string Mod1code { get; set; } = "";
        
        [Name("mod1param"), NameIndex(0), JsonProperty]
        public string Mod1param { get; set; } = "";
        
        [Name("mod1min"), NameIndex(0), JsonProperty]
        public string Mod1min { get; set; } = "";
        
        [Name("mod1max"), NameIndex(0), JsonProperty]
        public string Mod1max { get; set; } = "";
        
        [Name("mod2code"), NameIndex(0), JsonProperty]
        public string Mod2code { get; set; } = "";
        
        [Name("mod2param"), NameIndex(0), JsonProperty]
        public string Mod2param { get; set; } = "";
        
        [Name("mod2min"), NameIndex(0), JsonProperty]
        public string Mod2min { get; set; } = "";
        
        [Name("mod2max"), NameIndex(0), JsonProperty]
        public string Mod2max { get; set; } = "";
        
        [Name("mod3code"), NameIndex(0), JsonProperty]
        public string Mod3code { get; set; } = "";
        
        [Name("mod3param"), NameIndex(0), JsonProperty]
        public string Mod3param { get; set; } = "";
        
        [Name("mod3min"), NameIndex(0), JsonProperty]
        public string Mod3min { get; set; } = "";
        
        [Name("mod3max"), NameIndex(0), JsonProperty]
        public string Mod3max { get; set; } = "";
        
        [Name("transform"), NameIndex(0), JsonProperty]
        public string Transform { get; set; } = "";
        
        [Name("transformcolor"), NameIndex(0), JsonProperty]
        public string Transformcolor { get; set; } = "";
        
        [Name("itype1"), NameIndex(0), JsonProperty]
        public string Itype1 { get; set; } = "";
        
        [Name("itype2"), NameIndex(0), JsonProperty]
        public string Itype2 { get; set; } = "";
        
        [Name("itype3"), NameIndex(0), JsonProperty]
        public string Itype3 { get; set; } = "";
        
        [Name("itype4"), NameIndex(0), JsonProperty]
        public string Itype4 { get; set; } = "";
        
        [Name("itype5"), NameIndex(0), JsonProperty]
        public string Itype5 { get; set; } = "";
        
        [Name("itype6"), NameIndex(0), JsonProperty]
        public string Itype6 { get; set; } = "";
        
        [Name("itype7"), NameIndex(0), JsonProperty]
        public string Itype7 { get; set; } = "";
        
        [Name("etype1"), NameIndex(0), JsonProperty]
        public string Etype1 { get; set; } = "";
        
        [Name("etype2"), NameIndex(0), JsonProperty]
        public string Etype2 { get; set; } = "";
        
        [Name("etype3"), NameIndex(0), JsonProperty]
        public string Etype3 { get; set; } = "";
        
        [Name("etype4"), NameIndex(0), JsonProperty]
        public string Etype4 { get; set; } = "";
        
        [Name("etype5"), NameIndex(0), JsonProperty]
        public string Etype5 { get; set; } = "";
        
        [Name("divide"), NameIndex(0), JsonProperty]
        public string Divide { get; set; } = "";
        
        [Name("multiply"), NameIndex(0), JsonProperty]
        public string Multiply { get; set; } = "";
        
        [Name("add"), NameIndex(0), JsonProperty]
        public string Add { get; set; } = "";
        
        [Name(""), NameIndex(0), JsonProperty]
        public string Unknown { get; set; } = "";
        
        [Name(""), NameIndex(1), JsonProperty]
        public string Unknown1 { get; set; } = "";
        
        [Name(""), NameIndex(2), JsonProperty]
        public string Unknown2 { get; set; } = "";
        
        [Name(""), NameIndex(3), JsonProperty]
        public string Unknown3 { get; set; } = "";
        
        [Name(""), NameIndex(4), JsonProperty]
        public string Unknown4 { get; set; } = "";
        
        [Name(""), NameIndex(5), JsonProperty]
        public string Unknown5 { get; set; } = "";
        
        [Name(""), NameIndex(6), JsonProperty]
        public string Unknown6 { get; set; } = "";
        
        [Name(""), NameIndex(7), JsonProperty]
        public string Unknown7 { get; set; } = "";
        
        [Name(""), NameIndex(8), JsonProperty]
        public string Unknown8 { get; set; } = "";
        
        [Name(""), NameIndex(9), JsonProperty]
        public string Unknown9 { get; set; } = "";
        
        [Name(""), NameIndex(10), JsonProperty]
        public string Unknown10 { get; set; } = "";
        
        [Name(""), NameIndex(11), JsonProperty]
        public string Unknown11 { get; set; } = "";
        
        [Name(""), NameIndex(12), JsonProperty]
        public string Unknown12 { get; set; } = "";
        
        [Name(""), NameIndex(13), JsonProperty]
        public string Unknown13 { get; set; } = "";
        
        [Name(""), NameIndex(14), JsonProperty]
        public string Unknown14 { get; set; } = "";
        
        [Name(""), NameIndex(15), JsonProperty]
        public string Unknown15 { get; set; } = "";
        
        [Name(""), NameIndex(16), JsonProperty]
        public string Unknown16 { get; set; } = "";
        
        [Name(""), NameIndex(17), JsonProperty]
        public string Unknown17 { get; set; } = "";
        
        [Name(""), NameIndex(18), JsonProperty]
        public string Unknown18 { get; set; } = "";
        
        [Name(""), NameIndex(19), JsonProperty]
        public string Unknown19 { get; set; } = "";
        
        [Name(""), NameIndex(20), JsonProperty]
        public string Unknown20 { get; set; } = "";
        
        [Name(""), NameIndex(21), JsonProperty]
        public string Unknown21 { get; set; } = "";
        
        [Name(""), NameIndex(22), JsonProperty]
        public string Unknown22 { get; set; } = "";
        
        [Name(""), NameIndex(23), JsonProperty]
        public string Unknown23 { get; set; } = "";
        
        [Name(""), NameIndex(24), JsonProperty]
        public string Unknown24 { get; set; } = "";
        
        [Name(""), NameIndex(25), JsonProperty]
        public string Unknown25 { get; set; } = "";
        
        [Name(""), NameIndex(26), JsonProperty]
        public string Unknown26 { get; set; } = "";
        
        [Name(""), NameIndex(27), JsonProperty]
        public string Unknown27 { get; set; } = "";
        
        [Name(""), NameIndex(28), JsonProperty]
        public string Unknown28 { get; set; } = "";
        
        [Name(""), NameIndex(29), JsonProperty]
        public string Unknown29 { get; set; } = "";
        
        [Name(""), NameIndex(30), JsonProperty]
        public string Unknown30 { get; set; } = "";
        
        [Name(""), NameIndex(31), JsonProperty]
        public string Unknown31 { get; set; } = "";
        
        [Name(""), NameIndex(32), JsonProperty]
        public string Unknown32 { get; set; } = "";
        
    }
}
