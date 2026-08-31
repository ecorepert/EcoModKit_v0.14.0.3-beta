// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementFactory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Creating and destroying settlements.</summary>
public static class SettlementFactory
{
  /// <summary>Create a brand new settlement and fill it in, and create extra parts like leaders and immigration.</summary>
  public static Settlement CreateSettlement(
    WorldObject hostObj,
    User creator,
    SettlementType settlementType,
    Demographic existingDemographic,
    ElectionProcess existingElectionProcess,
    bool createImmigrationPolicy = true,
    bool createLeaderTitle = true,
    bool createConstitution = true,
    string name = null,
    bool addCurrentSettlementsAsChildAndParent = true);

  public static LocString ApplyDefaultSettlementSetup(
    Settlement settlement,
    bool createImmigrationPolicy,
    bool createLeaderTitle,
    bool createConstitution,
    bool resetAll = false);
}
