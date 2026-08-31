// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetworkClient
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Networking.Udp;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Shared.Networking;

public sealed class NetworkClient : IDisposable
{
  [ClientAPI]
  public readonly int QueuesCount;
  [ClientAPI]
  public int EnqueuedPackets;
  public 
  #nullable disable
  SubscribableEvent<Action> OnConnected;
  public SubscribableEvent<Action<string, bool>> OnDisconnected;
  public SubscribableEvent<Action<StrangeWorld>> ServerDiscovered;
  public SubscribableEvent<Action<StrangeWorld>> OfficialServerDiscovered;
  public SubscribableEvent<Action<(byte Channel, int TotalBytes, int DownloadedBytes, LocString Description)>> BigMessageIncoming;
  public SubscribableEvent<Action> ReceivedMessage;

  public static INetClient GetClient(int id);

  /// <summary>Count of packets pending to process on the queue carrying <paramref name="queue" />. Queues are drained independently (round-robin), so a flood on one is not back-pressure on another.</summary>
  [ClientAPI]
  public int EnqueuedPacketsInQueue(NetworkEvent queue);

  public UdpConnectionStatus Status { get; }

  public int Ping { get; }

  /// <summary> Actual remote end-point for the <see cref="F:Eco.Shared.Networking.NetworkClient.peer" />. </summary>
  public IPEndPoint RemoteEndPoint { get; }

  /// <summary> Server's original end-point (may differ from <see cref="P:Eco.Shared.Networking.NetworkClient.RemoteEndPoint" /> if connected with relay). </summary>
  public IPEndPoint ServerEndPoint { get; }

  public NetworkClient(IUdpLibrary udpLibrary);

  public Task GetServerInfo(Guid serverID);

  public void GetServerInfo(string address, int serverPort);

  public void GetServerInfo(IPEndPoint endPoint);

  public bool Connect(IPEndPoint endPoint);

  public bool Connect(string address, int port);

  public void Connect(Guid serverId);

  public void Connect(StrangeWorld world);

  public void Disconnect(string byeMessage = null, bool causedByError = false);

  public void Shutdown(string byeMessage);

  public void DiscoverLocalServers();

  [ClientAPI]
  public bool TryReceivePacket(int queueIndex, out ReceivedNetworkPacket packet);

  public void Update();

  public void SendEvent(NetworkEvent netEvent, BSONValue bson);

  public void HandleDisconnect(string reason);

  public void Service(int timeoutMs);

  public void SimulateDiscoverServer(StrangeWorld serverInfo);

  public NetworkClient.PingRequest SendPingRequest(StrangeWorld world);

  public string GetServerName();

  public string GetRawServerName();

  public NetStats GetConnectionStats();

  /// <summary>
  /// Disposes of the <see cref="T:System.ComponentModel.Component" />.
  /// </summary>
  public void Dispose();

  ~NetworkClient();

  public void Dispose(bool disposing);

  private enum ConnectionAttemptStatus
  {
    Discovery,
    DirectConnect,
    NATPunchConnect,
    RelayConnect,
  }

  private class ConnectionAttempt
  {
    public readonly List<IPEndPoint> RemoteEndPoints;
    public StrangeWorld World;
    public double Eta;
    public int ConnectToIndex;
    public int Attempts;
    public NetworkClient.ConnectionAttemptStatus Status;
  }

  public class PingRequest
  {
    public double CreatedAt;
    public bool SupportsSendTime;
    public bool Sent;
    public int Attempt;

    public bool IsDone { get; }

    public bool TimedOut { get; }

    public int PingMS { get; }
  }
}
