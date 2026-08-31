// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CraneToolComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Tests;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[ChatCommandHandler]
[HasIcon(null)]
public class CraneToolComponent : WorldObjectComponent
{
  [Serialized]
  [SyncToView(null, true)]
  public BuilderInventory ClawInventory { get; set; }

  [SyncToView(null, true)]
  public int OverrideStackSize { get; set; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  public override void OnCreate();

  public void Initialize(float joulesPerBuildBlock, int overrideStackSize);

  [RPC]
  public void Build(Player player, Vector3i min, Vector3i max, int blockRotation);

  [RPC]
  public void WorldObjectInteract(
    Player player,
    InteractionTarget target,
    InteractionTriggerInfo triggerInfo);

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);

  [ChatCommand("Shows commands for common testing scenarios.", ChatAuthorizationLevel.DevTier)]
  public static void Test(User user);

  [CITest(false)]
  [ChatSubCommand("Test", "Setup a test environment for cranes.", ChatAuthorizationLevel.DevTier)]
  public static void Cranes(User user);
}
