// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transfer.TaxUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Economy.Transfer;

/// <summary>Various helpers related to tax</summary>
public static class TaxUtils
{
  /// <summary>Get the taxes at the given position, for the named property of SettlementTaxes.</summary>
  public static void TaxesAtPosition(Vector3i pos, string taxType, LocStringBuilder sb);
}
