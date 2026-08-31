// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObjectManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Objects;

[LocDisplayName("WorldObjectManager")]
[Priority(0)]
public class WorldObjectManager : 
  IWorldObjectManager,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IInitializablePlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IConfigurablePlugin,
  IEditablePlugin
{
  public static readonly 
  #nullable disable
  ThreadSafeAction<WorldObject, User> WorldObjectAddedEvent;
  public static readonly ThreadSafeAction<WorldObject> WorldObjectRemovedEvent;
  public static readonly ThreadSafeAction<Item> ItemDestoryedPermanently;
  public static readonly ThreadSafeAction WorldObjectsInitializedEvent;
  public static Dictionary<Type, List<Type>> WorldObjectTypeToComponentTypes;
  public static Initializer Init;

  public Dictionary<string, Type> AllWorldObjectTypes { get; }

  public void Initialize(TimedTask timer);

  /// <summary>We get all the world objects that have the specified component.</summary>
  /// <param name="includeHiddenObjects">Do we want to also get the hidden objects ?</param>
  public static IEnumerable<Type> GetWorldObjectsFromComponent(
    Type componentType,
    bool includeHiddenObjects = true);

  public double TickStartTime { get; }

  public float TickDeltaTime { get; }

  public Type GetTypeFromName(string s);

  public static void ForEach(Action<WorldObject> action);

  public static IEnumerable<WorldObject> GetOwnedBy(User user);

  /// <inheritdoc cref="M:Eco.Gameplay.Objects.IWorldObjectManager.AddToTick(Eco.Gameplay.Objects.ITickOnDemand)" />
  public void AddToTick(ITickOnDemand tickable);

  public IEnumerable<WorldObject> GetObjectsWithin(WrappedPosition3 position, float range);

  public IEnumerable<WorldObject> GetObjectsWithin(Eco.Shared.Math.Vector2 position, float range);

  public IEnumerable<WorldObject> All { get; }

  public IEnumerable<Type> AllTypes { get; }

  public WorldObject GetFromID(Guid g);

  public WorldObject Add(
    WorldObject worldObject,
    User creator,
    WrappedWorldPosition3 position,
    Eco.Shared.Math.Quaternion rotation,
    WorldObject attachedToWorldObject);

  public bool RemoveWorldObject(WorldObject worldObject);

  public static WorldObject ForceAdd(
    Type worldObjectType,
    User creator,
    Vector3 position,
    Eco.Shared.Math.Quaternion rotation,
    bool validatePlacement = true,
    IPlaceableItem item = null,
    Action<WorldObject> onInstanceCreated = null,
    WorldObject attachedToWorldObject = null);

  /// <summary> Attempts to move an already placed WorldObject to a new position. </summary>
  /// <remarks> For stockpiles, calories will be used based on their total weight. </remarks>
  public static WorldObject TryMoveWorldObject(
    Player player,
    IPlaceableItem item,
    WorldObject worldObject,
    Vector3 newPosition,
    Eco.Shared.Math.Quaternion newRotation);

  /// <summary> Same as TryMoveWorldObject but does not consume calories (e.g. for freecar command). Ignores laws, civics, and settlement restrictions. </summary>
  public static WorldObject TryMoveWorldObjectFreecar(
    Player player,
    IPlaceableItem item,
    WorldObject worldObject,
    Vector3 newPosition,
    Eco.Shared.Math.Quaternion newRotation);

  public void Run();

  public Task ShutdownAsync();

  public void OnDisplayTabVisibilityChange(bool show);

  public void RemoveFromTick(ITickOnDemand tickable);

  public bool IsQueuedForTick(ITickOnDemand tickable);

  public override string ToString();

  public string GetCategory();

  public string GetStatus();

  public string GetDisplayText();

  public void OnWorldObjectLoaded(WorldObject worldObject);

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  /// <summary><list type="number">
  /// <item> Triggers OnPermanentDestroy on object's components. </item>
  /// <item> Packs the objects into an item and triggers OnPermanentDestroy on its entries. </item>
  /// <item> Destroys the object. </item>
  /// </list></summary>
  public static void DestroyPermanently(WorldObject worldObject);

  public static void DestroyPermanently(Item item, int quantity = 1);

  [Localized(true, false, "", false)]
  [IgnoreHostedWorlds]
  private class WorldObjectConfig
  {
    [LocDescription("Time between World Object Ticks in milliseconds. (0 for variable)")]
    public int TargetTickDeltaTimeMS { get; set; }

    [LocDescription("EXPERIMENTAL: Tick World Objects in parallel. May significantly increase performance, but also may cause crashes and inconsistency. Use it on your own risk.")]
    public bool ParallelWorldObjectTicks { get; set; }
  }
}
