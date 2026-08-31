// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatSettings
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>
/// Client's chat settings are stored on the server within this class (instead of UserPrefs)
/// Client can reorder tabs but can't add or remove tabs (using ChatManager's RPCs instead)
/// </summary>
[Serialized]
public class ChatSettings : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IHasClientControlledContainers
{
  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<ChatTabSettingsBase> ChatTabSettings { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool WhisperTabForEachPlayer { get; set; }

  /// <summary>Requests client to open draft chat tab editor, tab will be added only if pressed Apply button</summary>
  [RPC]
  public void AddTab(Player player, int index);

  /// <summary>Requests client to open draft chat tab editor.</summary>
  [RPC]
  public void EditTab(Player player, int index);

  /// <summary>Requests client to move the tab to the Hidden Tabs list.</summary>
  [RPC]
  public void HideTab(Player player, ChatTabSettingsBase settings);

  /// <summary>Ensure we have a tab for IChatReceiver and if not - try to create this tab</summary>
  /// <param name="activateTab">Should we set the tab as active ?</param>
  public void EnsureTabExistsForReceiver(
    User user,
    IChatReceiver receiver,
    bool activateTab,
    bool activateChat = false);

  /// <summary>Create a chat tab for notifications from  <param name="category">category</param></summary>
  [RPC]
  public void CreateNotificationTab(Player player, NotificationCategory category);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
