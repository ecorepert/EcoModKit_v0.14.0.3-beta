// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Immigration.InitialSpawnPoint
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Minimap;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.InitialSpawn;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.Civics.Immigration;

/// <summary>Contains a single point for a spawning option.</summary>
public class InitialSpawnPoint : 
  IMinimapObject,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public 
  #nullable disable
  Dictionary<InitialSpawnManager.Attractant, float> AttractantsAtPoint;
  public InitialSpawnManager.Attractant BestAttractant;

  [SyncToView(null, true)]
  public Vector3 Position { get; set; }

  [SyncToView(null, true)]
  public LocString Description { get; set; }

  [SyncToView(null, true)]
  public Color Color { get; set; }

  [SyncToView(null, true)]
  public float Priority { get; set; }

  [Notify]
  [WatchSubMember("Position", "UpdateSpawnPosition", SubPropWatcherFlag.None)]
  public Settlement Settlement { get; set; }

  [SyncToView(null, true)]
  public int TargetViewID { get; }

  [SyncToView(null, true)]
  public int TargetNetworkID { get; }

  [SyncToView(null, true)]
  public Type Type { get; }

  [SyncToView(null, true)]
  public Vector3 Scale { get; }

  [SyncToView(null, true)]
  public float Rotation { get; }

  [SyncToView(null, true)]
  public bool IsOverlayObject { get; }

  [SyncToView(null, true)]
  public IAlias Owner { get; }

  [SyncToView(null, true)]
  public User Creator { get; }

  [SyncToView(null, true)]
  public bool CanMove { get; }

  [SyncToView(null, true)]
  public bool CanChangeText { get; }

  [SyncToView(null, true)]
  public IMinimapObject OverrideTarget { get; }

  [SyncToView(null, true)]
  public ControllerHashSet<IAlias> HasAccess { get; }

  [SyncToView(null, true)]
  public string DisplayName { get; set; }

  [SyncToView(null, true)]
  public string SubTitle { get; set; }

  [SyncToView(null, true)]
  public bool IsVisibleOnMinimap { get; }

  [SyncToView(null, true)]
  public string DisplayObjectCategory { get; }

  [SyncToView(null, true)]
  public string DisplayObjectCategoryId { get; }

  [SyncToView(null, true)]
  public string DependantOverlayName { get; }

  [SyncToView(null, true)]
  public string IconNameOverride { get; }

  [SyncToView(null, true)]
  public bool IsAdditionalSpawnPoint { get; set; }

  public void UpdateSpawnPosition();

  public static InitialSpawnPoint FromSpawnPoint(SpawnPoint spawnPoint);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
