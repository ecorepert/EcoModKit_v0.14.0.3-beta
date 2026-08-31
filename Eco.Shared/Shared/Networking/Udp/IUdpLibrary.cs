// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.IUdpLibrary
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Net;

#nullable disable
namespace Eco.Shared.Networking.Udp;

/// <summary>
/// Interface for UDP libraries. Use this to create network lib peers.
/// </summary>
public interface IUdpLibrary
{
  /// <summary>
  /// Create UPD client for app with <c>appIdentifier</c>.
  /// </summary>
  /// <param name="appIdentifier">app identifier.</param>
  /// <param name="protocolVersion">version of binary protocol used between client and server.</param>
  /// <param name="connectTimeoutMs">connection timeout (time before Disconnect event received with <see cref="F:Eco.Shared.Networking.Udp.DisconnectReason.Timeout" />).</param>
  /// <returns><see cref="T:Eco.Shared.Networking.Udp.IUdpClient" /> implementation instance for this lib.</returns>
  IUdpClient CreateClient(string appIdentifier, uint protocolVersion, uint connectTimeoutMs = 3000);

  /// <summary>
  /// Create UPD server for app with <c>appIdentifier</c>.
  /// </summary>
  /// <param name="appIdentifier">App identifier.</param>
  /// <param name="protocolVersion">version of binary protocol used between client and server.</param>
  /// <param name="requestedEndPoint">Request endpoint for the server. You can use <c>IPEndPoint.Any</c> for address or <c>0</c>
  /// for port if you want to have automatically assigned values.</param>
  /// <param name="maxConnections">Maximum number of connections. <c>0</c> - for maximum possible.</param>
  /// <returns><see cref="T:Eco.Shared.Networking.Udp.IUdpServer" /> implementation instance for this lib.</returns>
  IUdpServer CreateServer(
    string appIdentifier,
    uint protocolVersion,
    IPEndPoint requestedEndPoint,
    int maxConnections);
}
