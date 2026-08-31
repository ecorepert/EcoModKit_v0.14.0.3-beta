// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionTests
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.GameActions;

[ChatCommandHandler]
public static class GameActionTests
{
  [CITest(false)]
  [ChatSubCommand("Civics", "Tests all the actions in the game by making laws for them and performing them.", ChatAuthorizationLevel.DevTier)]
  public static 
  #nullable disable
  Task TestGameActions(User user);

  public static void TestAddToWorkOrderAction(User mainUser);

  public static void TestMintCurrency(User mainUser);

  public static void TestCreateCurrency(User mainUser);

  public static Task TestCurrencyTrade(User mainUser);

  public static Task TestBarterTrade(User mainUser);

  public static void TestDemographicChange(User mainUser);

  public static void TestClaimOrUnclaimProperty(User mainUser);

  public static void TestPayTax(User mainUser);

  public static void TestReceiveGovernmentFunds(User mainUser);

  public static void TestPlay(User mainUser);

  public static void TestFirstLogin(User mainUser);

  public static void TestChatSent(User mainUser);

  public static void TestPolluteAir(User mainUser);

  public static void TestDropGarbage(User mainUser);

  public static void TestConstructOrDeconstruct(User mainUser);

  public static void TestCreateWorkOrder(User mainUser);

  public static void TestChopTree(User mainUser);

  public static void TestChopStump(User mainUser);

  public static void TestHarvestOrHunt(User mainUser);

  public static void TestPlantSeeds(User mainUser);

  public static void TestSpecialtyLevelUp(User mainUser);

  public static void TestCharacterLevelUp(User mainUser);

  public static void TestGainProfession(User mainUser);

  public static void TestGainSpecialty(User mainUser);

  public static void TestVote(User mainUser);

  public static void TestStartElection(User mainUser);

  public static void TestJoinOrLeaveElection(User mainUser);

  public static void TestWonElection(User mainUser);

  public static void TestLostElection(User mainUser);

  public static void TestDigOrMine(User mainUser);

  public static void TestPropertyTransfer(User mainUser);

  public static void TestTransferMoney(User mainUser);

  public static void TestPostedContract(User mainUser);

  public static void TestJoinedContract(User mainUser);

  public static void TestCompletedContract(User mainUser);

  public static void TestFailedContract(User mainUser);

  public static void TestOfferedLoanOrBond(User mainUser);

  public static void TestAcceptedLoanOrBond(User mainUser);

  public static void TestRepaidLoanOrBond(User mainUser);

  public static void TestDefaultedOnLoanOrBond(User mainUser);

  public static void TestPostedWorkParty(User mainUser);

  public static void TestJoinedWorkParty(User mainUser);

  public static void TestLeftWorkParty(User mainUser);

  public static void TestWorkedForWorkParty(User mainUser);

  public static void TestCompletedWorkParty(User mainUser);

  public static void TestCompletedWorkPartyTemplate(User mainUser, Type actionType);

  public static void TestTimer(User mainUser);

  public static void TestTampRoad(User mainUser);

  public static void TestPlowField(User mainUser);

  public static void TestDropOrPickupBlock(User mainUser);

  public static void TestOpenAction(User mainUser);

  public static void TestCleanupTreeDebris(User mainUser);

  public static void TestLaborWorkOrderAction(User mainUser);

  public static void TestCitizenTimer(User mainUser);

  public static void TestGlobalTimer(User mainUser);

  public static void TestItemCraftedAction(User mainUser);

  public static void TestProduceGarbage(User mainUser);

  public static void TestDidntVote(User mainUser);
}
