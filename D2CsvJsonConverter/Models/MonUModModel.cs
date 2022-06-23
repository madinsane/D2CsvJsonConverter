using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonUModModel
    {
        [Name("uniquemod"), NameIndex(0), JsonProperty]
        public string Uniquemod { get; set; } = "";
        
        [Name("id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("enabled"), NameIndex(0), JsonProperty]
        public string Enabled { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("xfer"), NameIndex(0), JsonProperty]
        public string Xfer { get; set; } = "";
        
        [Name("champion"), NameIndex(0), JsonProperty]
        public string Champion { get; set; } = "";
        
        [Name("fPick"), NameIndex(0), JsonProperty]
        public string Fpick { get; set; } = "";
        
        [Name("exclude1"), NameIndex(0), JsonProperty]
        public string Exclude1 { get; set; } = "";
        
        [Name("exclude2"), NameIndex(0), JsonProperty]
        public string Exclude2 { get; set; } = "";
        
        [Name("cpick"), NameIndex(0), JsonProperty]
        public string Cpick { get; set; } = "";
        
        [Name("cpick (N)"), NameIndex(0), JsonProperty]
        public string CpickN { get; set; } = "";
        
        [Name("cpick (H)"), NameIndex(0), JsonProperty]
        public string CpickH { get; set; } = "";
        
        [Name("upick"), NameIndex(0), JsonProperty]
        public string Upick { get; set; } = "";
        
        [Name("upick (N)"), NameIndex(0), JsonProperty]
        public string UpickN { get; set; } = "";
        
        [Name("upick (H)"), NameIndex(0), JsonProperty]
        public string UpickH { get; set; } = "";
        
        [Name("fInit"), NameIndex(0), JsonProperty]
        public string Finit { get; set; } = "";
        
        [Name("constants"), NameIndex(0), JsonProperty]
        public string Constants { get; set; } = "";
        
        [Name("*constant desc"), NameIndex(0), JsonProperty]
        public string ConstantDesc { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
