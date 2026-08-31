// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.SimpleUnconnectedUdpPeer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Net;

#nullable enable
namespace Eco.Shared.Networking.Udp;

/// <summary> Simplest implementation of Unconnected UDP peer (used by master server) which doesn't use any third-party library, but just async sockets from .NET Core. </summary>
public class SimpleUnconnectedUdpPeer : IUnconnectedUdpPeer
{
  public int ReceiveBufferSize { get; set; }

  public int SendBufferSize { get; set; }

  public SimpleUnconnectedUdpPeer(int port = 0);

  public event 
  #nullable disable
  UdpDataMessageHandler UnconnectedDataMessageReceived;

  public event Action<string> ErrorMessageReceived;

  public event Action<string> WarningMessageReceived;

  public event Action<string> DebugMessageReceived;

  public int MaximumUnconnectedMessageLength { get; }

  public int Port { get; }

  public bool IsRunning { get; }

  public IPEndPoint LocalEndPoint { get; }

  public void SendRaw(IPEndPoint remoteEndPoint, byte[] messageData, int offset, int length);

  public void SendUnconnectedMessage(
    IPEndPoint remoteEndPoint,
    byte[] messageData,
    int offset,
    int length);

  public void Service(int timeoutMs);

  public bool ServiceOne(int timeoutMs);

  public void SyncTimer(double currentTimeInSeconds);

  public void Start();

  public void Shutdown();
}
