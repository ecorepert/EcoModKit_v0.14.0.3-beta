// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Rcon.RconPacketType
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

#nullable disable
namespace Eco.Plugins.Rcon;

/// <summary>
/// <para>Represents all possible transaction types within the RCON protocol. </para>
/// <para>For a more complete breakdown of the individual packet types refer to the documentation found on the Wiki https://wiki.play.eco/en/RCON#Packet_Types </para>
/// </summary>
public enum RconPacketType
{
  /// <summary>SERVERDATA_RESPONSE_VALUE: This packet type is sent by the server after completing a command execution.</summary>
  ResponseValue = 0,
  /// <summary>
  /// SERVERDATA_AUTH_RESPONSE: This packet type is sent by the server after receiving a Auth request packet. The contents
  /// of this packet vary based on the results of the authentication request. An invalid authentication request will contain
  /// a packet id of -1.
  /// </summary>
  AuthResponse = 2,
  /// <summary>
  /// SERVERDATA_EXECCOMMAND: This packet type is sent by the client to request a command be run. This packet should
  /// be followed up by a ResponseValue packet containing the results of the execution.
  /// </summary>
  ExecCommand = 2,
  /// <summary>
  /// SERVERDATA_AUTH: This packet type is sent by the client to request authorization to use the RCON server and
  /// execute commands. It is followed up by a AuthResponse packet containing the results of authentication.
  /// </summary>
  Auth = 3,
}
