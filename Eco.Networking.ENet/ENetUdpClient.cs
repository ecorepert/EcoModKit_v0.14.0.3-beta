// Decompiled with JetBrains decompiler
// Type: Eco.Networking.ENet.ENetUdpClient
// Assembly: Eco.Networking.ENet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00C02FAA-9424-481A-B463-D4AE2C8B3EB5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Networking.ENet.dll

using Eco.Shared.Networking;
using Eco.Shared.Networking.Udp;
using ENet;
using System;
using System.Net;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Networking.ENet;

internal class ENetUdpClient : ENetUdpPeer, IUdpClient, IUdpPeer, IUnconnectedUdpPeer
{
  public ENetUdpClient(
    Func<InterceptCallback, InterceptCallback>? interceptCallbackFactory = null,
    Func<ConnectRequestCallback, ConnectRequestCallback>? connectRequestCallbackFactory = null);

  public UdpConnectionStatus ConnectionStatus { get; }

  public float AverageRoundtripTime { get; }

  public IPEndPoint? RemoteEndPoint { get; }

  public void Disconnect();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SendData(ReadOnlySpan<byte> data, byte channel);

  protected override void OnConnectionQueued();

  protected override void BeforeConnect();

  protected override void OnConnecting(ENetConnection connection);

  protected override void OnDisconnected(ENetConnection connection, DisconnectReason reason);

  public NetStats GetStats();
}
