// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.HashCodeHelper
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

public static class HashCodeHelper
{
  public static int HashCode(params object[] objects);

  public static int HashCode(IEnumerable objects);

  public static int HashCode<TKey, TValue>(
    IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs);

  public static int Hash(object a, object b);

  public static int HashWith(this int hash1, int hash2);
}
