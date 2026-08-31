// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.SettlementClaimStakeComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements.Components;

/// <summary>A component for claim stakes that can specify a settlement as their parent.  Not used for settlements being parented to other settlements.</summary>
[Serialized]
[Priority(-300)]
[LocDescription("Displays and sets the settlement that is the parent of this claim stake.")]
[CreateComponentTabLoc("Claim Stake", false)]
[HasIcon(null)]
[LocDisplayName("Settlement Claim Stake")]
public class SettlementClaimStakeComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IClaimStakeComponent
{
  public static ThreadSafeAction<SettlementClaimStakeComponent> SettlementNameChangedEvent;

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringPlaque")]
  public LocString Description { get; }

  [WatchSubMember("MarkedUpName", "OnClaimStakeSettlementNameChanged", SubPropWatcherFlag.None)]
  [Serialized]
  public Settlement InfluencingSettlement { get; }

  public Settlement OwningSettlement { get; }

  public override void Initialize();

  public override void OnCreate();

  /// <summary>Must be called by the placing thing after the deed is all setup.</summary>
  void IClaimStakeComponent.DeedChanged();

  /// <summary>Update the settlement that owns this stake.</summary>
  public void StakeOwnerUpdated();

  public override void Destroy();

  /// <summary>We update the lowest influencing settlement by also making sure to notify the settlement that's influencing it.</summary>
  public void SetInfluencingSettlement(Settlement newSettlement);
}
