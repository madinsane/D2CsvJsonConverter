using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using CsvHelper.Configuration.Attributes;

namespace D2CsvJsonConverter.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ObjectsModel
    {
        [Name("Name"), NameIndex(0), JsonProperty]
        public string Name { get; set; } = "";
        
        [Name("description - not loaded"), NameIndex(0), JsonProperty]
        public string DescriptionNotLoaded { get; set; } = "";
        
        [Name("Id"), NameIndex(0), JsonProperty]
        public string Id { get; set; } = "";
        
        [Name("Token"), NameIndex(0), JsonProperty]
        public string Token { get; set; } = "";
        
        [Name("SpawnMax"), NameIndex(0), JsonProperty]
        public string Spawnmax { get; set; } = "";
        
        [Name("Selectable0"), NameIndex(0), JsonProperty]
        public string Selectable0 { get; set; } = "";
        
        [Name("Selectable1"), NameIndex(0), JsonProperty]
        public string Selectable1 { get; set; } = "";
        
        [Name("Selectable2"), NameIndex(0), JsonProperty]
        public string Selectable2 { get; set; } = "";
        
        [Name("Selectable3"), NameIndex(0), JsonProperty]
        public string Selectable3 { get; set; } = "";
        
        [Name("Selectable4"), NameIndex(0), JsonProperty]
        public string Selectable4 { get; set; } = "";
        
        [Name("Selectable5"), NameIndex(0), JsonProperty]
        public string Selectable5 { get; set; } = "";
        
        [Name("Selectable6"), NameIndex(0), JsonProperty]
        public string Selectable6 { get; set; } = "";
        
        [Name("Selectable7"), NameIndex(0), JsonProperty]
        public string Selectable7 { get; set; } = "";
        
        [Name("TrapProb"), NameIndex(0), JsonProperty]
        public string Trapprob { get; set; } = "";
        
        [Name("SizeX"), NameIndex(0), JsonProperty]
        public string Sizex { get; set; } = "";
        
        [Name("SizeY"), NameIndex(0), JsonProperty]
        public string Sizey { get; set; } = "";
        
        [Name("nTgtFX"), NameIndex(0), JsonProperty]
        public string Ntgtfx { get; set; } = "";
        
        [Name("nTgtFY"), NameIndex(0), JsonProperty]
        public string Ntgtfy { get; set; } = "";
        
        [Name("nTgtBX"), NameIndex(0), JsonProperty]
        public string Ntgtbx { get; set; } = "";
        
        [Name("nTgtBY"), NameIndex(0), JsonProperty]
        public string Ntgtby { get; set; } = "";
        
        [Name("FrameCnt0"), NameIndex(0), JsonProperty]
        public string Framecnt0 { get; set; } = "";
        
        [Name("FrameCnt1"), NameIndex(0), JsonProperty]
        public string Framecnt1 { get; set; } = "";
        
        [Name("FrameCnt2"), NameIndex(0), JsonProperty]
        public string Framecnt2 { get; set; } = "";
        
        [Name("FrameCnt3"), NameIndex(0), JsonProperty]
        public string Framecnt3 { get; set; } = "";
        
        [Name("FrameCnt4"), NameIndex(0), JsonProperty]
        public string Framecnt4 { get; set; } = "";
        
        [Name("FrameCnt5"), NameIndex(0), JsonProperty]
        public string Framecnt5 { get; set; } = "";
        
        [Name("FrameCnt6"), NameIndex(0), JsonProperty]
        public string Framecnt6 { get; set; } = "";
        
        [Name("FrameCnt7"), NameIndex(0), JsonProperty]
        public string Framecnt7 { get; set; } = "";
        
        [Name("FrameDelta0"), NameIndex(0), JsonProperty]
        public string Framedelta0 { get; set; } = "";
        
        [Name("FrameDelta1"), NameIndex(0), JsonProperty]
        public string Framedelta1 { get; set; } = "";
        
        [Name("FrameDelta2"), NameIndex(0), JsonProperty]
        public string Framedelta2 { get; set; } = "";
        
        [Name("FrameDelta3"), NameIndex(0), JsonProperty]
        public string Framedelta3 { get; set; } = "";
        
        [Name("FrameDelta4"), NameIndex(0), JsonProperty]
        public string Framedelta4 { get; set; } = "";
        
        [Name("FrameDelta5"), NameIndex(0), JsonProperty]
        public string Framedelta5 { get; set; } = "";
        
        [Name("FrameDelta6"), NameIndex(0), JsonProperty]
        public string Framedelta6 { get; set; } = "";
        
        [Name("FrameDelta7"), NameIndex(0), JsonProperty]
        public string Framedelta7 { get; set; } = "";
        
        [Name("CycleAnim0"), NameIndex(0), JsonProperty]
        public string Cycleanim0 { get; set; } = "";
        
        [Name("CycleAnim1"), NameIndex(0), JsonProperty]
        public string Cycleanim1 { get; set; } = "";
        
        [Name("CycleAnim2"), NameIndex(0), JsonProperty]
        public string Cycleanim2 { get; set; } = "";
        
        [Name("CycleAnim3"), NameIndex(0), JsonProperty]
        public string Cycleanim3 { get; set; } = "";
        
        [Name("CycleAnim4"), NameIndex(0), JsonProperty]
        public string Cycleanim4 { get; set; } = "";
        
        [Name("CycleAnim5"), NameIndex(0), JsonProperty]
        public string Cycleanim5 { get; set; } = "";
        
        [Name("CycleAnim6"), NameIndex(0), JsonProperty]
        public string Cycleanim6 { get; set; } = "";
        
        [Name("CycleAnim7"), NameIndex(0), JsonProperty]
        public string Cycleanim7 { get; set; } = "";
        
        [Name("Lit0"), NameIndex(0), JsonProperty]
        public string Lit0 { get; set; } = "";
        
        [Name("Lit1"), NameIndex(0), JsonProperty]
        public string Lit1 { get; set; } = "";
        
        [Name("Lit2"), NameIndex(0), JsonProperty]
        public string Lit2 { get; set; } = "";
        
        [Name("Lit3"), NameIndex(0), JsonProperty]
        public string Lit3 { get; set; } = "";
        
        [Name("Lit4"), NameIndex(0), JsonProperty]
        public string Lit4 { get; set; } = "";
        
        [Name("Lit5"), NameIndex(0), JsonProperty]
        public string Lit5 { get; set; } = "";
        
        [Name("Lit6"), NameIndex(0), JsonProperty]
        public string Lit6 { get; set; } = "";
        
        [Name("Lit7"), NameIndex(0), JsonProperty]
        public string Lit7 { get; set; } = "";
        
        [Name("BlocksLight0"), NameIndex(0), JsonProperty]
        public string Blockslight0 { get; set; } = "";
        
        [Name("BlocksLight1"), NameIndex(0), JsonProperty]
        public string Blockslight1 { get; set; } = "";
        
        [Name("BlocksLight2"), NameIndex(0), JsonProperty]
        public string Blockslight2 { get; set; } = "";
        
        [Name("BlocksLight3"), NameIndex(0), JsonProperty]
        public string Blockslight3 { get; set; } = "";
        
        [Name("BlocksLight4"), NameIndex(0), JsonProperty]
        public string Blockslight4 { get; set; } = "";
        
        [Name("BlocksLight5"), NameIndex(0), JsonProperty]
        public string Blockslight5 { get; set; } = "";
        
        [Name("BlocksLight6"), NameIndex(0), JsonProperty]
        public string Blockslight6 { get; set; } = "";
        
        [Name("BlocksLight7"), NameIndex(0), JsonProperty]
        public string Blockslight7 { get; set; } = "";
        
        [Name("HasCollision0"), NameIndex(0), JsonProperty]
        public string Hascollision0 { get; set; } = "";
        
        [Name("HasCollision1"), NameIndex(0), JsonProperty]
        public string Hascollision1 { get; set; } = "";
        
        [Name("HasCollision2"), NameIndex(0), JsonProperty]
        public string Hascollision2 { get; set; } = "";
        
        [Name("HasCollision3"), NameIndex(0), JsonProperty]
        public string Hascollision3 { get; set; } = "";
        
        [Name("HasCollision4"), NameIndex(0), JsonProperty]
        public string Hascollision4 { get; set; } = "";
        
        [Name("HasCollision5"), NameIndex(0), JsonProperty]
        public string Hascollision5 { get; set; } = "";
        
        [Name("HasCollision6"), NameIndex(0), JsonProperty]
        public string Hascollision6 { get; set; } = "";
        
        [Name("HasCollision7"), NameIndex(0), JsonProperty]
        public string Hascollision7 { get; set; } = "";
        
        [Name("IsAttackable0"), NameIndex(0), JsonProperty]
        public string Isattackable0 { get; set; } = "";
        
        [Name("Start0"), NameIndex(0), JsonProperty]
        public string Start0 { get; set; } = "";
        
        [Name("Start1"), NameIndex(0), JsonProperty]
        public string Start1 { get; set; } = "";
        
        [Name("Start2"), NameIndex(0), JsonProperty]
        public string Start2 { get; set; } = "";
        
        [Name("Start3"), NameIndex(0), JsonProperty]
        public string Start3 { get; set; } = "";
        
        [Name("Start4"), NameIndex(0), JsonProperty]
        public string Start4 { get; set; } = "";
        
        [Name("Start5"), NameIndex(0), JsonProperty]
        public string Start5 { get; set; } = "";
        
        [Name("Start6"), NameIndex(0), JsonProperty]
        public string Start6 { get; set; } = "";
        
        [Name("Start7"), NameIndex(0), JsonProperty]
        public string Start7 { get; set; } = "";
        
        [Name("EnvEffect"), NameIndex(0), JsonProperty]
        public string Enveffect { get; set; } = "";
        
        [Name("IsDoor"), NameIndex(0), JsonProperty]
        public string Isdoor { get; set; } = "";
        
        [Name("BlocksVis"), NameIndex(0), JsonProperty]
        public string Blocksvis { get; set; } = "";
        
        [Name("Orientation"), NameIndex(0), JsonProperty]
        public string Orientation { get; set; } = "";
        
        [Name("Trans"), NameIndex(0), JsonProperty]
        public string Trans { get; set; } = "";
        
        [Name("OrderFlag0"), NameIndex(0), JsonProperty]
        public string Orderflag0 { get; set; } = "";
        
        [Name("OrderFlag1"), NameIndex(0), JsonProperty]
        public string Orderflag1 { get; set; } = "";
        
        [Name("OrderFlag2"), NameIndex(0), JsonProperty]
        public string Orderflag2 { get; set; } = "";
        
        [Name("OrderFlag3"), NameIndex(0), JsonProperty]
        public string Orderflag3 { get; set; } = "";
        
        [Name("OrderFlag4"), NameIndex(0), JsonProperty]
        public string Orderflag4 { get; set; } = "";
        
        [Name("OrderFlag5"), NameIndex(0), JsonProperty]
        public string Orderflag5 { get; set; } = "";
        
        [Name("OrderFlag6"), NameIndex(0), JsonProperty]
        public string Orderflag6 { get; set; } = "";
        
        [Name("OrderFlag7"), NameIndex(0), JsonProperty]
        public string Orderflag7 { get; set; } = "";
        
        [Name("PreOperate"), NameIndex(0), JsonProperty]
        public string Preoperate { get; set; } = "";
        
        [Name("Mode0"), NameIndex(0), JsonProperty]
        public string Mode0 { get; set; } = "";
        
        [Name("Mode1"), NameIndex(0), JsonProperty]
        public string Mode1 { get; set; } = "";
        
        [Name("Mode2"), NameIndex(0), JsonProperty]
        public string Mode2 { get; set; } = "";
        
        [Name("Mode3"), NameIndex(0), JsonProperty]
        public string Mode3 { get; set; } = "";
        
        [Name("Mode4"), NameIndex(0), JsonProperty]
        public string Mode4 { get; set; } = "";
        
        [Name("Mode5"), NameIndex(0), JsonProperty]
        public string Mode5 { get; set; } = "";
        
        [Name("Mode6"), NameIndex(0), JsonProperty]
        public string Mode6 { get; set; } = "";
        
        [Name("Mode7"), NameIndex(0), JsonProperty]
        public string Mode7 { get; set; } = "";
        
        [Name("Yoffset"), NameIndex(0), JsonProperty]
        public string Yoffset { get; set; } = "";
        
        [Name("Xoffset"), NameIndex(0), JsonProperty]
        public string Xoffset { get; set; } = "";
        
        [Name("Draw"), NameIndex(0), JsonProperty]
        public string Draw { get; set; } = "";
        
        [Name("Red"), NameIndex(0), JsonProperty]
        public string Red { get; set; } = "";
        
        [Name("Green"), NameIndex(0), JsonProperty]
        public string Green { get; set; } = "";
        
        [Name("Blue"), NameIndex(0), JsonProperty]
        public string Blue { get; set; } = "";
        
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
        
        [Name("SubClass"), NameIndex(0), JsonProperty]
        public string Subclass { get; set; } = "";
        
        [Name("Xspace"), NameIndex(0), JsonProperty]
        public string Xspace { get; set; } = "";
        
        [Name("Yspace"), NameIndex(0), JsonProperty]
        public string Yspace { get; set; } = "";
        
        [Name("NameOffset"), NameIndex(0), JsonProperty]
        public string Nameoffset { get; set; } = "";
        
        [Name("MonsterOK"), NameIndex(0), JsonProperty]
        public string Monsterok { get; set; } = "";
        
        [Name("OperateRange"), NameIndex(0), JsonProperty]
        public string Operaterange { get; set; } = "";
        
        [Name("ShrineFunction"), NameIndex(0), JsonProperty]
        public string Shrinefunction { get; set; } = "";
        
        [Name("Restore"), NameIndex(0), JsonProperty]
        public string Restore { get; set; } = "";
        
        [Name("Parm0"), NameIndex(0), JsonProperty]
        public string Parm0 { get; set; } = "";
        
        [Name("Parm1"), NameIndex(0), JsonProperty]
        public string Parm1 { get; set; } = "";
        
        [Name("Parm2"), NameIndex(0), JsonProperty]
        public string Parm2 { get; set; } = "";
        
        [Name("Parm3"), NameIndex(0), JsonProperty]
        public string Parm3 { get; set; } = "";
        
        [Name("Parm4"), NameIndex(0), JsonProperty]
        public string Parm4 { get; set; } = "";
        
        [Name("Parm5"), NameIndex(0), JsonProperty]
        public string Parm5 { get; set; } = "";
        
        [Name("Parm6"), NameIndex(0), JsonProperty]
        public string Parm6 { get; set; } = "";
        
        [Name("Parm7"), NameIndex(0), JsonProperty]
        public string Parm7 { get; set; } = "";
        
        [Name("Act"), NameIndex(0), JsonProperty]
        public string Act { get; set; } = "";
        
        [Name("Lockable"), NameIndex(0), JsonProperty]
        public string Lockable { get; set; } = "";
        
        [Name("Gore"), NameIndex(0), JsonProperty]
        public string Gore { get; set; } = "";
        
        [Name("Sync"), NameIndex(0), JsonProperty]
        public string Sync { get; set; } = "";
        
        [Name("Flicker"), NameIndex(0), JsonProperty]
        public string Flicker { get; set; } = "";
        
        [Name("Damage"), NameIndex(0), JsonProperty]
        public string Damage { get; set; } = "";
        
        [Name("Beta"), NameIndex(0), JsonProperty]
        public string Beta { get; set; } = "";
        
        [Name("Overlay"), NameIndex(0), JsonProperty]
        public string Overlay { get; set; } = "";
        
        [Name("CollisionSubst"), NameIndex(0), JsonProperty]
        public string Collisionsubst { get; set; } = "";
        
        [Name("Left"), NameIndex(0), JsonProperty]
        public string Left { get; set; } = "";
        
        [Name("Top"), NameIndex(0), JsonProperty]
        public string Top { get; set; } = "";
        
        [Name("Width"), NameIndex(0), JsonProperty]
        public string Width { get; set; } = "";
        
        [Name("Height"), NameIndex(0), JsonProperty]
        public string Height { get; set; } = "";
        
        [Name("OperateFn"), NameIndex(0), JsonProperty]
        public string Operatefn { get; set; } = "";
        
        [Name("PopulateFn"), NameIndex(0), JsonProperty]
        public string Populatefn { get; set; } = "";
        
        [Name("InitFn"), NameIndex(0), JsonProperty]
        public string Initfn { get; set; } = "";
        
        [Name("ClientFn"), NameIndex(0), JsonProperty]
        public string Clientfn { get; set; } = "";
        
        [Name("RestoreVirgins"), NameIndex(0), JsonProperty]
        public string Restorevirgins { get; set; } = "";
        
        [Name("BlockMissile"), NameIndex(0), JsonProperty]
        public string Blockmissile { get; set; } = "";
        
        [Name("DrawUnder"), NameIndex(0), JsonProperty]
        public string Drawunder { get; set; } = "";
        
        [Name("OpenWarp"), NameIndex(0), JsonProperty]
        public string Openwarp { get; set; } = "";
        
        [Name("AutoMap"), NameIndex(0), JsonProperty]
        public string Automap { get; set; } = "";
        
    }
}
