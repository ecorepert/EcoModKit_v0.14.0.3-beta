// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatTabSettingsCommon
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>
/// Represent the common tabs that are created manually by the player (or in some cases automatically) and that can be modified.
/// </summary>
[Serialized]
public class ChatTabSettingsCommon : 
  ChatTabSettingsBase,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  [ClientCanSelectAndAdd("Select Chat Sources", "Chat sources", "sources", false)]
  public 
  #nullable disable
  ControllerHashSet<Channel> Channels { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  public ControllerHashSet<NotificationMessageSource> Notifications { get; set; }

  public ChatTabSettingsCommon();

  public ChatTabSettingsCommon(
    string name,
    IEnumerable<Channel> channels,
    IEnumerable<NotificationMessageSource> notifications = null);

  public ChatTabSettingsCommon(
    string name,
    IEnumerable<NotificationMessageSource> notifications);

  /// <summary>Opens multi-selector popup on client. This is needed to allow pick from general picker without using registrars</summary>
  /// 
  ///             NOTE: on the client UI we change notifications to systems to prevent any confusion with the <see cref="F:Eco.Shared.Services.NotificationCategory.Notifications" />
  ///  cetegory.
  [LocDescription("Add or Remove System Sources.")]
  [RPC]
  public Task EditSystemSourcesSettings(Player player);

  /// <summary>Choose whether to make the submit button interactable or not depending on whether there's at least one channel or notification source.</summary>
  public Result Valid();
}
