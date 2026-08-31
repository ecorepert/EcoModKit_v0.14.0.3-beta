// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.MasterServer.ServerRegistration
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking.MasterServer;

public class ServerRegistration
{
  public Guid Id;
  public Guid Passport;
  public IPEndPoint LocalEndPoint;
  public IPEndPoint RemoteEndPoint;
  public string ServerInfoJson;
  public bool IsPublic;
}
