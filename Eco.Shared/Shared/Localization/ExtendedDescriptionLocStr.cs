// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.ExtendedDescriptionLocStr
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>Add more details that will only be shown in larger info panels for a type.</summary>
public class ExtendedDescriptionLocStr : DescriptionAttribute
{
  /// <summary> Non-resolved <see cref="T:Eco.Shared.Localization.LocString" /> value for the description. </summary>
  public LocString LocDescription { get; }

  public ExtendedDescriptionLocStr(string description);
}
