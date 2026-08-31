// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BlockItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

[Carried]
[WorldSpaceItem]
[ItemGroup("Block Items")]
[Tag("Block")]
[Serialized]
public abstract class BlockItem : 
  Item,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public static 
  #nullable disable
  ThreadSafeAction OnInitialize;

  public static BlockItem CreatingItem(Type blockType);

  /// <summary> Returns <see cref="T:Eco.Gameplay.Items.BlockItem" /> for requested <paramref name="blockType" />. </summary>
  public static BlockItem GetBlockItem(Type blockType);

  public static IEnumerable<BlockItem> CreatingItems(Type blockType);

  public static BlockItem FirstCreatingItem(Type blockType);

  public new static void Initialize();

  public abstract Type OriginType { get; }

  public abstract Type[] BlockTypes { get; }

  public virtual bool IgnoreRooms { get; }

  public virtual bool CanStickToWalls { get; }

  public virtual bool DisplayCrate { get; }

  public bool HasTier { get; }

  public int Tier { get; }

  public bool HasForms { get; }

  public static LocString ControlsText { get; }

  public static LocString ControlsTextCarried { get; }

  public static LocString ControlsTextHasForms { get; }

  /// <summary> Called from the client to finalize the 'Place' interaction. </summary>
  [RPC]
  public void Place(Player player, Vector3i position);

  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.False, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Priority = -5f, RequiredEnvVars = new string[] {"Carried"}, DisallowedEnvVars = new string[] {"Mounted"}, Flags = InteractionFlags.MustNotHaveTarget)]
  public void Drop(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);
}
