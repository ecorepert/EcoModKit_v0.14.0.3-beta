// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.UdpDataMessage
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking;

public readonly ref struct UdpDataMessage
{
  public readonly IPEndPoint SenderEndPoint;
  public readonly ReadOnlySpan<byte> Data;
  public readonly double ReceiveTime;
  public readonly object SenderConnection;
  public readonly byte Channel;

  public UdpDataMessage(
    IPEndPoint senderEndPoint,
    ReadOnlySpan<byte> data,
    double receiveTime,
    object senderConnection,
    byte channel = 0);

  public int GetBytesToRead(int readPosition);
}
