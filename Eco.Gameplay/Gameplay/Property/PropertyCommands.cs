// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Property;

[ChatCommandHandler]
public static class PropertyCommands
{
  public static void AssertAdminCommand(string method, LocString error);

  [ChatCommand("Shows commands for property manipulations.", ChatAuthorizationLevel.Admin)]
  public static void Property(User user);

  [ChatSubCommand("Property", "Boost the value of the given deed, or the deed at the current position if not specified. Persists across server restart.", "boostdeed", ChatAuthorizationLevel.Admin)]
  public static void BoostDeed(IChatClient user, float boost, Deed deed = null);

  [ChatSubCommand("Property", "Toggles first found Claim Tool in your toolbar to claim without needing the usually required claim papers on the corresponding Claim Stake. Lasts until server restart.", "unlimitedclaim", ChatAuthorizationLevel.Admin)]
  public static void UnlimitedClaim(User user);

  [CITest(false)]
  [ChatSubCommand("Property", "Claims plots in a given rect. If you're already standing on a claim you have auth on, it will use the existing deed. Otherwise, a new deed is created.", "claim", ChatAuthorizationLevel.Admin)]
  public static Deed ClaimRect(User user, int xSide = 5, int ySide = 5, bool overwriteExistingClaims = false);

  public static Deed ClaimRect(
    User user,
    Vector3i pos,
    int xSide = 5,
    int ySide = 5,
    bool overwriteExistingClaims = false);

  [ChatSubCommand("Property", "Unclaim the plot you're standing on", "unclaim", ChatAuthorizationLevel.Admin)]
  public static void Unclaim(User user);

  [ChatSubCommand("Property", "Unclaim plots across the world where the owner hasn't logged in for X days", ChatAuthorizationLevel.Admin)]
  public static void UnclaimAbandoned(User user, float days);

  [ChatSubCommand("Property", "Adds user to current deed (if username is not provided then adds current user)", ChatAuthorizationLevel.Admin)]
  public static void Add(User user, User otherPlayer = null);

  [ChatSubCommand("Property", "Removes user from current deed (if username is not provided then removes current user)", ChatAuthorizationLevel.Admin)]
  public static void Remove(User user, User otherPlayer = null);

  [ChatSubCommand("Property", "Revoke your property", ChatAuthorizationLevel.Admin)]
  public static void OwnNone(User user, User otherPlayer = null);

  [ChatSubCommand("Property", "Claim all property", ChatAuthorizationLevel.Admin)]
  public static void OwnAll(User user);

  [ChatSubCommand("Property", "Change owner of current deed", "owner", ChatAuthorizationLevel.Admin)]
  public static void Owner(User user, User newOwner = null);

  [ChatSubCommand("Property", "Turn on (default) or objects in a radiue.", "on", ChatAuthorizationLevel.Admin)]
  public static void TurnOn(User user, bool on = true, float raidus = 10f);

  /// <summary> own the target world object's deed, if it has credit component update it to avoid its closure. </summary>
  [ChatSubCommand("Property", "Change owner of current target, if the target is a store it will change it without closing it.", "ownit", ChatAuthorizationLevel.Admin)]
  public static void TargetOwner(User user, INetObject target, User newOwner = null);

  [ChatSubCommand("Property", "Check deeds and remove contained ownables that do not belong to them", ChatAuthorizationLevel.DevTier)]
  public static void RemoveInvalidOwnables(User user);

  [ChatSubCommand("Property", "Remove given deed or here currently standing if none specified.", ChatAuthorizationLevel.Admin)]
  public static void RemoveDeed(User user, Deed deed = null);

  [ChatSubCommand("Property", "Remove empty deeds", ChatAuthorizationLevel.Admin)]
  public static void RemoveEmptyDeeds();

  [ChatSubCommand("Property", "Any deed that is overburdened (too many plots claimed, not enough claim papers) will have plots unclaimed immediately (instead of waiting for timer)", "overb", ChatAuthorizationLevel.Admin)]
  public static void ResolveOverburdened();
}
