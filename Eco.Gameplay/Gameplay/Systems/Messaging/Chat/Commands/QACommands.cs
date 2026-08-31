// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.QACommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class QACommands
{
  [ChatCommand("Shows commands for preforming debugging and hard testing commands.", ChatAuthorizationLevel.DevTier)]
  public static void QA(
  #nullable disable
  User user);

  [ChatSubCommand("QA", "Forces a heartbeat to strange cloud", "hb", ChatAuthorizationLevel.DevTier)]
  public static void StrangeCloudHeartbeat(IChatClient user);

  [ChatSubCommand("QA", "Adjusts how many of a paid item a player counts as having crafted. Negative amounts refund blueprint uses lost to bugs.", "adjustblueprintcount", ChatAuthorizationLevel.Admin)]
  public static void AdjustBlueprintCount(User user, string itemName, int amount, User targetUser = null);

  [ChatSubCommand("QA", "A command to force the server to crash", ChatAuthorizationLevel.DevTier)]
  public static void ServerCrash(IChatClient user);

  [ChatSubCommand("QA", "Clear all playerprefs, requires a restart to take effect.", ChatAuthorizationLevel.DevTier)]
  public static void ClearPlayerPrefs(User user);

  [CITest(false)]
  [ChatSubCommand("QA", "List all supported languages with short codes", ChatAuthorizationLevel.Admin)]
  public static void ShowSupportedLanguages(User user);

  [CITest(false)]
  [ChatSubCommand("Build", "Generate a full stockpile", ChatAuthorizationLevel.DevTier)]
  public static Task FullStockpile(User user);

  [ChatSubCommand("QA", "Give all tools of the particular tier. Without specific tier a chest with all tools will be spawned", "gat", ChatAuthorizationLevel.DevTier)]
  public static void GiveAllTools(User user, float tier = 0.0f);

  [ChatSubCommand("QA", "Give all vehicles and hammer", "gav", ChatAuthorizationLevel.DevTier)]
  public static void GiveAllVehicles(User user);

  [ChatSubCommand("QA", "Give all boats and hammer", "gab", ChatAuthorizationLevel.DevTier)]
  public static void GiveAllBoats(User user);

  [ChatSubCommand("QA", "Give all vehicle tools", "gavt", ChatAuthorizationLevel.DevTier)]
  public static void GiveAllVehicleTools(User user);

  [ChatSubCommand("Test", "Build Zero Point place and teleport to it", ChatAuthorizationLevel.DevTier)]
  public static void ZeroPoint(User user, int sizeX, int sizeZ);

  [CITest(false)]
  [ChatSubCommand("Test", "Setup an elevator for testing", ChatAuthorizationLevel.DevTier)]
  public static void Elevator(User user);

  [ChatSubCommand("Test", "Setup an industrial elevator for testing", ChatAuthorizationLevel.DevTier)]
  public static void IndustrialElevator(User user);

  [ChatSubCommand("Test", "Generates some test combinations of foldout lists. Can optionally set the level of nesting.", "dbgf", ChatAuthorizationLevel.DevTier)]
  public static void Foldouts(User user, int nestingIterations = 5);

  [ChatSubCommand("Build", "Spawn all of the objects containing a string in its name. If they have text, add that too, can optionally set the string range.", ChatAuthorizationLevel.DevTier)]
  public static void Objects(User user, string objectstring, int textLengthMin = 3, int textLengthMax = 40);

  [ChatSubCommand("QA", "Inserts records to DB to get perfomance information on it.", "db", ChatAuthorizationLevel.DevTier)]
  public static void DBTest(User user, int parallelCount, int statsCountPerParallel, bool bulk = true);

  [ChatSubCommand("QA", "Spams database operations, in the hopes of reproducing errors or lag", ChatAuthorizationLevel.DevTier)]
  public static void SpamDb(User user, float numSeconds = 30f, int numWriteThreads = 16 /*0x10*/);

  [ChatSubCommand("QA", "Send many messages", ChatAuthorizationLevel.DevTier)]
  public static void TestSendMessage(IChatClient chatClient, int msgCount = 200, bool foldOut = true);

  [ChatSubCommand("QA", "Reset all players chat settings and tab settings", ChatAuthorizationLevel.DevTier)]
  public static void ResetChatSettingsForAll(IChatClient chatClient, int msgCount = 200, bool foldOut = true);

  [ChatSubCommand("QA", "Spawns a garbage sound-test scene: a leveled pad with a fueled Truck and Steam Truck (garbage collector modules installed) facing a row of garbage sources, filled and empty.", ChatAuthorizationLevel.DevTier)]
  public static Task GarbageScene(User user);
}
