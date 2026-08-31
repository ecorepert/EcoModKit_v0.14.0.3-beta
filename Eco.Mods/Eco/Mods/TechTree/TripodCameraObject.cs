// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TripodCameraObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Mods.TechTree;

/// <summary> World object with a custom UI (In-Game cameras UI). Allows player to take pictures </summary>
[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[Tag("Usable")]
[Ecopedia("Crafted Objects", "Specialty", false, true, "Tripod Camera Item")]
[RelatedFeature("CameraModeEnabled", true)]
[RequireComponent(typeof (CameraComponent), null)]
[RequireComponent(typeof (MountComponent), null)]
public class TripodCameraObject : WorldObject, IRepresentsItem, IGameCamera
{
  public virtual 
  #nullable disable
  Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  protected override void Initialize();

  protected override void PostInitialize();

  public override void Use(
    Player player,
    InteractionTarget target,
    InteractionTriggerInfo triggerInfo,
    string ui);

  [RPC]
  public bool ConsumeResources(Player player);

  [RPC]
  public Task CaptureImage(Player player, byte[] image);

  [RPC]
  public void Release(Player player);
}
