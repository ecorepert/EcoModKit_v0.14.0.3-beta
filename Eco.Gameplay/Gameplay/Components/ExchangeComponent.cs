// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ExchangeComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Tests;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>WorldObject component that allows players to trade currencies with each other.</summary>
[Serialized]
[Priority(0)]
[LocDescription("Set and view currencies to trade.")]
[RequireComponent(typeof (MustBeOwnedComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[HasIcon(null)]
[Tag("Economy")]
[Ecopedia(null, null, false, true, null)]
[ChatCommandHandler]
public sealed class ExchangeComponent : 
  WorldObjectComponent,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  OnOffComponent.IOnOffMessagesContainer
{
  public static 
  #nullable disable
  ThreadSafeAction<User, User, ExchangeEntry> CurrencyExchangedEvent;

  [Notify]
  public static ThreadSafeAction<ExchangeComponent> ExchangeComponentChangedEvent { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public OnOffComponent OnOff { get; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<ExchangeEntry> ExchangeList { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<HoldingEntry> HoldingList { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDisplayName("Owner Account")]
  [AllowNullInView]
  public BankAccount OwnerAccount { get; set; }

  LocString OnOffComponent.IOnOffMessagesContainer.NotAuthedMessage { get; }

  LocString OnOffComponent.IOnOffMessagesContainer.InvalidStatusMessage { get; }

  public override void Initialize();

  public override void OnCreate();

  public override void Destroy();

  [RPC]
  public void AddExchange(Player player);

  [RPC]
  public void AddHolding(Player player);

  [CITest(true)]
  [ChatSubCommand("Test", "Spawns 2 test exchanges, one for the user and one for another user. Adds some entries, performs some tests.", ChatAuthorizationLevel.DevTier)]
  public static Task Exchange(User user);
}
