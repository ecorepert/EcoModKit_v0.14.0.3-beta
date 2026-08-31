// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.GeneralUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

public static class GeneralUtils
{
  /// <summary>Tests if a given value is the default.  Used for structs. </summary>
  public static bool IsDefault<T>(this T value) where T : struct;

  /// <summary>We check whether the definition of a generic type is actually generic or not. This will also return true when the generic type has all its arguments as generic.</summary>
  public static bool TypeIsFullyGeneric(this Type type);

  /// <summary>We check whether the current type is the generic type definition of the specified type or any of its parents.</summary>
  public static bool IsGenericDefinitionOfType(this Type rootType, Type type);
}
