// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.FragmentedMessageHandler
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

public class FragmentedMessageHandler
{
  public FragmentedMessageHandler();

  public FragmentedMessageHandler(TimeSpan ttl);

  /// <summary>
  /// Gets or sets fragmented message Time-To-Life, if during this interval message will not be assembled then it will be cleaned up.
  /// </summary>
  public TimeSpan TTL { get; set; }

  /// <summary>
  /// Handles incoming message which may be a fragment. Will return same message if message is complete and may be processed further.
  /// If it is a message fragment then it will be added to collection of message fragments.
  /// As soon as all message fragments will be collected it will assemble NetBuffer with message content.
  /// </summary>
  /// <param name="message">UdpIncomingMessage message which may be fragment or complete message.</param>
  /// <param name="completeMessage">UdpIncomingMessage containing complete message data if success, null otherwise.</param>
  /// <returns>Returns true if able to get complete buffer, false otherwise.</returns>
  /// <exception cref="T:System.ArgumentException">In case of a fragment inconsistency.</exception>
  public bool TryGetCompleteBuffer(in UdpDataMessage message, out UdpDataMessage completeMessage);

  private class FragmentedMessage
  {
    public byte[][] Fragments { get; }

    public DateTime CreatedTime { get; }

    public int TotalCount { get; }

    public bool IsComplete { get; }

    public void AddFragment(int fragmentIndex, byte[] fragmentData);
  }
}
