// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ClaimPaperItemBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>This is the base class for all claim papers.</summary>
public abstract class ClaimPaperItemBase : 
  Item,
  ISettlementAssociated,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  /// <summary>Claiming is limited to this settlement, if set.</summary>
  [Serialized]
  [SyncToView(null, true)]
  public Settlement? Settlement { get; set; }

  public override bool IsStackable { get; }

  public override int StackingHash { get; }

  public override bool RepresentsItem(Item other);

  public override int RepresentativeHash();

  public override void Destroy(int quantity = 1);

  public override Item Clone();

  protected abstract void Deduct(int quantity);

  /// <summary>Check whether these papers can be added to the specified claim stake or not.</summary>
  public abstract Result CanBeAddedToStake(WorldObject claimStake, Deed parentDeed);

  /// <summary>We check whether these papers can be counted toward the maximum of allowed plots of the specified claim stake or not.</summary>
  public abstract Result CanBeCountedForStakePlots(WorldObject claimStake, Deed parentDeed);

  public event PropertyChangedEventHandler? PropertyChanged;

  public ref ThreadSafeSubscriptions? Subscriptions { get; }
}
