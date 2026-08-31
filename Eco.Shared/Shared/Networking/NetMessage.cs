// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetMessage
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking.Udp;
using Eco.Shared.Serialization;
using System;
using System.IO;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking;

public static class NetMessage
{
  public const byte RegisterHost = 0;
  public const byte RequestHostList = 1;
  public const byte RequestHostInfo = 2;
  public const byte RequestIntroduction = 3;
  public const byte ReceiveHostInfo = 4;
  public const byte Ping = 5;
  public const byte PingReply = 6;
  public const byte RequestOfficialList = 7;
  public const byte ReceiveOfficialServer = 8;
  public const byte RegisterHostReply = 9;
  public const byte FragmentedMessage = 10;
  public const byte DiscoveryRequest = 11;
  public const byte DiscoveryResponse = 12;
  public const byte NatIntroduction = 13;
  public const byte NatPunchMessage = 14;
  public const byte NatIntroductionConfirmed = 15;
  public const byte NatIntroductionConfirmRequest = 16 /*0x10*/;
  public const byte RelayRegister = 250;
  public const byte RelayIntroduce = 251;
  public const byte RelayConnect = 252;
  public const byte RelayAck = 253;

  public static void SendDiscoveryRequest(this IUnconnectedUdpPeer peer, IPEndPoint endPoint);

  public static void SendDiscoveryResponse(
    this IUnconnectedUdpPeer peer,
    IPEndPoint endPoint,
    string strangeWorldCloudData);

  public static void SendPingRequest(this IUnconnectedUdpPeer peer, IPEndPoint endPoint);

  public static void SendPingRequest(
    this IUnconnectedUdpPeer peer,
    IPEndPoint endPoint,
    double sendTime);

  public static void SendPingReply(
    this IUnconnectedUdpPeer peer,
    IPEndPoint endPoint,
    Guid serverId,
    double sendTime);

  /// <summary> Encodes <paramref name="payload" /> as network packet for <paramref name="netEvent" />. </summary>
  public static void EncodePacket(
    this MemoryStream message,
    NetworkEvent netEvent,
    BSONValue payload);

  public static ReceivedNetworkPacket DecodePacket(ReadOnlySpan<byte> message);

  /// <summary> Sends <paramref name="netEvent" /> with <paramref name="payload" /> through the <paramref name="peer" /> (to the server). </summary>
  public static void SendPacket(this IUdpClient peer, NetworkEvent netEvent, BSONObject payload);

  /// <summary> Broadcasts <paramref name="netEvent" /> with <paramref name="payload" /> to all connected clients. </summary>
  public static void BroadcastPacket(
    this IUdpServer peer,
    NetworkEvent netEvent,
    BSONObject payload);

  /// <summary> Encodes <paramref name="payload" /> and sends <paramref name="netEvent" /> with it's data to <paramref name="connection" /> (may be obtained from <see cref="E:Eco.Shared.Networking.Udp.IUdpPeer.Connected" />). </summary>
  public static void SendPacket(
    this IUdpPeer peer,
    NetworkEvent netEvent,
    BSONValue payload,
    object connection);

  public static void Disconnect(this IUdpClient client, string byeMessage, bool causedByError = false);

  public static void DisconnectWithAddingToQueue(
    this IUdpServer server,
    object connection,
    string byeMessage,
    int queuePosition);

  public static void Disconnect(
    this IUdpServer server,
    object connection,
    string byeMessage,
    bool disconectedByException = false);

  public static void Shutdown(this IUdpServer server, string reason);
}
