// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.CurrencyTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Economy;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class CurrencyTooltipLibrary
{
  public static void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TotalTooltip(this Currency currency);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 101, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TotalDebtTooltip(this Currency currency);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString BalancesTooltip(this Currency currency, TooltipOrigin origin);
}
