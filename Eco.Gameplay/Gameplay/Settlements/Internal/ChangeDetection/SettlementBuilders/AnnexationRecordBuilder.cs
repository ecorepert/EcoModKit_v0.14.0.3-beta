// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.ChangeDetection.SettlementBuilders.AnnexationRecordBuilder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Settlements.Annexation;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Settlements.Internal.ChangeDetection.SettlementBuilders;

public static class AnnexationRecordBuilder
{
  /// <summary>Update ability of all settlements to annex another, ooking only at given settlements. Null means check all.</summary>
  public static void RecalcAnnexRecords(
  #nullable disable
  IEnumerable<Settlement> dirtySettlementSet = null);

  public static void RemoveAnnexable(IAnnexable annexable);

  /// <summary>Evaluate how close one settlement is to annexing another and return the result.  Takes an existing record to update, and creates a new one if null is passed.</summary>
  public static AnnexationRecord CalcRecord(
    AnnexationRecord record,
    Settlement source,
    IAnnexable target);

  public static int GetNeededSettlementPapers(IAnnexable target, int nonAbandonedInTarget);

  private enum WarningLevel
  {
    None,
    Low,
    Medium,
    High,
    CultureMet,
    AnnexMet,
  }
}
