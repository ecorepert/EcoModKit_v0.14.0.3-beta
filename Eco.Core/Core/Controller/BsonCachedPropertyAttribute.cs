// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.BsonCachedPropertyAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>
/// Should be used with property having <see cref="F:Eco.Shared.View.SyncFlags.ServerRAMCached" />, specifies which property used as a cached counterpart of the attributed property. May be set manually or will be automatically added by <c>Eco.Fody.SyncToViewCacheWeaving</c> for every property with the flag.
/// Then the getter of the cached property will be used by <see cref="T:Eco.Core.Controller.SyncPropertyInfo" /> instead of the property getter.
/// When added manually then user code is responsible for cached value invalidation. May be preferred over auto-weaving when cached value is immutable or class doesn't match auto-weaving conditions.
/// <example><code><![CDATA[
/// public class Foo
/// {
///     BSONCachedValue CachedItems { get; set; }
///     [SyncToView(SyncFlags.Cached), BsonCachedProperty("CachedItems")] public List<Item> Items { get; }
///     public Foo(IEnumerable<Item> items)
///     {
///        this.Items = items.ToList();
///        this.CachedItems = BSONCachedValue.Cache(this.Items.ToBson());
///     }
/// }
/// ]]></code></example>
/// Read more details about auto-caching in `Eco.Fody/README.md`.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class BsonCachedPropertyAttribute : Attribute
{
  /// <summary>Name of cached property which will be used instead of the property during view synchronization.</summary>
  public string CachedPropertyName { get; }

  public BsonCachedPropertyAttribute(string cachedPropertyName);
}
