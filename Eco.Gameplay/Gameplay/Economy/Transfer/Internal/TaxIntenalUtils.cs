// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transfer.Internal.TaxIntenalUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;

#nullable disable
namespace Eco.Gameplay.Economy.Transfer.Internal;

public static class TaxIntenalUtils
{
  /// <summary>Try to pay tax into the given pack. May return failure.</summary>
  public static Result AddTaxPaymentsBasedOnTransferData(TransferData data, GameActionPack pack);

  public static float CalculateTax(TransferData data);
}
