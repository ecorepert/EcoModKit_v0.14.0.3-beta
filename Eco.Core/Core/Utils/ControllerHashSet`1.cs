// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ControllerHashSet`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Shared.Networking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

#nullable disable
namespace Eco.Core.Utils;

public class ControllerHashSet<T> : 
  ThreadSafeHashSet<T>,
  IClientControlledContainer,
  ITrackedControllerEnumerable,
  ITrackedEnumerable,
  IEnumerable
{
  public TrackingCallbacks Callbacks { get; }

  public IController Parent { get; }

  public string PropertyName { get; }

  public Type Type { get; }

  protected ControllerHashSet();

  public ControllerHashSet(IController parent, [ControllerPropertyName(null)] string propertyName);

  public override void Clear();

  public override void UnionWith(IEnumerable<T> entries);

  /// <summary>Returns true if and only if the set contains each element in the enumerbale and no others.  Does not support duplicates in entries list.</summary>
  public bool ContainsOnly(IEnumerable<T> entries);

  public override bool Add(T item);

  public override void Set(IEnumerable<T> e);

  public override bool Remove(T item);

  public override IEnumerable<T> RemoveRangeAndReturn(IEnumerable<T> range);

  public override void RemoveRange(IEnumerable<T> range);

  public override ImmutableHashSet<T> GetAndClear();

  public override IEnumerable<T> GetAndClearMatching(Func<T, bool> test);

  bool IClientControlledContainer.Add(INetObject caller, object e);

  bool IClientControlledContainer.Set(INetObject caller, IEnumerable<object> e);

  bool IClientControlledContainer.Remove(INetObject caller, object item);

  public override IEnumerable<T> RemoveAllAndReturn(Func<T, bool> match);

  public override int RemoveAll(Func<T, bool> match);
}
