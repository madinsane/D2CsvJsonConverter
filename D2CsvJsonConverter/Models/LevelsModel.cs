using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class LevelsModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("Pal"), NameIndex(0), JsonProperty]
        public string Pal { get; set; } = "";
        
        [Name("Act"), NameIndex(0), JsonProperty]
        public string Act { get; set; } = "";
        
        [Name("QuestFlag"), NameIndex(0), JsonProperty]
        public string Questflag { get; set; } = "";
        
        [Name("QuestFlagEx"), NameIndex(0), JsonProperty]
        public string Questflagex { get; set; } = "";
        
        [Name("Layer"), NameIndex(0), JsonProperty]
        public string Layer { get; set; } = "";
        
        [Name("SizeX"), NameIndex(0), JsonProperty]
        public string Sizex { get; set; } = "";
        
        [Name("SizeY"), NameIndex(0), JsonProperty]
        public string Sizey { get; set; } = "";
        
        [Name("SizeX(N)"), NameIndex(0), JsonProperty]
        public string SizexN { get; set; } = "";
        
        [Name("SizeY(N)"), NameIndex(0), JsonProperty]
        public string SizeyN { get; set; } = "";
        
        [Name("SizeX(H)"), NameIndex(0), JsonProperty]
        public string SizexH { get; set; } = "";
        
        [Name("SizeY(H)"), NameIndex(0), JsonProperty]
        public string SizeyH { get; set; } = "";
        
        [Name("OffsetX"), NameIndex(0), JsonProperty]
        public string Offsetx { get; set; } = "";
        
        [Name("OffsetY"), NameIndex(0), JsonProperty]
        public string Offsety { get; set; } = "";
        
        [Name("Depend"), NameIndex(0), JsonProperty]
        public string Depend { get; set; } = "";
        
        [Name("Teleport"), NameIndex(0), JsonProperty]
        public string Teleport { get; set; } = "";
        
        [Name("Rain"), NameIndex(0), JsonProperty]
        public string Rain { get; set; } = "";
        
        [Name("Mud"), NameIndex(0), JsonProperty]
        public string Mud { get; set; } = "";
        
        [Name("NoPer"), NameIndex(0), JsonProperty]
        public string Noper { get; set; } = "";
        
        [Name("LOSDraw"), NameIndex(0), JsonProperty]
        public string Losdraw { get; set; } = "";
        
        [Name("FloorFilter"), NameIndex(0), JsonProperty]
        public string Floorfilter { get; set; } = "";
        
        [Name("BlankScreen"), NameIndex(0), JsonProperty]
        public string Blankscreen { get; set; } = "";
        
        [Name("DrawEdges"), NameIndex(0), JsonProperty]
        public string Drawedges { get; set; } = "";
        
        [Name("IsInside"), NameIndex(0), JsonProperty]
        public string Isinside { get; set; } = "";
        
        [Name("DrlgType"), NameIndex(0), JsonProperty]
        public string Drlgtype { get; set; } = "";
        
        [Name("LevelType"), NameIndex(0), JsonProperty]
        public string Leveltype { get; set; } = "";
        
        [Name("SubType"), NameIndex(0), JsonProperty]
        public string Subtype { get; set; } = "";
        
        [Name("SubTheme"), NameIndex(0), JsonProperty]
        public string Subtheme { get; set; } = "";
        
        [Name("SubWaypoint"), NameIndex(0), JsonProperty]
        public string Subwaypoint { get; set; } = "";
        
        [Name("SubShrine"), NameIndex(0), JsonProperty]
        public string Subshrine { get; set; } = "";
        
        [Name("Vis0"), NameIndex(0), JsonProperty]
        public string Vis0 { get; set; } = "";
        
        [Name("Vis1"), NameIndex(0), JsonProperty]
        public string Vis1 { get; set; } = "";
        
        [Name("Vis2"), NameIndex(0), JsonProperty]
        public string Vis2 { get; set; } = "";
        
        [Name("Vis3"), NameIndex(0), JsonProperty]
        public string Vis3 { get; set; } = "";
        
        [Name("Vis4"), NameIndex(0), JsonProperty]
        public string Vis4 { get; set; } = "";
        
        [Name("Vis5"), NameIndex(0), JsonProperty]
        public string Vis5 { get; set; } = "";
        
        [Name("Vis6"), NameIndex(0), JsonProperty]
        public string Vis6 { get; set; } = "";
        
        [Name("Vis7"), NameIndex(0), JsonProperty]
        public string Vis7 { get; set; } = "";
        
        [Name("Warp0"), NameIndex(0), JsonProperty]
        public string Warp0 { get; set; } = "";
        
        [Name("Warp1"), NameIndex(0), JsonProperty]
        public string Warp1 { get; set; } = "";
        
        [Name("Warp2"), NameIndex(0), JsonProperty]
        public string Warp2 { get; set; } = "";
        
        [Name("Warp3"), NameIndex(0), JsonProperty]
        public string Warp3 { get; set; } = "";
        
        [Name("Warp4"), NameIndex(0), JsonProperty]
        public string Warp4 { get; set; } = "";
        
        [Name("Warp5"), NameIndex(0), JsonProperty]
        public string Warp5 { get; set; } = "";
        
        [Name("Warp6"), NameIndex(0), JsonProperty]
        public string Warp6 { get; set; } = "";
        
        [Name("Warp7"), NameIndex(0), JsonProperty]
        public string Warp7 { get; set; } = "";
        
        [Name("Intensity"), NameIndex(0), JsonProperty]
        public string Intensity { get; set; } = "";
        
        [Name("Red"), NameIndex(0), JsonProperty]
        public string Red { get; set; } = "";
        
        [Name("Green"), NameIndex(0), JsonProperty]
        public string Green { get; set; } = "";
        
        [Name("Blue"), NameIndex(0), JsonProperty]
        public string Blue { get; set; } = "";
        
        [Name("Portal"), NameIndex(0), JsonProperty]
        public string Portal { get; set; } = "";
        
        [Name("Position"), NameIndex(0), JsonProperty]
        public string Position { get; set; } = "";
        
        [Name("SaveMonsters"), NameIndex(0), JsonProperty]
        public string Savemonsters { get; set; } = "";
        
        [Name("Quest"), NameIndex(0), JsonProperty]
        public string Quest { get; set; } = "";
        
        [Name("WarpDist"), NameIndex(0), JsonProperty]
        public string Warpdist { get; set; } = "";
        
        [Name("MonLvl1"), NameIndex(0), JsonProperty]
        public string Monlvl1 { get; set; } = "";
        
        [Name("MonLvl2"), NameIndex(0), JsonProperty]
        public string Monlvl2 { get; set; } = "";
        
        [Name("MonLvl3"), NameIndex(0), JsonProperty]
        public string Monlvl3 { get; set; } = "";
        
        [Name("MonLvl1Ex"), NameIndex(0), JsonProperty]
        public string Monlvl1ex { get; set; } = "";
        
        [Name("MonLvl2Ex"), NameIndex(0), JsonProperty]
        public string Monlvl2ex { get; set; } = "";
        
        [Name("MonLvl3Ex"), NameIndex(0), JsonProperty]
        public string Monlvl3ex { get; set; } = "";
        
        [Name("MonDen"), NameIndex(0), JsonProperty]
        public string Monden { get; set; } = "";
        
        [Name("MonDen(N)"), NameIndex(0), JsonProperty]
        public string MondenN { get; set; } = "";
        
        [Name("MonDen(H)"), NameIndex(0), JsonProperty]
        public string MondenH { get; set; } = "";
        
        [Name("MonUMin"), NameIndex(0), JsonProperty]
        public string Monumin { get; set; } = "";
        
        [Name("MonUMax"), NameIndex(0), JsonProperty]
        public string Monumax { get; set; } = "";
        
        [Name("MonUMin(N)"), NameIndex(0), JsonProperty]
        public string MonuminN { get; set; } = "";
        
        [Name("MonUMax(N)"), NameIndex(0), JsonProperty]
        public string MonumaxN { get; set; } = "";
        
        [Name("MonUMin(H)"), NameIndex(0), JsonProperty]
        public string MonuminH { get; set; } = "";
        
        [Name("MonUMax(H)"), NameIndex(0), JsonProperty]
        public string MonumaxH { get; set; } = "";
        
        [Name("MonWndr"), NameIndex(0), JsonProperty]
        public string Monwndr { get; set; } = "";
        
        [Name("MonSpcWalk"), NameIndex(0), JsonProperty]
        public string Monspcwalk { get; set; } = "";
        
        [Name("NumMon"), NameIndex(0), JsonProperty]
        public string Nummon { get; set; } = "";
        
        [Name("mon1"), NameIndex(0), JsonProperty]
        public string Mon1 { get; set; } = "";
        
        [Name("mon2"), NameIndex(0), JsonProperty]
        public string Mon2 { get; set; } = "";
        
        [Name("mon3"), NameIndex(0), JsonProperty]
        public string Mon3 { get; set; } = "";
        
        [Name("mon4"), NameIndex(0), JsonProperty]
        public string Mon4 { get; set; } = "";
        
        [Name("mon5"), NameIndex(0), JsonProperty]
        public string Mon5 { get; set; } = "";
        
        [Name("mon6"), NameIndex(0), JsonProperty]
        public string Mon6 { get; set; } = "";
        
        [Name("mon7"), NameIndex(0), JsonProperty]
        public string Mon7 { get; set; } = "";
        
        [Name("mon8"), NameIndex(0), JsonProperty]
        public string Mon8 { get; set; } = "";
        
        [Name("mon9"), NameIndex(0), JsonProperty]
        public string Mon9 { get; set; } = "";
        
        [Name("mon10"), NameIndex(0), JsonProperty]
        public string Mon10 { get; set; } = "";
        
        [Name("mon11"), NameIndex(0), JsonProperty]
        public string Mon11 { get; set; } = "";
        
        [Name("mon12"), NameIndex(0), JsonProperty]
        public string Mon12 { get; set; } = "";
        
        [Name("mon13"), NameIndex(0), JsonProperty]
        public string Mon13 { get; set; } = "";
        
        [Name("mon14"), NameIndex(0), JsonProperty]
        public string Mon14 { get; set; } = "";
        
        [Name("mon15"), NameIndex(0), JsonProperty]
        public string Mon15 { get; set; } = "";
        
        [Name("mon16"), NameIndex(0), JsonProperty]
        public string Mon16 { get; set; } = "";
        
        [Name("mon17"), NameIndex(0), JsonProperty]
        public string Mon17 { get; set; } = "";
        
        [Name("mon18"), NameIndex(0), JsonProperty]
        public string Mon18 { get; set; } = "";
        
        [Name("mon19"), NameIndex(0), JsonProperty]
        public string Mon19 { get; set; } = "";
        
        [Name("mon20"), NameIndex(0), JsonProperty]
        public string Mon20 { get; set; } = "";
        
        [Name("mon21"), NameIndex(0), JsonProperty]
        public string Mon21 { get; set; } = "";
        
        [Name("mon22"), NameIndex(0), JsonProperty]
        public string Mon22 { get; set; } = "";
        
        [Name("mon23"), NameIndex(0), JsonProperty]
        public string Mon23 { get; set; } = "";
        
        [Name("mon24"), NameIndex(0), JsonProperty]
        public string Mon24 { get; set; } = "";
        
        [Name("mon25"), NameIndex(0), JsonProperty]
        public string Mon25 { get; set; } = "";
        
        [Name("rangedspawn"), NameIndex(0), JsonProperty]
        public string Rangedspawn { get; set; } = "";
        
        [Name("nmon1"), NameIndex(0), JsonProperty]
        public string Nmon1 { get; set; } = "";
        
        [Name("nmon2"), NameIndex(0), JsonProperty]
        public string Nmon2 { get; set; } = "";
        
        [Name("nmon3"), NameIndex(0), JsonProperty]
        public string Nmon3 { get; set; } = "";
        
        [Name("nmon4"), NameIndex(0), JsonProperty]
        public string Nmon4 { get; set; } = "";
        
        [Name("nmon5"), NameIndex(0), JsonProperty]
        public string Nmon5 { get; set; } = "";
        
        [Name("nmon6"), NameIndex(0), JsonProperty]
        public string Nmon6 { get; set; } = "";
        
        [Name("nmon7"), NameIndex(0), JsonProperty]
        public string Nmon7 { get; set; } = "";
        
        [Name("nmon8"), NameIndex(0), JsonProperty]
        public string Nmon8 { get; set; } = "";
        
        [Name("nmon9"), NameIndex(0), JsonProperty]
        public string Nmon9 { get; set; } = "";
        
        [Name("nmon10"), NameIndex(0), JsonProperty]
        public string Nmon10 { get; set; } = "";
        
        [Name("nmon11"), NameIndex(0), JsonProperty]
        public string Nmon11 { get; set; } = "";
        
        [Name("nmon12"), NameIndex(0), JsonProperty]
        public string Nmon12 { get; set; } = "";
        
        [Name("nmon13"), NameIndex(0), JsonProperty]
        public string Nmon13 { get; set; } = "";
        
        [Name("nmon14"), NameIndex(0), JsonProperty]
        public string Nmon14 { get; set; } = "";
        
        [Name("nmon15"), NameIndex(0), JsonProperty]
        public string Nmon15 { get; set; } = "";
        
        [Name("nmon16"), NameIndex(0), JsonProperty]
        public string Nmon16 { get; set; } = "";
        
        [Name("nmon17"), NameIndex(0), JsonProperty]
        public string Nmon17 { get; set; } = "";
        
        [Name("nmon18"), NameIndex(0), JsonProperty]
        public string Nmon18 { get; set; } = "";
        
        [Name("nmon19"), NameIndex(0), JsonProperty]
        public string Nmon19 { get; set; } = "";
        
        [Name("nmon20"), NameIndex(0), JsonProperty]
        public string Nmon20 { get; set; } = "";
        
        [Name("nmon21"), NameIndex(0), JsonProperty]
        public string Nmon21 { get; set; } = "";
        
        [Name("nmon22"), NameIndex(0), JsonProperty]
        public string Nmon22 { get; set; } = "";
        
        [Name("nmon23"), NameIndex(0), JsonProperty]
        public string Nmon23 { get; set; } = "";
        
        [Name("nmon24"), NameIndex(0), JsonProperty]
        public string Nmon24 { get; set; } = "";
        
        [Name("nmon25"), NameIndex(0), JsonProperty]
        public string Nmon25 { get; set; } = "";
        
        [Name("umon1"), NameIndex(0), JsonProperty]
        public string Umon1 { get; set; } = "";
        
        [Name("umon2"), NameIndex(0), JsonProperty]
        public string Umon2 { get; set; } = "";
        
        [Name("umon3"), NameIndex(0), JsonProperty]
        public string Umon3 { get; set; } = "";
        
        [Name("umon4"), NameIndex(0), JsonProperty]
        public string Umon4 { get; set; } = "";
        
        [Name("umon5"), NameIndex(0), JsonProperty]
        public string Umon5 { get; set; } = "";
        
        [Name("umon6"), NameIndex(0), JsonProperty]
        public string Umon6 { get; set; } = "";
        
        [Name("umon7"), NameIndex(0), JsonProperty]
        public string Umon7 { get; set; } = "";
        
        [Name("umon8"), NameIndex(0), JsonProperty]
        public string Umon8 { get; set; } = "";
        
        [Name("umon9"), NameIndex(0), JsonProperty]
        public string Umon9 { get; set; } = "";
        
        [Name("umon10"), NameIndex(0), JsonProperty]
        public string Umon10 { get; set; } = "";
        
        [Name("umon11"), NameIndex(0), JsonProperty]
        public string Umon11 { get; set; } = "";
        
        [Name("umon12"), NameIndex(0), JsonProperty]
        public string Umon12 { get; set; } = "";
        
        [Name("umon13"), NameIndex(0), JsonProperty]
        public string Umon13 { get; set; } = "";
        
        [Name("umon14"), NameIndex(0), JsonProperty]
        public string Umon14 { get; set; } = "";
        
        [Name("umon15"), NameIndex(0), JsonProperty]
        public string Umon15 { get; set; } = "";
        
        [Name("umon16"), NameIndex(0), JsonProperty]
        public string Umon16 { get; set; } = "";
        
        [Name("umon17"), NameIndex(0), JsonProperty]
        public string Umon17 { get; set; } = "";
        
        [Name("umon18"), NameIndex(0), JsonProperty]
        public string Umon18 { get; set; } = "";
        
        [Name("umon19"), NameIndex(0), JsonProperty]
        public string Umon19 { get; set; } = "";
        
        [Name("umon20"), NameIndex(0), JsonProperty]
        public string Umon20 { get; set; } = "";
        
        [Name("umon21"), NameIndex(0), JsonProperty]
        public string Umon21 { get; set; } = "";
        
        [Name("umon22"), NameIndex(0), JsonProperty]
        public string Umon22 { get; set; } = "";
        
        [Name("umon23"), NameIndex(0), JsonProperty]
        public string Umon23 { get; set; } = "";
        
        [Name("umon24"), NameIndex(0), JsonProperty]
        public string Umon24 { get; set; } = "";
        
        [Name("umon25"), NameIndex(0), JsonProperty]
        public string Umon25 { get; set; } = "";
        
        [Name("cmon1"), NameIndex(0), JsonProperty]
        public string Cmon1 { get; set; } = "";
        
        [Name("cmon2"), NameIndex(0), JsonProperty]
        public string Cmon2 { get; set; } = "";
        
        [Name("cmon3"), NameIndex(0), JsonProperty]
        public string Cmon3 { get; set; } = "";
        
        [Name("cmon4"), NameIndex(0), JsonProperty]
        public string Cmon4 { get; set; } = "";
        
        [Name("cpct1"), NameIndex(0), JsonProperty]
        public string Cpct1 { get; set; } = "";
        
        [Name("cpct2"), NameIndex(0), JsonProperty]
        public string Cpct2 { get; set; } = "";
        
        [Name("cpct3"), NameIndex(0), JsonProperty]
        public string Cpct3 { get; set; } = "";
        
        [Name("cpct4"), NameIndex(0), JsonProperty]
        public string Cpct4 { get; set; } = "";
        
        [Name("camt1"), NameIndex(0), JsonProperty]
        public string Camt1 { get; set; } = "";
        
        [Name("camt2"), NameIndex(0), JsonProperty]
        public string Camt2 { get; set; } = "";
        
        [Name("camt3"), NameIndex(0), JsonProperty]
        public string Camt3 { get; set; } = "";
        
        [Name("camt4"), NameIndex(0), JsonProperty]
        public string Camt4 { get; set; } = "";
        
        [Name("Themes"), NameIndex(0), JsonProperty]
        public string Themes { get; set; } = "";
        
        [Name("SoundEnv"), NameIndex(0), JsonProperty]
        public string Soundenv { get; set; } = "";
        
        [Name("Waypoint"), NameIndex(0), JsonProperty]
        public string Waypoint { get; set; } = "";
        
        [Name("LevelName"), NameIndex(0), JsonProperty]
        public string Levelname { get; set; } = "";
        
        [Name("LevelWarp"), NameIndex(0), JsonProperty]
        public string Levelwarp { get; set; } = "";
        
        [Name("EntryFile"), NameIndex(0), JsonProperty]
        public string Entryfile { get; set; } = "";
        
        [Name("ObjGrp0"), NameIndex(0), JsonProperty]
        public string Objgrp0 { get; set; } = "";
        
        [Name("ObjGrp1"), NameIndex(0), JsonProperty]
        public string Objgrp1 { get; set; } = "";
        
        [Name("ObjGrp2"), NameIndex(0), JsonProperty]
        public string Objgrp2 { get; set; } = "";
        
        [Name("ObjGrp3"), NameIndex(0), JsonProperty]
        public string Objgrp3 { get; set; } = "";
        
        [Name("ObjGrp4"), NameIndex(0), JsonProperty]
        public string Objgrp4 { get; set; } = "";
        
        [Name("ObjGrp5"), NameIndex(0), JsonProperty]
        public string Objgrp5 { get; set; } = "";
        
        [Name("ObjGrp6"), NameIndex(0), JsonProperty]
        public string Objgrp6 { get; set; } = "";
        
        [Name("ObjGrp7"), NameIndex(0), JsonProperty]
        public string Objgrp7 { get; set; } = "";
        
        [Name("ObjPrb0"), NameIndex(0), JsonProperty]
        public string Objprb0 { get; set; } = "";
        
        [Name("ObjPrb1"), NameIndex(0), JsonProperty]
        public string Objprb1 { get; set; } = "";
        
        [Name("ObjPrb2"), NameIndex(0), JsonProperty]
        public string Objprb2 { get; set; } = "";
        
        [Name("ObjPrb3"), NameIndex(0), JsonProperty]
        public string Objprb3 { get; set; } = "";
        
        [Name("ObjPrb4"), NameIndex(0), JsonProperty]
        public string Objprb4 { get; set; } = "";
        
        [Name("ObjPrb5"), NameIndex(0), JsonProperty]
        public string Objprb5 { get; set; } = "";
        
        [Name("ObjPrb6"), NameIndex(0), JsonProperty]
        public string Objprb6 { get; set; } = "";
        
        [Name("ObjPrb7"), NameIndex(0), JsonProperty]
        public string Objprb7 { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
    }
}
