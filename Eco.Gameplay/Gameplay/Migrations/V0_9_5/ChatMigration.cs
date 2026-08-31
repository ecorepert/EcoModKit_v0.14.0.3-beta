// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_5.ChatMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;
using Eco.Gameplay.Systems.Messaging.Mail;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Shared.Services;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Migrations.V0_9_5;

[Migration(SinceVersion = 3.913)]
[MigrationType(typeof (ChatMessage))]
[MigrationType(typeof (ChatDataPartition))]
[MigrationType(typeof (Mailbox))]
[MigrationType(typeof (MailMessage))]
[MigrationType(typeof (DirectNotification))]
[MigrationType(typeof (BroadcastNotification))]
[MigrationType(typeof (ElectionComment))]
[MigrationType(typeof (IChatReceiver))]
public class ChatMigration : AggregateMigration
{
  /// <summary>Lazy loading context with all registrars and caches.</summary>
  private class Context
  {
    public readonly Registrar<Channel> Channels;
    public readonly Registrar<User> Users;
    public readonly Demographic Admins;
    public readonly Demographic Everyone;
    public readonly Dictionary<SpecialChannel, Channel> SpecialChannels;
  }
}
