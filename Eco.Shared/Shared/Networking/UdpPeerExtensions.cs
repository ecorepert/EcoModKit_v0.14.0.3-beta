// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.UdpPeerExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking.Udp;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Networking;

public static class UdpPeerExtensions
{
  public static void SendUnconnectedMessage(
    this IUnconnectedUdpPeer peer,
    IPEndPoint recipient,
    MemoryStream message,
    bool withFragmentation);

  /// <summary>
  /// Sends unconnected message to recipient with fragmentation support.
  /// Fragmented messages conforms to following protocol:
  ///     [NetMessage.FragmentedMessage][fragmentation info byte][fragmented message guid][message body fragment]
  /// 
  /// [fragmentation info byte] - contains pair partIndex/numOfParts (4 bits each), lower 4 bits is a part index and upper 4 bits is a number of parts. If 0 then message is not fragmented
  /// [fragmented message guid] - Used as fragmented message identifier to assembly message from parts at destination. 16 bytes.
  /// [message body fragment] - actual message body. Each fragment will contain part of message body.
  /// 
  /// Samples:
  /// 0Hello World
  /// 
  /// One fragment:
  ///     [\0][H][e][l][l][o][ ][W][o][r][l][d]
  /// Two fragments:
  ///     [\10][\32][Guid:16 bytes][\0][H][e][l][l][o]
  ///     [\10][\33][Guid:16 bytes][ ][W][o][r][l][d]
  /// 
  /// Following this protocol maximum useful allowed message length is: (MTU - 18) * 15.
  /// </summary>
  /// <param name="peer">peer.</param>
  /// <param name="message">Message to send, if it matches MTU then it will be send as is, otherwise wrapped in fragmented message.</param>
  /// <param name="recipient">recipient endpoint.</param>
  /// <exception cref="T:System.ArgumentException">Thrown if message body is too long to split into 15 fragments (max number of fragments).</exception>
  public static void SendUnconnectedMessageWithFragmentation(
    this IUnconnectedUdpPeer peer,
    IPEndPoint recipient,
    MemoryStream message);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SendUnconnectedMessage(
    this IUnconnectedUdpPeer udpPeer,
    IPEndPoint remoteEndPoint,
    MemoryStream stream);
}
