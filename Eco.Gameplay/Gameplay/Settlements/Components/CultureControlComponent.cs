// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.CultureControlComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable enable
namespace Eco.Gameplay.Settlements.Components;

[LocDisplayName("Culture")]
[LocDescription("Allows various culture controls for a settlement.")]
[Serialized]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
[Ecopedia("Settlements", "Culture", false, true, null)]
[RequireComponent(typeof (JurisdictionComponent), null)]
public class CultureControlComponent : 
  WorldObjectComponent,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("GeneralHeader")]
  [DependsOnSubMember("Settlement", "MarkedUpName")]
  public LocString Title1 { get; }

  [SyncToView(null, true)]
  [Autogen]
  [PropReadOnly]
  [DependsOnMember("Settlement")]
  [UITypeName("StringDisplay")]
  public LocString SubTitle { get; }

  [SyncToView(null, true)]
  [Autogen]
  [HideDescription]
  [HideRoot]
  [PropReadOnly]
  [UITypeName("StringDisplay")]
  [DependsOnSubMember("Settlement", "AssignedCulturalDeeds")]
  public LocString PropListDesc { get; }

  [Autogen]
  [RPC]
  [UITypeName("BigButton")]
  public void ChooseProperties(
  #nullable disable
  Player player);

  public override void Initialize();
}
