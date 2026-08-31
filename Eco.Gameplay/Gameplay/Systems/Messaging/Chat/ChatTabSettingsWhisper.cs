// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatTabSettingsWhisper
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>Represent the private tabs that are created automatically when the whisperMode is active and the player send or receive a message from another player. Player cannot modify this tab.</summary>
[Serialized]
public class ChatTabSettingsWhisper : ChatTabSettingsBase
{
  [Serialized]
  [SyncToView(null, true)]
  public User WhisperUser { get; set; }

  public ChatTabSettingsWhisper();

  public ChatTabSettingsWhisper(string name, User user);
}
