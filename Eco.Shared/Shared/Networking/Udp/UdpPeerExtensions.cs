// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.UdpPeerExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Networking.Udp;

public static class UdpPeerExtensions
{
  /// <summary>Sends data to the <paramref name="connection" /> (one of connected peers). Optionally may be provided <paramref name="channel" />. Reliable sequenced packets delivers independently on different channels.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SendData(
    this IUdpPeer peer,
    object connection,
    byte[] data,
    int offset,
    int length,
    byte channel = 0);

  /// <summary>Sends data to all <paramref name="connections" />. Optionally may be provided <paramref name="channel" />. Reliable sequenced packets delivers independently on different channels.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SendData(
    this IUdpPeer peer,
    IEnumerable<object> connections,
    byte[] data,
    int offset,
    int length,
    byte channel = 0);
}
