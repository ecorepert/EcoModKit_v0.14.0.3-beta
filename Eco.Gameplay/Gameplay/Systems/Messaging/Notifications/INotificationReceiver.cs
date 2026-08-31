// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.INotificationReceiver
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Services;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Notifications;

/// <summary> Generic interface for smth that communicates through msg, errors, info boxes (like chat, player, etc) </summary>
public interface INotificationReceiver
{
  void ErrorLoc(FormattableString msg);

  void Error(LocString msg);

  void ErrorLocStr(string msg);

  void MsgLoc(FormattableString msg, NotificationStyle style = NotificationStyle.Chat);

  void Msg(LocString msg, NotificationStyle style = NotificationStyle.Chat);

  void MsgLocStr(string msg, NotificationStyle style = NotificationStyle.Chat);

  void OkBoxLoc(FormattableString msg);

  void OkBox(LocString msg);

  void OkBoxLocStr(string msg);
}
