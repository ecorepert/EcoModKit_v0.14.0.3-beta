// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.LoginQueue
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using System;
using System.Net;

#nullable disable
namespace Eco.Plugins.Networking;

/// <summary> This class controls the order in which users will be connected to the server if there are no space for everybody.
/// It allows to add a client to expiable queue via JoinQueue method. Once added, the user will have to try to reconnect in next 10 seconds in order to keep his place in queue
/// Once there are space to join, NetworkServer will connect the first not expired user from queue and advance queue to next one. </summary>
public class LoginQueue
{
  public LoginQueue(Func<double> timeFunc);

  public string DescribeQueue();

  public int QueueCount();

  /// <summary> Removes all expired consecutive clients in the queue and advances the queue. </summary>
  public int CleanExpiredClients();

  /// <summary> Removes the first client in queue. Used when client leaves the queue by one of two reasons: expiration or successful login. </summary>
  public void AdvanceQueueIfPossible();

  public bool IsEmpty();

  /// <summary> Adds a client to the queue if necessary.  </summary>
  /// <returns> Returns 1 if client can join immediately. Otherwise returns the position in the queue. </returns>
  public int JoinQueue(IPEndPoint clientEndpoint);
}
