// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetworkUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.Net;

#nullable enable
namespace Eco.Shared.Networking;

public static class NetworkUtils
{
  public static 
  #nullable disable
  IPEndPoint ParseIPEndPoint(this string endpoint);

  public static bool TryResolve(
    string hostAndOptionalPort,
    int defaultPort,
    out IPEndPoint endpoint);

  /// <summary>
  /// Resolves IP address or host name to IPAddress object.
  /// If '*' used then it will auto-discovery remote address using https://www.ipify.org/.
  /// </summary>
  public static bool TryResolve(string ipOrHost, out IPAddress address);

  /// <summary>Filters <paramref name="addresses" /> to include only IPv4 and IPv6 addresses.</summary>
  public static IEnumerable<IPAddress> V4OrV6(this IEnumerable<IPAddress> addresses);

  public static IPAddress GetOwnIPAddress();

  public static IEnumerable<IPAddress> GetOwnIPAddresses();

  public static IEnumerable<IPAddress> GetGatewayAddresses();

  public static bool IsOwnIPAddress(IPAddress ipAddress);

  public static bool IsPublicIPAddress(IPAddress ipAddress);

  public static bool IsPrivateIPAddress(IPAddress ipAddress);

  public static IPAddress GetBroadcastAddress();
}
