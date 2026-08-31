// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NatPunchThroughHandler
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking.Udp;
using Eco.Shared.Utils.Binary;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking;

public class NatPunchThroughHandler
{
  public const int Version = 0;

  public NatPunchThroughHandler(IUnconnectedUdpPeer peer, NatPunchThroughHandler.PeerKind kind);

  public void HandleNatIntroduction(ref ByteSpanReader reader);

  public void HandleNatPunchMessage(IPEndPoint senderEndPoint, ref ByteSpanReader reader);

  public void HandleNatIntroductionConfirmRequest(
    IPEndPoint senderEndPoint,
    ref ByteSpanReader reader);

  public bool TryHandleNatIntroductionConfirmed(ref ByteSpanReader reader, out string token);

  public void Introduce(
    IPEndPoint hostInternal,
    IPEndPoint hostExternal,
    IPEndPoint clientInternal,
    IPEndPoint clientExternal,
    string token);

  public void SendIntroduction(
    IPEndPoint peerEndPoint,
    NatPunchThroughHandler.PeerKind peerKind,
    IPEndPoint internalEndPoint,
    IPEndPoint externalEndPoint,
    string token);

  public void SendNatPunch(IPEndPoint toEndPoint, string token);

  public void SendNatIntroductionConfirmed(IPEndPoint toEndPoint, string token);

  public enum PeerKind : byte
  {
    Client,
    Host,
    MasterServer,
  }
}
