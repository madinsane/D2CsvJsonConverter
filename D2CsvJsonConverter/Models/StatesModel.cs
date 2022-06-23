using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class StatesModel
    {
        [Name("state"), NameIndex(0), JsonProperty]
        public string State { get; set; } = "";
        
        [Name("id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("group"), NameIndex(0), JsonProperty]
        public string Group { get; set; } = "";
        
        [Name("remhit"), NameIndex(0), JsonProperty]
        public string Remhit { get; set; } = "";
        
        [Name("nosend"), NameIndex(0), JsonProperty]
        public string Nosend { get; set; } = "";
        
        [Name("transform"), NameIndex(0), JsonProperty]
        public string Transform { get; set; } = "";
        
        [Name("aura"), NameIndex(0), JsonProperty]
        public string Aura { get; set; } = "";
        
        [Name("curable"), NameIndex(0), JsonProperty]
        public string Curable { get; set; } = "";
        
        [Name("curse"), NameIndex(0), JsonProperty]
        public string Curse { get; set; } = "";
        
        [Name("active"), NameIndex(0), JsonProperty]
        public string Active { get; set; } = "";
        
        [Name("immed"), NameIndex(0), JsonProperty]
        public string Immed { get; set; } = "";
        
        [Name("restrict"), NameIndex(0), JsonProperty]
        public string Restrict { get; set; } = "";
        
        [Name("disguise"), NameIndex(0), JsonProperty]
        public string Disguise { get; set; } = "";
        
        [Name("blue"), NameIndex(0), JsonProperty]
        public string Blue { get; set; } = "";
        
        [Name("attblue"), NameIndex(0), JsonProperty]
        public string Attblue { get; set; } = "";
        
        [Name("damblue"), NameIndex(0), JsonProperty]
        public string Damblue { get; set; } = "";
        
        [Name("armblue"), NameIndex(0), JsonProperty]
        public string Armblue { get; set; } = "";
        
        [Name("rfblue"), NameIndex(0), JsonProperty]
        public string Rfblue { get; set; } = "";
        
        [Name("rlblue"), NameIndex(0), JsonProperty]
        public string Rlblue { get; set; } = "";
        
        [Name("rcblue"), NameIndex(0), JsonProperty]
        public string Rcblue { get; set; } = "";
        
        [Name("stambarblue"), NameIndex(0), JsonProperty]
        public string Stambarblue { get; set; } = "";
        
        [Name("rpblue"), NameIndex(0), JsonProperty]
        public string Rpblue { get; set; } = "";
        
        [Name("attred"), NameIndex(0), JsonProperty]
        public string Attred { get; set; } = "";
        
        [Name("damred"), NameIndex(0), JsonProperty]
        public string Damred { get; set; } = "";
        
        [Name("armred"), NameIndex(0), JsonProperty]
        public string Armred { get; set; } = "";
        
        [Name("rfred"), NameIndex(0), JsonProperty]
        public string Rfred { get; set; } = "";
        
        [Name("rlred"), NameIndex(0), JsonProperty]
        public string Rlred { get; set; } = "";
        
        [Name("rcred"), NameIndex(0), JsonProperty]
        public string Rcred { get; set; } = "";
        
        [Name("rpred"), NameIndex(0), JsonProperty]
        public string Rpred { get; set; } = "";
        
        [Name("exp"), NameIndex(0), JsonProperty]
        public string Exp { get; set; } = "";
        
        [Name("plrstaydeath"), NameIndex(0), JsonProperty]
        public string Plrstaydeath { get; set; } = "";
        
        [Name("monstaydeath"), NameIndex(0), JsonProperty]
        public string Monstaydeath { get; set; } = "";
        
        [Name("bossstaydeath"), NameIndex(0), JsonProperty]
        public string Bossstaydeath { get; set; } = "";
        
        [Name("hide"), NameIndex(0), JsonProperty]
        public string Hide { get; set; } = "";
        
        [Name("shatter"), NameIndex(0), JsonProperty]
        public string Shatter { get; set; } = "";
        
        [Name("udead"), NameIndex(0), JsonProperty]
        public string Udead { get; set; } = "";
        
        [Name("life"), NameIndex(0), JsonProperty]
        public string Life { get; set; } = "";
        
        [Name("green"), NameIndex(0), JsonProperty]
        public string Green { get; set; } = "";
        
        [Name("pgsv"), NameIndex(0), JsonProperty]
        public string Pgsv { get; set; } = "";
        
        [Name("nooverlays"), NameIndex(0), JsonProperty]
        public string Nooverlays { get; set; } = "";
        
        [Name("noclear"), NameIndex(0), JsonProperty]
        public string Noclear { get; set; } = "";
        
        [Name("bossinv"), NameIndex(0), JsonProperty]
        public string Bossinv { get; set; } = "";
        
        [Name("meleeonly"), NameIndex(0), JsonProperty]
        public string Meleeonly { get; set; } = "";
        
        [Name("notondead"), NameIndex(0), JsonProperty]
        public string Notondead { get; set; } = "";
        
        [Name("overlay1"), NameIndex(0), JsonProperty]
        public string Overlay1 { get; set; } = "";
        
        [Name("overlay2"), NameIndex(0), JsonProperty]
        public string Overlay2 { get; set; } = "";
        
        [Name("overlay3"), NameIndex(0), JsonProperty]
        public string Overlay3 { get; set; } = "";
        
        [Name("overlay4"), NameIndex(0), JsonProperty]
        public string Overlay4 { get; set; } = "";
        
        [Name("pgsvoverlay"), NameIndex(0), JsonProperty]
        public string Pgsvoverlay { get; set; } = "";
        
        [Name("castoverlay"), NameIndex(0), JsonProperty]
        public string Castoverlay { get; set; } = "";
        
        [Name("removerlay"), NameIndex(0), JsonProperty]
        public string Removerlay { get; set; } = "";
        
        [Name("stat"), NameIndex(0), JsonProperty]
        public string Stat { get; set; } = "";
        
        [Name("setfunc"), NameIndex(0), JsonProperty]
        public string Setfunc { get; set; } = "";
        
        [Name("remfunc"), NameIndex(0), JsonProperty]
        public string Remfunc { get; set; } = "";
        
        [Name("missile"), NameIndex(0), JsonProperty]
        public string Missile { get; set; } = "";
        
        [Name("skill"), NameIndex(0), JsonProperty]
        public string Skill { get; set; } = "";
        
        [Name("itemtype"), NameIndex(0), JsonProperty]
        public string Itemtype { get; set; } = "";
        
        [Name("itemtrans"), NameIndex(0), JsonProperty]
        public string Itemtrans { get; set; } = "";
        
        [Name("colorpri"), NameIndex(0), JsonProperty]
        public string Colorpri { get; set; } = "";
        
        [Name("colorshift"), NameIndex(0), JsonProperty]
        public string Colorshift { get; set; } = "";
        
        [Name("light-r"), NameIndex(0), JsonProperty]
        public string LightR { get; set; } = "";
        
        [Name("light-g"), NameIndex(0), JsonProperty]
        public string LightG { get; set; } = "";
        
        [Name("light-b"), NameIndex(0), JsonProperty]
        public string LightB { get; set; } = "";
        
        [Name("onsound"), NameIndex(0), JsonProperty]
        public string Onsound { get; set; } = "";
        
        [Name("offsound"), NameIndex(0), JsonProperty]
        public string Offsound { get; set; } = "";
        
        [Name("gfxtype"), NameIndex(0), JsonProperty]
        public string Gfxtype { get; set; } = "";
        
        [Name("gfxclass"), NameIndex(0), JsonProperty]
        public string Gfxclass { get; set; } = "";
        
        [Name("cltevent"), NameIndex(0), JsonProperty]
        public string Cltevent { get; set; } = "";
        
        [Name("clteventfunc"), NameIndex(0), JsonProperty]
        public string Clteventfunc { get; set; } = "";
        
        [Name("cltactivefunc"), NameIndex(0), JsonProperty]
        public string Cltactivefunc { get; set; } = "";
        
        [Name("srvactivefunc"), NameIndex(0), JsonProperty]
        public string Srvactivefunc { get; set; } = "";
        
        [Name("eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
