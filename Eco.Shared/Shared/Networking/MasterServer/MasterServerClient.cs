// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.MasterServer.MasterServerClient
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking.Udp;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Networking.MasterServer;

public class MasterServerClient
{
  public MasterServerClient(IUnconnectedUdpPeer peer);

  public void RegisterHost(ServerRegistration registration);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void RequestHostInfo(Guid serverId);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void RequestHostList();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void RequestOfficialList();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void RequestIntroduction(Guid serverId);
}
