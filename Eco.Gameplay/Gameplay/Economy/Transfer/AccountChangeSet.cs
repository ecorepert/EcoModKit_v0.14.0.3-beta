// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transfer.AccountChangeSet
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Economy.Transfer;

/// <summary> A class used by transfers to track requested changes for account holdings.
/// This allows to perform several transfers within a single pack and check their final result without caring what was happening (and in which order) inbetween.
/// Every change set is bound to not-yet-disposed game action pack. </summary>
public class AccountChangeSet : IGameActionPackChangeSet
{
  public bool NeedsDispose { get; }

  /// <summary> Tries to add new change request. </summary>
  public Result AddChange(
    BankAccount source,
    BankAccount target,
    Currency currency,
    float delta,
    LocString transferDesc);

  /// <summary> Performs the changes without any checks.</summary>
  public void Apply();

  /// <summary>Sum together the current deltas around the given account to get a total delta. O(1) via the running cache.</summary>
  public float GetCurrentDelta(BankAccount account, Currency currency);

  /// <summary> Ensures that this change set will not result negative holdings. </summary>
  ///  // TODO: Pre-test for already existing negative holdings?
  public Result Verify();

  public LocString GameActionPackPostEffect();

  public Result GameActionPackPretest();

  public void GameActionPackDispose();

  /// <summary> A container for requested changes. </summary>
  protected struct AccountChange
  {
    public BankAccount Source { get; set; }

    public BankAccount Target { get; set; }

    public Currency Currency { get; set; }

    public float Delta { get; set; }

    public LocString TransferDesc { get; set; }
  }
}
