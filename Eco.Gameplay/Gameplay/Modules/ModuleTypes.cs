// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModuleTypes
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Carried by every auto-generated module class via <c>base(ModuleTypes.X | ModuleTypes.Y, ...)</c>; does not influence slot identity. Slot identity comes from the item's slot tag (one of <c>BasicModule</c>, <c>AdvancedModule</c>, <c>ModernModule</c>, <c>SpecialtyModule</c>) -- see <see cref="T:Eco.Gameplay.Modules.ModuleTags" />.</summary>
[Flags]
[Serialized]
[Localized(true, false, "", false)]
public enum ModuleTypes
{
  None = 0,
  ResourceEfficiency = 1,
  SpeedEfficiency = 2,
  LaborReservation = 4,
  PowerGrid = 8,
}
