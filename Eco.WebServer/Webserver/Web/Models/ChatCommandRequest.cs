// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Models.ChatCommandRequest
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using Eco.WebServer.DataTransferObjects.V1;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Web.Models;

/// <summary>Defines an <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> instance for making web based command requests.</summary>
public class ChatCommandRequest : IChatClient, INotificationReceiver
{
  public 
  #nullable disable
  string Name { get; }

  public LocString MarkedUpName { get; }

  public string ImplementationName { get; }

  public string ReportUserId { get; }

  public string ReportUsername { get; }

  public string ReportIpAddress { get; }

  public ChatCommandRequest(ChatAuthorizationLevel authLevel);

  /// <summary>Executes the command request instance with the specified command</summary>
  /// <param name="command">Command to execute</param>
  public Task ExecuteCommand(string command);

  public void TempServerMessage(
    LocString message,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat);

  public void MsgLoc(FormattableString msg, NotificationStyle style = NotificationStyle.Chat);

  public void Msg(LocString msg, NotificationStyle style = NotificationStyle.Chat);

  public void MsgLocStr(string msg, NotificationStyle style = NotificationStyle.Chat);

  public void ErrorLoc(FormattableString msg);

  public void Error(LocString msg);

  public void ErrorLocStr(string msg);

  public void OkBoxLoc(FormattableString msg);

  public void OkBox(LocString msg);

  public void OkBoxLocStr(string msg);

  /// <summary>Returns the finalized <seealso cref="T:Eco.WebServer.DataTransferObjects.V1.CommandResultV1" /> object</summary>
  public CommandResultV1 GetResponseDTO();

  public ChatAuthorizationLevel GetChatAuthLevel();
}
