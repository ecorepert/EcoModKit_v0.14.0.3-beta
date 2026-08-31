// Decompiled with JetBrains decompiler
// Type: Eco.Networking.ENet.ENetUdpLibrary
// Assembly: Eco.Networking.ENet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00C02FAA-9424-481A-B463-D4AE2C8B3EB5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Networking.ENet.dll

using Eco.Shared.Networking.Udp;
using ENet;
using System;
using System.Net;

#nullable enable
namespace Eco.Networking.ENet;

public class ENetUdpLibrary : IUdpLibrary, IDisposable
{
  public const int MaxPacketSize = 65536 /*0x010000*/;

  public ENetUdpLibrary();

  public ENetUdpLibrary(
    Func<InterceptCallback, InterceptCallback>? interceptCallbackFactory,
    Func<ConnectRequestCallback, ConnectRequestCallback>? connectRequestCallbackFactory);

  public IUdpClient CreateClient(string appIdentifier, uint protocolVersion, uint connectTimeout);

  public IUdpServer CreateServer(
    string appIdentifier,
    uint protocolVersion,
    IPEndPoint requestedEndPoint,
    int maxConnections);

  public void Dispose();

  protected virtual void Dispose(bool disposing);
}
