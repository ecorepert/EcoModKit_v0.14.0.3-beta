// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.RegistrarSnapshot`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Systems;

/// <summary>A lazily-rebuilt snapshot derived from a <see cref="T:Eco.Core.Systems.Registrar`1" />, invalidated whenever the registrar's
/// contents change (add/insert/remove) or a member changes proposable state. The snapshot is rebuilt on the first read
/// after an invalidation (double-checked under a lock), so reads stay O(1) between changes instead of rescanning the
/// registrar on every call. Callers that depend on live state should filter at read time - only structural/state changes
/// invalidate, not arbitrary field edits. Subscribes to the registrar callbacks once, on first use.</summary>
public sealed class RegistrarSnapshot<T, TResult>
  where T : class, IHasID
  where TResult : class
{
  public RegistrarSnapshot(Func<Registrar<T>, TResult> build);

  /// <summary>The current snapshot, rebuilding it first if the registrar changed since the last read.</summary>
  public TResult Get();
}
