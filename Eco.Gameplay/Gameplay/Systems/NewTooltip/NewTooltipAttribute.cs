// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.NewTooltipAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>Marks a method, property, or field as a 'TooltipPart'. Tooltip parts will be composed to form the tooltip for a type.</summary>
/// <remarks>See tootlip.md for the full picture.</remarks>
public class NewTooltipAttribute : NewTooltipAttributeBase
{
  public float Priority;
  public TTCat Categories;

  /// <summary>Declares a tooltip part, along with how it is cached.  Tooltip parts must be marked 'dirty' when they're updated, so the clients that are caching them can be informed of the change.</summary>
  /// <param name="cacheMode">How many cache entries should be created? One per instance, user, type, subytpe, etc</param>
  /// <param name="priority">What order is the tooltip part displayed to the client among other tooltip parts (lower value means higher priority)</param>
  /// <param name="categories">Allows defining categories, so certain types of tooltip parts can be excluded in certain situations (IE, we dont want to show 'controls' tooltip parts when showing items in the ecopedia, becasue its not an item you can control)</param>
  /// <param name="flags">Extra flags to control cache-clearing and other behavior</param>
  /// <param name="overrideType">Defining this will set the type that the tooltip part displays on.  By setting this, you can make a tooltip part appear on all objects of a given type.  The tooltip part function can accept a 'Type' param that will send in the type its being executed on.</param>
  public NewTooltipAttribute(
    CacheAs cacheMode,
    int priority = 0,
    TTCat categories = TTCat.Default,
    TTFlags flags = TTFlags.None,
    Type overrideType = null,
    params Type[] ignoreType);

  public override TooltipPartBase CreatePartInstance(MemberInfo member, Type rootType);
}
