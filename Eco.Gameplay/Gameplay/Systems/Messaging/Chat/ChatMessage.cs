// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatMessage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary> Used in server/client side and for storage.</summary>
[Serialized]
public class ChatMessage : ISerializable, IHasCreationTime
{
  [Serialized]
  public double TimeSeconds { get; set; }

  [Serialized]
  public User Sender { get; }

  [Serialized]
  public IChatReceiver Receiver { get; }

  [Serialized]
  public string Text { get; set; }

  public ChatMessage();

  public ChatMessage(User sender, IChatReceiver receiver, string message = null);

  /// <summary>Not IBSONSerializable because takes INetClient arg to pack controllers</summary>
  public BSONArray ToBson(INetClient client);
}
