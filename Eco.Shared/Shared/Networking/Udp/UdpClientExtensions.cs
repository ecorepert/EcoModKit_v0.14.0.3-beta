// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.UdpClientExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Networking.Udp;

/// <summary>Extension methods for <see cref="T:Eco.Shared.Networking.Udp.IUdpClient" />.</summary>
public static class UdpClientExtensions
{
  /// <summary>Sends data to the server peer. Optionally may be provided <paramref name="channel" />. Reliable sequenced packets delivers independently on different channels.</summary>
  public static void SendData(
    this IUdpClient udpClient,
    byte[] data,
    int offset,
    int length,
    byte channel = 0);
}
