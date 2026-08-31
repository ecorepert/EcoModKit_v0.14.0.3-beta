// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Channels.Channel
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Channels;

/// <summary>Channels are managed via <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Channels.ChannelManager" />. Channel has a Manager/User permission set using Aliases, that allows creating rich and contextual communication hubs in game.</summary>
[Eco.Shared.Networking.Eco(true)]
[LocDescription("A channel is a citizen-defined communication hub.")]
public class Channel : 
  SimpleEntry,
  ISpecialRegistrarEntry,
  ICustomValidity,
  IValidity,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IChatReceiver,
  IHasID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IRemovableEntry
{
  public static ThreadSafeAction<Channel> OnChange;

  [Eco.Shared.Networking.Eco(true)]
  [TreatAsReference]
  [AllowNullInView]
  [LocDescription("Managers are allowed to manage the channel details, including permission set.")]
  [ClientCanSelectAndAdd("Select Managers", "Manager", "Managers", true)]
  public ControllerAliasSet Managers { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [TreatAsReference]
  [AllowNullInView]
  [AllowEmpty]
  [LocDescription("Users are allowed to participate in the discussions of the channel.")]
  [ClientCanSelectAndAdd("Select Users", "User", "Users", true)]
  public ControllerAliasSet Users { get; set; }

  public IEnumerable<User> ChatRecipients { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Name")]
  public string ChatTag { get; }

  [SyncToView(null, true)]
  public string MarkedUpChatTag { get; }

  [Serialized]
  public int SpecialType { get; set; }

  [EcoTextLimit(EcoTextLimitAttribute.TextRangeStyle.ChannelName)]
  [ScanProp]
  public override string Name { get; }

  public override void Destroyed();

  public override void Initialize();

  [SyncToView(null, true)]
  public AccountAccess AccessType(User user);

  public Result CanAccess(User user, AccountAccess access = AccountAccess.Use);

  public Result Valid();

  /// <summary>Define a string that will be parsed as a link for the Channel, so we do not overlap custom names of channels and simple words or names of other objects.</summary>
  public string GetLinkableName();

  /// <summary>Set this channel as a receiver (change output tag) with clicking on it's name in the Chat Log.</summary>
  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public Task<Result> VerifyCanRemove(
    Player player,
    IClientControlledContainer container,
    object obj);

  [RPC]
  public Task<bool> Remove(User caller);

  public override bool CanBeDeleted { get; }
}
