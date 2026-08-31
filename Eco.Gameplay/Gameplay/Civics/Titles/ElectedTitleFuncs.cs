// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.ElectedTitleFuncs
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;

#nullable disable
namespace Eco.Gameplay.Civics.Titles;

public static class ElectedTitleFuncs
{
  public static bool CanChangeTreasuryTaxes(this User user, Settlement settlement);

  public static bool HasGovernmentBankingPrivileges(this User user, Settlement settlement);

  public static bool HasDiplomaticPrivileges(this User user, Settlement settlement, bool notify);

  public static bool CanChangeSettlementMarkers(
    this User user,
    Settlement settlement,
    out ElectedTitle title);
}
