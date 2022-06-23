using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonSoundsModel
    {
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("Attack1"), NameIndex(0), JsonProperty]
        public string Attack1 { get; set; } = "";
        
        [Name("Weapon1"), NameIndex(0), JsonProperty]
        public string Weapon1 { get; set; } = "";
        
        [Name("Att1Del"), NameIndex(0), JsonProperty]
        public string Att1del { get; set; } = "";
        
        [Name("Wea1Del"), NameIndex(0), JsonProperty]
        public string Wea1del { get; set; } = "";
        
        [Name("Att1Prb"), NameIndex(0), JsonProperty]
        public string Att1prb { get; set; } = "";
        
        [Name("Wea1Vol"), NameIndex(0), JsonProperty]
        public string Wea1vol { get; set; } = "";
        
        [Name("Attack2"), NameIndex(0), JsonProperty]
        public string Attack2 { get; set; } = "";
        
        [Name("Weapon2"), NameIndex(0), JsonProperty]
        public string Weapon2 { get; set; } = "";
        
        [Name("Att2Del"), NameIndex(0), JsonProperty]
        public string Att2del { get; set; } = "";
        
        [Name("Wea2Del"), NameIndex(0), JsonProperty]
        public string Wea2del { get; set; } = "";
        
        [Name("Att2Prb"), NameIndex(0), JsonProperty]
        public string Att2prb { get; set; } = "";
        
        [Name("Wea2Vol"), NameIndex(0), JsonProperty]
        public string Wea2vol { get; set; } = "";
        
        [Name("HitSound"), NameIndex(0), JsonProperty]
        public string Hitsound { get; set; } = "";
        
        [Name("DeathSound"), NameIndex(0), JsonProperty]
        public string Deathsound { get; set; } = "";
        
        [Name("HitDelay"), NameIndex(0), JsonProperty]
        public string Hitdelay { get; set; } = "";
        
        [Name("DeaDelay"), NameIndex(0), JsonProperty]
        public string Deadelay { get; set; } = "";
        
        [Name("Skill1"), NameIndex(0), JsonProperty]
        public string Skill1 { get; set; } = "";
        
        [Name("Skill2"), NameIndex(0), JsonProperty]
        public string Skill2 { get; set; } = "";
        
        [Name("Skill3"), NameIndex(0), JsonProperty]
        public string Skill3 { get; set; } = "";
        
        [Name("Skill4"), NameIndex(0), JsonProperty]
        public string Skill4 { get; set; } = "";
        
        [Name("Footstep"), NameIndex(0), JsonProperty]
        public string Footstep { get; set; } = "";
        
        [Name("FootstepLayer"), NameIndex(0), JsonProperty]
        public string Footsteplayer { get; set; } = "";
        
        [Name("FsCnt"), NameIndex(0), JsonProperty]
        public string Fscnt { get; set; } = "";
        
        [Name("FsOff"), NameIndex(0), JsonProperty]
        public string Fsoff { get; set; } = "";
        
        [Name("FsPrb"), NameIndex(0), JsonProperty]
        public string Fsprb { get; set; } = "";
        
        [Name("Neutral"), NameIndex(0), JsonProperty]
        public string Neutral { get; set; } = "";
        
        [Name("NeuTime"), NameIndex(0), JsonProperty]
        public string Neutime { get; set; } = "";
        
        [Name("Init"), NameIndex(0), JsonProperty]
        public string Init { get; set; } = "";
        
        [Name("Taunt"), NameIndex(0), JsonProperty]
        public string Taunt { get; set; } = "";
        
        [Name("Flee"), NameIndex(0), JsonProperty]
        public string Flee { get; set; } = "";
        
        [Name("CvtMo1"), NameIndex(0), JsonProperty]
        public string Cvtmo1 { get; set; } = "";
        
        [Name("CvtSk1"), NameIndex(0), JsonProperty]
        public string Cvtsk1 { get; set; } = "";
        
        [Name("CvtTgt1"), NameIndex(0), JsonProperty]
        public string Cvttgt1 { get; set; } = "";
        
        [Name("CvtMo2"), NameIndex(0), JsonProperty]
        public string Cvtmo2 { get; set; } = "";
        
        [Name("CvtSk2"), NameIndex(0), JsonProperty]
        public string Cvtsk2 { get; set; } = "";
        
        [Name("CvtTgt2"), NameIndex(0), JsonProperty]
        public string Cvttgt2 { get; set; } = "";
        
        [Name("CvtMo3"), NameIndex(0), JsonProperty]
        public string Cvtmo3 { get; set; } = "";
        
        [Name("CvtSk3"), NameIndex(0), JsonProperty]
        public string Cvtsk3 { get; set; } = "";
        
        [Name("CvtTgt3"), NameIndex(0), JsonProperty]
        public string Cvttgt3 { get; set; } = "";
        
        [Name("EOL"), NameIndex(0), JsonProperty]
        public string EOL { get; set; } = "";
        
    }
}
