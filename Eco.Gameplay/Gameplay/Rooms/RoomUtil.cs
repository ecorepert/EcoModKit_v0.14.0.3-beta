// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.RoomUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Rooms;

/// <summary>General utilities for room management</summary>
public static class RoomUtil
{
  /// <summary>
  /// Updates room object references when the room's contained objects change.
  /// Removes room reference from objects no longer in the room and sets room reference for new objects.
  /// </summary>
  /// <param name="room">The room being updated</param>
  /// <param name="oldObjects">Previous objects in the room</param>
  /// <param name="newObjects">New objects in the room</param>
  public static void UpdateRoomWithNewObjects(
    Room room,
    IEnumerable<WorldObject> oldObjects,
    IEnumerable<WorldObject> newObjects);

  public static Room CalculateRoomForObject(Deed deed, WorldObject obj);
}
