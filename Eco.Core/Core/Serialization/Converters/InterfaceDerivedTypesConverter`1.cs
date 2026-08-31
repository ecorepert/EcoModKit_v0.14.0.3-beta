// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Converters.InterfaceDerivedTypesConverter`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.ComponentModel;
using System.Globalization;

#nullable enable
namespace Eco.Core.Serialization.Converters;

/// <summary>Custom <see cref="T:System.ComponentModel.TypeConverter" /> for converting derived types to and from strings for use with the Eco server configuration UI</summary>
/// <typeparam name="TType">Base Interface to generated derrived options from.</typeparam>
/// <remarks>
/// To utilize the InterfaceDerivedTypesConverter for type selection create your property as normal then mark it with the TypeConverter attribute passing
/// the type of the InterfaceDerivedTypesConverter as its first parameter.
/// </remarks>
/// <seealso cref="T:System.ComponentModel.ExpandableObjectConverter" />
public class InterfaceDerivedTypesConverter<TType> : ExpandableObjectConverter
{
  /// <summary>
  /// Gets a value indicating whether this converter can convert an object in the
  /// given source type to a string using the specified context.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType);

  /// <summary>Returns wether this converter can convert the object to specified type,  using the context specified.</summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType);

  public override bool GetStandardValuesSupported(ITypeDescriptorContext? context);

  public override bool GetStandardValuesExclusive(ITypeDescriptorContext? context);

  /// <summary>
  /// Overridable method for creating the user selected <see cref="T:System.Type" /> instance. Intended for custom derived type converter
  /// implementations.
  /// </summary>
  /// <param name="name">Name of the derived type being created</param>
  /// <param name="derivedType">Type of the object that needs to be created</param>
  /// <returns>Newly created type instance or null if invalid</returns>
  protected virtual object? CreateDerivedTypeInstance(string name, Type derivedType);

  public override object? ConvertFrom(
    ITypeDescriptorContext? context,
    CultureInfo? culture,
    object value);

  public override object? ConvertTo(
    ITypeDescriptorContext? context,
    CultureInfo? culture,
    object? value,
    Type destinationType);

  /// <summary>Creates a <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> containing all the names of our derrived types for displaying to the user</summary>
  public override TypeConverter.StandardValuesCollection GetStandardValues(
    ITypeDescriptorContext? context);
}
