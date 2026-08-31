// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.DetectingValueRecorder
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Tools;

/// <summary><see cref="T:Eco.Shared.Tools.PerformanceCounter" /> which detects values which has duration over expected and emits static event for them.</summary>
public class DetectingValueRecorder : IValueRecorder
{
  public readonly TimeSpan ExpectedMaxDuration;
  public readonly bool GrabStacktrace;

  /// <summary>Event which reported every time when outstanding value detected. Stack trace is optional and only provided when <see cref="F:Eco.Shared.Tools.DetectingValueRecorder.GrabStacktrace" /> is <c>true</c>.</summary>
  public static event Action<PerformanceIssue>? PerformanceIssueDetected;

  public DetectingValueRecorder(
    PerformanceCounter counter,
    TimeSpan expectedMaxDuration,
    bool grabStacktrace = false);

  public void RecordValue(in PerformanceCounterValue value);

  void IValueRecorder.RecordValue(in PerformanceCounterValue value);
}
