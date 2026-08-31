// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.StrangeWorld
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Newtonsoft.Json;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking;

public class StrangeWorld : IServerInfo
{
  public StrangeWorld();

  public StrangeWorld(StrangeWorldCloudData cloudData);

  public void InitEndpoints();

  public StrangeWorldCloudData CloudData { get; set; }

  public ServerInfo ServerInfo { get; set; }

  [JsonIgnore]
  public IPEndPoint RemoteEndPoint { get; }

  [JsonIgnore]
  public IPEndPoint InternalEndPoint { get; }

  public string Description { get; }

  public Guid Id { get; }

  public string Address { get; }

  public int GamePort { get; }
}
