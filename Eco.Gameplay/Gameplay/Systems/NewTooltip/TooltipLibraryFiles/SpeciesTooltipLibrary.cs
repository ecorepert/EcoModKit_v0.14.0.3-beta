// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.SpeciesTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class SpeciesTooltipLibrary
{
  [NewTooltipTitle(CacheAs.Instance, 20, TTCat.Default, TTFlags.None, null, "")]
  public static LocString SpecieTitle(this SpeciesTooltip species);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 90, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SpeciesDescription(this SpeciesTooltip speciesTooltip);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PopulationTooltip(this SpeciesTooltip speciesTooltip);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ResourcesTooltip(this SpeciesTooltip speciesTooltip, TooltipOrigin origin);
}
