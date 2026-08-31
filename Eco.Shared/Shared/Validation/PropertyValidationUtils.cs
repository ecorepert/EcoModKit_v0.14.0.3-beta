// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Validation.PropertyValidationUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Validation;

/// <summary>Utilities to work with ValidationAttribute. Could be used on client.</summary>
public static class PropertyValidationUtils
{
  /// <summary>Tries to fix all values to fit it's RangeAttribute's restrictions.</summary>
  /// <param name="propertyContainer">Iterates through propertyContainer properties with RangeAttribute set.</param>
  /// <returns>Returns true if object has invalid values and was modified</returns>
  public static bool ClampRangeFloatValues(object propertyContainer);

  /// <summary>Tests if object's property contains float RangeAttribute and tries to fix that. Produces error message if invalid object was found.</summary>
  /// <param name="propertyContainer">Object with given property</param>
  /// <param name="propertyName">Propery name to test</param>
  /// <returns>Returns true if object has invalid values and was modified</returns>
  public static bool ClampRangeFloatValue(object propertyContainer, string propertyName);

  /// <summary>Get object's given property float range restrictions. If it has not RangeAttribute of valid float values returns whole float range.</summary>
  /// <param name="propertyContainer">Object with given property</param>
  /// <param name="propertyName">Property name to test</param>
  /// <returns>Returns effective float range</returns>
  public static (float Min, float Max) GetPropertyFloatRange(
    object propertyContainer,
    string propertyName);
}
