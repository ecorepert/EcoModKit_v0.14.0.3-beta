// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.TestUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

[ChatCommandHandler]
public static class TestUtils
{
  public const 
  #nullable disable
  string TestClientUsername = "Test Client";

  public static User TestUser { get; }

  /// <summary>If the chat client is already a user, use that. Otherwise, return a test user.</summary>
  public static User UserOrTestUser(this IChatClient client);

  public static User GetOrCreateOtherUser(User current);

  [ChatSubCommand("test", "Create test users up to the given amount (default 5)", ChatAuthorizationLevel.DevTier)]
  public static void MakeTestUsers(User user, int count = 5);

  [ChatSubCommand("test", "Create test user with a specified name.", ChatAuthorizationLevel.DevTier)]
  public static User MakeTUser(User caller = null, string name = null);

  public static User MakeTestUser();

  public static User MakeTestUser(string name);

  /// <summary>Return a name for a new twitch user. Note that this doesnt persist after server restarts, it will go back to 1.</summary>
  public static string NewTwitchUser();

  [ChatSubCommand("test", "Toggle qamode on/off.", ChatAuthorizationLevel.DevTier)]
  public static void QAMode(IChatClient client);

  [ChatSubCommand("test", "Demotes user from adnim to a regular user until server is restarted or this command is invoked again.", ChatAuthorizationLevel.DevTier)]
  public static void Demote(User user);

  public static AppointedTitle GetOrCreateTestTile(User user = null);

  /// <summary>Get an enumerable of test users, creating new ones as needed (or forcing only new ones if set to true)</summary>
  public static IEnumerable<User> GetOrCreateOtherUsers(
    int count,
    bool newUsersOnly = false,
    string nameBase = null);

  public static IEnumerable<User> GetOrCreateOtherUsers(int count, IEnumerable<User> existingUsers);
}
