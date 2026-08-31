// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ExpressionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Linq.Expressions;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Utility and helper methods for <see cref="T:System.Linq.Expressions.Expression" />.</summary>
public static class ExpressionUtils
{
  /// <summary>Creates indexed property expression (e.g. instance[index]).</summary>
  public static Expression IndexedProperty(Expression instance, string index);
}
