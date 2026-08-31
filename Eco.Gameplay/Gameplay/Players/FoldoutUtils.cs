// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.FoldoutUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Players;

public static class FoldoutUtils
{
  [RPC]
  public static TooltipSection GetAllObjectsTooltip(this Player player, string itemTypeName);

  [RPC]
  public static TooltipSection BalancedDietMultDescRPC(this Player player);

  [RPC]
  public static TooltipSection VarietyMultDescRPC(this Player player);

  [RPC]
  public static TooltipSection TastinessMultDescRPC(this Player player);
}
