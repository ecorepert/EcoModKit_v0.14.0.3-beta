// Decompiled with JetBrains decompiler
// Type: Eco.Networking.ENet.ENetConnection
// Assembly: Eco.Networking.ENet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00C02FAA-9424-481A-B463-D4AE2C8B3EB5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Networking.ENet.dll

using Eco.Shared.Networking;
using Eco.Shared.Pools;
using ENet;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Networking.ENet;

internal class ENetConnection
{
  public Host Host { get; }

  public Peer Peer { get; }

  public bool Disconnecting { get; set; }

  public ENetConnection(Host host, Peer peer);

  public void AddIncompletePacket(byte channel, ReadOnlySpan<byte> data);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryFinishIncompletePacket(byte channel, [MaybeNullWhen(false)] out PooledMemoryStream stream);

  public UdpConnectionStatus ConnectionStatus { get; }

  public IPEndPoint RemoteEndPoint { get; }
}
