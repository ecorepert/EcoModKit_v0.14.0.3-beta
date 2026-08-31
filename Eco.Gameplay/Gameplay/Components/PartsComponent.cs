// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PartsComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>A component that defines a set of parts that reduce in durability over time, and must have durability or else the object will disable.</summary>
[Serialized]
[CreateComponentTabLoc("Parts", true)]
[Priority(100)]
[HasIcon(null)]
[ChatCommandHandler]
[RequireComponent(typeof (RepairBountyComponent), null)]
[RequireComponent(typeof (SmokeComponent), null)]
public class PartsComponent : 
  WorldObjectComponent,
  IHasEnvVars,
  IPersistentData,
  IComponentDurability,
  ICopyPasteComponent
{
  public ThreadSafeAction DurabilityConsumed;
  public bool ConsumeWithoutDelay;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public LocString Description { get; }

  [Serialized]
  [SyncToView(null, true)]
  public AuthorizationInventory Parts { get; }

  [Serialized]
  public object PersistentData { get; set; }

  public PartsComponent.PartInfo[] PartsRequired { get; }

  [Notify]
  public bool AllPartsWorking { get; }

  [Notify]
  public bool AllPartsPresent { get; }

  float IComponentDurability.Durability { get; }

  public virtual float DecayMultiplier { get; set; }

  public override bool Enabled { get; }

  [Interaction(InteractionTrigger.DisplayOnly, "%WornParts%", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, "BrokenPartPopupMarkerUI", false, new string[] {})]
  public void None();

  [EnvVar]
  public AuthorizationInventory WornParts(User user);

  public void Config(
    Func<LocString> decayDescription,
    params PartsComponent.PartInfo[] partsRequired);

  /// <summary>Requirements to replace parts, if configured in settings. Any may match.</summary>
  public RepairRequiresSkillAttribute[] SkillReqs { get; }

  public override void Initialize();

  public Type CopyPasteGroup { get; }

  public LocString OverwriteWarning { get; }

  public Result CopyFrom(WorldObjectComponent source, Player player);

  public float MinDurability();

  public float MinDurabilityPercent();

  /// <summary>Return the weighted average durability of all installed parts.</summary>
  public float TotalDurability();

  /// <summary>Called by sibling components to consume in an acculumating way, so it doesnt make syncable changed too frequently.</summary>
  public void ConsumeDurabilityAccumulated(User user, double amountToConsume);

  /// <summary>Called by sibling components to reduce the durability of all our parts when an action is performed.  Should be used only for large consumptions,
  /// otherwise use the ConsumeDurability function which will accumulate changes to reduce updates.</summary>
  public void ConsumeDurabilityNow(User user, float amountToConsume);

  [ChatSubCommand("Craft", "On objects within a given radius, make part durability consumption optionally trigger constantly instead of accumulating, and set a multiplier for how fast it goes.", "partdecay", ChatAuthorizationLevel.Admin)]
  public static void SetPartDecayMult(
    User user,
    float multiplier = 100f,
    bool consumeWithoutDelay = true,
    float radius = 20f);

  [ChatSubCommand("Craft", "Set all parts durability of target object and/or selected item to defined value (100 by default)", ChatAuthorizationLevel.Admin)]
  public static void SetPartsDurability(User user, INetObject target, float durability = 100f);

  public struct PartInfo
  {
    public string TypeName;
    public int Quantity;
  }

  [Serialized]
  public class PartsInventoryData : 
    IClearRequestHandler,
    IController,
    IViewController,
    IHasUniversalID,
    INotifyPropertyChanged
  {
    [Serialized]
    public bool FirstPlacement;
    [Serialized]
    public AuthorizationInventory Parts;
    [Serialized]
    public double QueuedDurabilityToConsume;

    [Serialized]
    [Notify]
    public string Description { get; set; }

    public bool HasDataThatCanBeCleared { get; }

    public Result TryHandleClearRequest(Player player);

    [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 13, TTCat.Controls, TTFlags.None, null, new Type[] {})]
    [TooltipAffectedBy("Description", null, null)]
    public LocString PartsTooltip(TooltipOrigin origin);

    [DoNotNotify]
    public ref int ControllerID { get; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
