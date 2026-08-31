// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transfer.Transfers
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Economy.Transfer;

public static class Transfers
{
  /// <summary> Values within this cap will be considered as zero. </summary>
  public const float AlmostZero = 0.005f;
  public static ThreadSafeAction<Currency, float> OnTransferred;
  public static ThreadSafeAction<User, Currency, float> TaxPaidEvent;

  public static Result TransferNow(User userToNotify, TransferData data);

  public static LocString DescribeResult(
    this (ValResult<float> Result, float Tax) result,
    Currency currency);

  /// <summary>Add transfers to the game action pack.  Tax is paid on top. Returns full amount paid, including tax, and result message.</summary>
  public static (ValResult<float> Result, float Tax) Transfer(
    GameActionPack pack,
    TransferData data);
}
