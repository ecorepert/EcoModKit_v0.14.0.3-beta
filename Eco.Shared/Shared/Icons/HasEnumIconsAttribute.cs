// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Icons.HasEnumIconsAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Shared.Icons;

/// <summary>Use this attribute to mark an Enum if every name in it should be used as an Icon. E.g. <see cref="T:Eco.Shared.Icons.IconUtils.SymbolicIcons" />. They will respectively appear in the Icon Scene with the Enum name or GroupName category.</summary>
public class HasEnumIconsAttribute : Attribute
{
  public string GroupName { get; }

  public HasEnumIconsAttribute(string groupName = null);

  public static (string Name, LocString Comment)[] IconsNames<T>() where T : Enum;
}
