// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.PerformanceIssue
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Diagnostics;

#nullable enable
namespace Eco.Shared.Tools;

/// <summary>Structure containing information about performance issue detected by <see cref="T:Eco.Shared.Tools.DetectingValueRecorder" />.</summary>
public readonly struct PerformanceIssue
{
  public readonly PerformanceCounter Counter;
  public readonly PerformanceCounterValue Value;
  public readonly StackTrace? StackTrace;
  public readonly TimeSpan ExpectedMaxDuration;

  public PerformanceIssue(
    PerformanceCounter counter,
    TimeSpan expectedMaxDuration,
    PerformanceCounterValue value,
    StackTrace? stackTrace);

  public override string ToString();
}
