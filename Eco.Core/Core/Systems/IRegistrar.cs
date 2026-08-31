// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.IRegistrar
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
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Systems;

/// <summary>Interface allowing to have untyped access to <see cref="T:Eco.Core.Systems.Registrar`1" />.</summary>
public interface IRegistrar : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  Type ContainedType { get; }

  [SyncToView(null, true, ViewType = typeof (Dictionary<int, IHasID>))]
  protected BSONValue IdToObj(IWorldObserver worldObserver);

  [SyncToView(null, true, ViewType = typeof (Dictionary<string, IHasID>))]
  protected BSONValue NameToObj(IWorldObserver worldObserver);

  LocString RegistrarName { get; }

  bool ShareWithClient { get; }

  int Count { get; }

  IHasID? Random { get; }

  TrackingCallbacks Callbacks { get; }

  ThreadSafeAction<IHasID, ProposableState> OnContentsChangedStates { get; }

  ThreadSafeAction<IHasID, string?> OnRenamed { get; }

  ISaveablePlugin? SaveObject { get; }

  bool ShowInEcopedia { get; }

  bool Hidden { get; }

  string EcopediaPageName { get; }

  /// <summary>Returns all entries in <see cref="T:Eco.Core.Systems.IRegistrar" /> of specified type <typeparamref name="TResult" />.</summary>
  IEnumerable<TResult> OfType<TResult>();

  /// <summary>Returns all entries in <see cref="T:Eco.Core.Systems.IRegistrar" />.</summary>
  IEnumerable<IHasID> All();

  /// <summary> Verifies all entities in the registry and removes all which fails the verification. </summary>
  void Verify();

  void Initialize();

  /// <summary>Returns <see cref="T:Eco.Core.Systems.IRegistrar" /> entity by Name.</summary>
  IHasID? GetByName(string name);

  /// <summary>Adds new entity of <paramref name="type" /> which should be derived from <see cref="P:Eco.Core.Systems.IRegistrar.ContainedType" />. Optionally providing <paramref name="netObj" /> and <paramref name="name" />.</summary>
  IHasID? Add(Type type, INetObject? netObj = null, string? name = null);

  /// <summary>Inserts pre-created <paramref name="obj" />. It should match <see cref="P:Eco.Core.Systems.IRegistrar.ContainedType" /> of registar. Optionally providing <paramref name="netObj" />.</summary>
  IHasID Insert(IHasID obj, INetObject? netObj = null, bool overrideMaxNameLength = false);

  bool Remove(IHasID obj);

  bool Remove(INetObject? netObj, IHasID obj);

  bool Rename(IHasID obj, string newName, bool changeNameIfNeeded, bool overrideMaxNameLength = false);

  void Clear();

  /// <summary>Marks registry as dirty and asks persistence system to save it.</summary>
  void Save();
}
