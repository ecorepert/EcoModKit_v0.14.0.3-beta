// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.JurisdictionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Component that allows setting an associated settlement with a world object based on the settlements that are influencing the current position.
/// This component can be combined into another tab if its own tab isnt needed.</summary>
[Serialized]
[CreateComponentTabLoc("Jurisdiction", true)]
[HasIcon(null)]
[RelatedFeature("UseSettlementSystem", true)]
public class JurisdictionComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IController,
  IViewController,
  IHasUniversalID
{
  /// <summary>Set to false to prevent world object from being treated as disabled when no jurisdiction is selected.</summary>
  /// <remarks>This can be used for things like allowing crafting settlement foundation items on ballot box before jurisdiction is selected.</remarks>
  public bool DisableWhenInvalid;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The settlement that civic objects will be attached to.")]
  [OnlySettlementsAtLocation]
  public Settlement SettlementOfJurisdiction { get; }

  /// <summary>Callback that checks if changing the settlement is allowed.  Callback is expected to do the error notification to the user.</summary>
  public event Func<Player, Settlement, bool> CanChangeAssociatedSettlement;

  /// <summary>Does this world object have a jurisdiction selected?</summary>
  public bool IsValid { get; }

  public override bool Enabled { get; }

  public override void Initialize();

  public override void OnCreate();

  public override void Destroy();

  /// <summary>Trys to assigns a settlement upon which the objects in this civic object will apply. Validates it to make sure its
  /// influencing us, and prevents changes if there are active or proposed ones.</summary>
  [RPC(AccessType.FullAccess)]
  public void SetSettlementOfJurisdiction(Player player, Settlement settlement);

  public void ForceSetSettlementOfJurisdiction_Debug(Settlement settlement);
}
