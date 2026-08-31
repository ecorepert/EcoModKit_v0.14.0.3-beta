// Decompiled with JetBrains decompiler
// Type: Eco.Networking.ENet.ENetUdpServer
// Assembly: Eco.Networking.ENet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00C02FAA-9424-481A-B463-D4AE2C8B3EB5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Networking.ENet.dll

using Eco.Shared.Networking;
using Eco.Shared.Networking.Udp;
using ENet;
using System;
using System.Net;

#nullable enable
namespace Eco.Networking.ENet;

internal class ENetUdpServer : ENetUdpPeer, IUdpServer, IUdpPeer, IUnconnectedUdpPeer
{
  public ENetUdpServer(
    IPEndPoint endPoint,
    int maxPeers,
    Func<InterceptCallback, InterceptCallback>? interceptCallbackFactory = null,
    Func<ConnectRequestCallback, ConnectRequestCallback>? connectRequestCallbackFactory = null);

  public UdpConnectionStatus GetConnectionStatus(object connection);

  public void Disconnect(object connection);

  public void GetConnectionStatistic(
    object connection,
    out long totalSentBytes,
    out long totalReceivedBytes);

  public void BroadcastData(ReadOnlySpan<byte> data);
}
