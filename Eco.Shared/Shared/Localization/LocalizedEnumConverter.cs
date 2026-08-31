// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocalizedEnumConverter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.ComponentModel;
using System.Globalization;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>
/// Used to enable localized enum values in PropertyGrids.
/// Can also be manually added to any enum to override the default behaviour when casting to a string.
/// </summary>
public class LocalizedEnumConverter : EnumConverter
{
  public LocalizedEnumConverter(Type type);

  public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);

  public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);

  public override object ConvertTo(
    ITypeDescriptorContext context,
    CultureInfo culture,
    object value,
    Type destinationType);

  public override object ConvertFrom(
    ITypeDescriptorContext context,
    CultureInfo culture,
    object value);
}
