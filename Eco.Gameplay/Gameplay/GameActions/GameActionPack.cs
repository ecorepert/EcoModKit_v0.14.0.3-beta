// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionPack
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary>
/// In Eco many actions can be blocked or modified by laws. This is handled with the GameActionPack, which defines an action to try to run,
/// and a set of 'PostEffects' that subsequently run if it succeeds, as well as objects to dispose on completion. These packs are created then
/// passed to the GameActionManager to perform them.
/// </summary>
public sealed class GameActionPack : IDisposable
{
  /// <summary>GameActions that are put through laws, auth, and stats.</summary>
  internal List<GameAction> GameActions;
  /// <summary>Pretests to be run once the entire game action has been build and is being performed. This is used for things like changelists, which might have multiple
  /// things added throughout the compilation of the GameActionPack, and thus shouldn't be tested for early-out. Usually though, things can fail in early-outs.</summary>
  internal List<Func<Result>> PreTests;
  /// <summary>Code to run when everything succeeds. These may not fail.</summary>
  internal List<Func<LocString>> PostEffects;
  /// <summary>Other disposal actions.</summary>
  internal List<Action> OnDispose;
  /// <summary>Collection of ChangeSet, there is only one change set for each type. They are used to do pretests, add PostEffect or called dispose call back.</summary>
  internal Dictionary<Type, IGameActionPackChangeSet> ChangeSets;
  /// <summary>If an action fails early, this will be set, preventing further atomic actions from bothering to do anything.</summary>
  public Result EarlyResult;
  /// <summary>Locking object of gameactionpack. Sample: When pick up same item, it will be locked, so another similar action (pick up) with same item will block each other, still allowing different things interact with this item.</summary>
  public object Locker;

  /// <summary>We can modify how the pack is performed with these flags.</summary>
  public PackFlags PackFlags { get; set; }

  public GameActionPack();

  public GameActionPack(GameAction gameAction);

  public GameActionPack(IEnumerable<Func<LocString>> postEffects);

  public GameActionPack(InventoryChangeSet changeSet);

  public GameActionPack(GameAction gameAction, Func<LocString> postEffect);

  /// <summary>Wrapper that lets us attach post-effects that don't need to return a status.</summary>
  public GameActionPack(GameAction gameAction, Action postEffect);

  /// <summary>Add a delegate that will be executed after all tests in this pack pass successfully.</summary>
  /// <returns>This action pack.</returns>
  public GameActionPack AddPostEffect(Func<LocString> func);

  /// <inheritdoc cref="M:Eco.Gameplay.GameActions.GameActionPack.AddPostEffect(System.Func{Eco.Shared.Localization.LocString})" />
  public GameActionPack AddPostEffect(Action action);

  public GameActionPack AddGameAction(GameAction action);

  /// <summary>Returns a change set that tracks money transfers.</summary>
  public AccountChangeSet GetAccountChangeSet(bool create = true);

  /// <summary>Changesets need to be cleaned up afterwards.</summary>
  public void AddChangeSet(IGameActionPackChangeSet changeSet);

  public string DebugDescribe(User user);

  public T GetChangeSetOrDefault<T>() where T : IGameActionPackChangeSet;

  public bool TryGetChangeSet<T>(out T changeSet);

  public T GetOrCreateChangeSet<T>(Func<T> newChangeSetFunc) where T : IGameActionPackChangeSet;

  public void Dispose();

  public bool Empty { get; }
}
