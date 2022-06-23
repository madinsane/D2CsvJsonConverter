using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ItemStatCostModel
    {
        [Name("Stat"), NameIndex(0), JsonProperty]
        public string Stat { get; set; } = "";
        
        [Name("ID"), NameIndex(0), JsonProperty]
        public string ID { get; set; } = "";
        
        [Name("Send Other"), NameIndex(0), JsonProperty]
        public string SendOther { get; set; } = "";
        
        [Name("Signed"), NameIndex(0), JsonProperty]
        public string Signed { get; set; } = "";
        
        [Name("Send Bits"), NameIndex(0), JsonProperty]
        public string SendBits { get; set; } = "";
        
        [Name("Send Param Bits"), NameIndex(0), JsonProperty]
        public string SendParamBits { get; set; } = "";
        
        [Name("UpdateAnimRate"), NameIndex(0), JsonProperty]
        public string Updateanimrate { get; set; } = "";
        
        [Name("Saved"), NameIndex(0), JsonProperty]
        public string Saved { get; set; } = "";
        
        [Name("CSvSigned"), NameIndex(0), JsonProperty]
        public string Csvsigned { get; set; } = "";
        
        [Name("CSvBits"), NameIndex(0), JsonProperty]
        public string Csvbits { get; set; } = "";
        
        [Name("CSvParam"), NameIndex(0), JsonProperty]
        public string Csvparam { get; set; } = "";
        
        [Name("fCallback"), NameIndex(0), JsonProperty]
        public string Fcallback { get; set; } = "";
        
        [Name("fMin"), NameIndex(0), JsonProperty]
        public string Fmin { get; set; } = "";
        
        [Name("MinAccr"), NameIndex(0), JsonProperty]
        public string Minaccr { get; set; } = "";
        
        [Name("Encode"), NameIndex(0), JsonProperty]
        public string Encode { get; set; } = "";
        
        [Name("Add"), NameIndex(0), JsonProperty]
        public string Add { get; set; } = "";
        
        [Name("Multiply"), NameIndex(0), JsonProperty]
        public string Multiply { get; set; } = "";
        
        [Name("Divide"), NameIndex(0), JsonProperty]
        public string Divide { get; set; } = "";
        
        [Name("ValShift"), NameIndex(0), JsonProperty]
        public string Valshift { get; set; } = "";
        
        [Name("1.09-Save Bits"), NameIndex(0), JsonProperty]
        public string _109SaveBits { get; set; } = "";
        
        [Name("1.09-Save Add"), NameIndex(0), JsonProperty]
        public string _109SaveAdd { get; set; } = "";
        
        [Name("Save Bits"), NameIndex(0), JsonProperty]
        public string SaveBits { get; set; } = "";
        
        [Name("Save Add"), NameIndex(0), JsonProperty]
        public string SaveAdd { get; set; } = "";
        
        [Name("Save Param Bits"), NameIndex(0), JsonProperty]
        public string SaveParamBits { get; set; } = "";
        
        [Name("keepzero"), NameIndex(0), JsonProperty]
        public string Keepzero { get; set; } = "";
        
        [Name("op"), NameIndex(0), JsonProperty]
        public string Op { get; set; } = "";
        
        [Name("op param"), NameIndex(0), JsonProperty]
        public string OpParam { get; set; } = "";
        
        [Name("op base"), NameIndex(0), JsonProperty]
        public string OpBase { get; set; } = "";
        
        [Name("op stat1"), NameIndex(0), JsonProperty]
        public string OpStat1 { get; set; } = "";
        
        [Name("op stat2"), NameIndex(0), JsonProperty]
        public string OpStat2 { get; set; } = "";
        
        [Name("op stat3"), NameIndex(0), JsonProperty]
        public string OpStat3 { get; set; } = "";
        
        [Name("direct"), NameIndex(0), JsonProperty]
        public string Direct { get; set; } = "";
        
        [Name("maxstat"), NameIndex(0), JsonProperty]
        public string Maxstat { get; set; } = "";
        
        [Name("itemspecific"), NameIndex(0), JsonProperty]
        public string Itemspecific { get; set; } = "";
        
        [Name("damagerelated"), NameIndex(0), JsonProperty]
        public string Damagerelated { get; set; } = "";
        
        [Name("itemevent1"), NameIndex(0), JsonProperty]
        public string Itemevent1 { get; set; } = "";
        
        [Name("itemeventfunc1"), NameIndex(0), JsonProperty]
        public string Itemeventfunc1 { get; set; } = "";
        
        [Name("itemevent2"), NameIndex(0), JsonProperty]
        public string Itemevent2 { get; set; } = "";
        
        [Name("itemeventfunc2"), NameIndex(0), JsonProperty]
        public string Itemeventfunc2 { get; set; } = "";
        
        [Name("descpriority"), NameIndex(0), JsonProperty]
        public string Descpriority { get; set; } = "";
        
        [Name("descfunc"), NameIndex(0), JsonProperty]
        public string Descfunc { get; set; } = "";
        
        [Name("descval"), NameIndex(0), JsonProperty]
        public string Descval { get; set; } = "";
        
        [Name("descstrpos"), NameIndex(0), JsonProperty]
        public string Descstrpos { get; set; } = "";
        
        [Name("descstrneg"), NameIndex(0), JsonProperty]
        public string Descstrneg { get; set; } = "";
        
        [Name("descstr2"), NameIndex(0), JsonProperty]
        public string Descstr2 { get; set; } = "";
        
        [Name("dgrp"), NameIndex(0), JsonProperty]
        public string Dgrp { get; set; } = "";
        
        [Name("dgrpfunc"), NameIndex(0), JsonProperty]
        public string Dgrpfunc { get; set; } = "";
        
        [Name("dgrpval"), NameIndex(0), JsonProperty]
        public string Dgrpval { get; set; } = "";
        
        [Name("dgrpstrpos"), NameIndex(0), JsonProperty]
        public string Dgrpstrpos { get; set; } = "";
        
        [Name("dgrpstrneg"), NameIndex(0), JsonProperty]
        public string Dgrpstrneg { get; set; } = "";
        
        [Name("dgrpstr2"), NameIndex(0), JsonProperty]
        public string Dgrpstr2 { get; set; } = "";
        
        [Name("stuff"), NameIndex(0), JsonProperty]
        public string Stuff { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
