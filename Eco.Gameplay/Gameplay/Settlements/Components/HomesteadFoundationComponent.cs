// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.HomesteadFoundationComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Immutable;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Components;

/// <summary>
/// Component that lets a homestead claim stake notify the owner when towns become in range, and displays data about the town its associated to.
/// Personal claimstake can only be part of the town youre a citizen of.
/// </summary>
[Autogen]
[Serialized]
[Priority(-300)]
[LocDescription("Displays info on what settlement this claim stake is tied to.")]
[LocDisplayName("Homestead")]
[CreateComponentTabLoc("Homestead Foundation", false)]
[HasIcon(null)]
public class HomesteadFoundationComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IClaimStakeComponent
{
  public ImmutableArray<Settlement> TownsInRange;

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringPlaque")]
  public LocString Title { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public LocString Description { get; set; }

  [Notify]
  public Settlement? Settlement { get; }

  public User? Creator { get; }

  public Deed? Deed { get; }

  public Settlement? OwningSettlement { get; }

  public override void Initialize();

  /// <summary>Must be called by the placing thing after the deed is all setup.</summary>
  void IClaimStakeComponent.DeedChanged();

  public override void Destroy();

  public override void OnPickup(Player player);
}
