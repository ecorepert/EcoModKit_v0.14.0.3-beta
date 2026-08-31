// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.CivicPowersManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

/// <summary>Helpers for determining a user's 'Civic Powers', which is the various governmental actions they are
/// allowed to take, based on the settlement (used to be called Civic Duties).</summary>
public static class CivicPowersManager
{
  /// <summary>Called when powers change for a user for a given settlement.</summary>
  public static ThreadSafeAction<Settlement, IEnumerable<User>> CivicPowersChangedEvent;

  /// <summary>Subscribe to civic powers for a given settlement only.</summary>
  public static void WatchCivicPowersAndCall(
    ISubscriptions<ThreadSafeSubscriptions> subs,
    Func<Settlement> watchingSettlement,
    Action callback);

  public static void WatchCivicPowers(
    ISubscriptions<ThreadSafeSubscriptions> subs,
    Func<Settlement> watchingSettlement,
    Action callback);

  public static void Initialize();

  /// Civic Powers
  ///             <summary>Returns a multiline description for a list of types, ignoring non-constitutional types.</summary>
  /// <param name="isSettlementFromJurisdiction">True if settlement was selected using jurisdiction component. False if it was selected based on position.</param>
  public static LocString GetPowersDesc(
    Settlement settlement,
    User user,
    IEnumerable<Type> types,
    bool isSettlementFromJurisdiction);

  /// <summary>Returns an enumerable corresponding to the passed types, listing the powers the given user has in the given settlement for each action in that list.</summary>
  public static IEnumerable<Eval<CivicPowerFlags>> GetPowers(
    Settlement settlement,
    User user,
    IEnumerable<Type> types);

  /// <summary>Returns what powers the given users has for the given civic type (can be a Civic Action or an IPropsoable type),
  /// within the given settlement.</summary>
  public static Eval<CivicPowerFlags> GetCivicPower(
    this Settlement settlement,
    User user,
    Type type);

  /// <summary>When editing an IProposable, we color the button based on what civic power we have, execution or election.</summary>
  public static (Color Color, LocString Text) GetSubmitButtonText(
    User user,
    Settlement settlement,
    Type type,
    LocString actionText,
    LocString typeName);

  /// <summary>In QA mode, we periodically check to make sure that the last civic powers we made are what we expected them to be.</summary>
  public static void DoPeriodicErrorCheck();
}
