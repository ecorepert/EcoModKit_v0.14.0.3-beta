// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModulePowerType
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Power a module requires of its host. Ordered by the int value: a host with several modules adopts the highest (most advanced) one. Designers assign these per module; reorder the values if the tier order should change.</summary>
public enum ModulePowerType
{
  None,
  Heat,
  Mechanical,
  Electric,
}
