// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.DinnerPartyManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Culture;

[Serialized]
[ChatCommandHandler]
public class DinnerPartyManager : 
  Singleton<
  #nullable disable
  DinnerPartyManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  public static Initializer Init;
  public static ThreadSafeAction DinnerPartyListChanged;
  public static ThreadSafeAction<Deed> DinnerPartyOnDeedChangedEvent;
  public static ThreadSafeAction<DinnerParty> PartyHostedAndFinishedEvent;

  public void Initialize();

  [SyncToView(null, true)]
  public float FreshnessTimeMinutesPreparedFood { get; }

  [SyncToView(null, true)]
  public float FreshnessTimeMinutesRawFood { get; }

  /// <summary> Gets freshness time for food - if there's a recipe use prepared food time, otherwise use raw food time </summary>
  public float FreshTime(FoodItem food);

  /// <summary> Returns true if food durability satisfies DinnerPartyMinFreshnessPercent </summary>
  public bool IsFresh(FoodItem food);

  public void FastTick();

  [ChatCommand("Performs dinner party operations.", ChatAuthorizationLevel.DevTier)]
  public static void Dinner(IChatClient chatClient);

  [ChatSubCommand("Dinner", "Clear all active dinner parties.", ChatAuthorizationLevel.Admin)]
  public static void Clear(IChatClient client, bool clearActive = true, bool clearFinished = true);

  [ChatSubCommand("Dinner", "Finish all active dinner parties.", ChatAuthorizationLevel.Admin)]
  public static void Finish(IChatClient client);

  [ChatSubCommand("Dinner", "Changes how many dinner parties per day can count toward a user's dinner party nutrition bonus.", "am", ChatAuthorizationLevel.Admin)]
  public static void AllowMultiple(IChatClient client, int allowed = 10);

  [ChatSubCommand("Dinner", "Add test users to party.", ChatAuthorizationLevel.DevTier)]
  public static void Test(IChatClient client, int usersToAdd = 3, int coursesToEat = 3);

  [ChatSubCommand("Dinner", "List all dinner parties.", ChatAuthorizationLevel.Admin)]
  public static void List(IChatClient client);

  [RPC]
  public TooltipSection UserDinnerPartyBonus(User user);

  /// <summary> Returns the final skill rate mulitplier for all the parties in attendence. </summary>
  public float MultiplierForUser(User owner);

  [RPC]
  public TooltipSection DescribeSettlementCountMultiplier();

  public IEnumerable<DinnerParty> DinnerPartiesForDeed(Deed deed);

  public IEnumerable<DinnerParty> DinnerPartiesForUser(User user);

  [RPC]
  public TooltipSection DisplayDinnerPartiesForDeed(string deedID);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
