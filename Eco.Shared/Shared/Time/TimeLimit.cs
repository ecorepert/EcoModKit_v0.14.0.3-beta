// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Time.TimeLimit
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Time;

/// <summary>Represents time limit which may be checked for expiration and overtime.</summary>
public readonly struct TimeLimit
{
  private readonly long expirationTicks;

  public bool Expired { get; }

  public long OvertimeTicks { get; }

  public TimeSpan Overtime { get; }

  /// <summary> Creates new limit with upper bound set to current limit. </summary>
  /// <param name="ticks">new limit ticks.</param>
  /// <param name="truncatedTicks">number of ticks truncated to match current limit.</param>
  /// <returns>new TimeLimit object.</returns>
  public TimeLimit SubLimitFromTicks(long ticks, out long truncatedTicks);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TimeLimit FromTicks(long ticks);

  public static TimeLimit FromTimeSpan(TimeSpan timeSpan);

  public static TimeLimit FromSeconds(double seconds);

  public static TimeLimit FromMilliseconds(double ms);
}
