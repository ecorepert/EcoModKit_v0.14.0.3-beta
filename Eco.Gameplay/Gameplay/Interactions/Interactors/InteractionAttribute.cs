// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.Interactors.InteractionAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;

#nullable disable
namespace Eco.Gameplay.Interactions.Interactors;

/// <summary> Block of data sent to the client that defines how a general interactor works. Method applied to must have signature: void X(Player player, InteractionTriggerInfo trigger, InteractionTarget target, List{Tag} tagsTargetable) </summary>
/// <remarks> NOTE: This attribute inherits directly from <see cref="T:Eco.Shared.Networking.RPCAttribute" />, so an RPC will be created for every method this is defined on. </remarks>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class InteractionAttribute : 
  RPCAttribute,
  IController,
  IViewController,
  IHasUniversalID,
  IRPCAttribute
{
  [SyncToView(null, true)]
  public Type InteractorType { get; set; }

  [SyncToView(null, true)]
  public InteractionTriggerInfo TriggerInfo { get; set; }

  /// <summary>Description of the interaction, taken from the name of the method it's applied on, but can be overriden via our constructor.</summary>
  [SyncToView(null, true)]
  public LocString Description { get; set; }

  /// <summary>Name of the RPC to call. This is called on the interactor, but if the interactor is null its called on the target.</summary>
  [SyncToView(null, true)]
  public string RPCName { get; set; }

  /// <summary>If set, means that the RPC is called on the given subcomponent of a world object.</summary>
  [SyncToView(null, true)]
  public Type SubComponentTypeRPCTarget { get; set; }

  /// <summary>If set alongside SubComponentTypeRPCTarget, targets the component instance installed under this name (module-installed components are name-keyed, and a host can hold several of one type).</summary>
  [SyncToView(null, true)]
  public string SubComponentNameRPCTarget { get; set; }

  /// <summary>If set, means that the RPC is called on the given module item currently slotted into a world object.</summary>
  [SyncToView(null, true)]
  public Type ModuleItemTypeRPCTarget { get; set; }

  /// <summary>Blocks, NetObjects, and Items that have ANY of these tags can trigger this interaction.</summary>
  [SyncToView(null, true)]
  public Tag[] TagsTargetable { get; set; }

  /// <summary> Parameters that would allow this interaction to trigger (if a tag also matches). Exists to allow state-based definitions for WorldObjects (--e.g.: 'Turn on' vs 'Turn off', etc) </summary>
  /// <remarks> This is applied on top of tags. If this is null or empty, the interaction can be triggered. </remarks>
  [SyncToView(null, true)]
  public string[] RequiredEnvVars { get; set; }

  /// <summary>Environment vars that, if present and assigned any value besides 'false', will block the interaction.</summary>
  [SyncToView(null, true)]
  public string[] DisallowedEnvVars { get; set; }

  /// <summary>Max distance allowed to interact, 0 means default distance.</summary>
  [SyncToView(null, true)]
  public float InteractionDistance { get; set; }

  /// <summary>When two interactions are set on the same trigger, priority determines which is displayed and available.  Prefers higher number as more priority.</summary>
  [SyncToView(null, true)]
  public float Priority { get; set; }

  /// <summary>If we're includiung any views as envar paremeters in the description, they can be created on the client as prefabs of this type (listed in UIPrefab)</summary>
  [SyncToView(null, true)]
  public string UIType { get; set; }

  /// <summary>Define an action that can happen instantly on the client when the interaction takes place, and can be rewound if the server doesnt accept it.</summary>
  [SyncToView(null, true)]
  public ClientPredictedBlockAction PredictedBlockAction { get; set; }

  [SyncToView(null, true)]
  public Vector2i[] AreaBlocks { get; set; }

  [SyncToView(null, true)]
  public int MaxTake { get; set; }

  [SyncToView(null, true)]
  public bool AnimationDriven { get; set; }

  [SyncToView(null, true)]
  public TriBool CanHoldToTrigger { get; set; }

  [SyncToView(null, true)]
  public Color HighlightColor { get; set; }

  [SyncToView(null, true)]
  public AccessType AuthRequired { get; set; }

  [SyncToView(null, true)]
  public InteractionFlags Flags { get; set; }

  /// <summary>Min calories required to perform the action. The ingteraction may still consume more than this.  And the consumption doesnt happen automatically, the interaction func must do it.</summary>
  [SyncToView(null, true)]
  public float MinCaloriesRequired { get; set; }

  public InteractionAttribute(
    InteractionTrigger trigger,
    string overrideDescription = null,
    InteractionModifier modifier = InteractionModifier.None,
    string[] requiredEnvVars = null,
    float interactionDistance = 0.0f,
    float priority = 0.0f,
    ClientPredictedBlockAction predictedBlockAction = ClientPredictedBlockAction.None,
    int maxTake = 0,
    bool animationDriven = false,
    TriBool canHoldToTrigger = TriBool.None,
    string highlightColorHex = null,
    AccessType authRequired = AccessType.FullAccess,
    InteractionFlags flags = (InteractionFlags) 0,
    string uiType = null,
    bool useDefaultRPCAuthCheck = false,
    params string[] tags);

  /// <summary>Init an interaction definition defined on an interactor. </summary>
  public void Init(Type interactorType, string rpcName);

  /// <summary>Shallow copy, for republishing a definition under another key without mutating the shared original (e.g. proxying a component's interactions onto the module item that installs it).</summary>
  public InteractionAttribute Clone();

  bool IRPCAttribute.IsAuthorized(object target, IWorldObserver observer, object[] args);

  [DoNotNotify]
  public ref int ControllerID { get; }
}
