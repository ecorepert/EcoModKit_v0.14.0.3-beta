// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.AddressTakenError
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using System.Net;

#nullable disable
namespace Eco.Plugins.Networking;

public class AddressTakenError : PluginError
{
  public AddressTakenError(IServerPlugin plugin, IPEndPoint address);
}
