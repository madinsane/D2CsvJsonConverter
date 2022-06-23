using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonStats2Model
    {
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("Height"), NameIndex(0), JsonProperty]
        public string Height { get; set; } = "";
        
        [Name("OverlayHeight"), NameIndex(0), JsonProperty]
        public string Overlayheight { get; set; } = "";
        
        [Name("pixHeight"), NameIndex(0), JsonProperty]
        public string Pixheight { get; set; } = "";
        
        [Name("SizeX"), NameIndex(0), JsonProperty]
        public string Sizex { get; set; } = "";
        
        [Name("SizeY"), NameIndex(0), JsonProperty]
        public string Sizey { get; set; } = "";
        
        [Name("spawnCol"), NameIndex(0), JsonProperty]
        public string Spawncol { get; set; } = "";
        
        [Name("MeleeRng"), NameIndex(0), JsonProperty]
        public string Meleerng { get; set; } = "";
        
        [Name("BaseW"), NameIndex(0), JsonProperty]
        public string Basew { get; set; } = "";
        
        [Name("HitClass"), NameIndex(0), JsonProperty]
        public string Hitclass { get; set; } = "";
        
        [Name("HDv"), NameIndex(0), JsonProperty]
        public string Hdv { get; set; } = "";
        
        [Name("TRv"), NameIndex(0), JsonProperty]
        public string Trv { get; set; } = "";
        
        [Name("LGv"), NameIndex(0), JsonProperty]
        public string Lgv { get; set; } = "";
        
        [Name("Rav"), NameIndex(0), JsonProperty]
        public string Rav { get; set; } = "";
        
        [Name("Lav"), NameIndex(0), JsonProperty]
        public string Lav { get; set; } = "";
        
        [Name("RHv"), NameIndex(0), JsonProperty]
        public string Rhv { get; set; } = "";
        
        [Name("LHv"), NameIndex(0), JsonProperty]
        public string Lhv { get; set; } = "";
        
        [Name("SHv"), NameIndex(0), JsonProperty]
        public string Shv { get; set; } = "";
        
        [Name("S1v"), NameIndex(0), JsonProperty]
        public string S1v { get; set; } = "";
        
        [Name("S2v"), NameIndex(0), JsonProperty]
        public string S2v { get; set; } = "";
        
        [Name("S3v"), NameIndex(0), JsonProperty]
        public string S3v { get; set; } = "";
        
        [Name("S4v"), NameIndex(0), JsonProperty]
        public string S4v { get; set; } = "";
        
        [Name("S5v"), NameIndex(0), JsonProperty]
        public string S5v { get; set; } = "";
        
        [Name("S6v"), NameIndex(0), JsonProperty]
        public string S6v { get; set; } = "";
        
        [Name("S7v"), NameIndex(0), JsonProperty]
        public string S7v { get; set; } = "";
        
        [Name("S8v"), NameIndex(0), JsonProperty]
        public string S8v { get; set; } = "";
        
        [Name("HD"), NameIndex(0), JsonProperty]
        public string HD { get; set; } = "";
        
        [Name("TR"), NameIndex(0), JsonProperty]
        public string TR { get; set; } = "";
        
        [Name("LG"), NameIndex(0), JsonProperty]
        public string LG { get; set; } = "";
        
        [Name("RA"), NameIndex(0), JsonProperty]
        public string RA { get; set; } = "";
        
        [Name("LA"), NameIndex(0), JsonProperty]
        public string LA { get; set; } = "";
        
        [Name("RH"), NameIndex(0), JsonProperty]
        public string RH { get; set; } = "";
        
        [Name("LH"), NameIndex(0), JsonProperty]
        public string LH { get; set; } = "";
        
        [Name("SH"), NameIndex(0), JsonProperty]
        public string SH { get; set; } = "";
        
        [Name("S1"), NameIndex(0), JsonProperty]
        public string S1 { get; set; } = "";
        
        [Name("S2"), NameIndex(0), JsonProperty]
        public string S2 { get; set; } = "";
        
        [Name("S3"), NameIndex(0), JsonProperty]
        public string S3 { get; set; } = "";
        
        [Name("S4"), NameIndex(0), JsonProperty]
        public string S4 { get; set; } = "";
        
        [Name("S5"), NameIndex(0), JsonProperty]
        public string S5 { get; set; } = "";
        
        [Name("S6"), NameIndex(0), JsonProperty]
        public string S6 { get; set; } = "";
        
        [Name("S7"), NameIndex(0), JsonProperty]
        public string S7 { get; set; } = "";
        
        [Name("S8"), NameIndex(0), JsonProperty]
        public string S8 { get; set; } = "";
        
        [Name("TotalPieces"), NameIndex(0), JsonProperty]
        public string Totalpieces { get; set; } = "";
        
        [Name("mDT"), NameIndex(0), JsonProperty]
        public string Mdt { get; set; } = "";
        
        [Name("mNU"), NameIndex(0), JsonProperty]
        public string Mnu { get; set; } = "";
        
        [Name("mWL"), NameIndex(0), JsonProperty]
        public string Mwl { get; set; } = "";
        
        [Name("mGH"), NameIndex(0), JsonProperty]
        public string Mgh { get; set; } = "";
        
        [Name("mA1"), NameIndex(0), JsonProperty]
        public string Ma1 { get; set; } = "";
        
        [Name("mA2"), NameIndex(0), JsonProperty]
        public string Ma2 { get; set; } = "";
        
        [Name("mBL"), NameIndex(0), JsonProperty]
        public string Mbl { get; set; } = "";
        
        [Name("mSC"), NameIndex(0), JsonProperty]
        public string Msc { get; set; } = "";
        
        [Name("mS1"), NameIndex(0), JsonProperty]
        public string Ms1 { get; set; } = "";
        
        [Name("mS2"), NameIndex(0), JsonProperty]
        public string Ms2 { get; set; } = "";
        
        [Name("mS3"), NameIndex(0), JsonProperty]
        public string Ms3 { get; set; } = "";
        
        [Name("mS4"), NameIndex(0), JsonProperty]
        public string Ms4 { get; set; } = "";
        
        [Name("mDD"), NameIndex(0), JsonProperty]
        public string Mdd { get; set; } = "";
        
        [Name("mKB"), NameIndex(0), JsonProperty]
        public string Mkb { get; set; } = "";
        
        [Name("mSQ"), NameIndex(0), JsonProperty]
        public string Msq { get; set; } = "";
        
        [Name("mRN"), NameIndex(0), JsonProperty]
        public string Mrn { get; set; } = "";
        
        [Name("dDT"), NameIndex(0), JsonProperty]
        public string Ddt { get; set; } = "";
        
        [Name("dNU"), NameIndex(0), JsonProperty]
        public string Dnu { get; set; } = "";
        
        [Name("dWL"), NameIndex(0), JsonProperty]
        public string Dwl { get; set; } = "";
        
        [Name("dGH"), NameIndex(0), JsonProperty]
        public string Dgh { get; set; } = "";
        
        [Name("dA1"), NameIndex(0), JsonProperty]
        public string Da1 { get; set; } = "";
        
        [Name("dA2"), NameIndex(0), JsonProperty]
        public string Da2 { get; set; } = "";
        
        [Name("dBL"), NameIndex(0), JsonProperty]
        public string Dbl { get; set; } = "";
        
        [Name("dSC"), NameIndex(0), JsonProperty]
        public string Dsc { get; set; } = "";
        
        [Name("dS1"), NameIndex(0), JsonProperty]
        public string Ds1 { get; set; } = "";
        
        [Name("dS2"), NameIndex(0), JsonProperty]
        public string Ds2 { get; set; } = "";
        
        [Name("dS3"), NameIndex(0), JsonProperty]
        public string Ds3 { get; set; } = "";
        
        [Name("dS4"), NameIndex(0), JsonProperty]
        public string Ds4 { get; set; } = "";
        
        [Name("dDD"), NameIndex(0), JsonProperty]
        public string Ddd { get; set; } = "";
        
        [Name("dKB"), NameIndex(0), JsonProperty]
        public string Dkb { get; set; } = "";
        
        [Name("dSQ"), NameIndex(0), JsonProperty]
        public string Dsq { get; set; } = "";
        
        [Name("dRN"), NameIndex(0), JsonProperty]
        public string Drn { get; set; } = "";
        
        [Name("A1mv"), NameIndex(0), JsonProperty]
        public string A1mv { get; set; } = "";
        
        [Name("A2mv"), NameIndex(0), JsonProperty]
        public string A2mv { get; set; } = "";
        
        [Name("SCmv"), NameIndex(0), JsonProperty]
        public string Scmv { get; set; } = "";
        
        [Name("S1mv"), NameIndex(0), JsonProperty]
        public string S1mv { get; set; } = "";
        
        [Name("S2mv"), NameIndex(0), JsonProperty]
        public string S2mv { get; set; } = "";
        
        [Name("S3mv"), NameIndex(0), JsonProperty]
        public string S3mv { get; set; } = "";
        
        [Name("S4mv"), NameIndex(0), JsonProperty]
        public string S4mv { get; set; } = "";
        
        [Name("noGfxHitTest"), NameIndex(0), JsonProperty]
        public string Nogfxhittest { get; set; } = "";
        
        [Name("htTop"), NameIndex(0), JsonProperty]
        public string Httop { get; set; } = "";
        
        [Name("htLeft"), NameIndex(0), JsonProperty]
        public string Htleft { get; set; } = "";
        
        [Name("htWidth"), NameIndex(0), JsonProperty]
        public string Htwidth { get; set; } = "";
        
        [Name("htHeight"), NameIndex(0), JsonProperty]
        public string Htheight { get; set; } = "";
        
        [Name("restore"), NameIndex(0), JsonProperty]
        public string Restore { get; set; } = "";
        
        [Name("automapCel"), NameIndex(0), JsonProperty]
        public string Automapcel { get; set; } = "";
        
        [Name("noMap"), NameIndex(0), JsonProperty]
        public string Nomap { get; set; } = "";
        
        [Name("noOvly"), NameIndex(0), JsonProperty]
        public string Noovly { get; set; } = "";
        
        [Name("isSel"), NameIndex(0), JsonProperty]
        public string Issel { get; set; } = "";
        
        [Name("alSel"), NameIndex(0), JsonProperty]
        public string Alsel { get; set; } = "";
        
        [Name("noSel"), NameIndex(0), JsonProperty]
        public string Nosel { get; set; } = "";
        
        [Name("shiftSel"), NameIndex(0), JsonProperty]
        public string Shiftsel { get; set; } = "";
        
        [Name("corpseSel"), NameIndex(0), JsonProperty]
        public string Corpsesel { get; set; } = "";
        
        [Name("isAtt"), NameIndex(0), JsonProperty]
        public string Isatt { get; set; } = "";
        
        [Name("revive"), NameIndex(0), JsonProperty]
        public string Revive { get; set; } = "";
        
        [Name("critter"), NameIndex(0), JsonProperty]
        public string Critter { get; set; } = "";
        
        [Name("small"), NameIndex(0), JsonProperty]
        public string Small { get; set; } = "";
        
        [Name("large"), NameIndex(0), JsonProperty]
        public string Large { get; set; } = "";
        
        [Name("soft"), NameIndex(0), JsonProperty]
        public string Soft { get; set; } = "";
        
        [Name("inert"), NameIndex(0), JsonProperty]
        public string Inert { get; set; } = "";
        
        [Name("objCol"), NameIndex(0), JsonProperty]
        public string Objcol { get; set; } = "";
        
        [Name("deadCol"), NameIndex(0), JsonProperty]
        public string Deadcol { get; set; } = "";
        
        [Name("unflatDead"), NameIndex(0), JsonProperty]
        public string Unflatdead { get; set; } = "";
        
        [Name("Shadow"), NameIndex(0), JsonProperty]
        public string Shadow { get; set; } = "";
        
        [Name("noUniqueShift"), NameIndex(0), JsonProperty]
        public string Nouniqueshift { get; set; } = "";
        
        [Name("compositeDeath"), NameIndex(0), JsonProperty]
        public string Compositedeath { get; set; } = "";
        
        [Name("localBlood"), NameIndex(0), JsonProperty]
        public string Localblood { get; set; } = "";
        
        [Name("Bleed"), NameIndex(0), JsonProperty]
        public string Bleed { get; set; } = "";
        
        [Name("Light"), NameIndex(0), JsonProperty]
        public string Light { get; set; } = "";
        
        [Name("light-r"), NameIndex(0), JsonProperty]
        public string LightR { get; set; } = "";
        
        [Name("light-g"), NameIndex(0), JsonProperty]
        public string LightG { get; set; } = "";
        
        [Name("light-b"), NameIndex(0), JsonProperty]
        public string LightB { get; set; } = "";
        
        [Name("Utrans"), NameIndex(0), JsonProperty]
        public string Utrans { get; set; } = "";
        
        [Name("Utrans(N)"), NameIndex(0), JsonProperty]
        public string UtransN { get; set; } = "";
        
        [Name("Utrans(H)"), NameIndex(0), JsonProperty]
        public string UtransH { get; set; } = "";
        
        [Name("Heart"), NameIndex(0), JsonProperty]
        public string Heart { get; set; } = "";
        
        [Name("BodyPart"), NameIndex(0), JsonProperty]
        public string Bodypart { get; set; } = "";
        
        [Name("InfernoLen"), NameIndex(0), JsonProperty]
        public string Infernolen { get; set; } = "";
        
        [Name("InfernoAnim"), NameIndex(0), JsonProperty]
        public string Infernoanim { get; set; } = "";
        
        [Name("InfernoRollback"), NameIndex(0), JsonProperty]
        public string Infernorollback { get; set; } = "";
        
        [Name("ResurrectMode"), NameIndex(0), JsonProperty]
        public string Resurrectmode { get; set; } = "";
        
        [Name("ResurrectSkill"), NameIndex(0), JsonProperty]
        public string Resurrectskill { get; set; } = "";
        
        [Name("EOL"), NameIndex(0), JsonProperty]
        public string EOL { get; set; } = "";
        
    }
}
