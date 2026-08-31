// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.NetworkMessage
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Core.Controller;
using Eco.Shared.Networking;
using Eco.Shared.Pools;
using Eco.Shared.Pools.Collections;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Plugins.Networking;

/// <summary> Used to queue network events from NetworkServer.SendEvent/&gt;. </summary>
internal sealed class NetworkMessage : IDisposable
{
  public NetworkEvent Event { get; set; }

  public INetClient Target { get; set; }

  public IReadOnlyCollection<INetClient> Targets { get; set; }

  public INetObject NetObject { get; set; }

  public byte Channel { get; }

  public PoolableListWrapper<IMvcNetClient> Clients { get; set; }

  /// <summary>Every <see cref="M:Eco.Plugins.Networking.NetworkMessage.Encode(Eco.Shared.Serialization.BSONValue)" /> should be paired by <see cref="M:Eco.Plugins.Networking.NetworkMessage.WaitForEncodedData" />. These methods may be used in different threads.</summary>
  public void Encode(BSONValue data);

  public void PrepareForPool();

  /// <summary>Waits until <see cref="M:Eco.Plugins.Networking.NetworkMessage.Encode(Eco.Shared.Serialization.BSONValue)" /> complete (it may be performed in another thread) and returns it's result. Can be only used one time per <see cref="M:Eco.Plugins.Networking.NetworkMessage.Encode(Eco.Shared.Serialization.BSONValue)" /> call.</summary>
  public PooledMemoryStream WaitForEncodedData();

  public void Dispose();
}
