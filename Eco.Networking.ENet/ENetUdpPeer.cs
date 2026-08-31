// Decompiled with JetBrains decompiler
// Type: Eco.Networking.ENet.ENetUdpPeer
// Assembly: Eco.Networking.ENet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00C02FAA-9424-481A-B463-D4AE2C8B3EB5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Networking.ENet.dll

using Eco.Shared.Networking;
using Eco.Shared.Networking.Udp;
using ENet;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Networking.ENet;

internal class ENetUdpPeer : IUdpPeer, IUnconnectedUdpPeer, IDisposable
{
  protected Host? host;

  public uint DisconnectTimeout { get; set; }

  public uint ConnectTimeout { get; set; }

  public event UdpDataMessageHandler? UnconnectedDataMessageReceived;

  public event UdpDataMessageHandler? DataMessageReceived;

  public event UdpChannelDataReceived? ChannelDataReceived;

  public event Action<string>? ErrorMessageReceived;

  public event Action<string>? WarningMessageReceived;

  public event Action<string>? DebugMessageReceived;

  public event UdpConnectedHandler? Connected;

  public event UdpDisconnectedHandler? Disconnected;

  public uint ProtocolVersion { get; set; }

  public ENetUdpPeer(
    IPEndPoint endPoint,
    int maxPeers,
    Func<InterceptCallback, InterceptCallback>? interceptCallbackFactory = null,
    Func<ConnectRequestCallback, ConnectRequestCallback>? connectRequestCallbackFactory = null);

  public uint TimeoutLimit { get; set; }

  public uint TimeoutMinimum { get; set; }

  public uint TimeoutMaximum { get; set; }

  public int MaximumUnconnectedMessageLength { get; }

  public int Port { get; }

  public bool IsRunning { get; }

  public IPEndPoint? LocalEndPoint { get; }

  public void SendRaw(IPEndPoint remoteEndPoint, byte[] messageData, int offset, int length);

  public void SendUnconnectedMessage(
    IPEndPoint remoteEndPoint,
    byte[] messageData,
    int offset,
    int length);

  public void Start();

  public void Shutdown();

  public void Service(int timeoutMs);

  public bool ServiceOne(int timeoutMs);

  public float GetAverageRoundtripTime(object connection);

  public void SyncTimer(double currentTimeInSeconds);

  public void Connect(IPEndPoint endpoint);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SendData(object connection, ReadOnlySpan<byte> data, byte channel);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SendData(ENetConnection connection, ReadOnlySpan<byte> data, byte channel);

  public void SendData(IEnumerable<object> connections, ReadOnlySpan<byte> data, byte channel);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected void CreatePacket(ReadOnlySpan<byte> data, out Packet packet);

  protected Address ConvertToAddress(IPEndPoint endPoint);

  protected virtual void OnConnectionQueued();

  protected virtual void BeforeConnect();

  protected virtual void OnConnecting(ENetConnection connection);

  protected virtual void OnConnected(ENetConnection connection, uint protocolVersion);

  protected virtual void OnDisconnected(ENetConnection connection, DisconnectReason reason);

  protected void QueueDisconnect(ENetConnection connection);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected void HandleDisconnect(ENetConnection connection, DisconnectReason reason);

  protected UdpConnectionStatus GetConnectionStatusInternal(ENetConnection connection);

  protected virtual void Dispose(bool disposing);

  public void Dispose();
}
