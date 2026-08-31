// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.WorldMarker.WorldMarkerManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Tests;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.UI.WorldMarker;

/// <summary>World marker list and management for a single user. Global ones are held elsewhere.</summary>
[Serialized]
[ChatCommandHandler]
public class WorldMarkerManager : 
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  public ThreadSafeList<GroupMarkerPart> GroupMarkerParts;

  [Serialized]
  [SyncToView(null, true)]
  public ThreadSafeHashSet<Eco.Gameplay.UI.WorldMarker.WorldMarker> DisabledMarkers { get; }

  [Serialized]
  [SyncToView(null, true)]
  public ThreadSafeHashSet<string> DisabledFolders { get; }

  [Serialized]
  [SyncToView(null, true)]
  [ForceSerializeFullObject]
  public ControllerList<Eco.Gameplay.UI.WorldMarker.WorldMarker> List { get; }

  [SyncToView(null, true)]
  public IEnumerable<Eco.Gameplay.UI.WorldMarker.WorldMarker> AllMarkers { get; }

  public ThreadSafeAction<Eco.Gameplay.UI.WorldMarker.WorldMarker> OnMarkerOpen { get; }

  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions? Subscriptions { get; }

  public void Initialize(Action save, User user);

  public void SetGroupPartMarker(
    Guid id,
    Vector3i pos,
    string category,
    IEnumerable<IStack> items,
    string? text = null,
    bool displayOffScreen = true);

  public void RemoveGroupPartMarker(Guid id);

  [RPC]
  public void EnableMarker(Eco.Gameplay.UI.WorldMarker.WorldMarker marker, bool enable);

  [RPC]
  public void EnableAllMarkers(bool enable);

  [RPC]
  public void FolderStateChanged(string folder, bool enabled);

  [RPC]
  public void FolderDestroyed(string folder);

  public Eco.Gameplay.UI.WorldMarker.WorldMarker Add(
    User user,
    Vector3i pos,
    string text,
    bool useExistingIfAtPosition,
    bool isTutorialMarker = false,
    MarkerFolderName folderStructure = MarkerFolderName.None);

  public void Remove(Eco.Gameplay.UI.WorldMarker.WorldMarker worldMarker);

  public void Remove(IEnumerable<Eco.Gameplay.UI.WorldMarker.WorldMarker> worldMarkers);

  public void RemoveAll(Predicate<Eco.Gameplay.UI.WorldMarker.WorldMarker> markerPredicate);

  public void RemoveMarkerAt(Vector3i pos);

  [RPC]
  public void SetSettlement(Player player, Eco.Gameplay.UI.WorldMarker.WorldMarker marker, Settlement settlement);

  [CITest(false)]
  [ChatSubCommand("Land", "Drops a waypoint at the current position.  Accepts an optional text string for the waypoint.", "mark", ChatAuthorizationLevel.User)]
  public static bool Mark(User user, string? text = null);

  [CITest(false)]
  [ChatSubCommand("Land", "Drops a global waypoint at the current position.  Accepts an optional text string for the waypoint.", "markglobal", ChatAuthorizationLevel.Admin)]
  public static bool MarkGlobal(User user, string? text = null);

  [CITest(false)]
  [ChatSubCommand("Land", "Removes the nearest global waypoint to your current position.", "removenearestglobalmark", ChatAuthorizationLevel.Admin)]
  public static bool RemoveNearestGlobalMark(User user);

  public void Clear(Player player);
}
