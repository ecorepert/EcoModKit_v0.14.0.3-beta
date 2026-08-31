// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.IChatReceiver
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>Chat can only be sent to entities tagged as IChatReceiver.</summary>
[Serialized]
public interface IChatReceiver : 
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  /// <summary>The underlying users that the receiving target represents.</summary>
  IEnumerable<User> ChatRecipients { get; }

  /// <summary>Chat tag this chat receiver associated with.</summary>
  [ClientInterfaceProperty]
  string ChatTag { get; }

  /// <summary>Marked up name used to display in chat message</summary>
  [ClientInterfaceProperty]
  string MarkedUpChatTag { get; }
}
