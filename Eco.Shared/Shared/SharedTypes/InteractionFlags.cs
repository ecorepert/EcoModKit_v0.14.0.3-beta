// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.InteractionFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.SharedTypes;

[Flags]
public enum InteractionFlags
{
  BlocksOtherInteraction = 1,
  NoTargetRequired = 2,
  MustNotHaveTarget = 4,
  SendsInteractImmediatelyButStillAnimates = 8,
  CanTriggerOnSameTarget = 16, // 0x00000010
  SkipTargetObjectHighlight = 32, // 0x00000020
  SurfacePlacedSpecialHierarchyAuth = 64, // 0x00000040
  ContinuousWhileHeld = 128, // 0x00000080
}
