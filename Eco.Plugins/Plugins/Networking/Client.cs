// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.Client
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using ConcurrentCollections;
using Eco.Core.Agents;
using Eco.Core.Controller;
using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Collections;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Udp;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using PlayFab;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Networking;

[ChatCommandHandler]
public sealed class Client : IMvcNetClient, INetClient, INetObject
{
  public readonly 
  #nullable disable
  EventWaitHandle ClientUpdateEvent;

  public static Eco.Plugins.Networking.Client Get(int id);

  public ConcurrentHashSet<int> KnownBlobs { get; }

  public ConcurrentHashSet<string> HashesOfCachedData { get; }

  /// <summary>Did this client successfully finish authentication handshake?</summary>
  public bool IsAuthenticated { get; }

  /// <summary>Set before user is authenticated when authenticating in offline mode.</summary>
  /// <remarks>Used to identify client during offline authentication handshake.</remarks>
  public ulong SteamId { get; }

  bool IMvcNetClient.IsRequested(IController controller, string propertyName);

  void IMvcNetClient.Request(IController controller, string name);

  public WorldObserver Observer { get; }

  IWorldObserver INetClient.Observer { get; }

  public StrangeUser StrangeUser { get; }

  public string WorldTicket { get; }

  public bool Valid { get; }

  public string Name { get; }

  public bool Connected { get; }

  public bool IsLocal { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public AutoResetEvent UpdateEvent { get; set; }

  public IPEndPoint RemoteEndPoint { get; }

  public object Connection { get; }

  object INetClient.Connection { get; }

  public int LoginPriority { get; }

  public Client(IUdpServer serverPeer, object connection, IPEndPoint remoteEndPoint);

  public void EnqueuePacket(ReceivedNetworkPacket packet);

  public void AddAsyncException(Exception exception);

  [CITest(true)]
  [ChatSubCommand("Util", "Opens the server GUI, if the user is a local user.", "serverui", ChatAuthorizationLevel.Admin)]
  public static void OpenServerUI(User user);

  [RPC]
  public void SpawnPlayer(float viewDistance, string language);

  public Task ShutdownAsync();

  public void Shutdown(bool waitThreads = false);

  /// <summary>Disconnects a user from the server with a popup dialog and optional disconnect reason.</summary>
  /// <param name="title">Title of the message shown to the user.</param>
  /// <param name="reason">Optional Disconnect reason message shown to the user.</param>
  public void Disconnect(string title, string reason = null, bool endSteamAuthSession = true);

  void INetClient.Disconnect(string title, string reason);

  /// <summary>Disconnects a user with an error code that will be shown to the user along side their normal disconnect message.</summary>
  /// <param name="errorCode">Error code to show to the user.</param>
  /// <inheritdoc cref="M:Eco.Plugins.Networking.Client.Disconnect(System.String,System.String,System.Boolean)" />
  public void Disconnect(int errorCode, string title, string reason = null);

  /// <inheritdoc cref="M:Eco.Plugins.Networking.Client.Disconnect(System.Int32,System.String,System.String)" />
  public void Disconnect(PlayFabErrorCode errorCode, string title, string reason = null);

  /// <summary>Disconnects a user from the server with a popup dialog showing a playfab services error message.</summary>
  /// <param name="strangeApiError">Strange Cloud error to disconnect the user with.</param>
  public void Disconnect(StrangeApiError strangeApiError);

  public void Login(uint protocolVersion);

  /// <summary>Called by client to finish autentication handshake when connection to Strange Clound could not be estabilished.</summary>
  /// <param name="ticket">Steam auth session ticket used to verify user's identity and check if they own Eco.</param>
  /// <remarks>For online mode version see <see cref="M:Eco.Plugins.Networking.Client.AuthenticateOnline(System.String,System.String,System.String)" />.</remarks>
  [RPC]
  public void AuthenticateOffline(byte[] ticket, ulong steamId, string username, string version);

  /// <summary>Called by client to finish autentication handshake in online mode.</summary>
  /// <remarks>For offline mode version see <see cref="M:Eco.Plugins.Networking.Client.AuthenticateOffline(System.Byte[],System.UInt64,System.String,System.String)" />.</remarks>
  [RPC]
  public Task AuthenticateOnline(string worldTicket, [Profanity(Filter = ProfanityFilterType.NoFilter)] string username, string version);

  /// <summary>Requeries the strange user from the server, needs to be done with the user buys an item for example.</summary>
  public Task UpdateStrangeUser(string worldTicket);

  [RPC]
  public Task RequestContent(List<string> requestList);

  /// <summary> Next step of connection, used after session is confirmed. Here it checks if it should be done directly or via queue. </summary>
  public void RequireLoginQueueIfNeeded();

  [RPC]
  public object ViewRPC(INetClient client, int id, string methodname, BSONObject bson);

  /// <summary>Makes async RPC call on view with <paramref name="id" />. Ensures that after RPC method execution it will wait for next client update to ensure all changes initiated by RPC synced back to the client before RPC callback invoked.</summary>
  [RPC]
  public Task<object> SyncedViewRPC(INetClient client, int id, string methodname, BSONObject bson);

  [RPC]
  public void ReleaseViews(INetClient client, BSONValue viewIds);

  [RPC]
  public void BoundView(INetClient client, int viewId);

  [RPC]
  public string SubscribeToPropertyUpdates(
    INetClient client,
    IController controller,
    string propertyName);

  [RPC]
  public string UnsubscribeToPropertyUpdates(
    INetClient client,
    IController controller,
    string propertyName);

  public override string ToString();

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public SpinLockBuffer<byte[]> Views { get; }

  public SpinLockBuffer<byte[]> Blobs { get; }

  public bool ShouldNotify(IController controller, string name);

  /// <summary> Comparer for net objects by priority. </summary>
  private class NetObjectPriorityComparer : IComparer<INetObject>
  {
    public NetObjectPriorityComparer(Eco.Plugins.Networking.Client client);

    public int Compare(INetObject x, INetObject y);
  }
}
