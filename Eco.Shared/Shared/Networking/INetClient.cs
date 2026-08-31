// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.INetClient
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using StrangeCloud.Service.Client.Contracts;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Shared.Networking;

public interface INetClient : INetObject
{
  static event Action<INetClient> ClientDisconnectedEvent;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected static void FireClientDisconnected(INetClient client);

  bool Connected { get; }

  bool IsLocal { get; }

  IWorldObserver Observer { get; }

  object Connection { get; }

  StrangeUser StrangeUser { get; }

  Task UpdateStrangeUser(string worldTicket);

  string WorldTicket { get; }

  void Disconnect(string title, string reason);

  void AddAsyncException(Exception exception);
}
