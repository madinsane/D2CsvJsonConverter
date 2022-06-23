using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class InventoryModel
    {
        [Name("class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("invLeft"), NameIndex(0), JsonProperty]
        public string Invleft { get; set; } = "";
        
        [Name("invRight"), NameIndex(0), JsonProperty]
        public string Invright { get; set; } = "";
        
        [Name("invTop"), NameIndex(0), JsonProperty]
        public string Invtop { get; set; } = "";
        
        [Name("invBottom"), NameIndex(0), JsonProperty]
        public string Invbottom { get; set; } = "";
        
        [Name("gridX"), NameIndex(0), JsonProperty]
        public string Gridx { get; set; } = "";
        
        [Name("gridY"), NameIndex(0), JsonProperty]
        public string Gridy { get; set; } = "";
        
        [Name("gridLeft"), NameIndex(0), JsonProperty]
        public string Gridleft { get; set; } = "";
        
        [Name("gridRight"), NameIndex(0), JsonProperty]
        public string Gridright { get; set; } = "";
        
        [Name("gridTop"), NameIndex(0), JsonProperty]
        public string Gridtop { get; set; } = "";
        
        [Name("gridBottom"), NameIndex(0), JsonProperty]
        public string Gridbottom { get; set; } = "";
        
        [Name("gridBoxWidth"), NameIndex(0), JsonProperty]
        public string Gridboxwidth { get; set; } = "";
        
        [Name("gridBoxHeight"), NameIndex(0), JsonProperty]
        public string Gridboxheight { get; set; } = "";
        
        [Name("rArmLeft"), NameIndex(0), JsonProperty]
        public string Rarmleft { get; set; } = "";
        
        [Name("rArmRight"), NameIndex(0), JsonProperty]
        public string Rarmright { get; set; } = "";
        
        [Name("rArmTop"), NameIndex(0), JsonProperty]
        public string Rarmtop { get; set; } = "";
        
        [Name("rArmBottom"), NameIndex(0), JsonProperty]
        public string Rarmbottom { get; set; } = "";
        
        [Name("rArmWidth"), NameIndex(0), JsonProperty]
        public string Rarmwidth { get; set; } = "";
        
        [Name("rArmHeight"), NameIndex(0), JsonProperty]
        public string Rarmheight { get; set; } = "";
        
        [Name("torsoLeft"), NameIndex(0), JsonProperty]
        public string Torsoleft { get; set; } = "";
        
        [Name("torsoRight"), NameIndex(0), JsonProperty]
        public string Torsoright { get; set; } = "";
        
        [Name("torsoTop"), NameIndex(0), JsonProperty]
        public string Torsotop { get; set; } = "";
        
        [Name("torsoBottom"), NameIndex(0), JsonProperty]
        public string Torsobottom { get; set; } = "";
        
        [Name("torsoWidth"), NameIndex(0), JsonProperty]
        public string Torsowidth { get; set; } = "";
        
        [Name("torsoHeight"), NameIndex(0), JsonProperty]
        public string Torsoheight { get; set; } = "";
        
        [Name("lArmLeft"), NameIndex(0), JsonProperty]
        public string Larmleft { get; set; } = "";
        
        [Name("lArmRight"), NameIndex(0), JsonProperty]
        public string Larmright { get; set; } = "";
        
        [Name("lArmTop"), NameIndex(0), JsonProperty]
        public string Larmtop { get; set; } = "";
        
        [Name("lArmBottom"), NameIndex(0), JsonProperty]
        public string Larmbottom { get; set; } = "";
        
        [Name("lArmWidth"), NameIndex(0), JsonProperty]
        public string Larmwidth { get; set; } = "";
        
        [Name("lArmHeight"), NameIndex(0), JsonProperty]
        public string Larmheight { get; set; } = "";
        
        [Name("headLeft"), NameIndex(0), JsonProperty]
        public string Headleft { get; set; } = "";
        
        [Name("headRight"), NameIndex(0), JsonProperty]
        public string Headright { get; set; } = "";
        
        [Name("headTop"), NameIndex(0), JsonProperty]
        public string Headtop { get; set; } = "";
        
        [Name("headBottom"), NameIndex(0), JsonProperty]
        public string Headbottom { get; set; } = "";
        
        [Name("headWidth"), NameIndex(0), JsonProperty]
        public string Headwidth { get; set; } = "";
        
        [Name("headHeight"), NameIndex(0), JsonProperty]
        public string Headheight { get; set; } = "";
        
        [Name("neckLeft"), NameIndex(0), JsonProperty]
        public string Neckleft { get; set; } = "";
        
        [Name("neckRight"), NameIndex(0), JsonProperty]
        public string Neckright { get; set; } = "";
        
        [Name("neckTop"), NameIndex(0), JsonProperty]
        public string Necktop { get; set; } = "";
        
        [Name("neckBottom"), NameIndex(0), JsonProperty]
        public string Neckbottom { get; set; } = "";
        
        [Name("neckWidth"), NameIndex(0), JsonProperty]
        public string Neckwidth { get; set; } = "";
        
        [Name("neckHeight"), NameIndex(0), JsonProperty]
        public string Neckheight { get; set; } = "";
        
        [Name("rHandLeft"), NameIndex(0), JsonProperty]
        public string Rhandleft { get; set; } = "";
        
        [Name("rHandRight"), NameIndex(0), JsonProperty]
        public string Rhandright { get; set; } = "";
        
        [Name("rHandTop"), NameIndex(0), JsonProperty]
        public string Rhandtop { get; set; } = "";
        
        [Name("rHandBottom"), NameIndex(0), JsonProperty]
        public string Rhandbottom { get; set; } = "";
        
        [Name("rHandWidth"), NameIndex(0), JsonProperty]
        public string Rhandwidth { get; set; } = "";
        
        [Name("rHandHeight"), NameIndex(0), JsonProperty]
        public string Rhandheight { get; set; } = "";
        
        [Name("lHandLeft"), NameIndex(0), JsonProperty]
        public string Lhandleft { get; set; } = "";
        
        [Name("lHandRight"), NameIndex(0), JsonProperty]
        public string Lhandright { get; set; } = "";
        
        [Name("lHandTop"), NameIndex(0), JsonProperty]
        public string Lhandtop { get; set; } = "";
        
        [Name("lHandBottom"), NameIndex(0), JsonProperty]
        public string Lhandbottom { get; set; } = "";
        
        [Name("lHandWidth"), NameIndex(0), JsonProperty]
        public string Lhandwidth { get; set; } = "";
        
        [Name("lHandHeight"), NameIndex(0), JsonProperty]
        public string Lhandheight { get; set; } = "";
        
        [Name("beltLeft"), NameIndex(0), JsonProperty]
        public string Beltleft { get; set; } = "";
        
        [Name("beltRight"), NameIndex(0), JsonProperty]
        public string Beltright { get; set; } = "";
        
        [Name("beltTop"), NameIndex(0), JsonProperty]
        public string Belttop { get; set; } = "";
        
        [Name("beltBottom"), NameIndex(0), JsonProperty]
        public string Beltbottom { get; set; } = "";
        
        [Name("beltWidth"), NameIndex(0), JsonProperty]
        public string Beltwidth { get; set; } = "";
        
        [Name("beltHeight"), NameIndex(0), JsonProperty]
        public string Beltheight { get; set; } = "";
        
        [Name("feetLeft"), NameIndex(0), JsonProperty]
        public string Feetleft { get; set; } = "";
        
        [Name("feetRight"), NameIndex(0), JsonProperty]
        public string Feetright { get; set; } = "";
        
        [Name("feetTop"), NameIndex(0), JsonProperty]
        public string Feettop { get; set; } = "";
        
        [Name("feetBottom"), NameIndex(0), JsonProperty]
        public string Feetbottom { get; set; } = "";
        
        [Name("feetWidth"), NameIndex(0), JsonProperty]
        public string Feetwidth { get; set; } = "";
        
        [Name("feetHeight"), NameIndex(0), JsonProperty]
        public string Feetheight { get; set; } = "";
        
        [Name("glovesLeft"), NameIndex(0), JsonProperty]
        public string Glovesleft { get; set; } = "";
        
        [Name("glovesRight"), NameIndex(0), JsonProperty]
        public string Glovesright { get; set; } = "";
        
        [Name("glovesTop"), NameIndex(0), JsonProperty]
        public string Glovestop { get; set; } = "";
        
        [Name("glovesBottom"), NameIndex(0), JsonProperty]
        public string Glovesbottom { get; set; } = "";
        
        [Name("glovesWidth"), NameIndex(0), JsonProperty]
        public string Gloveswidth { get; set; } = "";
        
        [Name("glovesHeight"), NameIndex(0), JsonProperty]
        public string Glovesheight { get; set; } = "";
        
    }
}
