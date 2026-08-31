// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.AuthUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Objects;
using System;

#nullable enable
namespace Eco.Gameplay.Utils;

/// <summary>Static utility methods for working with the authorization component.</summary>
public static class AuthUtils
{
  /// <summary>Checks if the player has the required permissions to use the bank account. If not disable the WorldObject instance via its <see cref="T:Eco.Gameplay.Components.OnOffComponent" />.</summary>
  /// <param name="owner">Owner(s) to check for <see cref="T:Eco.Gameplay.Economy.BankAccount" /> access/ownership.</param>
  /// <param name="onOff"><see cref="T:Eco.Gameplay.Components.OnOffComponent" /> instance to toggle off when authorization fails.</param>
  /// <param name="account">The <see cref="T:Eco.Gameplay.Economy.BankAccount" /> to verify owner acesss.</param>
  /// <param name="handleCheckFail">Optional Action for running custom logic when the auth check fails.</param>
  public static void CheckBankAccountAndToggle(
    IAlias owner,
    OnOffComponent onOff,
    BankAccount account,
    Action? handleCheckFail = null);

  /// <inheritdoc cref="M:Eco.Gameplay.Utils.AuthUtils.CheckBankAccountAndToggle(Eco.Gameplay.Aliases.IAlias,Eco.Gameplay.Components.OnOffComponent,Eco.Gameplay.Economy.BankAccount,System.Action)" />
  /// <param name="credit">CreditComponent instance to operate on as our bank account instance.</param>
  public static void CheckBankAccountAndToggle(
    IAlias owner,
    OnOffComponent onOff,
    CreditComponent credit,
    Action? handleCheckFail = null);

  /// <summary>True if the stored account can still be used by the object's owners or by its placer. Persistent item data carries account
  /// references across pickup and re-placement, so when this fails the account belongs to a prior owner and must not stay on the object.</summary>
  public static bool AccountUsableByOwnersOrPlacer(WorldObject parent, BankAccount? account);
}
