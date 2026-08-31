// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.RoomData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

#nullable disable
namespace Eco.Gameplay.Rooms;

[Serialized]
[ChatCommandHandler]
[Priority(1)]
public class RoomData : 
  Singleton<RoomData>,
  IEditablePluginData,
  ISimplePluginData,
  IStorage,
  ISerializable
{
  public static ThreadSafeAction<IEnumerable<Room>> OnRoomsChanged;

  public static AutoResetEvent OnQueuedEvent { get; }

  [Serialized]
  public ThreadSafeList<Room> Rooms { get; }

  [Serialized]
  public bool DidPostFixSweep { get; set; }

  public RoomConfig RoomConfig { get; }

  IPersistent IStorage.StorageHandle { get; set; }

  public object EditObject { get; set; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public Atmosphere Atmosphere { get; set; }

  public void SyncRoomCheckerSettings();

  public bool IsOutside(Vector3i firstPos);

  public static void QueuePositionsTest(IEnumerable<Vector3i> positions);

  /// <summary> Queue up this position to be checked against all Rooms to determine if a Room has changed. </summary>
  public static void QueueRoomTest(WrappedWorldPosition3i pos);

  /// <summary> Queue up this RoomID to recalculate the relevant Room's RoomValue. </summary>
  public static void QueueRoomValueRecalculation(int roomID);

  public Room GetRoomById(int id);

  public void OnCreate();

  void ISimplePluginData.OnLoaded();

  public void Initialize();

  public void ScanChangesForRooms();

  public void UpdateRoomValues(IEnumerable<Room> rooms);

  public List<Vector3i> GetRoomsPosAsList();

  public Room GetRoom(Vector3i testPos);

  public Room GetRoom(WrappedWorldPosition3i testPos);

  /// <summary>Returns the room only if all the blocks of the World Object are inside the same room.</summary>
  public Room GetEnclosedRoomForWorldObject(WorldObject worldObject);

  public float PosRoomValue(Vector3i pos);

  public Room GetNearestRoom(Vector3 testPos);

  /// <summary> Search for an empty space that fits a rectangle with a given size, use user position as initial position. </summary>
  public Vector3i GetEmptySpace(Vector3i size, User user);

  /// <summary> Search for an empty space that fits a rectangle with a given size, use given position as initial position. </summary>
  public Vector3i GetEmptySpace(Vector3i size, WrappedPosition3i initialPos);

  public string GetDisplayText();

  public string GetStatus();

  public override string ToString();

  public string GetCategory();

  public void OnEditObjectChanged(object o, string param);
}
