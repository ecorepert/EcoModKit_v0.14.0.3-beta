// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.BoatComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>
/// Represents a boat. This component should be attached to all boats/vessels.
/// Handles boat moorage posts attachment.
/// </summary>
[Serialized]
[HasIcon(null)]
[Tag("Boat")]
public class BoatComponent : WorldObjectComponent
{
  [AutoRPC]
  public bool IsCarryingVehicles { get; set; }

  [SyncToView(null, true)]
  public BoatMooragePostComponent MoorageAttached { get; set; }

  public BoatComponent.BoatSize Size { get; set; }

  public override void Initialize();

  public override void Destroy();

  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, new string[] {"isRamp"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void ToggleRamp(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  /// <summary>Represents the size of a boat. Will be used in the moorage post, to check if the boat size is supported by the moorage post.</summary>
  public enum BoatSize
  {
    Small = 5,
    Large = 10, // 0x0000000A
  }
}
