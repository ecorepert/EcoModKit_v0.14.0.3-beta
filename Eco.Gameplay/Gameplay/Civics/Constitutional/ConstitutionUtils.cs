// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.ConstitutionUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

public static class ConstitutionUtils
{
  /// Civic Power Types
  public const string CanBeInConstitution = "CanBeInConstitution";
  public static Tag CanBeInConstitutionTag;
  public static HashSet<Type> ConstitutionalCivicTypes;

  public static void Initialize();
}
