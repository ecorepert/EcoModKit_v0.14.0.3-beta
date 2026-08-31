// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.DinnerPartyTooltips
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Settlements.Culture;

[TooltipLibrary]
public static class DinnerPartyTooltips
{
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 190, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DinnerPartyStatusTooltip(this DinnerParty party);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 200, TTCat.Default, TTFlags.None, null, new Type[] {})]
  [TooltipAffectedBy(true)]
  public static LocString DinnerPartyTooltip(this DinnerParty party);
}
