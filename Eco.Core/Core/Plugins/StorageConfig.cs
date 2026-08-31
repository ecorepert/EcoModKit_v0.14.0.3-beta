// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.StorageConfig
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Core.Plugins;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
[IgnoreHostedWorlds]
public class StorageConfig
{
  [LocDescription("Name of the save to load at startup.")]
  public string SaveName { get; set; }

  [LocDescription("How often to write changed data to disk, in seconds.")]
  public int SaveFrequency { get; set; }

  [LocDescription("If true, world objects are only persisted when their state actually changed instead of on every tick. Turn off to restore legacy behavior where every ticking object is re-saved each cycle.")]
  public bool PreciseDirtyTracking { get; set; }

  [LocDescription("Minutes between reconciliation sweeps that detect and persist state changed without a dirty mark (safety net for mods writing serialized fields directly). 0 disables the sweep.")]
  public int DirtyTrackingReconcileMinutes { get; set; }

  [LocDescription("QA option: run the dirty-tracking reconciliation on every persist cycle and report each divergence. Expensive, only enable to hunt missing dirty marks.")]
  public bool ValidateDirtyTracking { get; set; }

  [LocDescription("If true, removes failed to load objects upon loading.")]
  public bool CleanupFilesOnExceptions { get; set; }

  public string StorageDirectory { get; set; }

  [LocDescription("Path to file to start the game from for a New World, if null then the World will be generated")]
  public string NewGameTemplate { get; set; }
}
