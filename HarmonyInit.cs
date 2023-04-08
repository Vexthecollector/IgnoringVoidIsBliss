using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using DIgnoranceIsBliss;
using DIgnoranceIsBliss.Core_Patches;
using RimWorld;

namespace IgnoringVoidIsBliss
{
    [StaticConstructorOnStartup]
    public class HarmonyInit

    {
        static HarmonyInit()
        {



            IgnoranceBase.incidentDefNames.Add("VOID_N4Event", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_DroneEvent", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_RedDevil_NegativeEvent", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_NegativeEvent", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_Black_NegativeEvent", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_VolatileLeaper_ShipPartCrash", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_BlackTitan_ShipPartCrash", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_DevilHound_ShipPartCrash", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("Void_Stalker", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_N4Manhunter_RedZone", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_N4Manhunter_DeathRow", TechLevel.Ultra);
            IgnoranceBase.incidentDefNames.Add("VOID_DefoliatorShipPartCrash", TechLevel.Ultra);
        }

    }
}
