// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.IUdpClient
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Net;

#nullable enable
namespace Eco.Shared.Networking.Udp;

/// <summary>
/// Interface for Upd client.
/// It contains client specific methods and properties (like <see cref="P:Eco.Shared.Networking.Udp.IUdpClient.ConnectionStatus" /> or <see cref="M:Eco.Shared.Networking.Udp.IUdpClient.Disconnect" />).
/// </summary>
public interface IUdpClient : IUdpPeer, IUnconnectedUdpPeer
{
  UdpConnectionStatus ConnectionStatus { get; }

  float AverageRoundtripTime { get; }

  IPEndPoint? RemoteEndPoint { get; }

  /// <summary>Disconnects client from server peer.</summary>
  void Disconnect();

  /// <summary>Returns network stats like how much bytes sent and received. <see cref="T:Eco.Shared.Networking.NetStats" /> for more details.</summary>
  NetStats GetStats();

  /// <summary>Sends data to the server peer. Optionally may be provided <paramref name="channel" />. Reliable sequenced packets delivers independently on different channels.</summary>
  void SendData(ReadOnlySpan<byte> data, byte channel = 0);
}
