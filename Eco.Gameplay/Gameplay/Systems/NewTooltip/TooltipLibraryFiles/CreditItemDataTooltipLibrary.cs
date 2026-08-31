// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.CreditItemDataTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Components;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class CreditItemDataTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (CreditItemData), "Currency", null, null)]
  [TooltipAffectedBy(typeof (CreditItemData), "FeePerMinute", null, null)]
  [TooltipAffectedBy(typeof (CreditItemData), "FeePerItem", null, null)]
  [TooltipAffectedBy(typeof (CreditItemData), "BankAccount", null, null)]
  [TooltipAffectedBy(typeof (CreditItemData), "SelectedBankAccountRenamedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 145, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString FeeTooltip(this CreditItemData creditItemData, TooltipOrigin origin);
}
