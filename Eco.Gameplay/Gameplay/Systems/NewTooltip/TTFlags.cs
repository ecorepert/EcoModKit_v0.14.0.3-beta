// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TTFlags
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

[Flags]
public enum TTFlags
{
  None = 0,
  /// <summary>Use this flag for tooltip parts that need to be cached per user, but need to be marked as dirty for all users at once in some cases. If a specific user gets passed when marking a tooltip as dirty then this flag will be ignored.</summary>
  ClearCacheForAllUsers = 1,
  /// <summary>Use this flag for tooltip parts that need to be cached per instance, but need to be marked as dirty for all instances at once in some cases. If a specific instance gets passed when marking a tooltip as dirty then this flag will be ignored.</summary>
  ClearCacheForAllInstances = 2,
  /// <summary>Setting this flag for a tooltip part will cause server to notify clients and server's cache that it was marked as dirty instantly. Normally this happens in intervals defined by <see cref="F:Eco.Gameplay.Systems.NewTooltip.TooltipManagerServer.CacheRefreshRate" />.</summary>
  ForceInstantUpdate = 4,
  /// <summary>Allow <see cref="T:Eco.Gameplay.Systems.NewTooltip.NewTooltipChildrenAttribute" /> to be used with types that doesn't inherit from IController, if you're not sure about what you're doing don't use this.
  /// For example this is used in <see cref="T:Eco.Gameplay.Items.IPersistentData" /> where the type is object but we still want to use this because we are making sure manually that non IController types aren't assigned this attribute.</summary>
  AllowNonControllerTypeForChildren = 8,
  /// <summary>
  /// Setting this type will allow the use of the SubType cache mode with generic classes.
  /// When SubType cache mode is used, all instances of a generic type with a generic argument before runtime will be treated as a single subType meaning :
  /// -&gt; tooltip with "OverrideType: typeof(GenericType'')" and SubType cache mode will have the same cache for all the types (GenericType'int', GenericType'float', etc.)
  /// meaning only the derived types of GenericType'' will have their own caches.
  /// </summary>
  AllowSubTypeCacheForGenericTypes = 16, // 0x00000010
  /// <summary>
  /// Use this flag to allow operating with instance data for SubType cache mode (can be used for instance members or extension methods).
  /// <br>Even though tooltips cached as SubType should never depend on instance data (since it may differ for each instance), sometimes we can be sure that all instances of one type have the same data (e.g. static property).</br>
  /// </summary>
  AllowInstanceForSubTypeCache = 32, // 0x00000020
}
