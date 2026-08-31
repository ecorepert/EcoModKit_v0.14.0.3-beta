// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.SettlementInternalUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Settlements.Internal;

/// <summary>Utils meant to only be used by settlement system.</summary>
internal static class SettlementInternalUtils
{
  public static string MakeLeaderName(SettlementType type);

  public static string MakeSettlementName(SettlementType type);

  public static LocString MakeCitizenshipName(Settlement settlement);

  /// <summary>Check if any influence is neighboring a plot influenced by the other.</summary>
  public static bool InfluencesTouch(Settlement source, IAnnexable target);

  public static Color GetRandomSettlementColor();
}
