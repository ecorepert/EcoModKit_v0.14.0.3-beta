// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.IHasClientControlledContainers
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Utils;

[ForceCreateView]
public interface IHasClientControlledContainers : IController, IViewController, IHasUniversalID
{
  /// <summary>Snapshots the entry at <paramref name="index" /> into the player's clipboard.</summary>
  [RPC(AccessType.FullAccess)]
  void CopyEntry(
  #nullable disable
  Player player, string listName, int index);

  /// <summary>Appends a fresh clone of the player's clipboard content to the list, running the same validation as adding.</summary>
  [RPC(AccessType.FullAccess)]
  Task PasteEntry(Player player, string listName);

  bool VerifyCanAdd(Player player, IClientControlledContainer container, object obj);

  bool VerifyCanMove(Player player, IClientControlledContainer container, int index, int newIndex);

  Task<Result> VerifyCanRemove(Player player, IClientControlledContainer container, object obj);

  Task<Result> VerifyNewSetIsValid(
    Player player,
    IClientControlledContainer container,
    IEnumerable<object> newSet);

  /// <summary> Adds entry from registrar.
  /// The container and the entries are gotten from <paramref name="listName"></paramref>, then the container adds the <paramref name="player"></paramref> and each entry. </summary>
  [RPC(AccessType.FullAccess)]
  object Add(Player player, string listName);

  /// <summary> Removes index from registrar.
  /// The container is gotten from <paramref name="listName"></paramref>, then the container removes the selected <paramref name="index"></paramref>  </summary>
  [RPC(AccessType.FullAccess)]
  Task<bool> RemoveAt(Player player, string listName, int index);

  /// <summary> Removes entry from registrar. The container is gotten from <paramref name="listName"></paramref>,
  /// then the container removes the selected <paramref name="entry"></paramref>  </summary>
  [RPC(AccessType.FullAccess)]
  Task<bool> Remove(Player player, string listName, IController entry);

  /// <summary> Removes entry from registrar (shared logic). The container is gotten from <paramref name="listName"></paramref>,
  /// then the container removes the selected <paramref name="entry"></paramref>  </summary>
  Task<bool> RemoveInternal(
    Player player,
    string listName,
    object entry,
    IClientControlledContainer container,
    PropertyInfo property,
    Func<Result> removeFunc);

  /// <summary> Moves entry. The container is gotten from <paramref name="listName"></paramref>, then the <paramref name="entry"></paramref> is shifted in the container
  /// <paramref name="iDeltaMove"></paramref> positions </summary>
  [RPC(AccessType.FullAccess)]
  void MoveRelative(Player player, string listName, IController entry, int iDeltaMove);

  /// <summary> Move entry. The container is gotten from <paramref name="listName"></paramref>, then the container Moves the selected <paramref name="iEntry"></paramref>
  /// to the <paramref name="newIndex"></paramref></summary>
  [RPC(AccessType.FullAccess)]
  void Move(Player player, string listName, int iEntry, int newIndex);

  /// <summary> Replaces the existing entry of a list at given index. </summary>
  [RPC(AccessType.FullAccess)]
  void SetAt(Player player, [ControllerPropertyName(null)] string listName, int iEntry, object newEntry);
}
