// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.Firewall
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using System.Net.Sockets;

#nullable disable
namespace Eco.Plugins.Networking;

/// <summary>Firewall rules manager which helps to check and expose ports for external access.</summary>
public static class Firewall
{
  /// <summary>Ensures <paramref name="serviceName" /> has firewall port rule which allows internal access with specified protocol.</summary>
  public static void EnsureRule(string serviceName, ProtocolType protocolType, int port);
}
