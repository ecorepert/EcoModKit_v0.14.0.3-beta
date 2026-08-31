// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Gameplay.Settlements;

[ChatCommandHandler]
public static class SettlementCommands
{
  [ChatCommand("Shows commands for controlling settlements.", ChatAuthorizationLevel.DevTier)]
  public static void Settlement(
  #nullable disable
  User user);

  [ChatSubCommand("Settlement", "Shows a report of how neighboring settlements may impact a homestead that is placed at the citizen's current location.", "homesteadreport", ChatAuthorizationLevel.User)]
  public static void HomesteadReport(User user);

  [ChatSubCommand("Settlement", "Shows a report of how neighboring settlements may impact a settlement that is placed at the citizen's current location.  Pass a number to specify settlement type that would be placed (0 = town, 1 = country, etc)", "settlementreport", ChatAuthorizationLevel.User)]
  public static void SettlementReport(User user, int tier);

  [ChatSubCommand("Settlement", "Leave citizenship of whatever settlement you are a citizen of.", "renounce", ChatAuthorizationLevel.User)]
  public static void RenounceCitizenship(User user);

  [ChatSubCommand("Settlement", "Make someone leave citizenship of whatever settlement you they are a citizen of. Pass target or perform on self if not set.", "nocit", ChatAuthorizationLevel.Admin)]
  public static void ForceRenounceCitizenship(User user, User target = null);

  [ChatSubCommand("Settlement", "Make a citizen a resident of the given town. Removes them from the previous settlement.", "emigrate", ChatAuthorizationLevel.DevTier)]
  public static void Emigrate(User user, Eco.Gameplay.Settlements.Settlement target, User citizen);

  [ChatSubCommand("Settlement", "Make a given citizen leave citizenship of a given town.", "vacate", ChatAuthorizationLevel.DevTier)]
  public static void Vacate(User user, Eco.Gameplay.Settlements.Settlement target, User citizen);

  [ChatSubCommand("Settlement", "Make a given citizen remove all its citizens (or all settlements if none passed).", "vacateall", ChatAuthorizationLevel.DevTier)]
  public static void VacateAll(User user, Eco.Gameplay.Settlements.Settlement target = null);

  [ChatSubCommand("Settlement", "Move all citizens to the target settlement, or the first found if not set.", "emigrateall", ChatAuthorizationLevel.DevTier)]
  public static void EmigrateAll(User user, Eco.Gameplay.Settlements.Settlement target = null);

  [ChatSubCommand("Settlement", "Forces resolution of property crises by removing claims now.  Pass individual settlement, or leave blank for 'all settlements in crisis'.", "resolvecrisis", ChatAuthorizationLevel.DevTier)]
  public static void ResolveCrisis(User user, Eco.Gameplay.Settlements.Settlement settlement = null);

  [ChatSubCommand("Settlement", "Forces a recount and update of the number of spawned claims and stakes for each settlement, in case they are out of synch.", ChatAuthorizationLevel.Admin)]
  public static void RecountClaims(User user, Eco.Gameplay.Settlements.Settlement settlement = null);

  [ChatSubCommand("Settlement", "Create a nested homestead, town, country, and federation with simple force-enabled objects.", "sets", ChatAuthorizationLevel.DevTier)]
  public static void SpawnSimpleSettlements(
    User user,
    bool makeSelfLeaderAndCitizen = true,
    bool assignTaxes = true);

  [ChatSubCommand("Settlement", "Create a homestead for the passed user or a test user if null.", "home", ChatAuthorizationLevel.DevTier)]
  public static void SpawnHomestead(User user, bool makeCitizen = false, User homesteadOwner = null);

  [ChatSubCommand("Settlement", "Create a new town on this plot and add citizens.", "town", ChatAuthorizationLevel.DevTier)]
  public static void SpawnTown(
    User user,
    bool foundTown = true,
    bool makeSelfCitizenAndMayor = true,
    int newCitizenCount = 5,
    int newApplicantCount = 2,
    int newInviteeCount = 2,
    int boostCulture = 1000);

  [ChatSubCommand("Settlement", "Recalc civic powers for all settlements and users.", "rebuildcivicpowers", ChatAuthorizationLevel.Admin)]
  public static void RebuildCivicPowers(User user);

  [ChatSubCommand("Settlement", "Displays your civic powers.", "civicpowers", ChatAuthorizationLevel.User)]
  public static void CivicPowers(User user, bool settlementsWhereYoureACitizenOnly = true);

  [ChatSubCommand("Settlement", "Fill the town on this plot with citizens.", "populate", ChatAuthorizationLevel.Admin)]
  public static void Populate(
    User user,
    bool foundTown = true,
    int newCitizenCount = 5,
    int newApplicantCount = 2,
    int newInviteeCount = 2,
    bool makeAllActive = true);

  public static void Populate(
    User user,
    Eco.Gameplay.Settlements.Settlement settlement,
    int newCitizenCount = 5,
    int newApplicantCount = 0,
    int newInviteeCount = 0,
    bool makeAllActive = true);

  [ChatSubCommand("Settlement", "Force a given settlement to annex another, if the types support it.", "annex", ChatAuthorizationLevel.Admin)]
  public static void Annex(IChatClient client, Eco.Gameplay.Settlements.Settlement source, Eco.Gameplay.Settlements.Settlement target);

  [ChatSubCommand("Settlement", "Toggles the ability for admins to annex properties even if the requirements are not met.", "freeannex", ChatAuthorizationLevel.Admin)]
  public static void AllowAdminAnnex(IChatClient client, bool ignore = true);

  [ChatSubCommand("Settlement", "Disable Settlement requirements for the session (Ie, dont require child settlements or citizens for a country to spawn.", "nosetreqs", ChatAuthorizationLevel.Admin)]
  public static void IgnoreRequirements(IChatClient client, bool ignore = true);

  [ChatSubCommand("Settlement", "Add the specfied quantity of claim stakes to the specified settlement.", ChatAuthorizationLevel.Admin)]
  public static void AddClaimStakes(User user, int quantity, Eco.Gameplay.Settlements.Settlement settlement);

  [ChatSubCommand("Settlement", "Add the specified quantity of claim papers to the specified settlement.", ChatAuthorizationLevel.Admin)]
  public static void AddClaimPapers(User user, int quantity, Eco.Gameplay.Settlements.Settlement settlement);

  [ChatSubCommand("Settlement", "Remove your homestead from the world and get it back to you.", "GetHomesteadBack", ChatAuthorizationLevel.User)]
  public static void GetHomesteadBack(User user);

  [ChatSubCommand("Settlement", "Force-place a settlement at current position, either yourself or a test user.", "PlaceHomestead", ChatAuthorizationLevel.DevTier)]
  public static void PlaceHomestead(User user, bool self = false, bool addAsCitizen = false, bool abandoned = false);

  [ChatSubCommand("Settlement", "Resets any invalid entries in a settlement to a new default.  If true is passed, reset everything, regardless of validity.", "resettle", ChatAuthorizationLevel.Admin)]
  public static void Reset(User user, Eco.Gameplay.Settlements.Settlement set, bool forceAllDefaults = false);

  [ChatSubCommand("Settlement", "Enables or disables a settlement. This will stop it from casting influence or applying laws when disabled.", "seten", ChatAuthorizationLevel.Admin)]
  public static void EnableDisable(User user, Eco.Gameplay.Settlements.Settlement set, bool enabled);
}
