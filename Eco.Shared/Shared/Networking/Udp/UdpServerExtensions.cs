// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.UdpServerExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Networking.Udp;

/// <summary>Extension methods for <see cref="T:Eco.Shared.Networking.Udp.IUdpServer" />.</summary>
public static class UdpServerExtensions
{
  /// <summary>Broadcast data to every connected peer.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void BroadcastData(this IUdpServer udpServer, byte[] data, int offset, int length);
}
