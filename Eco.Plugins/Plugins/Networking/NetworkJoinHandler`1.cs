// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.NetworkJoinHandler`1
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Math;
using System;
using System.Net;

#nullable disable
namespace Eco.Plugins.Networking;

/// <summary> Handles queue joining logic and priorities relevant. </summary>
/// <typeparam name="T">Can be any type for tests.</typeparam>
public class NetworkJoinHandler<T>
{
  public int LoadingUsersCount { get; }

  /// <summary> Initialize the join handler with given delegates so that it be used for skipping protocols. </summary>
  /// <param name="isAdmin">An admin always skips everything so if a client is an admin even if server connections are complete it should join.</param>
  /// <param name="isReservedSlot">A reserved slot jumps connection queues but in case the server  connections is complete it can't connect to server. </param>
  /// <param name="canJoin">This binds with the server configuration to determine if the given client can join the server or not, gives final say on if the client can join.(usually connection counts check)</param>
  /// <param name="loginQueue">Priority login queue to be used.</param>
  public NetworkJoinHandler(
    Func<T, bool> isAdmin,
    Func<T, bool> isReservedSlot,
    Func<T, int, int, bool> canJoin,
    PriorityLoginQueue loginQueue);

  public int CleanExpired();

  /// <summary> Returns true if client enters with no queue. It's based on space for connection (any open slots) and users in login queue (even if there are space, new user should wait if there are somebody before him) </summary>
  public bool TryBypassQueue(T client);

  /// <summary> Returns true if new client can connect now. It's based on space for connection (any open slots) and users in login queue (even if there are space, new user should wait if there are somebody before him) result is Vector2i(Position, Queuelength) and (-1,-1) if success.</summary>
  public bool TryJoinWithQueue(
    T client,
    IPEndPoint remoteEndPoint,
    int loginPriority,
    out Vector2i result);

  public void RemoveOccupation(T target);
}
