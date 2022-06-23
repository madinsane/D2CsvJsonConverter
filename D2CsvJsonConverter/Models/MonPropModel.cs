using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonPropModel
    {
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("prop1"), NameIndex(0), JsonProperty]
        public string Prop1 { get; set; } = "";
        
        [Name("chance1"), NameIndex(0), JsonProperty]
        public string Chance1 { get; set; } = "";
        
        [Name("par1"), NameIndex(0), JsonProperty]
        public string Par1 { get; set; } = "";
        
        [Name("min1"), NameIndex(0), JsonProperty]
        public string Min1 { get; set; } = "";
        
        [Name("max1"), NameIndex(0), JsonProperty]
        public string Max1 { get; set; } = "";
        
        [Name("prop2"), NameIndex(0), JsonProperty]
        public string Prop2 { get; set; } = "";
        
        [Name("chance2"), NameIndex(0), JsonProperty]
        public string Chance2 { get; set; } = "";
        
        [Name("par2"), NameIndex(0), JsonProperty]
        public string Par2 { get; set; } = "";
        
        [Name("min2"), NameIndex(0), JsonProperty]
        public string Min2 { get; set; } = "";
        
        [Name("max2"), NameIndex(0), JsonProperty]
        public string Max2 { get; set; } = "";
        
        [Name("prop3"), NameIndex(0), JsonProperty]
        public string Prop3 { get; set; } = "";
        
        [Name("chance3"), NameIndex(0), JsonProperty]
        public string Chance3 { get; set; } = "";
        
        [Name("par3"), NameIndex(0), JsonProperty]
        public string Par3 { get; set; } = "";
        
        [Name("min3"), NameIndex(0), JsonProperty]
        public string Min3 { get; set; } = "";
        
        [Name("max3"), NameIndex(0), JsonProperty]
        public string Max3 { get; set; } = "";
        
        [Name("prop4"), NameIndex(0), JsonProperty]
        public string Prop4 { get; set; } = "";
        
        [Name("chance4"), NameIndex(0), JsonProperty]
        public string Chance4 { get; set; } = "";
        
        [Name("par4"), NameIndex(0), JsonProperty]
        public string Par4 { get; set; } = "";
        
        [Name("min4"), NameIndex(0), JsonProperty]
        public string Min4 { get; set; } = "";
        
        [Name("max4"), NameIndex(0), JsonProperty]
        public string Max4 { get; set; } = "";
        
        [Name("prop5"), NameIndex(0), JsonProperty]
        public string Prop5 { get; set; } = "";
        
        [Name("chance5"), NameIndex(0), JsonProperty]
        public string Chance5 { get; set; } = "";
        
        [Name("par5"), NameIndex(0), JsonProperty]
        public string Par5 { get; set; } = "";
        
        [Name("min5"), NameIndex(0), JsonProperty]
        public string Min5 { get; set; } = "";
        
        [Name("max5"), NameIndex(0), JsonProperty]
        public string Max5 { get; set; } = "";
        
        [Name("prop6"), NameIndex(0), JsonProperty]
        public string Prop6 { get; set; } = "";
        
        [Name("chance6"), NameIndex(0), JsonProperty]
        public string Chance6 { get; set; } = "";
        
        [Name("par6"), NameIndex(0), JsonProperty]
        public string Par6 { get; set; } = "";
        
        [Name("min6"), NameIndex(0), JsonProperty]
        public string Min6 { get; set; } = "";
        
        [Name("max6"), NameIndex(0), JsonProperty]
        public string Max6 { get; set; } = "";
        
        [Name("prop1 (N)"), NameIndex(0), JsonProperty]
        public string Prop1N { get; set; } = "";
        
        [Name("chance1 (N)"), NameIndex(0), JsonProperty]
        public string Chance1N { get; set; } = "";
        
        [Name("par1 (N)"), NameIndex(0), JsonProperty]
        public string Par1N { get; set; } = "";
        
        [Name("min1 (N)"), NameIndex(0), JsonProperty]
        public string Min1N { get; set; } = "";
        
        [Name("max1 (N)"), NameIndex(0), JsonProperty]
        public string Max1N { get; set; } = "";
        
        [Name("prop2 (N)"), NameIndex(0), JsonProperty]
        public string Prop2N { get; set; } = "";
        
        [Name("chance2 (N)"), NameIndex(0), JsonProperty]
        public string Chance2N { get; set; } = "";
        
        [Name("par2 (N)"), NameIndex(0), JsonProperty]
        public string Par2N { get; set; } = "";
        
        [Name("min2 (N)"), NameIndex(0), JsonProperty]
        public string Min2N { get; set; } = "";
        
        [Name("max2 (N)"), NameIndex(0), JsonProperty]
        public string Max2N { get; set; } = "";
        
        [Name("prop3 (N)"), NameIndex(0), JsonProperty]
        public string Prop3N { get; set; } = "";
        
        [Name("chance3 (N)"), NameIndex(0), JsonProperty]
        public string Chance3N { get; set; } = "";
        
        [Name("par3 (N)"), NameIndex(0), JsonProperty]
        public string Par3N { get; set; } = "";
        
        [Name("min3 (N)"), NameIndex(0), JsonProperty]
        public string Min3N { get; set; } = "";
        
        [Name("max3 (N)"), NameIndex(0), JsonProperty]
        public string Max3N { get; set; } = "";
        
        [Name("prop4 (N)"), NameIndex(0), JsonProperty]
        public string Prop4N { get; set; } = "";
        
        [Name("chance4 (N)"), NameIndex(0), JsonProperty]
        public string Chance4N { get; set; } = "";
        
        [Name("par4 (N)"), NameIndex(0), JsonProperty]
        public string Par4N { get; set; } = "";
        
        [Name("min4 (N)"), NameIndex(0), JsonProperty]
        public string Min4N { get; set; } = "";
        
        [Name("max4 (N)"), NameIndex(0), JsonProperty]
        public string Max4N { get; set; } = "";
        
        [Name("prop5 (N)"), NameIndex(0), JsonProperty]
        public string Prop5N { get; set; } = "";
        
        [Name("chance5 (N)"), NameIndex(0), JsonProperty]
        public string Chance5N { get; set; } = "";
        
        [Name("par5 (N)"), NameIndex(0), JsonProperty]
        public string Par5N { get; set; } = "";
        
        [Name("min5 (N)"), NameIndex(0), JsonProperty]
        public string Min5N { get; set; } = "";
        
        [Name("max5 (N)"), NameIndex(0), JsonProperty]
        public string Max5N { get; set; } = "";
        
        [Name("prop6 (N)"), NameIndex(0), JsonProperty]
        public string Prop6N { get; set; } = "";
        
        [Name("chance6 (N)"), NameIndex(0), JsonProperty]
        public string Chance6N { get; set; } = "";
        
        [Name("par6 (N)"), NameIndex(0), JsonProperty]
        public string Par6N { get; set; } = "";
        
        [Name("min6 (N)"), NameIndex(0), JsonProperty]
        public string Min6N { get; set; } = "";
        
        [Name("max6 (N)"), NameIndex(0), JsonProperty]
        public string Max6N { get; set; } = "";
        
        [Name("prop1 (H)"), NameIndex(0), JsonProperty]
        public string Prop1H { get; set; } = "";
        
        [Name("chance1 (H)"), NameIndex(0), JsonProperty]
        public string Chance1H { get; set; } = "";
        
        [Name("par1 (H)"), NameIndex(0), JsonProperty]
        public string Par1H { get; set; } = "";
        
        [Name("min1 (H)"), NameIndex(0), JsonProperty]
        public string Min1H { get; set; } = "";
        
        [Name("max1 (H)"), NameIndex(0), JsonProperty]
        public string Max1H { get; set; } = "";
        
        [Name("prop2 (H)"), NameIndex(0), JsonProperty]
        public string Prop2H { get; set; } = "";
        
        [Name("chance2 (H)"), NameIndex(0), JsonProperty]
        public string Chance2H { get; set; } = "";
        
        [Name("par2 (H)"), NameIndex(0), JsonProperty]
        public string Par2H { get; set; } = "";
        
        [Name("min2 (H)"), NameIndex(0), JsonProperty]
        public string Min2H { get; set; } = "";
        
        [Name("max2 (H)"), NameIndex(0), JsonProperty]
        public string Max2H { get; set; } = "";
        
        [Name("prop3 (H)"), NameIndex(0), JsonProperty]
        public string Prop3H { get; set; } = "";
        
        [Name("chance3 (H)"), NameIndex(0), JsonProperty]
        public string Chance3H { get; set; } = "";
        
        [Name("par3 (H)"), NameIndex(0), JsonProperty]
        public string Par3H { get; set; } = "";
        
        [Name("min3 (H)"), NameIndex(0), JsonProperty]
        public string Min3H { get; set; } = "";
        
        [Name("max3 (H)"), NameIndex(0), JsonProperty]
        public string Max3H { get; set; } = "";
        
        [Name("prop4 (H)"), NameIndex(0), JsonProperty]
        public string Prop4H { get; set; } = "";
        
        [Name("chance4 (H)"), NameIndex(0), JsonProperty]
        public string Chance4H { get; set; } = "";
        
        [Name("par4 (H)"), NameIndex(0), JsonProperty]
        public string Par4H { get; set; } = "";
        
        [Name("min4 (H)"), NameIndex(0), JsonProperty]
        public string Min4H { get; set; } = "";
        
        [Name("max4 (H)"), NameIndex(0), JsonProperty]
        public string Max4H { get; set; } = "";
        
        [Name("prop5 (H)"), NameIndex(0), JsonProperty]
        public string Prop5H { get; set; } = "";
        
        [Name("chance5 (H)"), NameIndex(0), JsonProperty]
        public string Chance5H { get; set; } = "";
        
        [Name("par5 (H)"), NameIndex(0), JsonProperty]
        public string Par5H { get; set; } = "";
        
        [Name("min5 (H)"), NameIndex(0), JsonProperty]
        public string Min5H { get; set; } = "";
        
        [Name("max5 (H)"), NameIndex(0), JsonProperty]
        public string Max5H { get; set; } = "";
        
        [Name("prop6 (H)"), NameIndex(0), JsonProperty]
        public string Prop6H { get; set; } = "";
        
        [Name("chance6 (H)"), NameIndex(0), JsonProperty]
        public string Chance6H { get; set; } = "";
        
        [Name("par6 (H)"), NameIndex(0), JsonProperty]
        public string Par6H { get; set; } = "";
        
        [Name("min6 (H)"), NameIndex(0), JsonProperty]
        public string Min6H { get; set; } = "";
        
        [Name("max6 (H)"), NameIndex(0), JsonProperty]
        public string Max6H { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
