// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.NetworkServer
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Udp;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;
using System.Net;

#nullable disable
namespace Eco.Plugins.Networking;

/// <summary>
/// A wrapper around IUdpServer, with threads to handle send/receive and serialization of messages.
/// Network events can be send with SendEvent or via interface with INetworkEventHandler.SendEvent"/&gt;.
/// They added to <see cref="F:Eco.Plugins.Networking.NetworkServer.messages" /> queue and then processed in background with <see cref="M:Eco.Plugins.Networking.NetworkServer.DeliverMessages" /> method.
/// It supports following network events:
/// <ul>
/// <li><see cref="F:Eco.Shared.Networking.NetworkEvent.ClientLogin" /> - when client connected it welcomed with message containing protocol version and other server related info;</li>
/// <li><see cref="F:Eco.Shared.Networking.NetworkEvent.ClientUpdate" /> - server sends this message to the client multiple times per second with network object updates (newly bounded objects, updates for bounded objects and list of unbound (deleted) objects).</li>
/// <li><see cref="F:Eco.Shared.Networking.NetworkEvent.RPC" /> and <see cref="F:Eco.Shared.Networking.NetworkEvent.RPCResponse" /> used to perform Remote Procedure Calls (either server-to-client or client-to-server). Most noticeable there is MVC traffic performed with "ViewRPC" calls. </li>
/// <li><see cref="F:Eco.Shared.Networking.NetworkEvent.DisconnectReason" /> special event which happens when client or server initiates disconnect and contains disconnection reason.</li>
/// <li><see cref="F:Eco.Shared.Networking.NetworkEvent.Views" /> used together with other events (like <see cref="F:Eco.Shared.Networking.NetworkEvent.RPC" />, <see cref="F:Eco.Shared.Networking.NetworkEvent.RPCResponse" /> and <see cref="F:Eco.Shared.Networking.NetworkEvent.ClientUpdate" />) and contains MVC views initial data.
/// Other messages itself doesn't contains View data, but instead has references to views sent in this event. It prevents from issues when same view sent in different messages from multiple threads or referenced in temporary objects for later delivery.
/// It also allows to apply optimizations when same network data sent to multiple objects, because different clients may have different set of already bounded views and using references instead of full view data allows us to use exactly same data for all of them.</li>
/// </ul>
/// See Networking.md for additional details.
/// </summary>
public sealed class NetworkServer : Singleton<NetworkServer>, INetworkEventHandler
{
  public const int LengthOfDataToWarn = 65536 /*0x010000*/;
  public PriorityLoginQueue LoginQueue;

  public IPEndPoint RelayEndpoint { get; }

  public static int NumClients { get; }

  public static IPAddress LocalAddress { get; }

  public NetworkServer(NetObjectManager netObjectManager);

  public void DisconnectOlderClients(Client newClient);

  public void Shutdown(string byeMessage);

  public void RefreshMasterServerListing(bool publicServer = false);

  public void RefreshRelayServerListing();

  public Client GetClient(IPEndPoint endPoint);

  public Client GetClient(object connection);

  public Client GetClient(string displayName);

  void INetworkEventHandler.SendEventNow(NetworkEvent netEvent, BSONValue bson, INetClient target);

  void INetworkEventHandler.SendEvent<TScopeAwareEnumerable>(
    NetworkEvent netEvent,
    BSONValue bson,
    TScopeAwareEnumerable targets,
    INetObject netObj);

  void INetworkEventHandler.SendEvent(
    NetworkEvent netEvent,
    BSONValue bson,
    INetClient target,
    INetObject netObj);

  void INetworkEventHandler.ReceiveEvent(
    INetClient client,
    NetworkEvent netEvent,
    BSONValue bsonValue);

  public void Initialize(IUdpLibrary udpLib);

  public IPAddress GetLocalIPAddress();

  public void SetRelayAddress(string relayAddress, bool allowAuto);

  public void SetRelayEndpoint(IPEndPoint relayEndpoint, bool allowAuto);

  public void Update();

  /// <summary>Check if the given client can bypass queues.</summary>
  public bool TryBypassQueue(Client client);

  /// <summary>Check if the client is first in queue or not.</summary>
  public bool TryJoinWithQueue(Client client, out Vector2i result);

  public bool ClientHaveFreeSpotForConnecion(Client client);

  /// <summary> Returns true if new client should use queue. It's based on space for connection (any open slots) and users in login queue (even if there are space, new user should wait if there are somebody before him) </summary>
  public bool NeedLoginQueue(Client client);

  /// <summary> Get Status report from <see cref="T:Eco.Shared.Networking.Monitoring.NetTrafficTracker" />. Optionally pass data to use instead of <see cref="T:Eco.Shared.Networking.Monitoring.NetTrafficTracker" /> (used to dump existing status data to file)</summary>
  public static string GetStatus(Dictionary<INetObjectViewer, string> data = null);
}
