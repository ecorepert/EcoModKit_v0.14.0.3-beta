// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Rcon.RconClient
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Rcon;

/// <summary>
/// Represents an active RCON server connection. RconClient implements the INetClient interface for assocating
/// our active connection with the internal RCON user used by the RconPlugin object.
/// </summary>
public sealed class RconClient : IDisposable, IChatClient, INotificationReceiver
{
  /// <summary>Represents the RCON client's current authenticated state.</summary>
  public bool Authenticated;

  /// <summary>Timestamp of when the last RCON packet was read from the network</summary>
  public DateTime LastRead { get; }

  /// <summary>Timestamp of when the last RCON packet was written to the network</summary>
  public DateTime LastWrite { get; }

  /// <summary>Represents the RCON client's current connected state</summary>
  public bool Connected { get; }

  /// <summary>Represents the RCON client's current availability state</summary>
  public int Available { get; }

  public 
  #nullable disable
  string Name { get; }

  public LocString MarkedUpName { get; }

  public string ImplementationName { get; }

  public string ReportUserId { get; }

  public string ReportUsername { get; }

  public string ReportIpAddress { get; }

  public RconClient(TcpClient client);

  /// <summary>Disposes of the RCON client and network connection</summary>
  public void Dispose();

  /// <summary>Reads an incoming <seealso cref="T:Eco.Plugins.Rcon.RconPacket" /> from the network stream</summary>
  /// <returns>Read <seealso cref="T:Eco.Plugins.Rcon.RconPacket" /></returns>
  public Task<RconPacket> ReadPacketAsync(CancellationToken token);

  /// <summary>Writes an <seealso cref="T:Eco.Plugins.Rcon.RconPacket" /> to the network stream</summary>
  /// <param name="packet"><seealso cref="T:Eco.Plugins.Rcon.RconPacket" /> to write to the network Stream</param>
  public Task WritePacketAsync(RconPacket packet, CancellationToken token);

  /// <summary>Disconnects the RCON client. Force closing the connection</summary>
  public void Disconnect();

  /// <summary>Handles the network traffic of the active RCON connection</summary>
  public Task PollConnection(CancellationToken token);

  public void TempServerMessage(
    LocString message,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Info);

  public void MsgLoc(FormattableString msg, NotificationStyle style = NotificationStyle.Info);

  public void Msg(LocString msg, NotificationStyle style = NotificationStyle.Info);

  public void MsgLocStr(string msg, NotificationStyle style = NotificationStyle.Info);

  public void ErrorLoc(FormattableString msg);

  public void Error(LocString msg);

  public void ErrorLocStr(string msg);

  /// <summary>Displays string to the client</summary>
  public void OkBoxLoc(FormattableString msg);

  public void OkBox(LocString msg);

  public void OkBoxLocStr(string msg);

  public ChatAuthorizationLevel GetChatAuthLevel();
}
