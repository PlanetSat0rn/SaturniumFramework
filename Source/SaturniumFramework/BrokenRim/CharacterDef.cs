using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace SaturniumFramework
{
    [StaticConstructorOnStartup]
    public class CharacterDef : Def
    {
        public Gender Gender;
        public string PawnKind;
        public Color HairColor;
        public HairDef Hair;
        public int Age = 18;
        public int SleepAge = 18;
        public string FirstName = "";
        public string LastName = "";
        public string NickName = "";
        public ThingDef Weapon;
        public ThingDef Weapon_Stuff = null;
        public Dictionary<string, Dictionary<Color, string>> Apparel;
        public BackstoryDef ChildStory;
        public BackstoryDef AdultStory;
        public Dictionary<SkillDef, int> WorkSkillLevel;
        public Dictionary<SkillDef, Passion> WorkSkillPassion;
        public HeadTypeDef Fix_Type;
        public BodyTypeDef bodyType;
        public FactionDef Faction;
        public Dictionary<TraitDef, int> Trait;
        public Dictionary<string, Color> BodyColor;
        public XenotypeDef Xenotype;
        public Dictionary<HediffDef, string> Hediff;
        public Dictionary<string, string> Relation;
    }
}
