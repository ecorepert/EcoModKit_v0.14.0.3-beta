// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.IUdpPeer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Net;

#nullable enable
namespace Eco.Shared.Networking.Udp;

/// <summary>
/// Base interface for all UPD peers (either client or server).
/// Contains common UPD transport methods: like Connect to specific peer, Send to peer or Receive message.
/// </summary>
public interface IUdpPeer : IUnconnectedUdpPeer
{
  static readonly int CountOfChannels;

  event UdpDataMessageHandler DataMessageReceived;

  event UdpConnectedHandler Connected;

  event UdpDisconnectedHandler Disconnected;

  event UdpChannelDataReceived ChannelDataReceived;

  uint ProtocolVersion { get; set; }

  void Connect(IPEndPoint endpoint);

  /// <summary>Sends data to the <paramref name="connection" /> (one of connected peers). Optionally may be provided <paramref name="channel" />. Reliable sequenced packets delivers independently on different channels.</summary>
  void SendData(object connection, ReadOnlySpan<byte> data, byte channel = 0);

  /// <summary>Sends data to all <paramref name="connections" />. Optionally may be provided <paramref name="channel" />. Reliable sequenced packets delivers independently on different channels.</summary>
  void SendData(IEnumerable<object> connections, ReadOnlySpan<byte> data, byte channel = 0);
}
