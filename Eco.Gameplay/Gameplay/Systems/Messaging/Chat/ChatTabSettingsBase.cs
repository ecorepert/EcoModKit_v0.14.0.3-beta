// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatTabSettingsBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>
/// Chat tab represents current chat 'window' and user always has at least on active tab. Tab settings tells chat which message are visible within that tab.
/// Settings for chat tabs are stored on server in ChatManager. Name should not be empty and can have collisions with other tabs. Tab names are not localized.
/// </summary>
[Serialized]
[LocDisplayName("Tab")]
public abstract class ChatTabSettingsBase : 
  INamed,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  [ScanProp]
  [EcoTextLimit(EcoTextLimitAttribute.TextRangeStyle.ChatTitle)]
  public 
  #nullable disable
  string Name { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ChatTabFlags Flags { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool IsHidden { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public double LastActivationTime { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Name")]
  public LocString MarkedUpName { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
