// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.ElectionTests
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[ChatCommandHandler]
public static class ElectionTests
{
  [ChatSubCommand("Civics", "Add a bunch of candidates to specfied election (or first election found if none specified).", ChatAuthorizationLevel.DevTier)]
  public static void AddCandidates(User user, Election election = null);

  [ChatSubCommand("Civics", "Add a bunch of test votes to a specified election, or first election found.", ChatAuthorizationLevel.DevTier)]
  public static void AddVotes(IChatClient client, Election election = null, int count = 10, bool forceYesVote = false);

  [ChatSubCommand("Civics", "Force a given number of players to be active, creating the users if there are not enough", ChatAuthorizationLevel.DevTier)]
  public static void SetActiveUsers(IChatClient client, int count = 20);
}
