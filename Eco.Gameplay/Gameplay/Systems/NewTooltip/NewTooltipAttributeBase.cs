// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.NewTooltipAttributeBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

public abstract class NewTooltipAttributeBase : Attribute
{
  public CacheAs CacheMode;
  public TTFlags Flags;
  public Type OverrideType;
  public Type[] IgnoreType;

  protected NewTooltipAttributeBase(
    CacheAs cacheMode,
    TTFlags flags,
    Type overrideType,
    Type[] ignoreType);

  /// <summary>Creates tooltip part instance that represents tooltip part defined by this attribute and member it's applied to.</summary>
  public abstract TooltipPartBase CreatePartInstance(MemberInfo member, Type rootType);

  /// <summary>Chech whether the specified type is ignored and doesn't really have this tooltip.</summary>
  public bool IsIgnoredType(Type type);
}
