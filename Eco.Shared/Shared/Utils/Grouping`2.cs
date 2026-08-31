// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Grouping`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> Simple implementation of <see cref="T:System.Linq.IGrouping`2" /> which allows us to make grouping remapping (like resolving key to string or filtering elements). </summary>
public class Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
  public TKey Key { get; }

  public Grouping(TKey key, IEnumerable<TElement> elements);

  public IEnumerator<TElement> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
