// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RpcRateLimiter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Networking;

/// <summary>Per-client token-bucket rate limiter for incoming RPCs. Sized so legitimate UI bursts
/// (~50 RPCs/sec worst case from rapid dragging/tooltip hover) never trigger it; spam attacks
/// (10K+ RPCs/sec from a modded client) are dropped silently so the attacker cannot probe the throttle.</summary>
public static class RpcRateLimiter
{
  /// <summary>Sustained rate cap (RPCs/sec).</summary>
  public const double SustainedRate = 500.0;
  /// <summary>Bucket capacity (burst allowance).</summary>
  public const double BurstCapacity = 1500.0;

  /// <summary>Returns true if the call should proceed, false if it should be dropped.</summary>
  public static bool TryConsume(INetClient client);

  /// <summary>Forget any state for a client that disconnected.</summary>
  public static void Forget(int clientID);

  private sealed class Bucket
  {
    public double Tokens;
    public long LastTimestampTicks;
    public long LastDropLogTicks;
    public long DroppedSinceLastLog;
  }
}
