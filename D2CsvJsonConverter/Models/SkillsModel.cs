using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class SkillsModel
    {
        [Name("skill"), NameIndex(0), JsonProperty]
        public string Skill { get; set; } = "";
        
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("charclass"), NameIndex(0), JsonProperty]
        public string Charclass { get; set; } = "";
        
        [Name("skilldesc"), NameIndex(0), JsonProperty]
        public string Skilldesc { get; set; } = "";
        
        [Name("srvstfunc"), NameIndex(0), JsonProperty]
        public string Srvstfunc { get; set; } = "";
        
        [Name("srvdofunc"), NameIndex(0), JsonProperty]
        public string Srvdofunc { get; set; } = "";
        
        [Name("prgstack"), NameIndex(0), JsonProperty]
        public string Prgstack { get; set; } = "";
        
        [Name("srvprgfunc1"), NameIndex(0), JsonProperty]
        public string Srvprgfunc1 { get; set; } = "";
        
        [Name("srvprgfunc2"), NameIndex(0), JsonProperty]
        public string Srvprgfunc2 { get; set; } = "";
        
        [Name("srvprgfunc3"), NameIndex(0), JsonProperty]
        public string Srvprgfunc3 { get; set; } = "";
        
        [Name("prgcalc1"), NameIndex(0), JsonProperty]
        public string Prgcalc1 { get; set; } = "";
        
        [Name("prgcalc2"), NameIndex(0), JsonProperty]
        public string Prgcalc2 { get; set; } = "";
        
        [Name("prgcalc3"), NameIndex(0), JsonProperty]
        public string Prgcalc3 { get; set; } = "";
        
        [Name("prgdam"), NameIndex(0), JsonProperty]
        public string Prgdam { get; set; } = "";
        
        [Name("srvmissile"), NameIndex(0), JsonProperty]
        public string Srvmissile { get; set; } = "";
        
        [Name("decquant"), NameIndex(0), JsonProperty]
        public string Decquant { get; set; } = "";
        
        [Name("lob"), NameIndex(0), JsonProperty]
        public string Lob { get; set; } = "";
        
        [Name("srvmissilea"), NameIndex(0), JsonProperty]
        public string Srvmissilea { get; set; } = "";
        
        [Name("srvmissileb"), NameIndex(0), JsonProperty]
        public string Srvmissileb { get; set; } = "";
        
        [Name("srvmissilec"), NameIndex(0), JsonProperty]
        public string Srvmissilec { get; set; } = "";
        
        [Name("srvoverlay"), NameIndex(0), JsonProperty]
        public string Srvoverlay { get; set; } = "";
        
        [Name("aurafilter"), NameIndex(0), JsonProperty]
        public string Aurafilter { get; set; } = "";
        
        [Name("aurastate"), NameIndex(0), JsonProperty]
        public string Aurastate { get; set; } = "";
        
        [Name("auratargetstate"), NameIndex(0), JsonProperty]
        public string Auratargetstate { get; set; } = "";
        
        [Name("auralencalc"), NameIndex(0), JsonProperty]
        public string Auralencalc { get; set; } = "";
        
        [Name("aurarangecalc"), NameIndex(0), JsonProperty]
        public string Aurarangecalc { get; set; } = "";
        
        [Name("aurastat1"), NameIndex(0), JsonProperty]
        public string Aurastat1 { get; set; } = "";
        
        [Name("aurastatcalc1"), NameIndex(0), JsonProperty]
        public string Aurastatcalc1 { get; set; } = "";
        
        [Name("aurastat2"), NameIndex(0), JsonProperty]
        public string Aurastat2 { get; set; } = "";
        
        [Name("aurastatcalc2"), NameIndex(0), JsonProperty]
        public string Aurastatcalc2 { get; set; } = "";
        
        [Name("aurastat3"), NameIndex(0), JsonProperty]
        public string Aurastat3 { get; set; } = "";
        
        [Name("aurastatcalc3"), NameIndex(0), JsonProperty]
        public string Aurastatcalc3 { get; set; } = "";
        
        [Name("aurastat4"), NameIndex(0), JsonProperty]
        public string Aurastat4 { get; set; } = "";
        
        [Name("aurastatcalc4"), NameIndex(0), JsonProperty]
        public string Aurastatcalc4 { get; set; } = "";
        
        [Name("aurastat5"), NameIndex(0), JsonProperty]
        public string Aurastat5 { get; set; } = "";
        
        [Name("aurastatcalc5"), NameIndex(0), JsonProperty]
        public string Aurastatcalc5 { get; set; } = "";
        
        [Name("aurastat6"), NameIndex(0), JsonProperty]
        public string Aurastat6 { get; set; } = "";
        
        [Name("aurastatcalc6"), NameIndex(0), JsonProperty]
        public string Aurastatcalc6 { get; set; } = "";
        
        [Name("auraevent1"), NameIndex(0), JsonProperty]
        public string Auraevent1 { get; set; } = "";
        
        [Name("auraeventfunc1"), NameIndex(0), JsonProperty]
        public string Auraeventfunc1 { get; set; } = "";
        
        [Name("auraevent2"), NameIndex(0), JsonProperty]
        public string Auraevent2 { get; set; } = "";
        
        [Name("auraeventfunc2"), NameIndex(0), JsonProperty]
        public string Auraeventfunc2 { get; set; } = "";
        
        [Name("auraevent3"), NameIndex(0), JsonProperty]
        public string Auraevent3 { get; set; } = "";
        
        [Name("auraeventfunc3"), NameIndex(0), JsonProperty]
        public string Auraeventfunc3 { get; set; } = "";
        
        [Name("auratgtevent"), NameIndex(0), JsonProperty]
        public string Auratgtevent { get; set; } = "";
        
        [Name("auratgteventfunc"), NameIndex(0), JsonProperty]
        public string Auratgteventfunc { get; set; } = "";
        
        [Name("passivestate"), NameIndex(0), JsonProperty]
        public string Passivestate { get; set; } = "";
        
        [Name("passiveitype"), NameIndex(0), JsonProperty]
        public string Passiveitype { get; set; } = "";
        
        [Name("passivestat1"), NameIndex(0), JsonProperty]
        public string Passivestat1 { get; set; } = "";
        
        [Name("passivecalc1"), NameIndex(0), JsonProperty]
        public string Passivecalc1 { get; set; } = "";
        
        [Name("passivestat2"), NameIndex(0), JsonProperty]
        public string Passivestat2 { get; set; } = "";
        
        [Name("passivecalc2"), NameIndex(0), JsonProperty]
        public string Passivecalc2 { get; set; } = "";
        
        [Name("passivestat3"), NameIndex(0), JsonProperty]
        public string Passivestat3 { get; set; } = "";
        
        [Name("passivecalc3"), NameIndex(0), JsonProperty]
        public string Passivecalc3 { get; set; } = "";
        
        [Name("passivestat4"), NameIndex(0), JsonProperty]
        public string Passivestat4 { get; set; } = "";
        
        [Name("passivecalc4"), NameIndex(0), JsonProperty]
        public string Passivecalc4 { get; set; } = "";
        
        [Name("passivestat5"), NameIndex(0), JsonProperty]
        public string Passivestat5 { get; set; } = "";
        
        [Name("passivecalc5"), NameIndex(0), JsonProperty]
        public string Passivecalc5 { get; set; } = "";
        
        [Name("passiveevent"), NameIndex(0), JsonProperty]
        public string Passiveevent { get; set; } = "";
        
        [Name("passiveeventfunc"), NameIndex(0), JsonProperty]
        public string Passiveeventfunc { get; set; } = "";
        
        [Name("summon"), NameIndex(0), JsonProperty]
        public string Summon { get; set; } = "";
        
        [Name("pettype"), NameIndex(0), JsonProperty]
        public string Pettype { get; set; } = "";
        
        [Name("petmax"), NameIndex(0), JsonProperty]
        public string Petmax { get; set; } = "";
        
        [Name("summode"), NameIndex(0), JsonProperty]
        public string Summode { get; set; } = "";
        
        [Name("sumskill1"), NameIndex(0), JsonProperty]
        public string Sumskill1 { get; set; } = "";
        
        [Name("sumsk1calc"), NameIndex(0), JsonProperty]
        public string Sumsk1calc { get; set; } = "";
        
        [Name("sumskill2"), NameIndex(0), JsonProperty]
        public string Sumskill2 { get; set; } = "";
        
        [Name("sumsk2calc"), NameIndex(0), JsonProperty]
        public string Sumsk2calc { get; set; } = "";
        
        [Name("sumskill3"), NameIndex(0), JsonProperty]
        public string Sumskill3 { get; set; } = "";
        
        [Name("sumsk3calc"), NameIndex(0), JsonProperty]
        public string Sumsk3calc { get; set; } = "";
        
        [Name("sumskill4"), NameIndex(0), JsonProperty]
        public string Sumskill4 { get; set; } = "";
        
        [Name("sumsk4calc"), NameIndex(0), JsonProperty]
        public string Sumsk4calc { get; set; } = "";
        
        [Name("sumskill5"), NameIndex(0), JsonProperty]
        public string Sumskill5 { get; set; } = "";
        
        [Name("sumsk5calc"), NameIndex(0), JsonProperty]
        public string Sumsk5calc { get; set; } = "";
        
        [Name("sumumod"), NameIndex(0), JsonProperty]
        public string Sumumod { get; set; } = "";
        
        [Name("sumoverlay"), NameIndex(0), JsonProperty]
        public string Sumoverlay { get; set; } = "";
        
        [Name("stsuccessonly"), NameIndex(0), JsonProperty]
        public string Stsuccessonly { get; set; } = "";
        
        [Name("stsound"), NameIndex(0), JsonProperty]
        public string Stsound { get; set; } = "";
        
        [Name("stsoundclass"), NameIndex(0), JsonProperty]
        public string Stsoundclass { get; set; } = "";
        
        [Name("stsounddelay"), NameIndex(0), JsonProperty]
        public string Stsounddelay { get; set; } = "";
        
        [Name("weaponsnd"), NameIndex(0), JsonProperty]
        public string Weaponsnd { get; set; } = "";
        
        [Name("dosound"), NameIndex(0), JsonProperty]
        public string Dosound { get; set; } = "";
        
        [Name("dosound a"), NameIndex(0), JsonProperty]
        public string DosoundA { get; set; } = "";
        
        [Name("dosound b"), NameIndex(0), JsonProperty]
        public string DosoundB { get; set; } = "";
        
        [Name("tgtoverlay"), NameIndex(0), JsonProperty]
        public string Tgtoverlay { get; set; } = "";
        
        [Name("tgtsound"), NameIndex(0), JsonProperty]
        public string Tgtsound { get; set; } = "";
        
        [Name("prgoverlay"), NameIndex(0), JsonProperty]
        public string Prgoverlay { get; set; } = "";
        
        [Name("prgsound"), NameIndex(0), JsonProperty]
        public string Prgsound { get; set; } = "";
        
        [Name("castoverlay"), NameIndex(0), JsonProperty]
        public string Castoverlay { get; set; } = "";
        
        [Name("cltoverlaya"), NameIndex(0), JsonProperty]
        public string Cltoverlaya { get; set; } = "";
        
        [Name("cltoverlayb"), NameIndex(0), JsonProperty]
        public string Cltoverlayb { get; set; } = "";
        
        [Name("cltstfunc"), NameIndex(0), JsonProperty]
        public string Cltstfunc { get; set; } = "";
        
        [Name("cltdofunc"), NameIndex(0), JsonProperty]
        public string Cltdofunc { get; set; } = "";
        
        [Name("cltprgfunc1"), NameIndex(0), JsonProperty]
        public string Cltprgfunc1 { get; set; } = "";
        
        [Name("cltprgfunc2"), NameIndex(0), JsonProperty]
        public string Cltprgfunc2 { get; set; } = "";
        
        [Name("cltprgfunc3"), NameIndex(0), JsonProperty]
        public string Cltprgfunc3 { get; set; } = "";
        
        [Name("cltmissile"), NameIndex(0), JsonProperty]
        public string Cltmissile { get; set; } = "";
        
        [Name("cltmissilea"), NameIndex(0), JsonProperty]
        public string Cltmissilea { get; set; } = "";
        
        [Name("cltmissileb"), NameIndex(0), JsonProperty]
        public string Cltmissileb { get; set; } = "";
        
        [Name("cltmissilec"), NameIndex(0), JsonProperty]
        public string Cltmissilec { get; set; } = "";
        
        [Name("cltmissiled"), NameIndex(0), JsonProperty]
        public string Cltmissiled { get; set; } = "";
        
        [Name("cltcalc1"), NameIndex(0), JsonProperty]
        public string Cltcalc1 { get; set; } = "";
        
        [Name("*cltcalc1 desc"), NameIndex(0), JsonProperty]
        public string Cltcalc1Desc { get; set; } = "";
        
        [Name("cltcalc2"), NameIndex(0), JsonProperty]
        public string Cltcalc2 { get; set; } = "";
        
        [Name("*cltcalc2 desc"), NameIndex(0), JsonProperty]
        public string Cltcalc2Desc { get; set; } = "";
        
        [Name("cltcalc3"), NameIndex(0), JsonProperty]
        public string Cltcalc3 { get; set; } = "";
        
        [Name("*cltcalc3 desc"), NameIndex(0), JsonProperty]
        public string Cltcalc3Desc { get; set; } = "";
        
        [Name("warp"), NameIndex(0), JsonProperty]
        public string Warp { get; set; } = "";
        
        [Name("immediate"), NameIndex(0), JsonProperty]
        public string Immediate { get; set; } = "";
        
        [Name("enhanceable"), NameIndex(0), JsonProperty]
        public string Enhanceable { get; set; } = "";
        
        [Name("attackrank"), NameIndex(0), JsonProperty]
        public string Attackrank { get; set; } = "";
        
        [Name("noammo"), NameIndex(0), JsonProperty]
        public string Noammo { get; set; } = "";
        
        [Name("range"), NameIndex(0), JsonProperty]
        public string Range { get; set; } = "";
        
        [Name("weapsel"), NameIndex(0), JsonProperty]
        public string Weapsel { get; set; } = "";
        
        [Name("itypea1"), NameIndex(0), JsonProperty]
        public string Itypea1 { get; set; } = "";
        
        [Name("itypea2"), NameIndex(0), JsonProperty]
        public string Itypea2 { get; set; } = "";
        
        [Name("itypea3"), NameIndex(0), JsonProperty]
        public string Itypea3 { get; set; } = "";
        
        [Name("etypea1"), NameIndex(0), JsonProperty]
        public string Etypea1 { get; set; } = "";
        
        [Name("etypea2"), NameIndex(0), JsonProperty]
        public string Etypea2 { get; set; } = "";
        
        [Name("itypeb1"), NameIndex(0), JsonProperty]
        public string Itypeb1 { get; set; } = "";
        
        [Name("itypeb2"), NameIndex(0), JsonProperty]
        public string Itypeb2 { get; set; } = "";
        
        [Name("itypeb3"), NameIndex(0), JsonProperty]
        public string Itypeb3 { get; set; } = "";
        
        [Name("etypeb1"), NameIndex(0), JsonProperty]
        public string Etypeb1 { get; set; } = "";
        
        [Name("etypeb2"), NameIndex(0), JsonProperty]
        public string Etypeb2 { get; set; } = "";
        
        [Name("anim"), NameIndex(0), JsonProperty]
        public string Anim { get; set; } = "";
        
        [Name("seqtrans"), NameIndex(0), JsonProperty]
        public string Seqtrans { get; set; } = "";
        
        [Name("monanim"), NameIndex(0), JsonProperty]
        public string Monanim { get; set; } = "";
        
        [Name("seqnum"), NameIndex(0), JsonProperty]
        public string Seqnum { get; set; } = "";
        
        [Name("seqinput"), NameIndex(0), JsonProperty]
        public string Seqinput { get; set; } = "";
        
        [Name("durability"), NameIndex(0), JsonProperty]
        public string Durability { get; set; } = "";
        
        [Name("UseAttackRate"), NameIndex(0), JsonProperty]
        public string Useattackrate { get; set; } = "";
        
        [Name("LineOfSight"), NameIndex(0), JsonProperty]
        public string Lineofsight { get; set; } = "";
        
        [Name("TargetableOnly"), NameIndex(0), JsonProperty]
        public string Targetableonly { get; set; } = "";
        
        [Name("SearchEnemyXY"), NameIndex(0), JsonProperty]
        public string Searchenemyxy { get; set; } = "";
        
        [Name("SearchEnemyNear"), NameIndex(0), JsonProperty]
        public string Searchenemynear { get; set; } = "";
        
        [Name("SearchOpenXY"), NameIndex(0), JsonProperty]
        public string Searchopenxy { get; set; } = "";
        
        [Name("SelectProc"), NameIndex(0), JsonProperty]
        public string Selectproc { get; set; } = "";
        
        [Name("TargetCorpse"), NameIndex(0), JsonProperty]
        public string Targetcorpse { get; set; } = "";
        
        [Name("TargetPet"), NameIndex(0), JsonProperty]
        public string Targetpet { get; set; } = "";
        
        [Name("TargetAlly"), NameIndex(0), JsonProperty]
        public string Targetally { get; set; } = "";
        
        [Name("TargetItem"), NameIndex(0), JsonProperty]
        public string Targetitem { get; set; } = "";
        
        [Name("AttackNoMana"), NameIndex(0), JsonProperty]
        public string Attacknomana { get; set; } = "";
        
        [Name("TgtPlaceCheck"), NameIndex(0), JsonProperty]
        public string Tgtplacecheck { get; set; } = "";
        
        [Name("ItemEffect"), NameIndex(0), JsonProperty]
        public string Itemeffect { get; set; } = "";
        
        [Name("ItemCltEffect"), NameIndex(0), JsonProperty]
        public string Itemclteffect { get; set; } = "";
        
        [Name("ItemTgtDo"), NameIndex(0), JsonProperty]
        public string Itemtgtdo { get; set; } = "";
        
        [Name("ItemTarget"), NameIndex(0), JsonProperty]
        public string Itemtarget { get; set; } = "";
        
        [Name("ItemCheckStart"), NameIndex(0), JsonProperty]
        public string Itemcheckstart { get; set; } = "";
        
        [Name("ItemCltCheckStart"), NameIndex(0), JsonProperty]
        public string Itemcltcheckstart { get; set; } = "";
        
        [Name("ItemCastSound"), NameIndex(0), JsonProperty]
        public string Itemcastsound { get; set; } = "";
        
        [Name("ItemCastOverlay"), NameIndex(0), JsonProperty]
        public string Itemcastoverlay { get; set; } = "";
        
        [Name("skpoints"), NameIndex(0), JsonProperty]
        public string Skpoints { get; set; } = "";
        
        [Name("reqlevel"), NameIndex(0), JsonProperty]
        public string Reqlevel { get; set; } = "";
        
        [Name("maxlvl"), NameIndex(0), JsonProperty]
        public string Maxlvl { get; set; } = "";
        
        [Name("reqstr"), NameIndex(0), JsonProperty]
        public string Reqstr { get; set; } = "";
        
        [Name("reqdex"), NameIndex(0), JsonProperty]
        public string Reqdex { get; set; } = "";
        
        [Name("reqint"), NameIndex(0), JsonProperty]
        public string Reqint { get; set; } = "";
        
        [Name("reqvit"), NameIndex(0), JsonProperty]
        public string Reqvit { get; set; } = "";
        
        [Name("reqskill1"), NameIndex(0), JsonProperty]
        public string Reqskill1 { get; set; } = "";
        
        [Name("reqskill2"), NameIndex(0), JsonProperty]
        public string Reqskill2 { get; set; } = "";
        
        [Name("reqskill3"), NameIndex(0), JsonProperty]
        public string Reqskill3 { get; set; } = "";
        
        [Name("restrict"), NameIndex(0), JsonProperty]
        public string Restrict { get; set; } = "";
        
        [Name("State1"), NameIndex(0), JsonProperty]
        public string State1 { get; set; } = "";
        
        [Name("State2"), NameIndex(0), JsonProperty]
        public string State2 { get; set; } = "";
        
        [Name("State3"), NameIndex(0), JsonProperty]
        public string State3 { get; set; } = "";
        
        [Name("delay"), NameIndex(0), JsonProperty]
        public string Delay { get; set; } = "";
        
        [Name("leftskill"), NameIndex(0), JsonProperty]
        public string Leftskill { get; set; } = "";
        
        [Name("repeat"), NameIndex(0), JsonProperty]
        public string Repeat { get; set; } = "";
        
        [Name("checkfunc"), NameIndex(0), JsonProperty]
        public string Checkfunc { get; set; } = "";
        
        [Name("nocostinstate"), NameIndex(0), JsonProperty]
        public string Nocostinstate { get; set; } = "";
        
        [Name("usemanaondo"), NameIndex(0), JsonProperty]
        public string Usemanaondo { get; set; } = "";
        
        [Name("startmana"), NameIndex(0), JsonProperty]
        public string Startmana { get; set; } = "";
        
        [Name("minmana"), NameIndex(0), JsonProperty]
        public string Minmana { get; set; } = "";
        
        [Name("manashift"), NameIndex(0), JsonProperty]
        public string Manashift { get; set; } = "";
        
        [Name("mana"), NameIndex(0), JsonProperty]
        public string Mana { get; set; } = "";
        
        [Name("lvlmana"), NameIndex(0), JsonProperty]
        public string Lvlmana { get; set; } = "";
        
        [Name("interrupt"), NameIndex(0), JsonProperty]
        public string Interrupt { get; set; } = "";
        
        [Name("InTown"), NameIndex(0), JsonProperty]
        public string Intown { get; set; } = "";
        
        [Name("aura"), NameIndex(0), JsonProperty]
        public string Aura { get; set; } = "";
        
        [Name("periodic"), NameIndex(0), JsonProperty]
        public string Periodic { get; set; } = "";
        
        [Name("perdelay"), NameIndex(0), JsonProperty]
        public string Perdelay { get; set; } = "";
        
        [Name("finishing"), NameIndex(0), JsonProperty]
        public string Finishing { get; set; } = "";
        
        [Name("passive"), NameIndex(0), JsonProperty]
        public string Passive { get; set; } = "";
        
        [Name("progressive"), NameIndex(0), JsonProperty]
        public string Progressive { get; set; } = "";
        
        [Name("general"), NameIndex(0), JsonProperty]
        public string General { get; set; } = "";
        
        [Name("scroll"), NameIndex(0), JsonProperty]
        public string Scroll { get; set; } = "";
        
        [Name("calc1"), NameIndex(0), JsonProperty]
        public string Calc1 { get; set; } = "";
        
        [Name("*calc1 desc"), NameIndex(0), JsonProperty]
        public string Calc1Desc { get; set; } = "";
        
        [Name("calc2"), NameIndex(0), JsonProperty]
        public string Calc2 { get; set; } = "";
        
        [Name("*calc2 desc"), NameIndex(0), JsonProperty]
        public string Calc2Desc { get; set; } = "";
        
        [Name("calc3"), NameIndex(0), JsonProperty]
        public string Calc3 { get; set; } = "";
        
        [Name("*calc3 desc"), NameIndex(0), JsonProperty]
        public string Calc3Desc { get; set; } = "";
        
        [Name("calc4"), NameIndex(0), JsonProperty]
        public string Calc4 { get; set; } = "";
        
        [Name("*calc4 desc"), NameIndex(0), JsonProperty]
        public string Calc4Desc { get; set; } = "";
        
        [Name("Param1"), NameIndex(0), JsonProperty]
        public string Param1 { get; set; } = "";
        
        [Name("*Param1 Description"), NameIndex(0), JsonProperty]
        public string Param1Description { get; set; } = "";
        
        [Name("Param2"), NameIndex(0), JsonProperty]
        public string Param2 { get; set; } = "";
        
        [Name("*Param2 Description"), NameIndex(0), JsonProperty]
        public string Param2Description { get; set; } = "";
        
        [Name("Param3"), NameIndex(0), JsonProperty]
        public string Param3 { get; set; } = "";
        
        [Name("*Param3 Description"), NameIndex(0), JsonProperty]
        public string Param3Description { get; set; } = "";
        
        [Name("Param4"), NameIndex(0), JsonProperty]
        public string Param4 { get; set; } = "";
        
        [Name("*Param4 Description"), NameIndex(0), JsonProperty]
        public string Param4Description { get; set; } = "";
        
        [Name("Param5"), NameIndex(0), JsonProperty]
        public string Param5 { get; set; } = "";
        
        [Name("*Param5 Description"), NameIndex(0), JsonProperty]
        public string Param5Description { get; set; } = "";
        
        [Name("Param6"), NameIndex(0), JsonProperty]
        public string Param6 { get; set; } = "";
        
        [Name("*Param6 Description"), NameIndex(0), JsonProperty]
        public string Param6Description { get; set; } = "";
        
        [Name("Param7"), NameIndex(0), JsonProperty]
        public string Param7 { get; set; } = "";
        
        [Name("*Param7 Description"), NameIndex(0), JsonProperty]
        public string Param7Description { get; set; } = "";
        
        [Name("Param8"), NameIndex(0), JsonProperty]
        public string Param8 { get; set; } = "";
        
        [Name("*Param8 Description"), NameIndex(0), JsonProperty]
        public string Param8Description { get; set; } = "";
        
        [Name("InGame"), NameIndex(0), JsonProperty]
        public string Ingame { get; set; } = "";
        
        [Name("ToHit"), NameIndex(0), JsonProperty]
        public string Tohit { get; set; } = "";
        
        [Name("LevToHit"), NameIndex(0), JsonProperty]
        public string Levtohit { get; set; } = "";
        
        [Name("ToHitCalc"), NameIndex(0), JsonProperty]
        public string Tohitcalc { get; set; } = "";
        
        [Name("ResultFlags"), NameIndex(0), JsonProperty]
        public string Resultflags { get; set; } = "";
        
        [Name("HitFlags"), NameIndex(0), JsonProperty]
        public string Hitflags { get; set; } = "";
        
        [Name("HitClass"), NameIndex(0), JsonProperty]
        public string Hitclass { get; set; } = "";
        
        [Name("Kick"), NameIndex(0), JsonProperty]
        public string Kick { get; set; } = "";
        
        [Name("HitShift"), NameIndex(0), JsonProperty]
        public string Hitshift { get; set; } = "";
        
        [Name("SrcDam"), NameIndex(0), JsonProperty]
        public string Srcdam { get; set; } = "";
        
        [Name("MinDam"), NameIndex(0), JsonProperty]
        public string Mindam { get; set; } = "";
        
        [Name("MinLevDam1"), NameIndex(0), JsonProperty]
        public string Minlevdam1 { get; set; } = "";
        
        [Name("MinLevDam2"), NameIndex(0), JsonProperty]
        public string Minlevdam2 { get; set; } = "";
        
        [Name("MinLevDam3"), NameIndex(0), JsonProperty]
        public string Minlevdam3 { get; set; } = "";
        
        [Name("MinLevDam4"), NameIndex(0), JsonProperty]
        public string Minlevdam4 { get; set; } = "";
        
        [Name("MinLevDam5"), NameIndex(0), JsonProperty]
        public string Minlevdam5 { get; set; } = "";
        
        [Name("MaxDam"), NameIndex(0), JsonProperty]
        public string Maxdam { get; set; } = "";
        
        [Name("MaxLevDam1"), NameIndex(0), JsonProperty]
        public string Maxlevdam1 { get; set; } = "";
        
        [Name("MaxLevDam2"), NameIndex(0), JsonProperty]
        public string Maxlevdam2 { get; set; } = "";
        
        [Name("MaxLevDam3"), NameIndex(0), JsonProperty]
        public string Maxlevdam3 { get; set; } = "";
        
        [Name("MaxLevDam4"), NameIndex(0), JsonProperty]
        public string Maxlevdam4 { get; set; } = "";
        
        [Name("MaxLevDam5"), NameIndex(0), JsonProperty]
        public string Maxlevdam5 { get; set; } = "";
        
        [Name("DmgSymPerCalc"), NameIndex(0), JsonProperty]
        public string Dmgsympercalc { get; set; } = "";
        
        [Name("EType"), NameIndex(0), JsonProperty]
        public string Etype { get; set; } = "";
        
        [Name("EMin"), NameIndex(0), JsonProperty]
        public string Emin { get; set; } = "";
        
        [Name("EMinLev1"), NameIndex(0), JsonProperty]
        public string Eminlev1 { get; set; } = "";
        
        [Name("EMinLev2"), NameIndex(0), JsonProperty]
        public string Eminlev2 { get; set; } = "";
        
        [Name("EMinLev3"), NameIndex(0), JsonProperty]
        public string Eminlev3 { get; set; } = "";
        
        [Name("EMinLev4"), NameIndex(0), JsonProperty]
        public string Eminlev4 { get; set; } = "";
        
        [Name("EMinLev5"), NameIndex(0), JsonProperty]
        public string Eminlev5 { get; set; } = "";
        
        [Name("EMax"), NameIndex(0), JsonProperty]
        public string Emax { get; set; } = "";
        
        [Name("EMaxLev1"), NameIndex(0), JsonProperty]
        public string Emaxlev1 { get; set; } = "";
        
        [Name("EMaxLev2"), NameIndex(0), JsonProperty]
        public string Emaxlev2 { get; set; } = "";
        
        [Name("EMaxLev3"), NameIndex(0), JsonProperty]
        public string Emaxlev3 { get; set; } = "";
        
        [Name("EMaxLev4"), NameIndex(0), JsonProperty]
        public string Emaxlev4 { get; set; } = "";
        
        [Name("EMaxLev5"), NameIndex(0), JsonProperty]
        public string Emaxlev5 { get; set; } = "";
        
        [Name("EDmgSymPerCalc"), NameIndex(0), JsonProperty]
        public string Edmgsympercalc { get; set; } = "";
        
        [Name("ELen"), NameIndex(0), JsonProperty]
        public string Elen { get; set; } = "";
        
        [Name("ELevLen1"), NameIndex(0), JsonProperty]
        public string Elevlen1 { get; set; } = "";
        
        [Name("ELevLen2"), NameIndex(0), JsonProperty]
        public string Elevlen2 { get; set; } = "";
        
        [Name("ELevLen3"), NameIndex(0), JsonProperty]
        public string Elevlen3 { get; set; } = "";
        
        [Name("ELenSymPerCalc"), NameIndex(0), JsonProperty]
        public string Elensympercalc { get; set; } = "";
        
        [Name("aitype"), NameIndex(0), JsonProperty]
        public string Aitype { get; set; } = "";
        
        [Name("aibonus"), NameIndex(0), JsonProperty]
        public string Aibonus { get; set; } = "";
        
        [Name("cost mult"), NameIndex(0), JsonProperty]
        public string CostMult { get; set; } = "";
        
        [Name("cost add"), NameIndex(0), JsonProperty]
        public string CostAdd { get; set; } = "";
        
    }
}
