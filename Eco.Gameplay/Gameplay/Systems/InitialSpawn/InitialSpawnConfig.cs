// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.InitialSpawn.InitialSpawnConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.InitialSpawn;

[Localized(true, false, "", false)]
public class InitialSpawnConfig : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [LocDescription("We calculate updated procedural starting positions ever X minutes set here. The settlement starting points are updated instantly.")]
  public float MinutesBetweenUpdates { get; set; }

  [LocDescription("When two spawn-points are within this distance (defined in 'percent of world width'), combine them.  Must be 0-1.")]
  public float CombineInitialSpawnPointsAtPercentOfWorldDistance { get; set; }

  [LocDescription("When true removes attractant points and only displays settlements. Note: If there are not settlements will display random points")]
  public bool DisplayOnlySettlements { get; set; }

  [LocDescription("When true removes attractant points and settlements. Note: If there are not additional spawn points will fallback to normal behaviour")]
  public bool DisplayOnlyAdditionalSpawnPoints { get; set; }

  [LocDescription("If set, this list of spawn points is added to the automatic spawn points.")]
  public ThreadSafeList<SpawnPoint> AdditionalSpawnPoints { get; set; }
}
