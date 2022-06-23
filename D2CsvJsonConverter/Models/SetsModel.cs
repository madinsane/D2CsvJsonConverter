using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SetsModel
    {
        [Name("index"), NameIndex(0), JsonProperty]
        public string Index { get; set; } = "";
        
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("PCode2a"), NameIndex(0), JsonProperty]
        public string Pcode2a { get; set; } = "";
        
        [Name("PParam2a"), NameIndex(0), JsonProperty]
        public string Pparam2a { get; set; } = "";
        
        [Name("PMin2a"), NameIndex(0), JsonProperty]
        public string Pmin2a { get; set; } = "";
        
        [Name("PMax2a"), NameIndex(0), JsonProperty]
        public string Pmax2a { get; set; } = "";
        
        [Name("PCode2b"), NameIndex(0), JsonProperty]
        public string Pcode2b { get; set; } = "";
        
        [Name("PParam2b"), NameIndex(0), JsonProperty]
        public string Pparam2b { get; set; } = "";
        
        [Name("PMin2b"), NameIndex(0), JsonProperty]
        public string Pmin2b { get; set; } = "";
        
        [Name("PMax2b"), NameIndex(0), JsonProperty]
        public string Pmax2b { get; set; } = "";
        
        [Name("PCode3a"), NameIndex(0), JsonProperty]
        public string Pcode3a { get; set; } = "";
        
        [Name("PParam3a"), NameIndex(0), JsonProperty]
        public string Pparam3a { get; set; } = "";
        
        [Name("PMin3a"), NameIndex(0), JsonProperty]
        public string Pmin3a { get; set; } = "";
        
        [Name("PMax3a"), NameIndex(0), JsonProperty]
        public string Pmax3a { get; set; } = "";
        
        [Name("PCode3b"), NameIndex(0), JsonProperty]
        public string Pcode3b { get; set; } = "";
        
        [Name("PParam3b"), NameIndex(0), JsonProperty]
        public string Pparam3b { get; set; } = "";
        
        [Name("PMin3b"), NameIndex(0), JsonProperty]
        public string Pmin3b { get; set; } = "";
        
        [Name("PMax3b"), NameIndex(0), JsonProperty]
        public string Pmax3b { get; set; } = "";
        
        [Name("PCode4a"), NameIndex(0), JsonProperty]
        public string Pcode4a { get; set; } = "";
        
        [Name("PParam4a"), NameIndex(0), JsonProperty]
        public string Pparam4a { get; set; } = "";
        
        [Name("PMin4a"), NameIndex(0), JsonProperty]
        public string Pmin4a { get; set; } = "";
        
        [Name("PMax4a"), NameIndex(0), JsonProperty]
        public string Pmax4a { get; set; } = "";
        
        [Name("PCode4b"), NameIndex(0), JsonProperty]
        public string Pcode4b { get; set; } = "";
        
        [Name("PParam4b"), NameIndex(0), JsonProperty]
        public string Pparam4b { get; set; } = "";
        
        [Name("PMin4b"), NameIndex(0), JsonProperty]
        public string Pmin4b { get; set; } = "";
        
        [Name("PMax4b"), NameIndex(0), JsonProperty]
        public string Pmax4b { get; set; } = "";
        
        [Name("PCode5a"), NameIndex(0), JsonProperty]
        public string Pcode5a { get; set; } = "";
        
        [Name("PParam5a"), NameIndex(0), JsonProperty]
        public string Pparam5a { get; set; } = "";
        
        [Name("PMin5a"), NameIndex(0), JsonProperty]
        public string Pmin5a { get; set; } = "";
        
        [Name("PMax5a"), NameIndex(0), JsonProperty]
        public string Pmax5a { get; set; } = "";
        
        [Name("PCode5b"), NameIndex(0), JsonProperty]
        public string Pcode5b { get; set; } = "";
        
        [Name("PParam5b"), NameIndex(0), JsonProperty]
        public string Pparam5b { get; set; } = "";
        
        [Name("PMin5b"), NameIndex(0), JsonProperty]
        public string Pmin5b { get; set; } = "";
        
        [Name("PMax5b"), NameIndex(0), JsonProperty]
        public string Pmax5b { get; set; } = "";
        
        [Name("FCode1"), NameIndex(0), JsonProperty]
        public string Fcode1 { get; set; } = "";
        
        [Name("FParam1"), NameIndex(0), JsonProperty]
        public string Fparam1 { get; set; } = "";
        
        [Name("FMin1"), NameIndex(0), JsonProperty]
        public string Fmin1 { get; set; } = "";
        
        [Name("FMax1"), NameIndex(0), JsonProperty]
        public string Fmax1 { get; set; } = "";
        
        [Name("FCode2"), NameIndex(0), JsonProperty]
        public string Fcode2 { get; set; } = "";
        
        [Name("FParam2"), NameIndex(0), JsonProperty]
        public string Fparam2 { get; set; } = "";
        
        [Name("FMin2"), NameIndex(0), JsonProperty]
        public string Fmin2 { get; set; } = "";
        
        [Name("FMax2"), NameIndex(0), JsonProperty]
        public string Fmax2 { get; set; } = "";
        
        [Name("FCode3"), NameIndex(0), JsonProperty]
        public string Fcode3 { get; set; } = "";
        
        [Name("FParam3"), NameIndex(0), JsonProperty]
        public string Fparam3 { get; set; } = "";
        
        [Name("FMin3"), NameIndex(0), JsonProperty]
        public string Fmin3 { get; set; } = "";
        
        [Name("FMax3"), NameIndex(0), JsonProperty]
        public string Fmax3 { get; set; } = "";
        
        [Name("FCode4"), NameIndex(0), JsonProperty]
        public string Fcode4 { get; set; } = "";
        
        [Name("FParam4"), NameIndex(0), JsonProperty]
        public string Fparam4 { get; set; } = "";
        
        [Name("FMin4"), NameIndex(0), JsonProperty]
        public string Fmin4 { get; set; } = "";
        
        [Name("FMax4"), NameIndex(0), JsonProperty]
        public string Fmax4 { get; set; } = "";
        
        [Name("FCode5"), NameIndex(0), JsonProperty]
        public string Fcode5 { get; set; } = "";
        
        [Name("FParam5"), NameIndex(0), JsonProperty]
        public string Fparam5 { get; set; } = "";
        
        [Name("FMin5"), NameIndex(0), JsonProperty]
        public string Fmin5 { get; set; } = "";
        
        [Name("FMax5"), NameIndex(0), JsonProperty]
        public string Fmax5 { get; set; } = "";
        
        [Name("FCode6"), NameIndex(0), JsonProperty]
        public string Fcode6 { get; set; } = "";
        
        [Name("FParam6"), NameIndex(0), JsonProperty]
        public string Fparam6 { get; set; } = "";
        
        [Name("FMin6"), NameIndex(0), JsonProperty]
        public string Fmin6 { get; set; } = "";
        
        [Name("FMax6"), NameIndex(0), JsonProperty]
        public string Fmax6 { get; set; } = "";
        
        [Name("FCode7"), NameIndex(0), JsonProperty]
        public string Fcode7 { get; set; } = "";
        
        [Name("FParam7"), NameIndex(0), JsonProperty]
        public string Fparam7 { get; set; } = "";
        
        [Name("FMin7"), NameIndex(0), JsonProperty]
        public string Fmin7 { get; set; } = "";
        
        [Name("FMax7"), NameIndex(0), JsonProperty]
        public string Fmax7 { get; set; } = "";
        
        [Name("FCode8"), NameIndex(0), JsonProperty]
        public string Fcode8 { get; set; } = "";
        
        [Name("FParam8"), NameIndex(0), JsonProperty]
        public string Fparam8 { get; set; } = "";
        
        [Name("FMin8"), NameIndex(0), JsonProperty]
        public string Fmin8 { get; set; } = "";
        
        [Name("FMax8"), NameIndex(0), JsonProperty]
        public string Fmax8 { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
