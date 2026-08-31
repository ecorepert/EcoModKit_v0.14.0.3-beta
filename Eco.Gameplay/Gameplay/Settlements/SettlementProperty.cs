// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementProperty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Settlements.ClaimStakes;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Component to Settlement that handles spawning/despawning stakes and claims as citizens come and go.
/// Handles property crises when not enough citizens for property.</summary>
[Serialized]
public class SettlementProperty : 
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public 
  #nullable disable
  ThreadSafeAction<bool> PropertyCrisisChangedEvent;
  public ThreadSafeAction ClaimsAndStakesUpdatedEvent;
  [Serialized]
  public double PropertyCrisisStartTime;

  public event PropertyChangedEventHandler PropertyChanged;

  [Notify]
  public SettlementProperty.ChangeInventoryEvent SpawnOrDespawnClaims { get; set; }

  [Serialized]
  public SpawnedClaims SpawnedClaims { get; }

  /// <summary>These are all the stakes used by this settlement (all the stakes currently influenced by this settlement).</summary>
  public ControllerList<SettlementClaimStakeObject> StakesInfluencedBySettlement { get; }

  [Notify]
  public bool HasPropertyCrisis { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public int DesiredStakes();

  public int DesiredSettlementClaims();

  public int DesiredSupportClaims();

  public void Initialize(Settlement settlement);

  public void Destroy();

  /// <summary>Called by our holder object to let us know the inventory holding the claims and stakes has recently changed.  We only care if there's a property crisis, though,
  /// because there might be stakes/claims we need to despawn.</summary>
  public void ClaimAndStakeInventoryChanged();

  /// <summary>Some things can spawn claim stakes outside our normal processes, like annexing a settlement.  This will increment the stakes and claims, perhaps even past the maximum, which may invoke a crisis/</summary>
  public void RegisterExternalClaimSpawns(SpawnedClaims spawned);

  /// <summary>Given current population and current number of spawned papers and stakes, we make sure to spawn or despawn claim papers/stakes until they are synchronized with the counters.</summary>
  public bool SynchronizeClaims(bool forceRecountAllPapersAndStakes = false);

  /// <summary>Creates a crisis notice for the current time.
  /// <paramref name="destinationDesc" />A description of where to return the stakes and claims.</summary>
  public LocString BuildCrisisNotice(LocString destinationDesc);

  public LocString BuildCrisisMailNotice(LocString destinationDesc);

  public LocString GlobalCrisisNotice();

  public float SettlementClaimsPerCitizen { get; }

  public float SettlementClaimsPerAbandonedCitizen { get; }

  public float StakesPerCitizen { get; }

  public float StakesPerAbandonedCitizen { get; }

  public float HomesteadSupportClaimsPerCitizen { get; }

  public float HomesteadSupportClaimsPerAbandonedCitizen { get; }

  public void Tick();

  public void ResolvePropertyCrisis(LocString? overrideReason = null, bool notify = true);

  public ref int ControllerID { get; }

  public delegate int ChangeInventoryEvent(Type itemType, int count);
}
