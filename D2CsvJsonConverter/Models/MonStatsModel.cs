using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MonStatsModel
    {
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("hcIdx"), NameIndex(0), JsonProperty]
        public string Hcidx { get; set; } = "";
        
        [Name("BaseId"), NameIndex(0), JsonProperty]
        public string Baseid { get; set; } = "";
        
        [Name("NextInClass"), NameIndex(0), JsonProperty]
        public string Nextinclass { get; set; } = "";
        
        [Name("TransLvl"), NameIndex(0), JsonProperty]
        public string Translvl { get; set; } = "";
        
        [Name("NameStr"), NameIndex(0), JsonProperty]
        public string Namestr { get; set; } = "";
        
        [Name("MonStatsEx"), NameIndex(0), JsonProperty]
        public string Monstatsex { get; set; } = "";
        
        [Name("MonProp"), NameIndex(0), JsonProperty]
        public string Monprop { get; set; } = "";
        
        [Name("MonType"), NameIndex(0), JsonProperty]
        public string Montype { get; set; } = "";
        
        [Name("AI"), NameIndex(0), JsonProperty]
        public string AI { get; set; } = "";
        
        [Name("DescStr"), NameIndex(0), JsonProperty]
        public string Descstr { get; set; } = "";
        
        [Name("Code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("enabled"), NameIndex(0), JsonProperty]
        public string Enabled { get; set; } = "";
        
        [Name("rangedtype"), NameIndex(0), JsonProperty]
        public string Rangedtype { get; set; } = "";
        
        [Name("placespawn"), NameIndex(0), JsonProperty]
        public string Placespawn { get; set; } = "";
        
        [Name("spawn"), NameIndex(0), JsonProperty]
        public string Spawn { get; set; } = "";
        
        [Name("spawnx"), NameIndex(0), JsonProperty]
        public string Spawnx { get; set; } = "";
        
        [Name("spawny"), NameIndex(0), JsonProperty]
        public string Spawny { get; set; } = "";
        
        [Name("spawnmode"), NameIndex(0), JsonProperty]
        public string Spawnmode { get; set; } = "";
        
        [Name("minion1"), NameIndex(0), JsonProperty]
        public string Minion1 { get; set; } = "";
        
        [Name("minion2"), NameIndex(0), JsonProperty]
        public string Minion2 { get; set; } = "";
        
        [Name("SetBoss"), NameIndex(0), JsonProperty]
        public string Setboss { get; set; } = "";
        
        [Name("BossXfer"), NameIndex(0), JsonProperty]
        public string Bossxfer { get; set; } = "";
        
        [Name("PartyMin"), NameIndex(0), JsonProperty]
        public string Partymin { get; set; } = "";
        
        [Name("PartyMax"), NameIndex(0), JsonProperty]
        public string Partymax { get; set; } = "";
        
        [Name("MinGrp"), NameIndex(0), JsonProperty]
        public string Mingrp { get; set; } = "";
        
        [Name("MaxGrp"), NameIndex(0), JsonProperty]
        public string Maxgrp { get; set; } = "";
        
        [Name("sparsePopulate"), NameIndex(0), JsonProperty]
        public string Sparsepopulate { get; set; } = "";
        
        [Name("Velocity"), NameIndex(0), JsonProperty]
        public string Velocity { get; set; } = "";
        
        [Name("Run"), NameIndex(0), JsonProperty]
        public string Run { get; set; } = "";
        
        [Name("Rarity"), NameIndex(0), JsonProperty]
        public string Rarity { get; set; } = "";
        
        [Name("Level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("Level(N)"), NameIndex(0), JsonProperty]
        public string LevelN { get; set; } = "";
        
        [Name("Level(H)"), NameIndex(0), JsonProperty]
        public string LevelH { get; set; } = "";
        
        [Name("MonSound"), NameIndex(0), JsonProperty]
        public string Monsound { get; set; } = "";
        
        [Name("UMonSound"), NameIndex(0), JsonProperty]
        public string Umonsound { get; set; } = "";
        
        [Name("threat"), NameIndex(0), JsonProperty]
        public string Threat { get; set; } = "";
        
        [Name("aidel"), NameIndex(0), JsonProperty]
        public string Aidel { get; set; } = "";
        
        [Name("aidel(N)"), NameIndex(0), JsonProperty]
        public string AidelN { get; set; } = "";
        
        [Name("aidel(H)"), NameIndex(0), JsonProperty]
        public string AidelH { get; set; } = "";
        
        [Name("aidist"), NameIndex(0), JsonProperty]
        public string Aidist { get; set; } = "";
        
        [Name("aidist(N)"), NameIndex(0), JsonProperty]
        public string AidistN { get; set; } = "";
        
        [Name("aidist(H)"), NameIndex(0), JsonProperty]
        public string AidistH { get; set; } = "";
        
        [Name("aip1"), NameIndex(0), JsonProperty]
        public string Aip1 { get; set; } = "";
        
        [Name("aip1(N)"), NameIndex(0), JsonProperty]
        public string Aip1N { get; set; } = "";
        
        [Name("aip1(H)"), NameIndex(0), JsonProperty]
        public string Aip1H { get; set; } = "";
        
        [Name("aip2"), NameIndex(0), JsonProperty]
        public string Aip2 { get; set; } = "";
        
        [Name("aip2(N)"), NameIndex(0), JsonProperty]
        public string Aip2N { get; set; } = "";
        
        [Name("aip2(H)"), NameIndex(0), JsonProperty]
        public string Aip2H { get; set; } = "";
        
        [Name("aip3"), NameIndex(0), JsonProperty]
        public string Aip3 { get; set; } = "";
        
        [Name("aip3(N)"), NameIndex(0), JsonProperty]
        public string Aip3N { get; set; } = "";
        
        [Name("aip3(H)"), NameIndex(0), JsonProperty]
        public string Aip3H { get; set; } = "";
        
        [Name("aip4"), NameIndex(0), JsonProperty]
        public string Aip4 { get; set; } = "";
        
        [Name("aip4(N)"), NameIndex(0), JsonProperty]
        public string Aip4N { get; set; } = "";
        
        [Name("aip4(H)"), NameIndex(0), JsonProperty]
        public string Aip4H { get; set; } = "";
        
        [Name("aip5"), NameIndex(0), JsonProperty]
        public string Aip5 { get; set; } = "";
        
        [Name("aip5(N)"), NameIndex(0), JsonProperty]
        public string Aip5N { get; set; } = "";
        
        [Name("aip5(H)"), NameIndex(0), JsonProperty]
        public string Aip5H { get; set; } = "";
        
        [Name("aip6"), NameIndex(0), JsonProperty]
        public string Aip6 { get; set; } = "";
        
        [Name("aip6(N)"), NameIndex(0), JsonProperty]
        public string Aip6N { get; set; } = "";
        
        [Name("aip6(H)"), NameIndex(0), JsonProperty]
        public string Aip6H { get; set; } = "";
        
        [Name("aip7"), NameIndex(0), JsonProperty]
        public string Aip7 { get; set; } = "";
        
        [Name("aip7(N)"), NameIndex(0), JsonProperty]
        public string Aip7N { get; set; } = "";
        
        [Name("aip7(H)"), NameIndex(0), JsonProperty]
        public string Aip7H { get; set; } = "";
        
        [Name("aip8"), NameIndex(0), JsonProperty]
        public string Aip8 { get; set; } = "";
        
        [Name("aip8(N)"), NameIndex(0), JsonProperty]
        public string Aip8N { get; set; } = "";
        
        [Name("aip8(H)"), NameIndex(0), JsonProperty]
        public string Aip8H { get; set; } = "";
        
        [Name("MissA1"), NameIndex(0), JsonProperty]
        public string Missa1 { get; set; } = "";
        
        [Name("MissA2"), NameIndex(0), JsonProperty]
        public string Missa2 { get; set; } = "";
        
        [Name("MissS1"), NameIndex(0), JsonProperty]
        public string Misss1 { get; set; } = "";
        
        [Name("MissS2"), NameIndex(0), JsonProperty]
        public string Misss2 { get; set; } = "";
        
        [Name("MissS3"), NameIndex(0), JsonProperty]
        public string Misss3 { get; set; } = "";
        
        [Name("MissS4"), NameIndex(0), JsonProperty]
        public string Misss4 { get; set; } = "";
        
        [Name("MissC"), NameIndex(0), JsonProperty]
        public string Missc { get; set; } = "";
        
        [Name("MissSQ"), NameIndex(0), JsonProperty]
        public string Misssq { get; set; } = "";
        
        [Name("Align"), NameIndex(0), JsonProperty]
        public string Align { get; set; } = "";
        
        [Name("isSpawn"), NameIndex(0), JsonProperty]
        public string Isspawn { get; set; } = "";
        
        [Name("isMelee"), NameIndex(0), JsonProperty]
        public string Ismelee { get; set; } = "";
        
        [Name("npc"), NameIndex(0), JsonProperty]
        public string Npc { get; set; } = "";
        
        [Name("interact"), NameIndex(0), JsonProperty]
        public string Interact { get; set; } = "";
        
        [Name("inventory"), NameIndex(0), JsonProperty]
        public string Inventory { get; set; } = "";
        
        [Name("inTown"), NameIndex(0), JsonProperty]
        public string Intown { get; set; } = "";
        
        [Name("lUndead"), NameIndex(0), JsonProperty]
        public string Lundead { get; set; } = "";
        
        [Name("hUndead"), NameIndex(0), JsonProperty]
        public string Hundead { get; set; } = "";
        
        [Name("demon"), NameIndex(0), JsonProperty]
        public string Demon { get; set; } = "";
        
        [Name("flying"), NameIndex(0), JsonProperty]
        public string Flying { get; set; } = "";
        
        [Name("opendoors"), NameIndex(0), JsonProperty]
        public string Opendoors { get; set; } = "";
        
        [Name("boss"), NameIndex(0), JsonProperty]
        public string Boss { get; set; } = "";
        
        [Name("primeevil"), NameIndex(0), JsonProperty]
        public string Primeevil { get; set; } = "";
        
        [Name("killable"), NameIndex(0), JsonProperty]
        public string Killable { get; set; } = "";
        
        [Name("switchai"), NameIndex(0), JsonProperty]
        public string Switchai { get; set; } = "";
        
        [Name("noAura"), NameIndex(0), JsonProperty]
        public string Noaura { get; set; } = "";
        
        [Name("nomultishot"), NameIndex(0), JsonProperty]
        public string Nomultishot { get; set; } = "";
        
        [Name("neverCount"), NameIndex(0), JsonProperty]
        public string Nevercount { get; set; } = "";
        
        [Name("petIgnore"), NameIndex(0), JsonProperty]
        public string Petignore { get; set; } = "";
        
        [Name("deathDmg"), NameIndex(0), JsonProperty]
        public string Deathdmg { get; set; } = "";
        
        [Name("genericSpawn"), NameIndex(0), JsonProperty]
        public string Genericspawn { get; set; } = "";
        
        [Name("zoo"), NameIndex(0), JsonProperty]
        public string Zoo { get; set; } = "";
        
        [Name("SendSkills"), NameIndex(0), JsonProperty]
        public string Sendskills { get; set; } = "";
        
        [Name("Skill1"), NameIndex(0), JsonProperty]
        public string Skill1 { get; set; } = "";
        
        [Name("Sk1mode"), NameIndex(0), JsonProperty]
        public string Sk1mode { get; set; } = "";
        
        [Name("Sk1lvl"), NameIndex(0), JsonProperty]
        public string Sk1lvl { get; set; } = "";
        
        [Name("Skill2"), NameIndex(0), JsonProperty]
        public string Skill2 { get; set; } = "";
        
        [Name("Sk2mode"), NameIndex(0), JsonProperty]
        public string Sk2mode { get; set; } = "";
        
        [Name("Sk2lvl"), NameIndex(0), JsonProperty]
        public string Sk2lvl { get; set; } = "";
        
        [Name("Skill3"), NameIndex(0), JsonProperty]
        public string Skill3 { get; set; } = "";
        
        [Name("Sk3mode"), NameIndex(0), JsonProperty]
        public string Sk3mode { get; set; } = "";
        
        [Name("Sk3lvl"), NameIndex(0), JsonProperty]
        public string Sk3lvl { get; set; } = "";
        
        [Name("Skill4"), NameIndex(0), JsonProperty]
        public string Skill4 { get; set; } = "";
        
        [Name("Sk4mode"), NameIndex(0), JsonProperty]
        public string Sk4mode { get; set; } = "";
        
        [Name("Sk4lvl"), NameIndex(0), JsonProperty]
        public string Sk4lvl { get; set; } = "";
        
        [Name("Skill5"), NameIndex(0), JsonProperty]
        public string Skill5 { get; set; } = "";
        
        [Name("Sk5mode"), NameIndex(0), JsonProperty]
        public string Sk5mode { get; set; } = "";
        
        [Name("Sk5lvl"), NameIndex(0), JsonProperty]
        public string Sk5lvl { get; set; } = "";
        
        [Name("Skill6"), NameIndex(0), JsonProperty]
        public string Skill6 { get; set; } = "";
        
        [Name("Sk6mode"), NameIndex(0), JsonProperty]
        public string Sk6mode { get; set; } = "";
        
        [Name("Sk6lvl"), NameIndex(0), JsonProperty]
        public string Sk6lvl { get; set; } = "";
        
        [Name("Skill7"), NameIndex(0), JsonProperty]
        public string Skill7 { get; set; } = "";
        
        [Name("Sk7mode"), NameIndex(0), JsonProperty]
        public string Sk7mode { get; set; } = "";
        
        [Name("Sk7lvl"), NameIndex(0), JsonProperty]
        public string Sk7lvl { get; set; } = "";
        
        [Name("Skill8"), NameIndex(0), JsonProperty]
        public string Skill8 { get; set; } = "";
        
        [Name("Sk8mode"), NameIndex(0), JsonProperty]
        public string Sk8mode { get; set; } = "";
        
        [Name("Sk8lvl"), NameIndex(0), JsonProperty]
        public string Sk8lvl { get; set; } = "";
        
        [Name("Drain"), NameIndex(0), JsonProperty]
        public string Drain { get; set; } = "";
        
        [Name("Drain(N)"), NameIndex(0), JsonProperty]
        public string DrainN { get; set; } = "";
        
        [Name("Drain(H)"), NameIndex(0), JsonProperty]
        public string DrainH { get; set; } = "";
        
        [Name("coldeffect"), NameIndex(0), JsonProperty]
        public string Coldeffect { get; set; } = "";
        
        [Name("coldeffect(N)"), NameIndex(0), JsonProperty]
        public string ColdeffectN { get; set; } = "";
        
        [Name("coldeffect(H)"), NameIndex(0), JsonProperty]
        public string ColdeffectH { get; set; } = "";
        
        [Name("ResDm"), NameIndex(0), JsonProperty]
        public string Resdm { get; set; } = "";
        
        [Name("ResMa"), NameIndex(0), JsonProperty]
        public string Resma { get; set; } = "";
        
        [Name("ResFi"), NameIndex(0), JsonProperty]
        public string Resfi { get; set; } = "";
        
        [Name("ResLi"), NameIndex(0), JsonProperty]
        public string Resli { get; set; } = "";
        
        [Name("ResCo"), NameIndex(0), JsonProperty]
        public string Resco { get; set; } = "";
        
        [Name("ResPo"), NameIndex(0), JsonProperty]
        public string Respo { get; set; } = "";
        
        [Name("ResDm(N)"), NameIndex(0), JsonProperty]
        public string ResdmN { get; set; } = "";
        
        [Name("ResMa(N)"), NameIndex(0), JsonProperty]
        public string ResmaN { get; set; } = "";
        
        [Name("ResFi(N)"), NameIndex(0), JsonProperty]
        public string ResfiN { get; set; } = "";
        
        [Name("ResLi(N)"), NameIndex(0), JsonProperty]
        public string ResliN { get; set; } = "";
        
        [Name("ResCo(N)"), NameIndex(0), JsonProperty]
        public string RescoN { get; set; } = "";
        
        [Name("ResPo(N)"), NameIndex(0), JsonProperty]
        public string RespoN { get; set; } = "";
        
        [Name("ResDm(H)"), NameIndex(0), JsonProperty]
        public string ResdmH { get; set; } = "";
        
        [Name("ResMa(H)"), NameIndex(0), JsonProperty]
        public string ResmaH { get; set; } = "";
        
        [Name("ResFi(H)"), NameIndex(0), JsonProperty]
        public string ResfiH { get; set; } = "";
        
        [Name("ResLi(H)"), NameIndex(0), JsonProperty]
        public string ResliH { get; set; } = "";
        
        [Name("ResCo(H)"), NameIndex(0), JsonProperty]
        public string RescoH { get; set; } = "";
        
        [Name("ResPo(H)"), NameIndex(0), JsonProperty]
        public string RespoH { get; set; } = "";
        
        [Name("DamageRegen"), NameIndex(0), JsonProperty]
        public string Damageregen { get; set; } = "";
        
        [Name("SkillDamage"), NameIndex(0), JsonProperty]
        public string Skilldamage { get; set; } = "";
        
        [Name("noRatio"), NameIndex(0), JsonProperty]
        public string Noratio { get; set; } = "";
        
        [Name("NoShldBlock"), NameIndex(0), JsonProperty]
        public string Noshldblock { get; set; } = "";
        
        [Name("ToBlock"), NameIndex(0), JsonProperty]
        public string Toblock { get; set; } = "";
        
        [Name("ToBlock(N)"), NameIndex(0), JsonProperty]
        public string ToblockN { get; set; } = "";
        
        [Name("ToBlock(H)"), NameIndex(0), JsonProperty]
        public string ToblockH { get; set; } = "";
        
        [Name("Crit"), NameIndex(0), JsonProperty]
        public string Crit { get; set; } = "";
        
        [Name("minHP"), NameIndex(0), JsonProperty]
        public string Minhp { get; set; } = "";
        
        [Name("maxHP"), NameIndex(0), JsonProperty]
        public string Maxhp { get; set; } = "";
        
        [Name("AC"), NameIndex(0), JsonProperty]
        public string AC { get; set; } = "";
        
        [Name("Exp"), NameIndex(0), JsonProperty]
        public string Exp { get; set; } = "";
        
        [Name("A1MinD"), NameIndex(0), JsonProperty]
        public string A1mind { get; set; } = "";
        
        [Name("A1MaxD"), NameIndex(0), JsonProperty]
        public string A1maxd { get; set; } = "";
        
        [Name("A1TH"), NameIndex(0), JsonProperty]
        public string A1TH { get; set; } = "";
        
        [Name("A2MinD"), NameIndex(0), JsonProperty]
        public string A2mind { get; set; } = "";
        
        [Name("A2MaxD"), NameIndex(0), JsonProperty]
        public string A2maxd { get; set; } = "";
        
        [Name("A2TH"), NameIndex(0), JsonProperty]
        public string A2TH { get; set; } = "";
        
        [Name("S1MinD"), NameIndex(0), JsonProperty]
        public string S1mind { get; set; } = "";
        
        [Name("S1MaxD"), NameIndex(0), JsonProperty]
        public string S1maxd { get; set; } = "";
        
        [Name("S1TH"), NameIndex(0), JsonProperty]
        public string S1TH { get; set; } = "";
        
        [Name("MinHP(N)"), NameIndex(0), JsonProperty]
        public string MinhpN { get; set; } = "";
        
        [Name("MaxHP(N)"), NameIndex(0), JsonProperty]
        public string MaxhpN { get; set; } = "";
        
        [Name("AC(N)"), NameIndex(0), JsonProperty]
        public string ACN { get; set; } = "";
        
        [Name("Exp(N)"), NameIndex(0), JsonProperty]
        public string ExpN { get; set; } = "";
        
        [Name("A1MinD(N)"), NameIndex(0), JsonProperty]
        public string A1mindN { get; set; } = "";
        
        [Name("A1MaxD(N)"), NameIndex(0), JsonProperty]
        public string A1maxdN { get; set; } = "";
        
        [Name("A1TH(N)"), NameIndex(0), JsonProperty]
        public string A1THN { get; set; } = "";
        
        [Name("A2MinD(N)"), NameIndex(0), JsonProperty]
        public string A2mindN { get; set; } = "";
        
        [Name("A2MaxD(N)"), NameIndex(0), JsonProperty]
        public string A2maxdN { get; set; } = "";
        
        [Name("A2TH(N)"), NameIndex(0), JsonProperty]
        public string A2THN { get; set; } = "";
        
        [Name("S1MinD(N)"), NameIndex(0), JsonProperty]
        public string S1mindN { get; set; } = "";
        
        [Name("S1MaxD(N)"), NameIndex(0), JsonProperty]
        public string S1maxdN { get; set; } = "";
        
        [Name("S1TH(N)"), NameIndex(0), JsonProperty]
        public string S1THN { get; set; } = "";
        
        [Name("MinHP(H)"), NameIndex(0), JsonProperty]
        public string MinhpH { get; set; } = "";
        
        [Name("MaxHP(H)"), NameIndex(0), JsonProperty]
        public string MaxhpH { get; set; } = "";
        
        [Name("AC(H)"), NameIndex(0), JsonProperty]
        public string ACH { get; set; } = "";
        
        [Name("Exp(H)"), NameIndex(0), JsonProperty]
        public string ExpH { get; set; } = "";
        
        [Name("A1MinD(H)"), NameIndex(0), JsonProperty]
        public string A1mindH { get; set; } = "";
        
        [Name("A1MaxD(H)"), NameIndex(0), JsonProperty]
        public string A1maxdH { get; set; } = "";
        
        [Name("A1TH(H)"), NameIndex(0), JsonProperty]
        public string A1THH { get; set; } = "";
        
        [Name("A2MinD(H)"), NameIndex(0), JsonProperty]
        public string A2mindH { get; set; } = "";
        
        [Name("A2MaxD(H)"), NameIndex(0), JsonProperty]
        public string A2maxdH { get; set; } = "";
        
        [Name("A2TH(H)"), NameIndex(0), JsonProperty]
        public string A2THH { get; set; } = "";
        
        [Name("S1MinD(H)"), NameIndex(0), JsonProperty]
        public string S1mindH { get; set; } = "";
        
        [Name("S1MaxD(H)"), NameIndex(0), JsonProperty]
        public string S1maxdH { get; set; } = "";
        
        [Name("S1TH(H)"), NameIndex(0), JsonProperty]
        public string S1THH { get; set; } = "";
        
        [Name("El1Mode"), NameIndex(0), JsonProperty]
        public string El1mode { get; set; } = "";
        
        [Name("El1Type"), NameIndex(0), JsonProperty]
        public string El1type { get; set; } = "";
        
        [Name("El1Pct"), NameIndex(0), JsonProperty]
        public string El1pct { get; set; } = "";
        
        [Name("El1MinD"), NameIndex(0), JsonProperty]
        public string El1mind { get; set; } = "";
        
        [Name("El1MaxD"), NameIndex(0), JsonProperty]
        public string El1maxd { get; set; } = "";
        
        [Name("El1Dur"), NameIndex(0), JsonProperty]
        public string El1dur { get; set; } = "";
        
        [Name("El1Pct(N)"), NameIndex(0), JsonProperty]
        public string El1pctN { get; set; } = "";
        
        [Name("El1MinD(N)"), NameIndex(0), JsonProperty]
        public string El1mindN { get; set; } = "";
        
        [Name("El1MaxD(N)"), NameIndex(0), JsonProperty]
        public string El1maxdN { get; set; } = "";
        
        [Name("El1Dur(N)"), NameIndex(0), JsonProperty]
        public string El1durN { get; set; } = "";
        
        [Name("El1Pct(H)"), NameIndex(0), JsonProperty]
        public string El1pctH { get; set; } = "";
        
        [Name("El1MinD(H)"), NameIndex(0), JsonProperty]
        public string El1mindH { get; set; } = "";
        
        [Name("El1MaxD(H)"), NameIndex(0), JsonProperty]
        public string El1maxdH { get; set; } = "";
        
        [Name("El1Dur(H)"), NameIndex(0), JsonProperty]
        public string El1durH { get; set; } = "";
        
        [Name("El2Mode"), NameIndex(0), JsonProperty]
        public string El2mode { get; set; } = "";
        
        [Name("El2Type"), NameIndex(0), JsonProperty]
        public string El2type { get; set; } = "";
        
        [Name("El2Pct"), NameIndex(0), JsonProperty]
        public string El2pct { get; set; } = "";
        
        [Name("El2MinD"), NameIndex(0), JsonProperty]
        public string El2mind { get; set; } = "";
        
        [Name("El2MaxD"), NameIndex(0), JsonProperty]
        public string El2maxd { get; set; } = "";
        
        [Name("El2Dur"), NameIndex(0), JsonProperty]
        public string El2dur { get; set; } = "";
        
        [Name("El2Pct(N)"), NameIndex(0), JsonProperty]
        public string El2pctN { get; set; } = "";
        
        [Name("El2MinD(N)"), NameIndex(0), JsonProperty]
        public string El2mindN { get; set; } = "";
        
        [Name("El2MaxD(N)"), NameIndex(0), JsonProperty]
        public string El2maxdN { get; set; } = "";
        
        [Name("El2Dur(N)"), NameIndex(0), JsonProperty]
        public string El2durN { get; set; } = "";
        
        [Name("El2Pct(H)"), NameIndex(0), JsonProperty]
        public string El2pctH { get; set; } = "";
        
        [Name("El2MinD(H)"), NameIndex(0), JsonProperty]
        public string El2mindH { get; set; } = "";
        
        [Name("El2MaxD(H)"), NameIndex(0), JsonProperty]
        public string El2maxdH { get; set; } = "";
        
        [Name("El2Dur(H)"), NameIndex(0), JsonProperty]
        public string El2durH { get; set; } = "";
        
        [Name("El3Mode"), NameIndex(0), JsonProperty]
        public string El3mode { get; set; } = "";
        
        [Name("El3Type"), NameIndex(0), JsonProperty]
        public string El3type { get; set; } = "";
        
        [Name("El3Pct"), NameIndex(0), JsonProperty]
        public string El3pct { get; set; } = "";
        
        [Name("El3MinD"), NameIndex(0), JsonProperty]
        public string El3mind { get; set; } = "";
        
        [Name("El3MaxD"), NameIndex(0), JsonProperty]
        public string El3maxd { get; set; } = "";
        
        [Name("El3Dur"), NameIndex(0), JsonProperty]
        public string El3dur { get; set; } = "";
        
        [Name("El3Pct(N)"), NameIndex(0), JsonProperty]
        public string El3pctN { get; set; } = "";
        
        [Name("El3MinD(N)"), NameIndex(0), JsonProperty]
        public string El3mindN { get; set; } = "";
        
        [Name("El3MaxD(N)"), NameIndex(0), JsonProperty]
        public string El3maxdN { get; set; } = "";
        
        [Name("El3Dur(N)"), NameIndex(0), JsonProperty]
        public string El3durN { get; set; } = "";
        
        [Name("El3Pct(H)"), NameIndex(0), JsonProperty]
        public string El3pctH { get; set; } = "";
        
        [Name("El3MinD(H)"), NameIndex(0), JsonProperty]
        public string El3mindH { get; set; } = "";
        
        [Name("El3MaxD(H)"), NameIndex(0), JsonProperty]
        public string El3maxdH { get; set; } = "";
        
        [Name("El3Dur(H)"), NameIndex(0), JsonProperty]
        public string El3durH { get; set; } = "";
        
        [Name("TreasureClass1"), NameIndex(0), JsonProperty]
        public string Treasureclass1 { get; set; } = "";
        
        [Name("TreasureClass2"), NameIndex(0), JsonProperty]
        public string Treasureclass2 { get; set; } = "";
        
        [Name("TreasureClass3"), NameIndex(0), JsonProperty]
        public string Treasureclass3 { get; set; } = "";
        
        [Name("TreasureClass4"), NameIndex(0), JsonProperty]
        public string Treasureclass4 { get; set; } = "";
        
        [Name("TreasureClass1(N)"), NameIndex(0), JsonProperty]
        public string Treasureclass1N { get; set; } = "";
        
        [Name("TreasureClass2(N)"), NameIndex(0), JsonProperty]
        public string Treasureclass2N { get; set; } = "";
        
        [Name("TreasureClass3(N)"), NameIndex(0), JsonProperty]
        public string Treasureclass3N { get; set; } = "";
        
        [Name("TreasureClass4(N)"), NameIndex(0), JsonProperty]
        public string Treasureclass4N { get; set; } = "";
        
        [Name("TreasureClass1(H)"), NameIndex(0), JsonProperty]
        public string Treasureclass1H { get; set; } = "";
        
        [Name("TreasureClass2(H)"), NameIndex(0), JsonProperty]
        public string Treasureclass2H { get; set; } = "";
        
        [Name("TreasureClass3(H)"), NameIndex(0), JsonProperty]
        public string Treasureclass3H { get; set; } = "";
        
        [Name("TreasureClass4(H)"), NameIndex(0), JsonProperty]
        public string Treasureclass4H { get; set; } = "";
        
        [Name("TCQuestId"), NameIndex(0), JsonProperty]
        public string Tcquestid { get; set; } = "";
        
        [Name("TCQuestCP"), NameIndex(0), JsonProperty]
        public string Tcquestcp { get; set; } = "";
        
        [Name("SplEndDeath"), NameIndex(0), JsonProperty]
        public string Splenddeath { get; set; } = "";
        
        [Name("SplGetModeChart"), NameIndex(0), JsonProperty]
        public string Splgetmodechart { get; set; } = "";
        
        [Name("SplEndGeneric"), NameIndex(0), JsonProperty]
        public string Splendgeneric { get; set; } = "";
        
        [Name("SplClientEnd"), NameIndex(0), JsonProperty]
        public string Splclientend { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
