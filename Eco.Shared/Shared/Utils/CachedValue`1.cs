// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.CachedValue`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Simple structure to cache a value on a timer, supporting async functions and handling concurrent access.</summary>
public class CachedValue<T>
{
  public CachedValue(
  #nullable disable
  Func<Task<T>> updateCacheFunc, double cacheSeconds = 60.0);

  public Task<T> GetAsync();
}
