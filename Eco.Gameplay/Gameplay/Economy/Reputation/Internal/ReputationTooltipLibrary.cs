// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.Internal.ReputationTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation.Internal;

[TooltipLibrary]
public static class ReputationTooltipLibrary
{
  public static void Initialize();

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString ReputationTooltipTitle(this Eco.Gameplay.Economy.Reputation.Internal.Reputation reputation);

  [TooltipAffectedBy("ReputationChangedEvent", null, null)]
  [TooltipAffectedBy("CachedTotalReputation", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 100, TTCat.Default, TTFlags.None, null, new Type[] {}, Flags = TTFlags.ClearCacheForAllUsers)]
  public static LocString RepTooltip(this Eco.Gameplay.Economy.Reputation.Internal.Reputation reputation, User user);
}
