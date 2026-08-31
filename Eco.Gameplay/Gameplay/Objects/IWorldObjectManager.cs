// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.IWorldObjectManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Objects;

public interface IWorldObjectManager
{
  double TickStartTime { get; }

  float TickDeltaTime { get; }

  /// <summary>
  /// Adds <paramref name="tickable" /> to closest (current or next) <see cref="M:Eco.Gameplay.Objects.WorldObjectManager.TickAll" /> which may not want to tick every time, but instead tick only when specific event happens.
  /// It may be useful if you wanna delay component state update until tick time, because it may have lot of updates between ticks and processing multiple syncs for every update
  /// may significantly impact performance. At same time we don't wanna to <see cref="M:Eco.Gameplay.Objects.WorldObjectComponent.Tick" /> every time, because these syncs may not happen for long time
  /// for most of components and it will just waste CPU time.
  /// </summary>
  void AddToTick(ITickOnDemand tickable);

  void RemoveFromTick(ITickOnDemand tickable);

  bool IsQueuedForTick(ITickOnDemand tickable);

  IEnumerable<WorldObject> GetObjectsWithin(WrappedPosition3 position, float range);

  IEnumerable<WorldObject> GetObjectsWithin(Vector2 position, float range);

  IEnumerable<WorldObject> All { get; }

  Dictionary<string, Type> AllWorldObjectTypes { get; }

  IEnumerable<Type> AllTypes { get; }

  Type GetTypeFromName(string s);

  WorldObject Add(
    WorldObject worldObject,
    User creator,
    WrappedWorldPosition3 position,
    Quaternion rotation,
    WorldObject attachedToWorldObject = null);

  WorldObject GetFromID(Guid g);

  bool RemoveWorldObject(WorldObject worldObject);
}
