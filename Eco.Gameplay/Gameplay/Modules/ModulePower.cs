// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModulePower
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Maps between <see cref="T:Eco.Gameplay.Modules.ModulePowerType" /> and the grid's <see cref="T:Eco.Gameplay.Components.IPowerEnergyType" /> instances.</summary>
public static class ModulePower
{
  public static IPowerEnergyType ToEnergyType(ModulePowerType type);

  public static ModulePowerType FromEnergyType(IPowerEnergyType type);
}
