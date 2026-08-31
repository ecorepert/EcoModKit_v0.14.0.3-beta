// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.NewTooltipChildrenAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>
/// Use on properties returning one or more objects of type that implements IController interface.
/// Objects returned by this member will have their tooltip members included along with
/// this object's tooltip.  Adding a <see cref="F:Eco.Gameplay.Systems.NewTooltip.NewTooltipChildrenAttribute.ExcludeCategories" /> as a parameter
/// to the attribute will filter tooltips of that type from the child(ren) for this object's tooltip.
/// </summary>
/// <remarks>If the child value is going to be updated during runtime and we want the child tooltip to reflect that, the parent class should implement <see cref="T:System.ComponentModel.INotifyPropertyChanged" />.</remarks>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = true)]
public class NewTooltipChildrenAttribute : NewTooltipAttributeBase
{
  public TTCat ExcludeCategories;

  public NewTooltipChildrenAttribute(CacheAs cacheMode);

  public NewTooltipChildrenAttribute(CacheAs cacheMode, TTCat excludeCategories);

  public NewTooltipChildrenAttribute(
    CacheAs cacheMode,
    TTCat excludeCategories = TTCat.None,
    TTFlags flags = TTFlags.None,
    Type overrideType = null,
    params Type[] ignoreType);

  public override TooltipPartBase CreatePartInstance(MemberInfo member, Type rootType);
}
