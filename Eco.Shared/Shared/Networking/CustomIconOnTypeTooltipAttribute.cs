// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.CustomIconOnTypeTooltipAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>
/// Use to have a property prepended with an icon different than its type's.
/// <para>Example: Alias has no icon of its own, but we want it to appear with the icon of 'Demographics', so we apply [CustomIconOnTypeTooltip(typeof(Demographics))].</para>
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CustomIconOnTypeTooltipAttribute : Attribute
{
  public Type IconType;

  /// <param name="type"> Type to inherit the icon from. </param>
  public CustomIconOnTypeTooltipAttribute(Type type);
}
