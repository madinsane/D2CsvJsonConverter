using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MissilesModel
    {
        [Name("Missile"), NameIndex(0), JsonProperty]
        public string Missile { get; set; } = "";
        
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("pCltDoFunc"), NameIndex(0), JsonProperty]
        public string Pcltdofunc { get; set; } = "";
        
        [Name("pCltHitFunc"), NameIndex(0), JsonProperty]
        public string Pclthitfunc { get; set; } = "";
        
        [Name("pSrvDoFunc"), NameIndex(0), JsonProperty]
        public string Psrvdofunc { get; set; } = "";
        
        [Name("pSrvHitFunc"), NameIndex(0), JsonProperty]
        public string Psrvhitfunc { get; set; } = "";
        
        [Name("pSrvDmgFunc"), NameIndex(0), JsonProperty]
        public string Psrvdmgfunc { get; set; } = "";
        
        [Name("SrvCalc1"), NameIndex(0), JsonProperty]
        public string Srvcalc1 { get; set; } = "";
        
        [Name("*srv calc 1 desc"), NameIndex(0), JsonProperty]
        public string SrvCalc1Desc { get; set; } = "";
        
        [Name("Param1"), NameIndex(0), JsonProperty]
        public string Param1 { get; set; } = "";
        
        [Name("*param1 desc"), NameIndex(0), JsonProperty]
        public string Param1Desc { get; set; } = "";
        
        [Name("Param2"), NameIndex(0), JsonProperty]
        public string Param2 { get; set; } = "";
        
        [Name("*param2 desc"), NameIndex(0), JsonProperty]
        public string Param2Desc { get; set; } = "";
        
        [Name("Param3"), NameIndex(0), JsonProperty]
        public string Param3 { get; set; } = "";
        
        [Name("*param3 desc"), NameIndex(0), JsonProperty]
        public string Param3Desc { get; set; } = "";
        
        [Name("Param4"), NameIndex(0), JsonProperty]
        public string Param4 { get; set; } = "";
        
        [Name("*param4 desc"), NameIndex(0), JsonProperty]
        public string Param4Desc { get; set; } = "";
        
        [Name("Param5"), NameIndex(0), JsonProperty]
        public string Param5 { get; set; } = "";
        
        [Name("*param5 desc"), NameIndex(0), JsonProperty]
        public string Param5Desc { get; set; } = "";
        
        [Name("CltCalc1"), NameIndex(0), JsonProperty]
        public string Cltcalc1 { get; set; } = "";
        
        [Name("*client calc 1 desc"), NameIndex(0), JsonProperty]
        public string ClientCalc1Desc { get; set; } = "";
        
        [Name("CltParam1"), NameIndex(0), JsonProperty]
        public string Cltparam1 { get; set; } = "";
        
        [Name("*client param1 desc"), NameIndex(0), JsonProperty]
        public string ClientParam1Desc { get; set; } = "";
        
        [Name("CltParam2"), NameIndex(0), JsonProperty]
        public string Cltparam2 { get; set; } = "";
        
        [Name("*client param2 desc"), NameIndex(0), JsonProperty]
        public string ClientParam2Desc { get; set; } = "";
        
        [Name("CltParam3"), NameIndex(0), JsonProperty]
        public string Cltparam3 { get; set; } = "";
        
        [Name("*client param3 desc"), NameIndex(0), JsonProperty]
        public string ClientParam3Desc { get; set; } = "";
        
        [Name("CltParam4"), NameIndex(0), JsonProperty]
        public string Cltparam4 { get; set; } = "";
        
        [Name("*client param4 desc"), NameIndex(0), JsonProperty]
        public string ClientParam4Desc { get; set; } = "";
        
        [Name("CltParam5"), NameIndex(0), JsonProperty]
        public string Cltparam5 { get; set; } = "";
        
        [Name("*client param5 desc"), NameIndex(0), JsonProperty]
        public string ClientParam5Desc { get; set; } = "";
        
        [Name("SHitCalc1"), NameIndex(0), JsonProperty]
        public string Shitcalc1 { get; set; } = "";
        
        [Name("*server hit calc 1 desc"), NameIndex(0), JsonProperty]
        public string ServerHitCalc1Desc { get; set; } = "";
        
        [Name("sHitPar1"), NameIndex(0), JsonProperty]
        public string Shitpar1 { get; set; } = "";
        
        [Name("*server hit param1 desc"), NameIndex(0), JsonProperty]
        public string ServerHitParam1Desc { get; set; } = "";
        
        [Name("sHitPar2"), NameIndex(0), JsonProperty]
        public string Shitpar2 { get; set; } = "";
        
        [Name("*server hit param2 desc"), NameIndex(0), JsonProperty]
        public string ServerHitParam2Desc { get; set; } = "";
        
        [Name("sHitPar3"), NameIndex(0), JsonProperty]
        public string Shitpar3 { get; set; } = "";
        
        [Name("*server hit param3 desc"), NameIndex(0), JsonProperty]
        public string ServerHitParam3Desc { get; set; } = "";
        
        [Name("CHitCalc1"), NameIndex(0), JsonProperty]
        public string Chitcalc1 { get; set; } = "";
        
        [Name("*client hit calc1 desc"), NameIndex(0), JsonProperty]
        public string ClientHitCalc1Desc { get; set; } = "";
        
        [Name("cHitPar1"), NameIndex(0), JsonProperty]
        public string Chitpar1 { get; set; } = "";
        
        [Name("*client hit param1 desc"), NameIndex(0), JsonProperty]
        public string ClientHitParam1Desc { get; set; } = "";
        
        [Name("cHitPar2"), NameIndex(0), JsonProperty]
        public string Chitpar2 { get; set; } = "";
        
        [Name("*client hit param2 desc"), NameIndex(0), JsonProperty]
        public string ClientHitParam2Desc { get; set; } = "";
        
        [Name("cHitPar3"), NameIndex(0), JsonProperty]
        public string Chitpar3 { get; set; } = "";
        
        [Name("*client hit param3 desc"), NameIndex(0), JsonProperty]
        public string ClientHitParam3Desc { get; set; } = "";
        
        [Name("DmgCalc1"), NameIndex(0), JsonProperty]
        public string Dmgcalc1 { get; set; } = "";
        
        [Name("*damage calc 1"), NameIndex(0), JsonProperty]
        public string DamageCalc1 { get; set; } = "";
        
        [Name("dParam1"), NameIndex(0), JsonProperty]
        public string Dparam1 { get; set; } = "";
        
        [Name("*damage param1 desc"), NameIndex(0), JsonProperty]
        public string DamageParam1Desc { get; set; } = "";
        
        [Name("dParam2"), NameIndex(0), JsonProperty]
        public string Dparam2 { get; set; } = "";
        
        [Name("*damage param2 desc"), NameIndex(0), JsonProperty]
        public string DamageParam2Desc { get; set; } = "";
        
        [Name("Vel"), NameIndex(0), JsonProperty]
        public string Vel { get; set; } = "";
        
        [Name("MaxVel"), NameIndex(0), JsonProperty]
        public string Maxvel { get; set; } = "";
        
        [Name("VelLev"), NameIndex(0), JsonProperty]
        public string Vellev { get; set; } = "";
        
        [Name("Accel"), NameIndex(0), JsonProperty]
        public string Accel { get; set; } = "";
        
        [Name("Range"), NameIndex(0), JsonProperty]
        public string Range { get; set; } = "";
        
        [Name("LevRange"), NameIndex(0), JsonProperty]
        public string Levrange { get; set; } = "";
        
        [Name("Light"), NameIndex(0), JsonProperty]
        public string Light { get; set; } = "";
        
        [Name("Flicker"), NameIndex(0), JsonProperty]
        public string Flicker { get; set; } = "";
        
        [Name("Red"), NameIndex(0), JsonProperty]
        public string Red { get; set; } = "";
        
        [Name("Green"), NameIndex(0), JsonProperty]
        public string Green { get; set; } = "";
        
        [Name("Blue"), NameIndex(0), JsonProperty]
        public string Blue { get; set; } = "";
        
        [Name("InitSteps"), NameIndex(0), JsonProperty]
        public string Initsteps { get; set; } = "";
        
        [Name("Activate"), NameIndex(0), JsonProperty]
        public string Activate { get; set; } = "";
        
        [Name("LoopAnim"), NameIndex(0), JsonProperty]
        public string Loopanim { get; set; } = "";
        
        [Name("CelFile"), NameIndex(0), JsonProperty]
        public string Celfile { get; set; } = "";
        
        [Name("animrate"), NameIndex(0), JsonProperty]
        public string Animrate { get; set; } = "";
        
        [Name("AnimLen"), NameIndex(0), JsonProperty]
        public string Animlen { get; set; } = "";
        
        [Name("AnimSpeed"), NameIndex(0), JsonProperty]
        public string Animspeed { get; set; } = "";
        
        [Name("RandStart"), NameIndex(0), JsonProperty]
        public string Randstart { get; set; } = "";
        
        [Name("SubLoop"), NameIndex(0), JsonProperty]
        public string Subloop { get; set; } = "";
        
        [Name("SubStart"), NameIndex(0), JsonProperty]
        public string Substart { get; set; } = "";
        
        [Name("SubStop"), NameIndex(0), JsonProperty]
        public string Substop { get; set; } = "";
        
        [Name("CollideType"), NameIndex(0), JsonProperty]
        public string Collidetype { get; set; } = "";
        
        [Name("CollideKill"), NameIndex(0), JsonProperty]
        public string Collidekill { get; set; } = "";
        
        [Name("CollideFriend"), NameIndex(0), JsonProperty]
        public string Collidefriend { get; set; } = "";
        
        [Name("LastCollide"), NameIndex(0), JsonProperty]
        public string Lastcollide { get; set; } = "";
        
        [Name("Collision"), NameIndex(0), JsonProperty]
        public string Collision { get; set; } = "";
        
        [Name("ClientCol"), NameIndex(0), JsonProperty]
        public string Clientcol { get; set; } = "";
        
        [Name("ClientSend"), NameIndex(0), JsonProperty]
        public string Clientsend { get; set; } = "";
        
        [Name("NextHit"), NameIndex(0), JsonProperty]
        public string Nexthit { get; set; } = "";
        
        [Name("NextDelay"), NameIndex(0), JsonProperty]
        public string Nextdelay { get; set; } = "";
        
        [Name("xoffset"), NameIndex(0), JsonProperty]
        public string Xoffset { get; set; } = "";
        
        [Name("yoffset"), NameIndex(0), JsonProperty]
        public string Yoffset { get; set; } = "";
        
        [Name("zoffset"), NameIndex(0), JsonProperty]
        public string Zoffset { get; set; } = "";
        
        [Name("Size"), NameIndex(0), JsonProperty]
        public string Size { get; set; } = "";
        
        [Name("SrcTown"), NameIndex(0), JsonProperty]
        public string Srctown { get; set; } = "";
        
        [Name("CltSrcTown"), NameIndex(0), JsonProperty]
        public string Cltsrctown { get; set; } = "";
        
        [Name("CanDestroy"), NameIndex(0), JsonProperty]
        public string Candestroy { get; set; } = "";
        
        [Name("ToHit"), NameIndex(0), JsonProperty]
        public string Tohit { get; set; } = "";
        
        [Name("AlwaysExplode"), NameIndex(0), JsonProperty]
        public string Alwaysexplode { get; set; } = "";
        
        [Name("Explosion"), NameIndex(0), JsonProperty]
        public string Explosion { get; set; } = "";
        
        [Name("Town"), NameIndex(0), JsonProperty]
        public string Town { get; set; } = "";
        
        [Name("NoUniqueMod"), NameIndex(0), JsonProperty]
        public string Nouniquemod { get; set; } = "";
        
        [Name("NoMultiShot"), NameIndex(0), JsonProperty]
        public string Nomultishot { get; set; } = "";
        
        [Name("Holy"), NameIndex(0), JsonProperty]
        public string Holy { get; set; } = "";
        
        [Name("CanSlow"), NameIndex(0), JsonProperty]
        public string Canslow { get; set; } = "";
        
        [Name("ReturnFire"), NameIndex(0), JsonProperty]
        public string Returnfire { get; set; } = "";
        
        [Name("GetHit"), NameIndex(0), JsonProperty]
        public string Gethit { get; set; } = "";
        
        [Name("SoftHit"), NameIndex(0), JsonProperty]
        public string Softhit { get; set; } = "";
        
        [Name("KnockBack"), NameIndex(0), JsonProperty]
        public string Knockback { get; set; } = "";
        
        [Name("Trans"), NameIndex(0), JsonProperty]
        public string Trans { get; set; } = "";
        
        [Name("Qty"), NameIndex(0), JsonProperty]
        public string Qty { get; set; } = "";
        
        [Name("Pierce"), NameIndex(0), JsonProperty]
        public string Pierce { get; set; } = "";
        
        [Name("SpecialSetup"), NameIndex(0), JsonProperty]
        public string Specialsetup { get; set; } = "";
        
        [Name("MissileSkill"), NameIndex(0), JsonProperty]
        public string Missileskill { get; set; } = "";
        
        [Name("Skill"), NameIndex(0), JsonProperty]
        public string Skill { get; set; } = "";
        
        [Name("ResultFlags"), NameIndex(0), JsonProperty]
        public string Resultflags { get; set; } = "";
        
        [Name("HitFlags"), NameIndex(0), JsonProperty]
        public string Hitflags { get; set; } = "";
        
        [Name("HitShift"), NameIndex(0), JsonProperty]
        public string Hitshift { get; set; } = "";
        
        [Name("ApplyMastery"), NameIndex(0), JsonProperty]
        public string Applymastery { get; set; } = "";
        
        [Name("SrcDamage"), NameIndex(0), JsonProperty]
        public string Srcdamage { get; set; } = "";
        
        [Name("Half2HSrc"), NameIndex(0), JsonProperty]
        public string Half2hsrc { get; set; } = "";
        
        [Name("SrcMissDmg"), NameIndex(0), JsonProperty]
        public string Srcmissdmg { get; set; } = "";
        
        [Name("MinDamage"), NameIndex(0), JsonProperty]
        public string Mindamage { get; set; } = "";
        
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
        
        [Name("MaxDamage"), NameIndex(0), JsonProperty]
        public string Maxdamage { get; set; } = "";
        
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
        
        [Name("MinELev1"), NameIndex(0), JsonProperty]
        public string Minelev1 { get; set; } = "";
        
        [Name("MinELev2"), NameIndex(0), JsonProperty]
        public string Minelev2 { get; set; } = "";
        
        [Name("MinELev3"), NameIndex(0), JsonProperty]
        public string Minelev3 { get; set; } = "";
        
        [Name("MinELev4"), NameIndex(0), JsonProperty]
        public string Minelev4 { get; set; } = "";
        
        [Name("MinELev5"), NameIndex(0), JsonProperty]
        public string Minelev5 { get; set; } = "";
        
        [Name("Emax"), NameIndex(0), JsonProperty]
        public string Emax { get; set; } = "";
        
        [Name("MaxELev1"), NameIndex(0), JsonProperty]
        public string Maxelev1 { get; set; } = "";
        
        [Name("MaxELev2"), NameIndex(0), JsonProperty]
        public string Maxelev2 { get; set; } = "";
        
        [Name("MaxELev3"), NameIndex(0), JsonProperty]
        public string Maxelev3 { get; set; } = "";
        
        [Name("MaxELev4"), NameIndex(0), JsonProperty]
        public string Maxelev4 { get; set; } = "";
        
        [Name("MaxELev5"), NameIndex(0), JsonProperty]
        public string Maxelev5 { get; set; } = "";
        
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
        
        [Name("HitClass"), NameIndex(0), JsonProperty]
        public string Hitclass { get; set; } = "";
        
        [Name("NumDirections"), NameIndex(0), JsonProperty]
        public string Numdirections { get; set; } = "";
        
        [Name("LocalBlood"), NameIndex(0), JsonProperty]
        public string Localblood { get; set; } = "";
        
        [Name("DamageRate"), NameIndex(0), JsonProperty]
        public string Damagerate { get; set; } = "";
        
        [Name("TravelSound"), NameIndex(0), JsonProperty]
        public string Travelsound { get; set; } = "";
        
        [Name("HitSound"), NameIndex(0), JsonProperty]
        public string Hitsound { get; set; } = "";
        
        [Name("ProgSound"), NameIndex(0), JsonProperty]
        public string Progsound { get; set; } = "";
        
        [Name("ProgOverlay"), NameIndex(0), JsonProperty]
        public string Progoverlay { get; set; } = "";
        
        [Name("ExplosionMissile"), NameIndex(0), JsonProperty]
        public string Explosionmissile { get; set; } = "";
        
        [Name("SubMissile1"), NameIndex(0), JsonProperty]
        public string Submissile1 { get; set; } = "";
        
        [Name("SubMissile2"), NameIndex(0), JsonProperty]
        public string Submissile2 { get; set; } = "";
        
        [Name("SubMissile3"), NameIndex(0), JsonProperty]
        public string Submissile3 { get; set; } = "";
        
        [Name("HitSubMissile1"), NameIndex(0), JsonProperty]
        public string Hitsubmissile1 { get; set; } = "";
        
        [Name("HitSubMissile2"), NameIndex(0), JsonProperty]
        public string Hitsubmissile2 { get; set; } = "";
        
        [Name("HitSubMissile3"), NameIndex(0), JsonProperty]
        public string Hitsubmissile3 { get; set; } = "";
        
        [Name("HitSubMissile4"), NameIndex(0), JsonProperty]
        public string Hitsubmissile4 { get; set; } = "";
        
        [Name("CltSubMissile1"), NameIndex(0), JsonProperty]
        public string Cltsubmissile1 { get; set; } = "";
        
        [Name("CltSubMissile2"), NameIndex(0), JsonProperty]
        public string Cltsubmissile2 { get; set; } = "";
        
        [Name("CltSubMissile3"), NameIndex(0), JsonProperty]
        public string Cltsubmissile3 { get; set; } = "";
        
        [Name("CltHitSubMissile1"), NameIndex(0), JsonProperty]
        public string Clthitsubmissile1 { get; set; } = "";
        
        [Name("CltHitSubMissile2"), NameIndex(0), JsonProperty]
        public string Clthitsubmissile2 { get; set; } = "";
        
        [Name("CltHitSubMissile3"), NameIndex(0), JsonProperty]
        public string Clthitsubmissile3 { get; set; } = "";
        
        [Name("CltHitSubMissile4"), NameIndex(0), JsonProperty]
        public string Clthitsubmissile4 { get; set; } = "";
        
        [Name("EOL"), NameIndex(0), JsonProperty]
        public string EOL { get; set; } = "";
        
    }
}
