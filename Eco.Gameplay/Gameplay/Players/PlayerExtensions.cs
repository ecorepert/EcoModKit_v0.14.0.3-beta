// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.PlayerExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Systems.Messaging.Mail;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Players;

public static class PlayerExtensions
{
  public static void MsgLoc(
    this IEnumerable<User> users,
    FormattableString msg,
    NotificationStyle style = NotificationStyle.Info);

  public static void MsgLocStr(this IEnumerable<User> users, string msg, NotificationStyle style = NotificationStyle.Info);

  public static void Msg(this IEnumerable<User> users, LocString msg, NotificationStyle style = NotificationStyle.Info);

  public static void Msg(
    this IEnumerable<User> users,
    LocString msg,
    NotificationCategory category,
    NotificationStyle style = NotificationStyle.Info);

  public static void Mail(this User user, LocString text, NotificationCategory tag);

  public static MailMessage MailLoc(
    this User user,
    FormattableString text,
    NotificationCategory tag);

  public static void Mail(this IEnumerable<User> users, LocString text, NotificationCategory tag);

  public static void MailLoc(
    this IEnumerable<User> users,
    FormattableString text,
    NotificationCategory tag);

  public static void MailLocStr(
    this IEnumerable<User> users,
    string text,
    NotificationCategory tag);

  public static void OkBoxLoc(this User user, FormattableString msg);

  public static Task<bool> ConfirmBoxLoc(this User user, FormattableString msg);

  public static Task<bool> ConfirmBox(this User user, LocString msg);

  public static void OkBox(this User user, LocString msg);

  public static Result OkBox(this User user, LocString msg, bool succeeded);

  /// <summary> Sends a message to the user if online. if the user is offline the same message will be sent but to the mail, so that it gets seen when the user logs in.</summary>
  public static void MsgOrMailLoc(
    this User user,
    FormattableString text,
    NotificationCategory mailTag,
    NotificationStyle msgStyle = NotificationStyle.Chat);

  /// <summary> Sends a message to the user if online. if the user is offline the same message will be sent but to the mail, so that it gets seen when the user logs in.</summary>
  public static void MsgOrMail(
    this User user,
    LocString text,
    NotificationCategory mailTag,
    NotificationStyle msgStyle = NotificationStyle.Chat);
}
