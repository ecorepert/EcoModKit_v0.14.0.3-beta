// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.CacheAs
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Defines different caching modes tooltip part can use.</summary>
[Serialized]
[Flags]
public enum CacheAs
{
  /// <summary>Disable caching for tooltip part entirely (on server and on client).</summary>
  /// <remarks>When this flag is set all other flags should not be used.</remarks>
  Disabled = 1,
  /// <summary>Cache tooltip part for every instance of a type individually.</summary>
  /// <remarks>Can be combined with <see cref="F:Eco.Shared.Items.CacheAs.User" /> flag to also disable server-side cache.</remarks>
  Instance = 2,
  /// <summary>Cache tooltip part for every user individually.</summary>
  /// <remarks>Disables caching for tooltip part on server causing it to only be cached on client.</remarks>
  User = 4,
  /// <summary>Create only one cache entry for tooltip part and use it for all instances and users.</summary>
  /// <remarks>When this flag is set all other flags should not be used.</remarks>
  Global = 8,
  /// <summary>Create separate cache entry for every type derived from the type that defines tooltip part and share those entries among instances of their respective types.</summary>
  /// <remarks>Can be combined with <see cref="F:Eco.Shared.Items.CacheAs.User" /> flag to also disable server-side cache. Can not be used with instance members or for extension methods.</remarks>
  SubType = 16, // 0x00000010
}
