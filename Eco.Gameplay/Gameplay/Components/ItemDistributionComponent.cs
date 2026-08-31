// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ItemDistributionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Tests;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components.Internal;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(-300)]
[HasIcon(null)]
[Tag("Economy")]
[Ecopedia(null, null, false, true, null)]
[ChatCommandHandler]
[RequireComponent(typeof (JurisdictionComponent), null)]
[LocDescription("Distributes items to new citizens of a settlement.")]
public class ItemDistributionComponent : 
  WorldObjectComponent,
  ICanOverrideAuth,
  IPersistentData,
  IGameActionAware
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  [DependsOnMember("Settlement")]
  public LocString Title { get; }

  [Serialized]
  public 
  #nullable disable
  ItemDistributionData AppliedDistributionData { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public ItemDistributionData DistributionData { get; set; }

  public IEnumerable<ItemStack> Stacks { get; }

  public IEnumerable<ItemStack> AvailableStacks { get; }

  public double MaxSecondsToGetStuff { get; }

  public IEnumerable<User> CitizensWithAccess { get; }

  public object PersistentData { get; set; }

  public override void Initialize();

  public override void Destroy();

  protected void ResetTrackersInternal(User executor);

  protected void ApplyInternal(User executor);

  public LazyResult ShouldOverrideAuth(IAlias alias, IOwned property, GameAction action);

  public bool ShouldReceiveDistribution(User user);

  public bool CanRecieveDistribution(User user);

  public LocString Describe();

  public LocString DescribeConsumers();

  public ItemTracker GetTrackerByUser(User user);

  public void ActionPerformed(GameAction action);

  [ChatSubCommand("Test", "Creates and applies a Distribution Station with carried items", ChatAuthorizationLevel.DevTier)]
  public static void DistributionStationCarried(User user);

  [CITest(false)]
  [ChatSubCommand("Test", "Creates and applies a Distribution Station.", ChatAuthorizationLevel.DevTier)]
  public static void DistributionStation(
    User user,
    bool fixedCount = false,
    int itemMax = 20,
    int itemDistribute = 1,
    int itemCountMax = 1,
    bool carried = false);
}
