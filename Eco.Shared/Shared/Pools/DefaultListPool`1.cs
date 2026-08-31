// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.DefaultListPool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Pools;

internal class DefaultListPool<T> : ListPool<T>
{
  public DefaultListPool();

  public DefaultListPool(int maxCapacity, int maxListsPerBucket);

  public override List<T> Rent(int minimumCapacity);

  public override void Return(List<T> list);

  private sealed class Bucket
  {
  }
}
