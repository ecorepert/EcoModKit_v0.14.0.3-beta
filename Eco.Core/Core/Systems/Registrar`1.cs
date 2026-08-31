// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.Registrar`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

#nullable enable
namespace Eco.Core.Systems;

/// <summary>A registrar stores things of a single type that are accessible via an ID or via a name.
/// Types that are stored in a registrar must have a private constructor,
/// only the registrar is allowed to construct them so that the ID stays assigned and tracked properly.</summary>
[ForceCreateView(ViewTypeName = "RegistrarView")]
[Serialized]
[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof (Registrar<>.DebuggerDisplay))]
public class Registrar<T> : 
  IRegistrar,
  IController,
  IViewController,
  IHasUniversalID,
  ITrackedEnumerable,
  IEnumerable,
  IEnumerable<T>
  where T : class, IHasID
{
  public Initializer Initializer;
  /// <summary> Min name length of entry in this registrar, can be overriden in <see cref="M:Eco.Core.Systems.Registrar`1.PreInit(Eco.Shared.Localization.LocString,System.Boolean,Eco.Core.Plugins.Interfaces.ISaveablePlugin,System.String,System.Boolean,System.Int32,System.Int32)" /> </summary>
  public int MinNameLength;
  /// <summary> Max name length of entry in this registrar, can be overriden in <see cref="M:Eco.Core.Systems.Registrar`1.PreInit(Eco.Shared.Localization.LocString,System.Boolean,Eco.Core.Plugins.Interfaces.ISaveablePlugin,System.String,System.Boolean,System.Int32,System.Int32)" /> </summary>
  public int MaxNameLength;

  public TrackingCallbacks Callbacks { get; set; }

  public ThreadSafeAction<IHasID, string?> OnRenamed { get; set; }

  [Serialized]
  [ForceSerializeFullObject]
  protected ControllerHashSet<T> Objs { get; set; }

  protected ControllerDictionary<string, T> NameToObj { get; init; }

  public bool ShowInEcopedia { get; }

  public bool Hidden { get; set; }

  public ISaveablePlugin? SaveObject { get; set; }

  public override string ToString();

  public void PreInit(
    LocString registrarName,
    bool shareWithClient,
    ISaveablePlugin? save,
    string? ecopediaPageName = null,
    bool hidden = false,
    int minNameLength = -1,
    int maxNameLength = -1);

  public void Verify(T entity);

  /// <summary> Verifies all entities in the registry and removes all which fails the verification. </summary>
  public void Verify();

  public LocString RegistrarName { get; }

  public string EcopediaPageName { get; }

  public bool ShareWithClient { get; }

  [SyncToView(null, true)]
  public Type ContainedType { get; }

  public int Count { get; }

  IHasID? IRegistrar.GetByName(string name);

  IEnumerable<IHasID> IRegistrar.All();

  IHasID? IRegistrar.Add(Type type, INetObject? netObj, string? name);

  IHasID? IRegistrar.Random { get; }

  bool IRegistrar.Remove(IHasID obj);

  bool IRegistrar.Remove(INetObject? netObj, IHasID obj);

  IHasID IRegistrar.Insert(IHasID newObj, INetObject? netObj, bool overrideMaxNameLength);

  bool IRegistrar.Rename(
    IHasID obj,
    string newName,
    bool changeNameIfNeeded,
    bool overrideMaxNameLength);

  [SyncToView(null, true, ViewType = typeof (Dictionary<int, IHasID>))]
  BSONValue IRegistrar.IdToObj(IWorldObserver worldObserver);

  [SyncToView(null, true, ViewType = typeof (Dictionary<string, IHasID>))]
  BSONValue IRegistrar.NameToObj(IWorldObserver worldObserver);

  public void Initialize();

  public T? GetByName(string? name);

  public IEnumerable<T> All();

  public IReadOnlySet<T> Snapshot();

  public IEnumerable<TResult> OfType<TResult>();

  public T? Add();

  public T? Add(INetObject? netObj);

  public T? Add(INetObject? netObj, string? name, Action<T>? preInit = null);

  public TImpl? Add<TImpl>(INetObject? netObj, string? name, Action<TImpl>? preInit = null) where TImpl : T;

  public T? Add(Type type, INetObject? netObj = null, string? name = null, Action<T>? preInit = null);

  public T? Random { get; }

  public T Insert(T newObj, INetObject? netObj = null, bool overrideMaxNameLength = false);

  public void UpdateName(T t);

  public Result IsNameValid(string name);

  public Result Rename(
    T obj,
    string newName,
    bool changeNameIfAlreadyExists,
    bool overrideMaxNameLength = false);

  public string GetUniqueName(string name);

  /// <summary>Checks a name for requirements (length and profanity-free). If 'allowChanges' is set, it will fix the name to meet reqs. Otherwise it fails if it
  /// doesnt meet reqs.</summary>
  public Result SanitizeName(
    ref string newName,
    bool allowChange,
    string registrarName = "",
    bool overrideMaxNameLength = false);

  public void RemoveAll(Func<T, bool> func);

  public bool Remove(T t);

  public bool Remove(INetObject? netObj, T? obj);

  public void Clear();

  public void Save();

  public ref int ControllerID { get; }

  public ThreadSafeAction<IHasID, ProposableState> OnContentsChangedStates { get; set; }

  IEnumerator IEnumerable.GetEnumerator();

  public IEnumerator<T> GetEnumerator();

  private class DebuggerDisplay
  {
    public DebuggerDisplay(IRegistrar reg);

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public List<IHasID> Items { get; }
  }
}
