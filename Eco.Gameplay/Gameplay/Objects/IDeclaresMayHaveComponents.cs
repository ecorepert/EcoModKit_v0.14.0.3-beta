// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.IDeclaresMayHaveComponents
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>Implemented by a component that declares additional (Type, Name) keys which should be treated as may-have during ValidateComponents, so dynamically-installed sibling components survive save/load.</summary>
public interface IDeclaresMayHaveComponents
{
  IEnumerable<(Type Type, string Name)> ExpectedComponents { get; }
}
