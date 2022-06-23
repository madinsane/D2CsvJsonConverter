using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class BeltsModel
    {
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("numboxes"), NameIndex(0), JsonProperty]
        public string Numboxes { get; set; } = "";
        
        [Name("boxwidth"), NameIndex(0), JsonProperty]
        public string Boxwidth { get; set; } = "";
        
        [Name("boxheight"), NameIndex(0), JsonProperty]
        public string Boxheight { get; set; } = "";
        
        [Name("box1left"), NameIndex(0), JsonProperty]
        public string Box1left { get; set; } = "";
        
        [Name("box1right"), NameIndex(0), JsonProperty]
        public string Box1right { get; set; } = "";
        
        [Name("box1top"), NameIndex(0), JsonProperty]
        public string Box1top { get; set; } = "";
        
        [Name("box1bottom"), NameIndex(0), JsonProperty]
        public string Box1bottom { get; set; } = "";
        
        [Name("box2left"), NameIndex(0), JsonProperty]
        public string Box2left { get; set; } = "";
        
        [Name("box2right"), NameIndex(0), JsonProperty]
        public string Box2right { get; set; } = "";
        
        [Name("box2top"), NameIndex(0), JsonProperty]
        public string Box2top { get; set; } = "";
        
        [Name("box2bottom"), NameIndex(0), JsonProperty]
        public string Box2bottom { get; set; } = "";
        
        [Name("box3left"), NameIndex(0), JsonProperty]
        public string Box3left { get; set; } = "";
        
        [Name("box3right"), NameIndex(0), JsonProperty]
        public string Box3right { get; set; } = "";
        
        [Name("box3top"), NameIndex(0), JsonProperty]
        public string Box3top { get; set; } = "";
        
        [Name("box3bottom"), NameIndex(0), JsonProperty]
        public string Box3bottom { get; set; } = "";
        
        [Name("box4left"), NameIndex(0), JsonProperty]
        public string Box4left { get; set; } = "";
        
        [Name("box4right"), NameIndex(0), JsonProperty]
        public string Box4right { get; set; } = "";
        
        [Name("box4top"), NameIndex(0), JsonProperty]
        public string Box4top { get; set; } = "";
        
        [Name("box4bottom"), NameIndex(0), JsonProperty]
        public string Box4bottom { get; set; } = "";
        
        [Name("box5left"), NameIndex(0), JsonProperty]
        public string Box5left { get; set; } = "";
        
        [Name("box5right"), NameIndex(0), JsonProperty]
        public string Box5right { get; set; } = "";
        
        [Name("box5top"), NameIndex(0), JsonProperty]
        public string Box5top { get; set; } = "";
        
        [Name("box5bottom"), NameIndex(0), JsonProperty]
        public string Box5bottom { get; set; } = "";
        
        [Name("box6left"), NameIndex(0), JsonProperty]
        public string Box6left { get; set; } = "";
        
        [Name("box6right"), NameIndex(0), JsonProperty]
        public string Box6right { get; set; } = "";
        
        [Name("box6top"), NameIndex(0), JsonProperty]
        public string Box6top { get; set; } = "";
        
        [Name("box6bottom"), NameIndex(0), JsonProperty]
        public string Box6bottom { get; set; } = "";
        
        [Name("box7left"), NameIndex(0), JsonProperty]
        public string Box7left { get; set; } = "";
        
        [Name("box7right"), NameIndex(0), JsonProperty]
        public string Box7right { get; set; } = "";
        
        [Name("box7top"), NameIndex(0), JsonProperty]
        public string Box7top { get; set; } = "";
        
        [Name("box7bottom"), NameIndex(0), JsonProperty]
        public string Box7bottom { get; set; } = "";
        
        [Name("box8left"), NameIndex(0), JsonProperty]
        public string Box8left { get; set; } = "";
        
        [Name("box8right"), NameIndex(0), JsonProperty]
        public string Box8right { get; set; } = "";
        
        [Name("box8top"), NameIndex(0), JsonProperty]
        public string Box8top { get; set; } = "";
        
        [Name("box8bottom"), NameIndex(0), JsonProperty]
        public string Box8bottom { get; set; } = "";
        
        [Name("box9left"), NameIndex(0), JsonProperty]
        public string Box9left { get; set; } = "";
        
        [Name("box9right"), NameIndex(0), JsonProperty]
        public string Box9right { get; set; } = "";
        
        [Name("box9top"), NameIndex(0), JsonProperty]
        public string Box9top { get; set; } = "";
        
        [Name("box9bottom"), NameIndex(0), JsonProperty]
        public string Box9bottom { get; set; } = "";
        
        [Name("box10left"), NameIndex(0), JsonProperty]
        public string Box10left { get; set; } = "";
        
        [Name("box10right"), NameIndex(0), JsonProperty]
        public string Box10right { get; set; } = "";
        
        [Name("box10top"), NameIndex(0), JsonProperty]
        public string Box10top { get; set; } = "";
        
        [Name("box10bottom"), NameIndex(0), JsonProperty]
        public string Box10bottom { get; set; } = "";
        
        [Name("box11left"), NameIndex(0), JsonProperty]
        public string Box11left { get; set; } = "";
        
        [Name("box11right"), NameIndex(0), JsonProperty]
        public string Box11right { get; set; } = "";
        
        [Name("box11top"), NameIndex(0), JsonProperty]
        public string Box11top { get; set; } = "";
        
        [Name("box11bottom"), NameIndex(0), JsonProperty]
        public string Box11bottom { get; set; } = "";
        
        [Name("box12left"), NameIndex(0), JsonProperty]
        public string Box12left { get; set; } = "";
        
        [Name("box12right"), NameIndex(0), JsonProperty]
        public string Box12right { get; set; } = "";
        
        [Name("box12top"), NameIndex(0), JsonProperty]
        public string Box12top { get; set; } = "";
        
        [Name("box12bottom"), NameIndex(0), JsonProperty]
        public string Box12bottom { get; set; } = "";
        
        [Name("box13left"), NameIndex(0), JsonProperty]
        public string Box13left { get; set; } = "";
        
        [Name("box13right"), NameIndex(0), JsonProperty]
        public string Box13right { get; set; } = "";
        
        [Name("box13top"), NameIndex(0), JsonProperty]
        public string Box13top { get; set; } = "";
        
        [Name("box13bottom"), NameIndex(0), JsonProperty]
        public string Box13bottom { get; set; } = "";
        
        [Name("box14left"), NameIndex(0), JsonProperty]
        public string Box14left { get; set; } = "";
        
        [Name("box14right"), NameIndex(0), JsonProperty]
        public string Box14right { get; set; } = "";
        
        [Name("box14top"), NameIndex(0), JsonProperty]
        public string Box14top { get; set; } = "";
        
        [Name("box14bottom"), NameIndex(0), JsonProperty]
        public string Box14bottom { get; set; } = "";
        
        [Name("box15left"), NameIndex(0), JsonProperty]
        public string Box15left { get; set; } = "";
        
        [Name("box15right"), NameIndex(0), JsonProperty]
        public string Box15right { get; set; } = "";
        
        [Name("box15top"), NameIndex(0), JsonProperty]
        public string Box15top { get; set; } = "";
        
        [Name("box15bottom"), NameIndex(0), JsonProperty]
        public string Box15bottom { get; set; } = "";
        
        [Name("box16left"), NameIndex(0), JsonProperty]
        public string Box16left { get; set; } = "";
        
        [Name("box16right"), NameIndex(0), JsonProperty]
        public string Box16right { get; set; } = "";
        
        [Name("box16top"), NameIndex(0), JsonProperty]
        public string Box16top { get; set; } = "";
        
        [Name("box16bottom"), NameIndex(0), JsonProperty]
        public string Box16bottom { get; set; } = "";
        
        [Name("*EOL"), NameIndex(0), JsonProperty]
        public string EOL { get; set; } = "";
        
    }
}
