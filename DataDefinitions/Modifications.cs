﻿namespace EddiDataDefinitions
{
    /// <summary>
    /// Modification types
    /// </summary>
    public class Modifications : ResourceBasedLocalizedEDName<Modifications>
    {
        static Modifications()
        {
            resourceManager = Properties.Modifications.ResourceManager;
            resourceManager.IgnoreCase = true;

            None = new Modifications("None");
            var AFMShielded = new Modifications("AFM_Shielded");
            var ArmourAdvanced = new Modifications("Armour_Advanced");
            var ArmourExplosive = new Modifications("Armour_Explosive");
            var ArmourHeavyDuty = new Modifications("Armour_HeavyDuty");
            var ArmourKinetic = new Modifications("Armour_Kinetic");
            var ArmourThermic = new Modifications("Armour_Thermic");
            var CargoScannerFast = new Modifications("CargoScanner_Fast");
            var CargoScannerLightWeight = new Modifications("CargoScanner_LightWeight");
            var CargoScannerLongRange = new Modifications("CargoScanner_LongRange");
            var CargoScannerReinforced = new Modifications("CargoScanner_Reinforced");
            var CargoScannerShielded = new Modifications("CargoScanner_Shielded");
            var CargoScannerWideAngle = new Modifications("CargoScanner_WideAngle");
            var ChaffLauncherCapacity = new Modifications("ChaffLauncher_Capacity");
            var ChaffLauncherLightWeight = new Modifications("ChaffLauncher_LightWeight");
            var ChaffLauncherReinforced = new Modifications("ChaffLauncher_Reinforced");
            var ChaffLauncherShielded = new Modifications("ChaffLauncher_Shielded");
            var CollectionLimpetLightWeight = new Modifications("CollectionLimpet_LightWeight");
            var CollectionLimpetReinforced = new Modifications("CollectionLimpet_Reinforced");
            var CollectionLimpetShielded = new Modifications("CollectionLimpet_Shielded");
            var ECMShielded = new Modifications("ECM_Shielded");
            var EngineDirty = new Modifications("Engine_Dirty");
            var EngineReinforced = new Modifications("Engine_Reinforced");
            var EngineTuned = new Modifications("Engine_Tuned");
            var FSDFastBoot = new Modifications("FSD_FastBoot");
            var FSDinterdictorExpanded = new Modifications("FSDinterdictor_Expanded");
            var FSDinterdictorLongRange = new Modifications("FSDinterdictor_LongRange");
            var FSDLongRange = new Modifications("FSD_LongRange");
            var FSDShielded = new Modifications("FSD_Shielded");
            var FuelScoopShielded = new Modifications("FuelScoop_Shielded");
            var FuelTransferLimpetLightWeight = new Modifications("FuelTransferLimpet_LightWeight");
            var FuelTransferLimpetReinforced = new Modifications("FuelTransferLimpet_Reinforced");
            var FuelTransferLimpetShielded = new Modifications("FuelTransferLimpet_Shielded");
            var HatchBreakerLimpetLightWeight = new Modifications("HatchBreakerLimpet_LightWeight");
            var HatchBreakerLimpetReinforced = new Modifications("HatchBreakerLimpet_Reinforced");
            var HatchBreakerLimpetShielded = new Modifications("HatchBreakerLimpet_Shielded");
            var HeatsinkLauncherCapacity = new Modifications("HeatsinkLauncher_Capacity");
            var HeatsinkLauncherLightWeight = new Modifications("HeatsinkLauncher_LightWeight");
            var HeatsinkLauncherReinforced = new Modifications("HeatsinkLauncher_Reinforced");
            var HeatsinkLauncherShielded = new Modifications("HeatsinkLauncher_Shielded");
            var HullReinforcementAdvanced = new Modifications("HullReinforcement_Advanced");
            var HullReinforcementExplosive = new Modifications("HullReinforcement_Explosive");
            var HullReinforcementHeavyDuty = new Modifications("HullReinforcement_HeavyDuty");
            var HullReinforcementKinetic = new Modifications("HullReinforcement_Kinetic");
            var HullReinforcementThermic = new Modifications("HullReinforcement_Thermic");
            var KillWarrantScannerFast = new Modifications("KillWarrantScanner_Fast");
            var KillWarrantScannerLightWeight = new Modifications("KillWarrantScanner_LightWeight");
            var KillWarrantScannerLongRange = new Modifications("KillWarrantScanner_LongRange");
            var KillWarrantScannerReinforced = new Modifications("KillWarrantScanner_Reinforced");
            var KillWarrantScannerShielded = new Modifications("KillWarrantScanner_Shielded");
            var KillWarrantScannerWideAngle = new Modifications("KillWarrantScanner_WideAngle");
            var LifeSupportLightWeight = new Modifications("LifeSupport_LightWeight");
            var LifeSupportReinforced = new Modifications("LifeSupport_Reinforced");
            var LifeSupportShielded = new Modifications("LifeSupport_Shielded");
            var MiscLightWeight = new Modifications("Misc_LightWeight");
            var MiscReinforced = new Modifications("Misc_Reinforced");
            var MiscShielded = new Modifications("Misc_Shielded");
            var PointDefenseCapacity = new Modifications("PointDefense_Capacity");
            var PointDefenseLightWeight = new Modifications("PointDefense_LightWeight");
            var PointDefenseReinforced = new Modifications("PointDefense_Reinforced");
            var PointDefenseShielded = new Modifications("PointDefense_Shielded");
            var PowerDistributorHighCapacity = new Modifications("PowerDistributor_HighCapacity");
            var PowerDistributorHighFrequency = new Modifications("PowerDistributor_HighFrequency");
            var PowerDistributorPriorityEngines = new Modifications("PowerDistributor_PriorityEngines");
            var PowerDistributorPrioritySystems = new Modifications("PowerDistributor_PrioritySystems");
            var PowerDistributorPriorityWeapons = new Modifications("PowerDistributor_PriorityWeapons");
            var PowerDistributorShielded = new Modifications("PowerDistributor_Shielded");
            var PowerPlantArmoured = new Modifications("PowerPlant_Armoured");
            var PowerPlantBoosted = new Modifications("PowerPlant_Boosted");
            var PowerPlantStealth = new Modifications("PowerPlant_Stealth");
            var RefineriesShielded = new Modifications("Refineries_Shielded");
            var SensorLightWeight = new Modifications("Sensor_Sensor_LightWeight");
            var SensorLongRange = new Modifications("Sensor_Sensor_LongRange");
            var SensorWideAngle = new Modifications("Sensor_Sensor_WideAngle");
            var ShieldBoosterExplosive = new Modifications("ShieldBooster_Explosive");
            var ShieldBoosterHeavyDuty = new Modifications("ShieldBooster_HeavyDuty");
            var ShieldBoosterKinetic = new Modifications("ShieldBooster_Kinetic");
            var ShieldBoosterResistive = new Modifications("ShieldBooster_Resistive");
            var ShieldBoosterThermic = new Modifications("ShieldBooster_Thermic");
            var ShieldCellBankRapid = new Modifications("ShieldCellBank_Rapid");
            var ShieldCellBankSpecialised = new Modifications("ShieldCellBank_Specialised");
            var ShieldGeneratorKinetic = new Modifications("ShieldGenerator_Kinetic");
            var ShieldGeneratorOptimised = new Modifications("ShieldGenerator_Optimised");
            var ShieldGeneratorReinforced = new Modifications("ShieldGenerator_Reinforced");
            var ShieldGeneratorThermic = new Modifications("ShieldGenerator_Thermic");
            var SurfaceScannerExpanded = new Modifications("SurfaceScanner_Expanded");
            var WakeScannerFastScan = new Modifications("Sensor_WakeScanner_FastScan");
            var WakeScannerLightWeight = new Modifications("Sensor_WakeScanner_LightWeight");
            var WakeScannerLongRange = new Modifications("Sensor_WakeScanner_LongRange");
            var WakeScannerReinforced = new Modifications("Sensor_WakeScanner_Reinforced");
            var WakeScannerShielded = new Modifications("Sensor_WakeScanner_Shielded");
            var WakeScannerWideAngle = new Modifications("Sensor_WakeScanner_WideAngle");
            var WeaponDoubleShot = new Modifications("Weapon_DoubleShot");
            var WeaponEfficient = new Modifications("Weapon_Efficient");
            var WeaponFocused = new Modifications("Weapon_Focused");
            var WeaponHighCapacity = new Modifications("Weapon_HighCapacity");
            var WeaponLightWeight = new Modifications("Weapon_LightWeight");
            var WeaponLongRange = new Modifications("Weapon_LongRange");
            var WeaponOvercharged = new Modifications("Weapon_Overcharged");
            var WeaponRapidFire = new Modifications("Weapon_RapidFire");
            var WeaponShortRange = new Modifications("Weapon_ShortRange");
            var WeaponSturdy = new Modifications("Weapon_Sturdy");
        }

        public static readonly Modifications None;

        // dummy used to ensure that the static constructor has run
        public Modifications() : this("")
        { }

        private Modifications(string edname) : base(edname, edname.Replace("_", ""))
        { }
    }
}