// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementPropertyUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Voxel;
using System;

#nullable disable
namespace Eco.Gameplay.Settlements;

public static class SettlementPropertyUtils
{
  /// <summary>Look at all immigration policies on settlements at the given location and see if youre allowed to claim land here.</summary>
  /// <param name="associatedSettlement">this is set if claiming on a claim stake that is associated to a particular settlement.</param>
  public static Result ShouldAllowClaim(
    User user,
    Settlement associatedSettlement,
    PlotPos pos,
    Type itemUsedToClaim);
}
