// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.DeedTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class DeedTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy("Deed", "MarkedUpName", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 10, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ClaimToolTooltip(this 
  #nullable disable
  ClaimToolBaseItem tool);

  [TooltipAffectedBy("Name", null, null)]
  [TooltipAffectedBy("Color", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString DeedTooltipTitle(this Deed deed);

  [TooltipAffectedBy(typeof (Deed), "CachedInfluencingSettlement", null, null)]
  [TooltipAffectedBy(typeof (Deed), "OwnedObjectRenamedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 10, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PropertyDesriptionTooltip(this Deed deed);

  [TooltipAffectedBy(typeof (Deed), true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 20, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DeedTable(this Deed deed);

  [TooltipAffectedBy(typeof (Deed), "WarningsDescription", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 5, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DeedsWarnings(this Deed deed);
}
