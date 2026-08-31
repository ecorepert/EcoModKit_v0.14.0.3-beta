// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.BorderControlComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Settlements.Components;

[LocDisplayName("Border Control")]
[LocDescription("Determines who can claim within our influence.")]
[Serialized]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
[Ecopedia("Settlements", "Influence", false, true, null)]
public class BorderControlComponent : 
  WorldObjectComponent,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  public static ThreadSafeAction BorderControlPermissionsChanged;

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("GeneralHeader")]
  [DependsOnSubMember("Settlement", "MarkedUpName")]
  public LocString Title { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public LocString SubTitle { get; }

  [LocDescription("When this is toggled, only unaffiliated homesteads (not a member of any settlement) will be allowed to expand into our settlement influence.")]
  [Eco.Shared.Networking.Eco(true)]
  public bool AllowAnyUnaffiliatedHomesteadDeedToExpandWithinOurInfluence { get; set; }

  [LocDescription("Settlements listed here may claim plots that are currently influenced by the assigned jurisidction.")]
  [Eco.Shared.Networking.Eco(true)]
  public ControllerList<Settlement> CitizensOfTheseSettlementsMayExpandClaimsWithinOurInfluence { get; set; }

  [LocDescription("Citizens listed here may claim plots that are currently influenced by the assigned jurisidction.")]
  [TreatAsReference]
  [Eco.Shared.Networking.Eco(true)]
  public ControllerListAlias SpecificCitizensThatMayExpandClaimsWithinOurInfluence { get; set; }

  public override void Initialize();
}
