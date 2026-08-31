// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.UPnPMapping
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Plugins.Networking;

public sealed class UPnPMapping : IDisposable
{
  public ProtocolType ProtocolType { get; }

  public int PrivatePort { get; }

  public IPEndPoint PublicEndPoint { get; }

  public UPnPMapping(ProtocolType protocolType, int privatePort);

  public Task<IPEndPoint> CreateAsync();

  public Task DeleteAsync();

  public void Dispose();
}
