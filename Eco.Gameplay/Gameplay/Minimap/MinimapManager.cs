// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Minimap.MinimapManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Minimap;

[LocDisplayName("MinimapManager")]
public sealed class MinimapManager : 
  Singleton<
  #nullable disable
  MinimapManager>,
  INetObject,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IWorkerPlugin,
  IInitializablePlugin,
  INetObjectPriority,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public static int LastMapEntry;

  [SyncToView(null, true)]
  public DeltaControllerHashSet<MinimapObject> DeltaHashSetObjects { get; set; }

  internal static MinimapLandData Data { get; }

  public float Priority { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public void Initialize(TimedTask timer);

  /// <summary>Queues a minimap object for batched registration on the next sync tick.
  /// Use this in place of <c>DeltaHashSetObjects.Add</c> for bursty producers (world-load tree init etc.).</summary>
  public void QueueForBulkRegister(MinimapObject obj);

  /// <summary>Removes a minimap object. If it was queued for bulk registration but not yet drained, the queued entry is cancelled
  /// so it never reaches the delta set; otherwise the delta set's <c>Remove</c> is invoked. Null is treated as a no-op.</summary>
  public bool UnregisterMinimapObject(MinimapObject obj);

  /// <summary>True if the object is either pending bulk-registration or already in the delta set.</summary>
  public bool IsRegistered(MinimapObject obj);

  void INetObject.SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public static void NotifyMinimapIsOpenInWindowOrFullscreenMode(Player subscriber);

  public string GetDisplayText();

  public string GetStatus();

  public string GetCategory();

  public Task ShutdownAsync();

  public void Run();

  public override string ToString();

  public Task DoWork(CancellationToken token);

  bool INetObject.IsRelevant(INetObjectViewer viewer);

  bool INetObject.IsNotRelevant(INetObjectViewer viewer);

  bool INetObject.IsUpdated(INetObjectViewer viewer);

  void INetObject.SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  void INetObject.ReceiveInitialState(BSONObject bsonObj);

  void INetObject.ReceiveUpdate(BSONObject bsonObj);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [Localized(true, false, "", false)]
  private class TickSample : ITickSample
  {
    public double TimeTotal { get; set; }

    public double TimeChunkMaps { get; set; }
  }
}
