// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.SettlementInfluence
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.InfluenceObjects;
using Eco.Gameplay.Property;
using Eco.Shared.Gameplay;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Internal;

/// <summary>Handles settlement influence for a given settlement.</summary>
[Serialized]
public sealed class SettlementInfluence : 
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public static 
  #nullable disable
  ThreadSafeAction<IInfluencer> InfluenceTimerRunOut { get; }

  [Serialized]
  [Notify]
  public Color Color { get; set; }

  [Serialized]
  public bool InfluenceWholeWorld { get; set; }

  public IInfluencer Influencer { get; }

  public void Initialize(
    IInfluencer influencer,
    Vector3i pos,
    SettlementType type,
    bool isFounded,
    Func<bool> settlementEnabled,
    Func<IEnumerable<Deed>> getInfluencingDeeds,
    SettlementCachedData cachedData,
    Func<Deed> sourceDeed);

  /// <summary>Get called whenever the parent influencer get gounded.</summary>
  public void ParentFounded(Vector3i foundingPosition);

  public void ParentUnfounded();

  public Influence MakeInfluence();

  public IReadOnlySet<RadPoint> InfluencePoints { get; }

  public IReadOnlySet<Deed> InfluencingDeeds { get; }

  /// <summary>Calling this will make sure to update the cached influence points.</summary>
  public void UpdateInfluencePoints();

  /// <summary>Gives the influence point of the settlement once it's founded, which is the passed position with the given influence radius for our type.</summary>
  public RadPoint InfluencePointOnceFounded();

  /// <summary>If founded, returns the cached influence points. If not, returns what the initial influence will be when founded.</summary>
  public IEnumerable<RadPoint> InfluencePointsNowOrWhenFounded { get; }

  /// <summary>This will get called constantly and will take care of checking whether there's a deed that has just became invalid or not.</summary>
  public void Tick();

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
