﻿using BattleTech;
using MechEngineer.Features.AccuracyEffects;
using MechEngineer.Features.ArmActuators;
using MechEngineer.Features.ArmorStructureChanges;
using MechEngineer.Features.ArmorStructureRatio;
using MechEngineer.Features.AutoFix;
using MechEngineer.Features.ComponentExplosions;
using MechEngineer.Features.CompressFloatieMessages;
using MechEngineer.Features.CriticalEffects;
using MechEngineer.Features.DamageIgnore;
using MechEngineer.Features.DebugCycleCombatSounds;
using MechEngineer.Features.DebugSaveMechToFile;
using MechEngineer.Features.DebugScreenshotMechs;
using MechEngineer.Features.DynamicSlots;
using MechEngineer.Features.Engines;
using MechEngineer.Features.Globals;
using MechEngineer.Features.HardpointFix;
using MechEngineer.Features.InvalidInventory;
using MechEngineer.Features.LocationalEffects;
using MechEngineer.Features.MechLabSlots;
using MechEngineer.Features.MoveMultiplierStat;
using MechEngineer.Features.NewSaveFolder;
using MechEngineer.Features.OverrideDescriptions;
using MechEngineer.Features.OverrideGhostVFX;
using MechEngineer.Features.OverrideTonnage;
using MechEngineer.Features.ShutdownInjuryProtection;
using MechEngineer.Features.TagManager;
using MechEngineer.Features.TurretLimitedAmmo;
using MechEngineer.Features.TurretMechComponents;

namespace MechEngineer
{
    public class AddHelper
    {
        public string ComponentDefId { get; set; }
        public ChassisLocations ChassisLocation { get; set; }
        public ComponentType ComponentType { get; set; }
    }

    internal class MechEngineerSettings
    {
        public AccuracyEffectsSettings AccuracyEffects = new AccuracyEffectsSettings();
        public ArmActuatorSettings ArmActuator = new ArmActuatorSettings();
        public ArmorStructureChangesSettings ArmorStructureChanges = new ArmorStructureChangesSettings();
        public ArmorStructureRatioSettings ArmorStructureRatio = new ArmorStructureRatioSettings();
        public AutoFixerSettings AutoFixer = new AutoFixerSettings();
        public ComponentExplosionsSettings ComponentExplosions = new ComponentExplosionsSettings();
        public CompressFloatieMessagesSettings CompressFloatieMessages = new CompressFloatieMessagesSettings();
        public CriticalEffectsSettings CriticalEffects = new CriticalEffectsSettings();
        public DamageIgnoreSettings DamageIgnore = new DamageIgnoreSettings();
        public DynamicSlotsSettings DynamicSlots = new DynamicSlotsSettings();
        public EngineSettings Engine = new EngineSettings();
        public GlobalsSettings Globals = new GlobalsSettings();
        public HardpointFixSettings HardpointFix = new HardpointFixSettings();
        public InvalidInventorySettings InvalidInventory = new InvalidInventorySettings();
        public LocationalEffectsSettings LocationalEffects = new LocationalEffectsSettings();
        public MechLabSlotsSettings MechLabSlots = new MechLabSlotsSettings();
        public MoveMultiplierStatSettings MoveMultiplierStat = new MoveMultiplierStatSettings();
        public NewSaveFolderSettings NewSaveFolder = new NewSaveFolderSettings();
        public OverrideDescriptionsSettings OverrideDescriptions = new OverrideDescriptionsSettings();
        public OverrideGhostVFXSettings OverrideGhostVFX = new OverrideGhostVFXSettings();
        public OverrideTonnageSettings OverrideTonnage = new OverrideTonnageSettings();
        public ShutdownInjuryProtectionSettings ShutdownInjuryProtection = new ShutdownInjuryProtectionSettings();
        public TurretLimitedAmmoSettings TurretLimitedAmmo = new TurretLimitedAmmoSettings();
        public TurretMechComponentSettings TurretMechComponents = new TurretMechComponentSettings();
        public TagManagerSettings TagManager = new TagManagerSettings();
        
        public DebugCycleCombatSoundsSettings DebugCycleCombatSounds = new DebugCycleCombatSoundsSettings();
        public DebugSaveMechToFileSettings DebugSaveMechToFile = new DebugSaveMechToFileSettings();
        public DebugScreenshotMechsSettings DebugScreenshotMechs = new DebugScreenshotMechsSettings();
    }
}
