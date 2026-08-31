// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MemberwiseEqualityObject
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Base class that provides a dynamic, memberwise Equals/GetHashCode
/// implementation. Rather than using reflection, methods are created
/// using compiled expression trees.
/// </summary>
public class MemberwiseEqualityObject
{
  /// <summary>Returns the member-wise hash code for this instance.</summary>
  /// <returns></returns>
  public override int GetHashCode();

  /// <summary>
  /// Determines whether two instances are equal, using a member-wise comparison.
  /// </summary>
  /// <param name="obj"></param>
  /// <returns></returns>
  public override bool Equals(object obj);

  /// <summary>Used to hold delegates for the compiled methods.</summary>
  private class MemberwiseFunctions
  {
    /// <summary>Delegate for the Equals method.</summary>
    public Func<object, object, bool> EqualsFunc;
    /// <summary>Delegate for the GetHashCode method.</summary>
    public Func<object, int> GetHashCodeFunc;
  }
}
