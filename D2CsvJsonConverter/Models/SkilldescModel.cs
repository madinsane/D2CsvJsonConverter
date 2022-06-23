using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SkilldescModel
    {
        [Name("skilldesc"), NameIndex(0), JsonProperty]
        public string Skilldesc { get; set; } = "";
        
        [Name("SkillPage"), NameIndex(0), JsonProperty]
        public string Skillpage { get; set; } = "";
        
        [Name("SkillRow"), NameIndex(0), JsonProperty]
        public string Skillrow { get; set; } = "";
        
        [Name("SkillColumn"), NameIndex(0), JsonProperty]
        public string Skillcolumn { get; set; } = "";
        
        [Name("ListRow"), NameIndex(0), JsonProperty]
        public string Listrow { get; set; } = "";
        
        [Name("ListPool"), NameIndex(0), JsonProperty]
        public string Listpool { get; set; } = "";
        
        [Name("IconCel"), NameIndex(0), JsonProperty]
        public string Iconcel { get; set; } = "";
        
        [Name("str name"), NameIndex(0), JsonProperty]
        public string StrName { get; set; } = "";
        
        [Name("str short"), NameIndex(0), JsonProperty]
        public string StrShort { get; set; } = "";
        
        [Name("str long"), NameIndex(0), JsonProperty]
        public string StrLong { get; set; } = "";
        
        [Name("str alt"), NameIndex(0), JsonProperty]
        public string StrAlt { get; set; } = "";
        
        [Name("str mana"), NameIndex(0), JsonProperty]
        public string StrMana { get; set; } = "";
        
        [Name("descdam"), NameIndex(0), JsonProperty]
        public string Descdam { get; set; } = "";
        
        [Name("ddam calc1"), NameIndex(0), JsonProperty]
        public string DdamCalc1 { get; set; } = "";
        
        [Name("ddam calc2"), NameIndex(0), JsonProperty]
        public string DdamCalc2 { get; set; } = "";
        
        [Name("p1dmelem"), NameIndex(0), JsonProperty]
        public string P1dmelem { get; set; } = "";
        
        [Name("p1dmmin"), NameIndex(0), JsonProperty]
        public string P1dmmin { get; set; } = "";
        
        [Name("p1dmmax"), NameIndex(0), JsonProperty]
        public string P1dmmax { get; set; } = "";
        
        [Name("p2dmelem"), NameIndex(0), JsonProperty]
        public string P2dmelem { get; set; } = "";
        
        [Name("p2dmmin"), NameIndex(0), JsonProperty]
        public string P2dmmin { get; set; } = "";
        
        [Name("p2dmmax"), NameIndex(0), JsonProperty]
        public string P2dmmax { get; set; } = "";
        
        [Name("p3dmelem"), NameIndex(0), JsonProperty]
        public string P3dmelem { get; set; } = "";
        
        [Name("p3dmmin"), NameIndex(0), JsonProperty]
        public string P3dmmin { get; set; } = "";
        
        [Name("p3dmmax"), NameIndex(0), JsonProperty]
        public string P3dmmax { get; set; } = "";
        
        [Name("descatt"), NameIndex(0), JsonProperty]
        public string Descatt { get; set; } = "";
        
        [Name("descmissile1"), NameIndex(0), JsonProperty]
        public string Descmissile1 { get; set; } = "";
        
        [Name("descmissile2"), NameIndex(0), JsonProperty]
        public string Descmissile2 { get; set; } = "";
        
        [Name("descmissile3"), NameIndex(0), JsonProperty]
        public string Descmissile3 { get; set; } = "";
        
        [Name("descline1"), NameIndex(0), JsonProperty]
        public string Descline1 { get; set; } = "";
        
        [Name("desctexta1"), NameIndex(0), JsonProperty]
        public string Desctexta1 { get; set; } = "";
        
        [Name("desctextb1"), NameIndex(0), JsonProperty]
        public string Desctextb1 { get; set; } = "";
        
        [Name("desccalca1"), NameIndex(0), JsonProperty]
        public string Desccalca1 { get; set; } = "";
        
        [Name("desccalcb1"), NameIndex(0), JsonProperty]
        public string Desccalcb1 { get; set; } = "";
        
        [Name("descline2"), NameIndex(0), JsonProperty]
        public string Descline2 { get; set; } = "";
        
        [Name("desctexta2"), NameIndex(0), JsonProperty]
        public string Desctexta2 { get; set; } = "";
        
        [Name("desctextb2"), NameIndex(0), JsonProperty]
        public string Desctextb2 { get; set; } = "";
        
        [Name("desccalca2"), NameIndex(0), JsonProperty]
        public string Desccalca2 { get; set; } = "";
        
        [Name("desccalcb2"), NameIndex(0), JsonProperty]
        public string Desccalcb2 { get; set; } = "";
        
        [Name("descline3"), NameIndex(0), JsonProperty]
        public string Descline3 { get; set; } = "";
        
        [Name("desctexta3"), NameIndex(0), JsonProperty]
        public string Desctexta3 { get; set; } = "";
        
        [Name("desctextb3"), NameIndex(0), JsonProperty]
        public string Desctextb3 { get; set; } = "";
        
        [Name("desccalca3"), NameIndex(0), JsonProperty]
        public string Desccalca3 { get; set; } = "";
        
        [Name("desccalcb3"), NameIndex(0), JsonProperty]
        public string Desccalcb3 { get; set; } = "";
        
        [Name("descline4"), NameIndex(0), JsonProperty]
        public string Descline4 { get; set; } = "";
        
        [Name("desctexta4"), NameIndex(0), JsonProperty]
        public string Desctexta4 { get; set; } = "";
        
        [Name("desctextb4"), NameIndex(0), JsonProperty]
        public string Desctextb4 { get; set; } = "";
        
        [Name("desccalca4"), NameIndex(0), JsonProperty]
        public string Desccalca4 { get; set; } = "";
        
        [Name("desccalcb4"), NameIndex(0), JsonProperty]
        public string Desccalcb4 { get; set; } = "";
        
        [Name("descline5"), NameIndex(0), JsonProperty]
        public string Descline5 { get; set; } = "";
        
        [Name("desctexta5"), NameIndex(0), JsonProperty]
        public string Desctexta5 { get; set; } = "";
        
        [Name("desctextb5"), NameIndex(0), JsonProperty]
        public string Desctextb5 { get; set; } = "";
        
        [Name("desccalca5"), NameIndex(0), JsonProperty]
        public string Desccalca5 { get; set; } = "";
        
        [Name("desccalcb5"), NameIndex(0), JsonProperty]
        public string Desccalcb5 { get; set; } = "";
        
        [Name("descline6"), NameIndex(0), JsonProperty]
        public string Descline6 { get; set; } = "";
        
        [Name("desctexta6"), NameIndex(0), JsonProperty]
        public string Desctexta6 { get; set; } = "";
        
        [Name("desctextb6"), NameIndex(0), JsonProperty]
        public string Desctextb6 { get; set; } = "";
        
        [Name("desccalca6"), NameIndex(0), JsonProperty]
        public string Desccalca6 { get; set; } = "";
        
        [Name("desccalcb6"), NameIndex(0), JsonProperty]
        public string Desccalcb6 { get; set; } = "";
        
        [Name("dsc2line1"), NameIndex(0), JsonProperty]
        public string Dsc2line1 { get; set; } = "";
        
        [Name("dsc2texta1"), NameIndex(0), JsonProperty]
        public string Dsc2texta1 { get; set; } = "";
        
        [Name("dsc2textb1"), NameIndex(0), JsonProperty]
        public string Dsc2textb1 { get; set; } = "";
        
        [Name("dsc2calca1"), NameIndex(0), JsonProperty]
        public string Dsc2calca1 { get; set; } = "";
        
        [Name("dsc2calcb1"), NameIndex(0), JsonProperty]
        public string Dsc2calcb1 { get; set; } = "";
        
        [Name("dsc2line2"), NameIndex(0), JsonProperty]
        public string Dsc2line2 { get; set; } = "";
        
        [Name("dsc2texta2"), NameIndex(0), JsonProperty]
        public string Dsc2texta2 { get; set; } = "";
        
        [Name("dsc2textb2"), NameIndex(0), JsonProperty]
        public string Dsc2textb2 { get; set; } = "";
        
        [Name("dsc2calca2"), NameIndex(0), JsonProperty]
        public string Dsc2calca2 { get; set; } = "";
        
        [Name("dsc2calcb2"), NameIndex(0), JsonProperty]
        public string Dsc2calcb2 { get; set; } = "";
        
        [Name("dsc2line3"), NameIndex(0), JsonProperty]
        public string Dsc2line3 { get; set; } = "";
        
        [Name("dsc2texta3"), NameIndex(0), JsonProperty]
        public string Dsc2texta3 { get; set; } = "";
        
        [Name("dsc2textb3"), NameIndex(0), JsonProperty]
        public string Dsc2textb3 { get; set; } = "";
        
        [Name("dsc2calca3"), NameIndex(0), JsonProperty]
        public string Dsc2calca3 { get; set; } = "";
        
        [Name("dsc2calcb3"), NameIndex(0), JsonProperty]
        public string Dsc2calcb3 { get; set; } = "";
        
        [Name("dsc2line4"), NameIndex(0), JsonProperty]
        public string Dsc2line4 { get; set; } = "";
        
        [Name("dsc2texta4"), NameIndex(0), JsonProperty]
        public string Dsc2texta4 { get; set; } = "";
        
        [Name("dsc2textb4"), NameIndex(0), JsonProperty]
        public string Dsc2textb4 { get; set; } = "";
        
        [Name("dsc2calca4"), NameIndex(0), JsonProperty]
        public string Dsc2calca4 { get; set; } = "";
        
        [Name("dsc2calcb4"), NameIndex(0), JsonProperty]
        public string Dsc2calcb4 { get; set; } = "";
        
        [Name("dsc3line1"), NameIndex(0), JsonProperty]
        public string Dsc3line1 { get; set; } = "";
        
        [Name("dsc3texta1"), NameIndex(0), JsonProperty]
        public string Dsc3texta1 { get; set; } = "";
        
        [Name("dsc3textb1"), NameIndex(0), JsonProperty]
        public string Dsc3textb1 { get; set; } = "";
        
        [Name("dsc3calca1"), NameIndex(0), JsonProperty]
        public string Dsc3calca1 { get; set; } = "";
        
        [Name("dsc3calcb1"), NameIndex(0), JsonProperty]
        public string Dsc3calcb1 { get; set; } = "";
        
        [Name("dsc3line2"), NameIndex(0), JsonProperty]
        public string Dsc3line2 { get; set; } = "";
        
        [Name("dsc3texta2"), NameIndex(0), JsonProperty]
        public string Dsc3texta2 { get; set; } = "";
        
        [Name("dsc3textb2"), NameIndex(0), JsonProperty]
        public string Dsc3textb2 { get; set; } = "";
        
        [Name("dsc3calca2"), NameIndex(0), JsonProperty]
        public string Dsc3calca2 { get; set; } = "";
        
        [Name("dsc3calcb2"), NameIndex(0), JsonProperty]
        public string Dsc3calcb2 { get; set; } = "";
        
        [Name("dsc3line3"), NameIndex(0), JsonProperty]
        public string Dsc3line3 { get; set; } = "";
        
        [Name("dsc3texta3"), NameIndex(0), JsonProperty]
        public string Dsc3texta3 { get; set; } = "";
        
        [Name("dsc3textb3"), NameIndex(0), JsonProperty]
        public string Dsc3textb3 { get; set; } = "";
        
        [Name("dsc3calca3"), NameIndex(0), JsonProperty]
        public string Dsc3calca3 { get; set; } = "";
        
        [Name("dsc3calcb3"), NameIndex(0), JsonProperty]
        public string Dsc3calcb3 { get; set; } = "";
        
        [Name("dsc3line4"), NameIndex(0), JsonProperty]
        public string Dsc3line4 { get; set; } = "";
        
        [Name("dsc3texta4"), NameIndex(0), JsonProperty]
        public string Dsc3texta4 { get; set; } = "";
        
        [Name("dsc3textb4"), NameIndex(0), JsonProperty]
        public string Dsc3textb4 { get; set; } = "";
        
        [Name("dsc3calca4"), NameIndex(0), JsonProperty]
        public string Dsc3calca4 { get; set; } = "";
        
        [Name("dsc3calcb4"), NameIndex(0), JsonProperty]
        public string Dsc3calcb4 { get; set; } = "";
        
        [Name("dsc3line5"), NameIndex(0), JsonProperty]
        public string Dsc3line5 { get; set; } = "";
        
        [Name("dsc3texta5"), NameIndex(0), JsonProperty]
        public string Dsc3texta5 { get; set; } = "";
        
        [Name("dsc3textb5"), NameIndex(0), JsonProperty]
        public string Dsc3textb5 { get; set; } = "";
        
        [Name("dsc3calca5"), NameIndex(0), JsonProperty]
        public string Dsc3calca5 { get; set; } = "";
        
        [Name("dsc3calcb5"), NameIndex(0), JsonProperty]
        public string Dsc3calcb5 { get; set; } = "";
        
        [Name("dsc3line6"), NameIndex(0), JsonProperty]
        public string Dsc3line6 { get; set; } = "";
        
        [Name("dsc3texta6"), NameIndex(0), JsonProperty]
        public string Dsc3texta6 { get; set; } = "";
        
        [Name("dsc3textb6"), NameIndex(0), JsonProperty]
        public string Dsc3textb6 { get; set; } = "";
        
        [Name("dsc3calca6"), NameIndex(0), JsonProperty]
        public string Dsc3calca6 { get; set; } = "";
        
        [Name("dsc3calcb6"), NameIndex(0), JsonProperty]
        public string Dsc3calcb6 { get; set; } = "";
        
        [Name("dsc3line7"), NameIndex(0), JsonProperty]
        public string Dsc3line7 { get; set; } = "";
        
        [Name("dsc3texta7"), NameIndex(0), JsonProperty]
        public string Dsc3texta7 { get; set; } = "";
        
        [Name("dsc3textb7"), NameIndex(0), JsonProperty]
        public string Dsc3textb7 { get; set; } = "";
        
        [Name("dsc3calca7"), NameIndex(0), JsonProperty]
        public string Dsc3calca7 { get; set; } = "";
        
        [Name("dsc3calcb7"), NameIndex(0), JsonProperty]
        public string Dsc3calcb7 { get; set; } = "";
        
        [Name("eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
