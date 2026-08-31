// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.CultureCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Gameplay.Settlements.Culture;

[ChatCommandHandler]
public static class CultureCommands
{
  [ChatCommand("Shows commands for controlling culture.", ChatAuthorizationLevel.Admin)]
  public static void Culture(
  #nullable disable
  User user);

  [ChatSubCommand("Culture", "Force an update of all settlement properties.", "updatesets", ChatAuthorizationLevel.Admin)]
  public static void UpdateSettlements(IChatClient user);

  [ChatSubCommand("Culture", "Update annex settings and describe them.", "describeannex", ChatAuthorizationLevel.Admin)]
  public static void DescribeAnnex(IChatClient user);

  [ChatSubCommand("Culture", "Set a culture-boost to lowest tier settlement at position, or specified position.  If null is passed, will take the lowest-tier settlement the user is a citizen of, or an arbitrary settlement if they are not a citizen of any.", "boostsettlementculture", ChatAuthorizationLevel.Admin)]
  public static void BoostSettlement(IChatClient user, float val, Settlement settlement = null);

  [ChatSubCommand("Culture", "Sets a boost to the culture value of the given deed, or the property where the user is standing if not specified", "boostpropertyculture", ChatAuthorizationLevel.Admin)]
  public static void BoostProperty(IChatClient user, float val, Deed deed = null);

  [ChatSubCommand("Culture", "Give a randomly generated picture item for testing.", "pic", ChatAuthorizationLevel.DevTier)]
  public static void GiveRandomPicture(User user);

  [ChatSubCommand("Culture", "Spawn a museum of images generating culture", ChatAuthorizationLevel.DevTier)]
  public static void SpawnWallOfPictures(User user, int textureCount = 100, int textureSize = 1024 /*0x0400*/);

  [ChatSubCommand("Culture", "Spawn a museum of images generating culture", "museum", ChatAuthorizationLevel.DevTier)]
  public static void SpawnMuseum(User user, int dim = 10);

  [ChatSubCommand("Culture", "Gives reputation from the given user (defaulting to self if not set) to the given target (picture or user) ignoring limits by default.", "rep", ChatAuthorizationLevel.Admin)]
  public static void GiveReputation(
    IChatClient chatClient,
    int rep,
    int targetID,
    User sourceUser = null,
    bool ignoreLimit = true);

  [ChatSubCommand("Culture", "Refills givable reputation for given Citizen, or all Citizens if left blank.", "reprep", ChatAuthorizationLevel.Admin)]
  public static void ReplenishGivableReputation(IChatClient chatClient, User targetUser = null);

  [ChatSubCommand("Culture", "Gives reputation to all pictures ignoring limits, can set settlement to only apply reputation to pictures under its influence.", "vincent", ChatAuthorizationLevel.Admin)]
  public static void Masterpieces(IChatClient chatClient, int reputation = 3, Settlement settlement = null);
}
