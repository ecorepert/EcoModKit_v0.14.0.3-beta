// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Delegates
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Helper methods for delegates.</summary>
public static class Delegates
{
  /// <summary>Atomic thread-safe alternative to += operator.</summary>
  public static void InterlockedAddAssign<TDelegate>(ref TDelegate? del, TDelegate action) where TDelegate : Delegate;

  /// <summary>Atomic thread-safe alternative to -= operator.</summary>
  public static void InterlockedSubtractAssign<TDelegate>(ref TDelegate? del, TDelegate action) where TDelegate : Delegate;
}
