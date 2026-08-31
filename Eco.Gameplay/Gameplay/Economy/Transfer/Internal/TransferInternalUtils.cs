// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transfer.Internal.TransferInternalUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Economy.Transfer.Internal;

public static class TransferInternalUtils
{
  /// <summary> Gets or creates change set for the pack, adds related deltas and composes post-effect. </summary>
  public static void TransferInternal(
    GameActionPack pack,
    float amount,
    Currency currency,
    BankAccount sourceAccount,
    BankAccount targetAccount,
    User sender,
    LocString transferDesc,
    AccountChangeSet pendingChanges);
}
