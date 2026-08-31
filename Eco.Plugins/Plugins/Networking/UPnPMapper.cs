// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.UPnPMapper
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Utils;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Networking;

public class UPnPMapper : AutoSingleton<
#nullable disable
UPnPMapper>
{
  public Task<IPEndPoint> CreateAsync(ProtocolType protocolType, int privatePort);

  public Task<IPEndPoint> CreateAsync(
    ProtocolType protocolType,
    int privatePort,
    CancellationToken token);

  public Task DeleteAsync(ProtocolType protocol, int privatePort, int publicPort);
}
