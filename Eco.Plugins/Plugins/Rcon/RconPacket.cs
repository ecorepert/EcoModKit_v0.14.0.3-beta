// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Rcon.RconPacket
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Rcon;

/// <summary>Represents an RCON packet used by the RCON server inside RconPlugin. Handles the encode/decode of outbound and inbound packets.</summary>
public struct RconPacket
{
  public const int MaxPacketSize = 4096 /*0x1000*/;
  public const int MinPacketSize = 14;
  public const int BasePacketSize = 10;
  private static 
  #nullable disable
  byte[] buffer;
  public readonly int Id;
  public readonly int Size;
  public readonly RconPacketType Type;
  public readonly string Payload;

  public RconPacket(int id, int size, RconPacketType type, string payload);

  /// <summary>Writes the RCON packet instance to a NetworkStream for sending over the network</summary>
  public Task WriteToAsync(NetworkStream stream, CancellationToken token);

  /// <inheritdoc cref="M:Eco.Plugins.Rcon.RconPacket.FromStream(System.IO.Stream)" />
  public static Task<RconPacket> FromStreamAsync(Stream stream, CancellationToken token);

  /// <summary>Reads the RCON packet from a NetworkStream instance and returns the <seealso cref="T:Eco.Plugins.Rcon.RconPacket" /> instance.</summary>
  public static RconPacket FromStream(Stream stream);

  public static RconPacket FromBuffer(byte[] buffer, int packetLength);

  public static RconPacket MakeAuthResponse(int id);

  public static RconPacket MakeExecResponse(int id, string payload = "");
}
