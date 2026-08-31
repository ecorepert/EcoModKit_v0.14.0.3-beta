// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTreeCommands
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Tests;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Mods;

[ChatCommandHandler]
public static class TechTreeCommands
{
  [ChatCommand("Shows commands for skills", ChatAuthorizationLevel.Admin)]
  public static void Skills(User user);

  [CITest(true)]
  [ChatSubCommand("Skills", "Level up a citizen by one.  Default levels you up.", ChatAuthorizationLevel.Admin)]
  public static void LevelUpUser(User user, string name = null);

  [ChatSubCommand("Skills", "Remove restrictions and gives you every skill at max level.", "creative", ChatAuthorizationLevel.DevTier)]
  public static void Creative(User user);

  [ChatSubCommand("Inventory", "Adds random items to the user's inventory.", ChatAuthorizationLevel.DevTier)]
  public static void FillMeUp(User user);

  [CITest(false)]
  [ChatSubCommand("QA", "Lists the items that cannot be crafted from some set of other items.  Note that many of these are not meant to be crafted, e.g. hips and stone.", ChatAuthorizationLevel.DevTier)]
  public static void ListUnobtainableItems(User user);

  [ChatSubCommand("Craft", "Gets the resources needed to craft something", ChatAuthorizationLevel.DevTier)]
  public static void GetPathToItem(User user, string target);

  public static void GetPathToSkillRec(
    Skill target,
    bool includeItems,
    ref TechTreePath path,
    int level = 0);

  public static void GetPathToItemRec(
    Item target,
    bool includeSkills,
    ref TechTreePath path,
    int number = 1);
}
