// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Aliases.AliasExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Aliases;

public static class AliasExtensions
{
  /// <summary>If this alias is a single user, return it.  This is used for parts of the game that can't handle something being multiple users. Over time we can add support to that (like housing values spreading across multiple people for example).</summary>
  public static 
  #nullable disable
  User OneUser(this IAlias alias);

  /// <summary>If this alias has multiple users, return the first one.</summary>
  public static User FirstUser(this IAlias alias);

  /// <summary>Get the full list of users in all these aliases, no repeats.</summary>
  public static IEnumerable<User> ToUsers(this IEnumerable<IAlias> aliases);

  public static bool ContainsUser(this IEnumerable<IAlias> aliases, User user);

  public static bool ContainsExactAlias(this IEnumerable<IAlias> aliases, IAlias query);

  public static void Msg(
    this IAlias alias,
    LocString message,
    bool temp = true,
    NotificationStyle style = NotificationStyle.Chat,
    NotificationCategory tag = NotificationCategory.Notifications);

  public static void MsgLoc(
    this IAlias alias,
    FormattableString message,
    bool temp = true,
    NotificationStyle style = NotificationStyle.Chat,
    NotificationCategory tag = NotificationCategory.Notifications);

  public static void MsgLocStr(
    this IAlias alias,
    string message,
    bool temp = true,
    NotificationStyle style = NotificationStyle.Chat,
    NotificationCategory tag = NotificationCategory.Notifications);

  public static void Mail(this IAlias alias, LocString text, NotificationCategory tag);

  public static void MailLoc(this IAlias alias, FormattableString text, NotificationCategory tag);

  public static void MailLocStr(this IAlias alias, string text, NotificationCategory tag);

  public static IAlias GetBackupOwner(this IAlias alias);
}
