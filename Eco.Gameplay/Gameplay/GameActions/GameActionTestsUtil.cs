// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionTestsUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Civics.Laws.LegalActions.Money;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable enable
namespace Eco.Gameplay.GameActions;

public static class GameActionTestsUtil
{
  public static 
  #nullable disable
  CivicObjectComponent LawContainer { get; set; }

  public static CraftingComponent TestTable { get; }

  public static float GetTestContractPaymentAmount(Currency currency = null, bool minusTax = true);

  public static float GetTestLawPaymentAmount(Currency currency = null, bool minusTax = true);

  public static float GetTestDebtAmount(Currency currency = null, bool minusTax = true);

  public static Pay_LegalAction TestPayLegalAction(User client, User contractor);

  public static Law CreatePreventingLawForGameAction(Type actionType, User user);

  public static Law CreatePayingLawForGameAction(Type actionType, User client, User contractor);

  public static Law CreateTestLaw(Type actionType, User user, LegalAction effect = null, bool makeActive = true);

  public static void ClearTestsCache();

  public static bool TestLevelUp(User mainUser, out ToolItem tool);

  public static Contract CreateTestContract(User client, Type clauseType, User contractor = null);

  public static Contract CreateTestContract(User client, ContractClause clause, User contractor = null);

  public static Contract CreateTestContract(User client, ContractClause[] clauses = null, User contractor = null);

  public static void GiveItemInventorySelect(User user, string itemName = "");

  public static MintComponent GetOrCreateTestMint(User user, bool setCurrency = true);

  public static TreasuryComponent GetOrCreateTestTreasury(User user, bool setCurrency = true);

  public static void CheckAndDisposeAll(
    Result result,
    Type actionType,
    Law law,
    Contract contract = null,
    WorkParty party = null,
    bool isPreventedLaw = true);

  public static void CheckOrThrowError(
    Law law,
    Type actionType,
    Result result,
    bool isPreventedLaw = true);

  public static ContractClause CreateTestClause(Type clauseType, User client, User contractor = null);

  public static WorkParty CreateTestPartyThrow(User client, Vector3i pos, RecipeFamily recipe = null);

  public static (WorkParty Party, Result Result) CreateTestParty(
    User client,
    Vector3i pos,
    RecipeFamily recipe = null);

  public static BSONObject TradeDataBSON(StoreComponent store);

  public static BSONArray TrafeOfferBSON(StoreComponent store, bool buying, int requestedAmount);
}
