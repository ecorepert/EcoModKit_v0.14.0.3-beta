// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ExplosionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>
/// Base explosion component that allows block manipulation in areas.
/// Has basic logic and derived components can implement block processor of any kind. Ex block removal/replacement, etc
/// </summary>
[Serialized]
[NoIcon]
public class ExplosionComponent : WorldObjectComponent, IHasEnvVars
{
  [Serialized]
  public ExplosionConfig Config { get; }

  [Serialized]
  [EnvVar]
  public bool CanBeUsedManually { get; set; }

  public static 
  #nullable disable
  Dictionary<Type, Type> ExplosionBlockMap { get; }

  public static List<Type> CrushedBlockTypes { get; }

  public static void GenerateExplosionBlockMap();

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet invChanges,
    Inventory targetInventory,
    bool force);

  public void Initialize(ExplosionConfig config, bool canUseManually = true);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.Shift, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, DisallowedEnvVars = new string[] {"IsFuseStarted"}, RequiredEnvVars = new string[] {"CanBeUsedManually"}, AuthRequired = AccessType.OwnerAccess)]
  public void LightUp(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);

  [RPC]
  public void StartFuseTimer(Player player);

  /// <summary> Allows to start detonation with custom timer and radius. Good to be reused from extra extensions and sources </summary>
  public void StartFuseTimerCustom(Player player, float fuseTime, int radius = -1, bool notify = true);

  /// <summary> Determines area for explosion, in case any custom shape needed - override this. </summary>
  protected virtual IEnumerable<Vector3i> GetExplosionArea();

  /// <summary>
  /// Determines what will happen with block positions after explosion event from server
  /// This is called as post action in atomic actions and passes all valid positions after auth validation, etc.
  /// </summary>
  protected virtual void ProcessExplosion(IEnumerable<Vector3i> area);
}
