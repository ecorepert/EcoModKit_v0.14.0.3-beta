// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeActionBase`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Diagnostics;

#nullable disable
namespace Eco.Core.Utils;

public abstract class ThreadSafeActionBase<TAction> : IEvent where TAction : Delegate
{
  protected TAction action;

  void IEvent.Add(object entry);

  bool IEvent.Remove(object entry);

  public void Clear();

  public bool Set();

  public void Add(TAction other);

  public void AddUnique(TAction other);

  public bool Remove(TAction other);

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public bool Any { get; }

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public int CallbackCount { get; }

  [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
  public ThreadSafeActionBase<TAction>.DelegateDebug[] Callbacks { get; }

  public struct DelegateDebug
  {
    public Delegate Delegate;

    public override string ToString();
  }
}
