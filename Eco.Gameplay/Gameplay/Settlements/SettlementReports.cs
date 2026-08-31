// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementReports
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Settlements;

public static class SettlementReports
{
  /// <summary>Get a description of what children settlements of the given type may be claimed here, and which parent settlements may lay claim to us here.</summary>
  public static (LocString Body, LocString Title) GetSettlementReport(
    User user,
    SettlementType? settlementType,
    Vector2i worldpos);
}
