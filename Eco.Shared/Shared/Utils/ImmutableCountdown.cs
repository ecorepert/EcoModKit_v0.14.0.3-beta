// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ImmutableCountdown
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> An immutable timer that is sycned with the client and doesn't require ticks. </summary>
[Serialized]
public readonly struct ImmutableCountdown
{
  [Serialized]
  private readonly double duration;
  [Serialized]
  private readonly double timeLeftIfPaused;
  [Serialized]
  private readonly double expirationTimeIfRunning;

  public static ImmutableCountdown CreatePaused(double duration);

  public static ImmutableCountdown CreatePaused(double duration, double timeLeft);

  public static ImmutableCountdown CreateRunning(double duration, double timeLeft);

  /// <summary> Creates <see cref="T:Eco.Shared.Utils.ImmutableCountdown" /> either paused or running with <paramref name="duration" /> and <paramref name="timeLeft" />. <paramref name="timeLeft" /> may exceed duration for over-value items (e.g. over-fresh food starts at &gt;100%). </summary>
  public static ImmutableCountdown Create(double duration, double timeLeft, bool paused);

  public ImmutableCountdown(
    double duration,
    double timeLeftIfPaused,
    double expirationTimeIfRunning);

  public double Duration();

  public bool Paused();

  public bool Expired();

  public double TimeSpent();

  public float PercentComplete();

  public float PercentLeft();

  public double TimeLeft();

  public double ExpirationTime();
}
