using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ItemTypesModel
    {
        [Name("ItemType"), NameIndex(0), JsonProperty]
        public string Itemtype { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("Equiv1"), NameIndex(0), JsonProperty]
        public string Equiv1 { get; set; } = "";
        
        [Name("Equiv2"), NameIndex(0), JsonProperty]
        public string Equiv2 { get; set; } = "";
        
        [Name("Repair"), NameIndex(0), JsonProperty]
        public string Repair { get; set; } = "";
        
        [Name("Body"), NameIndex(0), JsonProperty]
        public string Body { get; set; } = "";
        
        [Name("BodyLoc1"), NameIndex(0), JsonProperty]
        public string Bodyloc1 { get; set; } = "";
        
        [Name("BodyLoc2"), NameIndex(0), JsonProperty]
        public string Bodyloc2 { get; set; } = "";
        
        [Name("Shoots"), NameIndex(0), JsonProperty]
        public string Shoots { get; set; } = "";
        
        [Name("Quiver"), NameIndex(0), JsonProperty]
        public string Quiver { get; set; } = "";
        
        [Name("Throwable"), NameIndex(0), JsonProperty]
        public string Throwable { get; set; } = "";
        
        [Name("Reload"), NameIndex(0), JsonProperty]
        public string Reload { get; set; } = "";
        
        [Name("ReEquip"), NameIndex(0), JsonProperty]
        public string Reequip { get; set; } = "";
        
        [Name("AutoStack"), NameIndex(0), JsonProperty]
        public string Autostack { get; set; } = "";
        
        [Name("Magic"), NameIndex(0), JsonProperty]
        public string Magic { get; set; } = "";
        
        [Name("Rare"), NameIndex(0), JsonProperty]
        public string Rare { get; set; } = "";
        
        [Name("Normal"), NameIndex(0), JsonProperty]
        public string Normal { get; set; } = "";
        
        [Name("Charm"), NameIndex(0), JsonProperty]
        public string Charm { get; set; } = "";
        
        [Name("Gem"), NameIndex(0), JsonProperty]
        public string Gem { get; set; } = "";
        
        [Name("Beltable"), NameIndex(0), JsonProperty]
        public string Beltable { get; set; } = "";
        
        [Name("MaxSock1"), NameIndex(0), JsonProperty]
        public string Maxsock1 { get; set; } = "";
        
        [Name("MaxSock25"), NameIndex(0), JsonProperty]
        public string Maxsock25 { get; set; } = "";
        
        [Name("MaxSock40"), NameIndex(0), JsonProperty]
        public string Maxsock40 { get; set; } = "";
        
        [Name("TreasureClass"), NameIndex(0), JsonProperty]
        public string Treasureclass { get; set; } = "";
        
        [Name("Rarity"), NameIndex(0), JsonProperty]
        public string Rarity { get; set; } = "";
        
        [Name("StaffMods"), NameIndex(0), JsonProperty]
        public string Staffmods { get; set; } = "";
        
        [Name("CostFormula"), NameIndex(0), JsonProperty]
        public string Costformula { get; set; } = "";
        
        [Name("Class"), NameIndex(0), JsonProperty]
        public string Class { get; set; } = "";
        
        [Name("VarInvGfx"), NameIndex(0), JsonProperty]
        public string Varinvgfx { get; set; } = "";
        
        [Name("InvGfx1"), NameIndex(0), JsonProperty]
        public string Invgfx1 { get; set; } = "";
        
        [Name("InvGfx2"), NameIndex(0), JsonProperty]
        public string Invgfx2 { get; set; } = "";
        
        [Name("InvGfx3"), NameIndex(0), JsonProperty]
        public string Invgfx3 { get; set; } = "";
        
        [Name("InvGfx4"), NameIndex(0), JsonProperty]
        public string Invgfx4 { get; set; } = "";
        
        [Name("InvGfx5"), NameIndex(0), JsonProperty]
        public string Invgfx5 { get; set; } = "";
        
        [Name("InvGfx6"), NameIndex(0), JsonProperty]
        public string Invgfx6 { get; set; } = "";
        
        [Name("StorePage"), NameIndex(0), JsonProperty]
        public string Storepage { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
