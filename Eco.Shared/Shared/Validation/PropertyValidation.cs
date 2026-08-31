// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Validation.PropertyValidation
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Validation;

public static class PropertyValidation
{
  public static void CorrectProperty(object propertyContainer, string propertyName);

  public static bool ValidateProperty(
    object value,
    PropertyDescriptor propertyDescriptor,
    out string message);

  public static bool ValidateAndCorrectProperty(
    object propertyContainer,
    string propertyName,
    out string message);

  public static void ValidateAndCorrectObject(object propertyContainer);
}
