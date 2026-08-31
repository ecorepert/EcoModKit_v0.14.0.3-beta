// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Udp.IUnconnectedUdpPeer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Net;

#nullable disable
namespace Eco.Shared.Networking.Udp;

/// <summary>
/// Interface for unconnected UPD peers.
/// Contains UPD Peer Api for unconnected messages only.
/// </summary>
public interface IUnconnectedUdpPeer
{
  /// <summary>Event called when unconnected data message received.</summary>
  event UdpDataMessageHandler UnconnectedDataMessageReceived;

  /// <summary>Event called when an error message received.</summary>
  event Action<string> ErrorMessageReceived;

  /// <summary>Event called when a warning message received.</summary>
  event Action<string> WarningMessageReceived;

  /// <summary>Event called when a debug message received.</summary>
  event Action<string> DebugMessageReceived;

  /// <summary>
  /// MTU - maximum transmission unit size. Maximum size of UPD packet.
  /// </summary>
  int MaximumUnconnectedMessageLength { get; }

  /// <summary>Gets local port.</summary>
  int Port { get; }

  /// <summary>Gets running state of the peer.</summary>
  bool IsRunning { get; }

  /// <summary>Local IP End Point for the peer.</summary>
  IPEndPoint LocalEndPoint { get; }

  /// <summary>
  /// Sends raw data with socket to destination peer.
  /// It releases buffer after a send operation, so it is safe to reuse the <c>messageData</c> buffer.
  /// </summary>
  /// <param name="remoteEndPoint">destination end point.</param>
  /// <param name="messageData">message data to send.</param>
  /// <param name="offset">offset in message data.</param>
  /// <param name="length">length of message.</param>
  void SendRaw(IPEndPoint remoteEndPoint, byte[] messageData, int offset, int length);

  /// <summary>
  /// Sends unconnected message with network lib to destination peer.
  /// It releases buffer after a send operation, so it is safe to reuse the <c>messageData</c> buffer.
  /// </summary>
  /// <param name="remoteEndPoint">destination end point.</param>
  /// <param name="messageData">message data to send.</param>
  /// <param name="offset">offset in message data.</param>
  /// <param name="length">length of message.</param>
  void SendUnconnectedMessage(
    IPEndPoint remoteEndPoint,
    byte[] messageData,
    int offset,
    int length);

  /// <summary>
  /// Starts peer. Makes initialization, creates socket and optionally starts background message processing thread.
  /// You need to call <see cref="M:Eco.Shared.Networking.Udp.IUnconnectedUdpPeer.Service(System.Int32)" /> or <see cref="M:Eco.Shared.Networking.Udp.IUnconnectedUdpPeer.ServiceOne(System.Int32)" /> to have network messages processed and trigger message events.
  /// </summary>
  void Start();

  /// <summary>
  /// Shutdowns peers. Releases resources and stops background threads (if any).
  /// </summary>
  void Shutdown();

  /// <summary>
  /// Services network messages - sending, receiving, connecting etc. You should call this method regular.
  /// /// Typical usage is following:
  /// <code>
  /// while (peer.IsRunning)
  ///    peer.Service(10);
  /// </code>
  /// You can service single network event with <see cref="M:Eco.Shared.Networking.Udp.IUnconnectedUdpPeer.ServiceOne(System.Int32)" />.
  /// </summary>
  /// <param name="timeoutMs">Maximum timeout between events. It will return if timeout exceed.</param>
  void Service(int timeoutMs);

  /// <summary>
  /// Same as <see cref="M:Eco.Shared.Networking.Udp.IUnconnectedUdpPeer.Service(System.Int32)" />, but only service single network event.
  /// </summary>
  /// <param name="timeoutMs">Maximum timeout until event. It will return <c>false</c> if the event won't happen.</param>
  /// <returns><c>true</c> if the event serviced, <c>false</c> otherwise.</returns>
  bool ServiceOne(int timeoutMs);

  /// <summary>
  /// Synchronize timers. Ensures local timer and network timer will use same time base.
  /// </summary>
  /// <param name="currentTimeInSeconds">current time on your timer.</param>
  void SyncTimer(double currentTimeInSeconds);
}
