// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.DecodedObject
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Internal;
using System;
using System.Collections.Concurrent;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary>
/// Returned decoded object.  It can either be
/// 1. The fully formed object. Assigned in 'obj'
/// 2. A reference to the object, which will need to be assigned later, after all serialization is complete.
/// In this case, object with the 'applyFunc' will be added fixupList to apply the reference, and that will
/// be later executed.
/// </summary>
public readonly struct DecodedObject
{
  public readonly object Obj;
  public readonly IObjectReference Reference;
  private static ConcurrentQueue<(IObjectReference, Action<IObjectReference>)> fixupList;
  public static ConcurrentQueue<Action> SimpleFixups;

  public bool IsReference { get; }

  public bool IsFullObject { get; }

  internal void DoLater(Action<IObjectReference> func);

  /// <summary>Tries to get <paramref name="value" /> as already known or resolved from reference.</summary>
  public bool TryGetValue(out object value);

  /// <summary>Tries to get non-null <paramref name="value" /> as already known or resolved from reference. Returns <c>false</c> if value isn't valid reference or it is <c>null</c>.</summary>
  public bool TryGetNotNullValue(out object value);

  public static void ApplyAllReferenceFixups();

  /// <summary>Cleanups fixup lists.</summary>
  internal static void CleanUp();

  internal static DecodedObject MakeObj(object obj);

  internal static DecodedObject MakeReference(IObjectReference reference);
}
