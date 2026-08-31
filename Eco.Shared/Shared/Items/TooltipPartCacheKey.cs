// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipPartCacheKey
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>
/// Servers as a key for lookup in tooltip part cache on both server and client.
/// Given this key, cached content of a tooltip part can be retrieved from cache, if it is present.
/// </summary>
public readonly struct TooltipPartCacheKey : IEquatable<TooltipPartCacheKey>
{
  /// <summary>ControllerID of tooltip part.</summary>
  public readonly int PartId;
  /// <summary>ControllerID of view for which tooltip part content was generated or 0, depending on the cache mode used.</summary>
  public readonly int ViewId;
  /// <summary><see cref="T:Eco.Shared.Items.TooltipOrigin" /> for which tooltip part content was generated.</summary>
  public readonly TooltipOrigin Origin;

  /// <param name="partId">ControllerID of tooltip part.</param>
  /// <param name="viewId">ControllerID of view for which tooltip part content was generated or 0, depending on the cache mode used.</param>
  /// <param name="origin"><see cref="T:Eco.Shared.Items.TooltipOrigin" /> for which tooltip part content was generated.&gt;</param>
  public TooltipPartCacheKey(int partId, int viewId, TooltipOrigin origin);

  /// <summary>Same as <see cref="M:Eco.Shared.Items.TooltipPartCacheKey.#ctor(System.Int32,System.Int32,Eco.Shared.Items.TooltipOrigin)" />, but checks cache mode first to determine if viewId should be replaced with 0.</summary>
  public TooltipPartCacheKey(int partId, int viewId, TooltipOrigin origin, CacheAs cacheMode);

  public override bool Equals(object obj);

  public bool Equals(TooltipPartCacheKey other);

  public override int GetHashCode();

  public static bool operator ==(TooltipPartCacheKey left, TooltipPartCacheKey right);

  public static bool operator !=(TooltipPartCacheKey left, TooltipPartCacheKey right);
}
