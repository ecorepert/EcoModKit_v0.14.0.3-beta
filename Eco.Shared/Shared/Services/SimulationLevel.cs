// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.SimulationLevel
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Services;

public enum SimulationLevel
{
  [LocDescription("Citizens can carry way more than reality, and craft time is much reduced.")] Generous,
  [LocDescription("Citizens can carry a bit more than reality, and craft times are normal.")] Normal,
  [LocDescription("Citizens can carry the same amount as in reality, and craft times reflect real times.")] Hardcore,
}
