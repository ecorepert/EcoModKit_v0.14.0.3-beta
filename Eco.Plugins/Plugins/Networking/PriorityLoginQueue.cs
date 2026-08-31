// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.PriorityLoginQueue
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using System;
using System.Net;

#nullable disable
namespace Eco.Plugins.Networking;

/// <summary>
/// It's similar to Login Queue which allows to have expiable connections, but it also allows to prioritize them.
/// For each priority of client it will create it's own login queue and it won't let you join until all queues with higher priority are empty
/// </summary>
public class PriorityLoginQueue
{
  public bool IsEmpty();

  public string DescribeQueue();

  public int CleanExpired();

  /// <summary> Removes the first client in queue. Used when client leaves the queue by one of two reasons: expiration or successful login. </summary>
  public void AdvanceQueueIfPossible();

  /// <summary> Adds a client to the queue  </summary>
  /// <returns> Returns 1 if client can join immediately. Otherwise returns the position in the queue. </returns>
  public int JoinQueue(IPEndPoint clientEndpoint, int priority);

  public PriorityLoginQueue(Func<double> timeFunc = null);

  public int QueueLength();
}
