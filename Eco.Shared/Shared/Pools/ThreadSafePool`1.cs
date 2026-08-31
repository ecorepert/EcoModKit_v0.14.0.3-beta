// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.ThreadSafePool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Pools;

/// <summary>
/// Simple thread-safe <see cref="T:System.Collections.Generic.Stack`1" /> based pool implementation. It implements <see cref="T:Eco.Shared.Pools.IObjectPool`1" /> interface and has unlimited pool size.
/// For optimal performance you should prefer thread-safe lock free <see cref="T:Eco.Shared.Pools.FixedSizePool`1" />, but it has fixed pool size and can't be shrink or extended.
/// </summary>
public class ThreadSafePool<T> : IObjectPool<T> where T : class
{
  public int Count { get; }

  public T? Get();

  public bool TryAdd(T obj);
}
