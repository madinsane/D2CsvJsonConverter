using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class MiscModel
    {
        [Name("name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("*name"), NameIndex(0), JsonProperty]
        public string _Name { get; set; } = "";
        
        [Name("szFlavorText"), NameIndex(0), JsonProperty]
        public string Szflavortext { get; set; } = "";
        
        [Name("compactsave"), NameIndex(0), JsonProperty]
        public string Compactsave { get; set; } = "";
        
        [Name("version"), NameIndex(0), JsonProperty]
        public string Version { get; set; } = "";
        
        [Name("level"), NameIndex(0), JsonProperty]
        public string Level { get; set; } = "";
        
        [Name("levelreq"), NameIndex(0), JsonProperty]
        public string Levelreq { get; set; } = "";
        
        [Name("rarity"), NameIndex(0), JsonProperty]
        public string Rarity { get; set; } = "";
        
        [Name("spawnable"), NameIndex(0), JsonProperty]
        public string Spawnable { get; set; } = "";
        
        [Name("speed"), NameIndex(0), JsonProperty]
        public string Speed { get; set; } = "";
        
        [Name("nodurability"), NameIndex(0), JsonProperty]
        public string Nodurability { get; set; } = "";
        
        [Name("cost"), NameIndex(0), JsonProperty]
        public string Cost { get; set; } = "";
        
        [Name("gamble cost"), NameIndex(0), JsonProperty]
        public string GambleCost { get; set; } = "";
        
        [Name("code"), NameIndex(0), JsonProperty]
        public string Code { get; set; } = "";
        
        [Name("alternategfx"), NameIndex(0), JsonProperty]
        public string Alternategfx { get; set; } = "";
        
        [Name("namestr"), NameIndex(0), JsonProperty]
        public string Namestr { get; set; } = "";
        
        [Name("component"), NameIndex(0), JsonProperty]
        public string Component { get; set; } = "";
        
        [Name("invwidth"), NameIndex(0), JsonProperty]
        public string Invwidth { get; set; } = "";
        
        [Name("invheight"), NameIndex(0), JsonProperty]
        public string Invheight { get; set; } = "";
        
        [Name("hasinv"), NameIndex(0), JsonProperty]
        public string Hasinv { get; set; } = "";
        
        [Name("gemsockets"), NameIndex(0), JsonProperty]
        public string Gemsockets { get; set; } = "";
        
        [Name("gemapplytype"), NameIndex(0), JsonProperty]
        public string Gemapplytype { get; set; } = "";
        
        [Name("flippyfile"), NameIndex(0), JsonProperty]
        public string Flippyfile { get; set; } = "";
        
        [Name("invfile"), NameIndex(0), JsonProperty]
        public string Invfile { get; set; } = "";
        
        [Name("uniqueinvfile"), NameIndex(0), JsonProperty]
        public string Uniqueinvfile { get; set; } = "";
        
        [Name("special"), NameIndex(0), JsonProperty]
        public string Special { get; set; } = "";
        
        [Name("Transmogrify"), NameIndex(0), JsonProperty]
        public string Transmogrify { get; set; } = "";
        
        [Name("TMogType"), NameIndex(0), JsonProperty]
        public string Tmogtype { get; set; } = "";
        
        [Name("TMogMin"), NameIndex(0), JsonProperty]
        public string Tmogmin { get; set; } = "";
        
        [Name("TMogMax"), NameIndex(0), JsonProperty]
        public string Tmogmax { get; set; } = "";
        
        [Name("useable"), NameIndex(0), JsonProperty]
        public string Useable { get; set; } = "";
        
        [Name("throwable"), NameIndex(0), JsonProperty]
        public string Throwable { get; set; } = "";
        
        [Name("type"), NameIndex(0), JsonProperty]
        public string Type { get; set; } = "";
        
        [Name("type2"), NameIndex(0), JsonProperty]
        public string Type2 { get; set; } = "";
        
        [Name("dropsound"), NameIndex(0), JsonProperty]
        public string Dropsound { get; set; } = "";
        
        [Name("dropsfxframe"), NameIndex(0), JsonProperty]
        public string Dropsfxframe { get; set; } = "";
        
        [Name("usesound"), NameIndex(0), JsonProperty]
        public string Usesound { get; set; } = "";
        
        [Name("unique"), NameIndex(0), JsonProperty]
        public string Unique { get; set; } = "";
        
        [Name("transparent"), NameIndex(0), JsonProperty]
        public string Transparent { get; set; } = "";
        
        [Name("transtbl"), NameIndex(0), JsonProperty]
        public string Transtbl { get; set; } = "";
        
        [Name("lightradius"), NameIndex(0), JsonProperty]
        public string Lightradius { get; set; } = "";
        
        [Name("belt"), NameIndex(0), JsonProperty]
        public string Belt { get; set; } = "";
        
        [Name("autobelt"), NameIndex(0), JsonProperty]
        public string Autobelt { get; set; } = "";
        
        [Name("stackable"), NameIndex(0), JsonProperty]
        public string Stackable { get; set; } = "";
        
        [Name("minstack"), NameIndex(0), JsonProperty]
        public string Minstack { get; set; } = "";
        
        [Name("maxstack"), NameIndex(0), JsonProperty]
        public string Maxstack { get; set; } = "";
        
        [Name("spawnstack"), NameIndex(0), JsonProperty]
        public string Spawnstack { get; set; } = "";
        
        [Name("quest"), NameIndex(0), JsonProperty]
        public string Quest { get; set; } = "";
        
        [Name("questdiffcheck"), NameIndex(0), JsonProperty]
        public string Questdiffcheck { get; set; } = "";
        
        [Name("missiletype"), NameIndex(0), JsonProperty]
        public string Missiletype { get; set; } = "";
        
        [Name("spellicon"), NameIndex(0), JsonProperty]
        public string Spellicon { get; set; } = "";
        
        [Name("pSpell"), NameIndex(0), JsonProperty]
        public string Pspell { get; set; } = "";
        
        [Name("state"), NameIndex(0), JsonProperty]
        public string State { get; set; } = "";
        
        [Name("cstate1"), NameIndex(0), JsonProperty]
        public string Cstate1 { get; set; } = "";
        
        [Name("cstate2"), NameIndex(0), JsonProperty]
        public string Cstate2 { get; set; } = "";
        
        [Name("len"), NameIndex(0), JsonProperty]
        public string Len { get; set; } = "";
        
        [Name("stat1"), NameIndex(0), JsonProperty]
        public string Stat1 { get; set; } = "";
        
        [Name("calc1"), NameIndex(0), JsonProperty]
        public string Calc1 { get; set; } = "";
        
        [Name("stat2"), NameIndex(0), JsonProperty]
        public string Stat2 { get; set; } = "";
        
        [Name("calc2"), NameIndex(0), JsonProperty]
        public string Calc2 { get; set; } = "";
        
        [Name("stat3"), NameIndex(0), JsonProperty]
        public string Stat3 { get; set; } = "";
        
        [Name("calc3"), NameIndex(0), JsonProperty]
        public string Calc3 { get; set; } = "";
        
        [Name("spelldesc"), NameIndex(0), JsonProperty]
        public string Spelldesc { get; set; } = "";
        
        [Name("spelldescstr"), NameIndex(0), JsonProperty]
        public string Spelldescstr { get; set; } = "";
        
        [Name("spelldesccalc"), NameIndex(0), JsonProperty]
        public string Spelldesccalc { get; set; } = "";
        
        [Name("durwarning"), NameIndex(0), JsonProperty]
        public string Durwarning { get; set; } = "";
        
        [Name("qntwarning"), NameIndex(0), JsonProperty]
        public string Qntwarning { get; set; } = "";
        
        [Name("gemoffset"), NameIndex(0), JsonProperty]
        public string Gemoffset { get; set; } = "";
        
        [Name("BetterGem"), NameIndex(0), JsonProperty]
        public string Bettergem { get; set; } = "";
        
        [Name("bitfield1"), NameIndex(0), JsonProperty]
        public string Bitfield1 { get; set; } = "";
        
        [Name("CharsiMin"), NameIndex(0), JsonProperty]
        public string Charsimin { get; set; } = "";
        
        [Name("CharsiMax"), NameIndex(0), JsonProperty]
        public string Charsimax { get; set; } = "";
        
        [Name("CharsiMagicMin"), NameIndex(0), JsonProperty]
        public string Charsimagicmin { get; set; } = "";
        
        [Name("CharsiMagicMax"), NameIndex(0), JsonProperty]
        public string Charsimagicmax { get; set; } = "";
        
        [Name("CharsiMagicLvl"), NameIndex(0), JsonProperty]
        public string Charsimagiclvl { get; set; } = "";
        
        [Name("GheedMin"), NameIndex(0), JsonProperty]
        public string Gheedmin { get; set; } = "";
        
        [Name("GheedMax"), NameIndex(0), JsonProperty]
        public string Gheedmax { get; set; } = "";
        
        [Name("GheedMagicMin"), NameIndex(0), JsonProperty]
        public string Gheedmagicmin { get; set; } = "";
        
        [Name("GheedMagicMax"), NameIndex(0), JsonProperty]
        public string Gheedmagicmax { get; set; } = "";
        
        [Name("GheedMagicLvl"), NameIndex(0), JsonProperty]
        public string Gheedmagiclvl { get; set; } = "";
        
        [Name("AkaraMin"), NameIndex(0), JsonProperty]
        public string Akaramin { get; set; } = "";
        
        [Name("AkaraMax"), NameIndex(0), JsonProperty]
        public string Akaramax { get; set; } = "";
        
        [Name("AkaraMagicMin"), NameIndex(0), JsonProperty]
        public string Akaramagicmin { get; set; } = "";
        
        [Name("AkaraMagicMax"), NameIndex(0), JsonProperty]
        public string Akaramagicmax { get; set; } = "";
        
        [Name("AkaraMagicLvl"), NameIndex(0), JsonProperty]
        public string Akaramagiclvl { get; set; } = "";
        
        [Name("FaraMin"), NameIndex(0), JsonProperty]
        public string Faramin { get; set; } = "";
        
        [Name("FaraMax"), NameIndex(0), JsonProperty]
        public string Faramax { get; set; } = "";
        
        [Name("FaraMagicMin"), NameIndex(0), JsonProperty]
        public string Faramagicmin { get; set; } = "";
        
        [Name("FaraMagicMax"), NameIndex(0), JsonProperty]
        public string Faramagicmax { get; set; } = "";
        
        [Name("FaraMagicLvl"), NameIndex(0), JsonProperty]
        public string Faramagiclvl { get; set; } = "";
        
        [Name("LysanderMin"), NameIndex(0), JsonProperty]
        public string Lysandermin { get; set; } = "";
        
        [Name("LysanderMax"), NameIndex(0), JsonProperty]
        public string Lysandermax { get; set; } = "";
        
        [Name("LysanderMagicMin"), NameIndex(0), JsonProperty]
        public string Lysandermagicmin { get; set; } = "";
        
        [Name("LysanderMagicMax"), NameIndex(0), JsonProperty]
        public string Lysandermagicmax { get; set; } = "";
        
        [Name("LysanderMagicLvl"), NameIndex(0), JsonProperty]
        public string Lysandermagiclvl { get; set; } = "";
        
        [Name("DrognanMin"), NameIndex(0), JsonProperty]
        public string Drognanmin { get; set; } = "";
        
        [Name("DrognanMax"), NameIndex(0), JsonProperty]
        public string Drognanmax { get; set; } = "";
        
        [Name("DrognanMagicMin"), NameIndex(0), JsonProperty]
        public string Drognanmagicmin { get; set; } = "";
        
        [Name("DrognanMagicMax"), NameIndex(0), JsonProperty]
        public string Drognanmagicmax { get; set; } = "";
        
        [Name("DrognanMagicLvl"), NameIndex(0), JsonProperty]
        public string Drognanmagiclvl { get; set; } = "";
        
        [Name("HraltiMin"), NameIndex(0), JsonProperty]
        public string Hraltimin { get; set; } = "";
        
        [Name("HraltiMax"), NameIndex(0), JsonProperty]
        public string Hraltimax { get; set; } = "";
        
        [Name("HraltiMagicMin"), NameIndex(0), JsonProperty]
        public string Hraltimagicmin { get; set; } = "";
        
        [Name("HraltiMagicMax"), NameIndex(0), JsonProperty]
        public string Hraltimagicmax { get; set; } = "";
        
        [Name("HraltiMagicLvl"), NameIndex(0), JsonProperty]
        public string Hraltimagiclvl { get; set; } = "";
        
        [Name("AlkorMin"), NameIndex(0), JsonProperty]
        public string Alkormin { get; set; } = "";
        
        [Name("AlkorMax"), NameIndex(0), JsonProperty]
        public string Alkormax { get; set; } = "";
        
        [Name("AlkorMagicMin"), NameIndex(0), JsonProperty]
        public string Alkormagicmin { get; set; } = "";
        
        [Name("AlkorMagicMax"), NameIndex(0), JsonProperty]
        public string Alkormagicmax { get; set; } = "";
        
        [Name("AlkorMagicLvl"), NameIndex(0), JsonProperty]
        public string Alkormagiclvl { get; set; } = "";
        
        [Name("OrmusMin"), NameIndex(0), JsonProperty]
        public string Ormusmin { get; set; } = "";
        
        [Name("OrmusMax"), NameIndex(0), JsonProperty]
        public string Ormusmax { get; set; } = "";
        
        [Name("OrmusMagicMin"), NameIndex(0), JsonProperty]
        public string Ormusmagicmin { get; set; } = "";
        
        [Name("OrmusMagicMax"), NameIndex(0), JsonProperty]
        public string Ormusmagicmax { get; set; } = "";
        
        [Name("OrmusMagicLvl"), NameIndex(0), JsonProperty]
        public string Ormusmagiclvl { get; set; } = "";
        
        [Name("ElzixMin"), NameIndex(0), JsonProperty]
        public string Elzixmin { get; set; } = "";
        
        [Name("ElzixMax"), NameIndex(0), JsonProperty]
        public string Elzixmax { get; set; } = "";
        
        [Name("ElzixMagicMin"), NameIndex(0), JsonProperty]
        public string Elzixmagicmin { get; set; } = "";
        
        [Name("ElzixMagicMax"), NameIndex(0), JsonProperty]
        public string Elzixmagicmax { get; set; } = "";
        
        [Name("ElzixMagicLvl"), NameIndex(0), JsonProperty]
        public string Elzixmagiclvl { get; set; } = "";
        
        [Name("AshearaMin"), NameIndex(0), JsonProperty]
        public string Ashearamin { get; set; } = "";
        
        [Name("AshearaMax"), NameIndex(0), JsonProperty]
        public string Ashearamax { get; set; } = "";
        
        [Name("AshearaMagicMin"), NameIndex(0), JsonProperty]
        public string Ashearamagicmin { get; set; } = "";
        
        [Name("AshearaMagicMax"), NameIndex(0), JsonProperty]
        public string Ashearamagicmax { get; set; } = "";
        
        [Name("AshearaMagicLvl"), NameIndex(0), JsonProperty]
        public string Ashearamagiclvl { get; set; } = "";
        
        [Name("CainMin"), NameIndex(0), JsonProperty]
        public string Cainmin { get; set; } = "";
        
        [Name("CainMax"), NameIndex(0), JsonProperty]
        public string Cainmax { get; set; } = "";
        
        [Name("CainMagicMin"), NameIndex(0), JsonProperty]
        public string Cainmagicmin { get; set; } = "";
        
        [Name("CainMagicMax"), NameIndex(0), JsonProperty]
        public string Cainmagicmax { get; set; } = "";
        
        [Name("CainMagicLvl"), NameIndex(0), JsonProperty]
        public string Cainmagiclvl { get; set; } = "";
        
        [Name("HalbuMin"), NameIndex(0), JsonProperty]
        public string Halbumin { get; set; } = "";
        
        [Name("HalbuMax"), NameIndex(0), JsonProperty]
        public string Halbumax { get; set; } = "";
        
        [Name("HalbuMagicMin"), NameIndex(0), JsonProperty]
        public string Halbumagicmin { get; set; } = "";
        
        [Name("HalbuMagicMax"), NameIndex(0), JsonProperty]
        public string Halbumagicmax { get; set; } = "";
        
        [Name("HalbuMagicLvl"), NameIndex(0), JsonProperty]
        public string Halbumagiclvl { get; set; } = "";
        
        [Name("MalahMin"), NameIndex(0), JsonProperty]
        public string Malahmin { get; set; } = "";
        
        [Name("MalahMax"), NameIndex(0), JsonProperty]
        public string Malahmax { get; set; } = "";
        
        [Name("MalahMagicMin"), NameIndex(0), JsonProperty]
        public string Malahmagicmin { get; set; } = "";
        
        [Name("MalahMagicMax"), NameIndex(0), JsonProperty]
        public string Malahmagicmax { get; set; } = "";
        
        [Name("MalahMagicLvl"), NameIndex(0), JsonProperty]
        public string Malahmagiclvl { get; set; } = "";
        
        [Name("LarzukMin"), NameIndex(0), JsonProperty]
        public string Larzukmin { get; set; } = "";
        
        [Name("LarzukMax"), NameIndex(0), JsonProperty]
        public string Larzukmax { get; set; } = "";
        
        [Name("LarzukMagicMin"), NameIndex(0), JsonProperty]
        public string Larzukmagicmin { get; set; } = "";
        
        [Name("LarzukMagicMax"), NameIndex(0), JsonProperty]
        public string Larzukmagicmax { get; set; } = "";
        
        [Name("LarzukMagicLvl"), NameIndex(0), JsonProperty]
        public string Larzukmagiclvl { get; set; } = "";
        
        [Name("DrehyaMin"), NameIndex(0), JsonProperty]
        public string Drehyamin { get; set; } = "";
        
        [Name("DrehyaMax"), NameIndex(0), JsonProperty]
        public string Drehyamax { get; set; } = "";
        
        [Name("DrehyaMagicMin"), NameIndex(0), JsonProperty]
        public string Drehyamagicmin { get; set; } = "";
        
        [Name("DrehyaMagicMax"), NameIndex(0), JsonProperty]
        public string Drehyamagicmax { get; set; } = "";
        
        [Name("DrehyaMagicLvl"), NameIndex(0), JsonProperty]
        public string Drehyamagiclvl { get; set; } = "";
        
        [Name("JamellaMin"), NameIndex(0), JsonProperty]
        public string Jamellamin { get; set; } = "";
        
        [Name("JamellaMax"), NameIndex(0), JsonProperty]
        public string Jamellamax { get; set; } = "";
        
        [Name("JamellaMagicMin"), NameIndex(0), JsonProperty]
        public string Jamellamagicmin { get; set; } = "";
        
        [Name("JamellaMagicMax"), NameIndex(0), JsonProperty]
        public string Jamellamagicmax { get; set; } = "";
        
        [Name("JamellaMagicLvl"), NameIndex(0), JsonProperty]
        public string Jamellamagiclvl { get; set; } = "";
        
        [Name("Source Art"), NameIndex(0), JsonProperty]
        public string SourceArt { get; set; } = "";
        
        [Name("Game Art"), NameIndex(0), JsonProperty]
        public string GameArt { get; set; } = "";
        
        [Name("Transform"), NameIndex(0), JsonProperty]
        public string Transform { get; set; } = "";
        
        [Name("InvTrans"), NameIndex(0), JsonProperty]
        public string Invtrans { get; set; } = "";
        
        [Name("SkipName"), NameIndex(0), JsonProperty]
        public string Skipname { get; set; } = "";
        
        [Name("NightmareUpgrade"), NameIndex(0), JsonProperty]
        public string Nightmareupgrade { get; set; } = "";
        
        [Name("HellUpgrade"), NameIndex(0), JsonProperty]
        public string Hellupgrade { get; set; } = "";
        
        [Name("mindam"), NameIndex(0), JsonProperty]
        public string Mindam { get; set; } = "";
        
        [Name("maxdam"), NameIndex(0), JsonProperty]
        public string Maxdam { get; set; } = "";
        
        [Name("PermStoreItem"), NameIndex(0), JsonProperty]
        public string Permstoreitem { get; set; } = "";
        
        [Name("multibuy"), NameIndex(0), JsonProperty]
        public string Multibuy { get; set; } = "";
        
        [Name("Nameable"), NameIndex(0), JsonProperty]
        public string Nameable { get; set; } = "";
        
        [Name("*eol"), NameIndex(0), JsonProperty]
        public string Eol { get; set; } = "";
        
    }
}
