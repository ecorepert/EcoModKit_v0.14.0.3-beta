// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.RoomUpdater
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Rooms;

public class RoomUpdater
{
  /// <summary> Update rooms to reflect the actual blocks. Adds to the passed list and sets up world objects.</summary>
  /// <param name="rooms">Full list of rooms, which is added to.</param>
  /// <param name="positions">Positions that we need to check for updates</param>
  /// <returns>The changes that occurred during the update: new, changed, and removed rooms.</returns>
  public static RoomUpdater.Changes Update(
    ThreadSafeList<Room> rooms,
    ThreadSafeDictionary<WrappedWorldPosition3i, Room> posToRooms,
    IEnumerable<WrappedWorldPosition3i> positions,
    IEnumerable<Room> roomsToUpdateValue);

  /// <summary> A more limited update that simply builds the room values, keeping the existing room stats on each room. </summary>
  public static void UpdateValueOnly(IEnumerable<Room> rooms);

  public static void RemoveRoom(Room room);

  public struct Changes
  {
    public IEnumerable<Room> AddedRooms;
    public IEnumerable<Room> ChangedRooms;
    public IEnumerable<Room> RemovedRooms;

    public IEnumerable<Room> All { get; }
  }

  public interface IRoomUpdates
  {
    void RoomUpdated(Room room);
  }
}
