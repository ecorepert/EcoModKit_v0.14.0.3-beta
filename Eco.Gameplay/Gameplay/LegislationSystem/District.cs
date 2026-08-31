// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.LegislationSystem.District
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.Districts;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.LegislationSystem;

[Ecopedia(null, "Districts", false, true, null)]
[LocDescription("A defined section of land, which can be referenced by laws and other systems.")]
[Tag("CanBeInConstitution")]
[Serialized]
[Eco.Shared.Networking.Eco(true)]
public class District : 
  SimpleProposable,
  IParentedEntry,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [Serialized]
  [SyncToView(null, true)]
  public Color Color { get; }

  [Serialized]
  [SyncToView(null, true)]
  [DontClone]
  public DistrictMap ContainingMap { get; set; }

  public IHasID Parent { get; }

  [SyncToView(null, true)]
  public string EntryDescription { get; }

  [RPC]
  public void SetColor(Color color);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  protected override LocString TextName { get; }

  protected override bool RequiresSlot { get; }
}
