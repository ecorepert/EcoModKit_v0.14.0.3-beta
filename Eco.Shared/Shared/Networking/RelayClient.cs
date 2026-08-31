// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RelayClient
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking.Udp;
using Eco.Shared.Utils.Binary;
using System;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking;

public class RelayClient
{
  /// <value>Default Relay Server port.</value>
  public const int DefaultRelayServerPort = 3300;
  /// <value>Current message serialization version, bump when message format changes.</value>
  public const byte RelayServerProtocolVersion = 0;
  public Action<IPEndPoint> RelayPingReceived;
  public Action<IPEndPoint> BetterRelayServerDiscovered;

  public bool IsServer { get; }

  public RelayClient(IUdpPeer peer);

  public void StartRefreshing();

  public void StopRefreshing();

  public void RefreshRelayServerEndpoint();

  public void SendPing(string address);

  public void RegisterServer(IPEndPoint relayEndpoint, Guid serverId, Guid passport);

  public void ProcessPingReply(IPEndPoint senderEndpoint, ref ByteSpanReader reader);

  /// <summary>
  /// Processes relay introduce message:
  ///  [remote port:2 bytes][server id:guid].
  /// </summary>
  /// <param name="senderEndpoint">remote endpoint from which message received.</param>
  /// <param name="reader">reference to message data reader.</param>
  /// <param name="serverId">expected server id.</param>
  /// <param name="connectionEndPoint">output parameter for connection end point.</param>
  public bool TryProcessRelayIntroduce(
    IPEndPoint senderEndpoint,
    ref ByteSpanReader reader,
    in Guid serverId,
    out IPEndPoint connectionEndPoint);

  public void ConnectWithRelay(IPEndPoint relayEndpoint, Guid serverID);
}
