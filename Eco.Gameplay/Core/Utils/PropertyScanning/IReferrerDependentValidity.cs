// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.IReferrerDependentValidity
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

/// <summary>Defines a validity to be used when item is referenced by something else.</summary>
public interface IReferrerDependentValidity : ICustomValidity, IValidity
{
  /// <summary>
  /// Check if valid for types that refer to this item.  IE, some references to a given object may be valid while others invalid, depending on who's referring to it.
  /// </summary>
  /// <param name="referrerType">The immediate parent of the item.</param>
  /// <param name="referrerRootType">The root object this item belongs to.</param>
  Result Valid(Type referrerType, Type referrerRootType);
}
