// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.TotalsRecorder
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Tools;

/// <summary>Totals recorder for <see cref="T:Eco.Shared.Tools.PerformanceCounter" />.</summary>
public class TotalsRecorder : IValueRecorder
{
  public int TotalCount { get; }

  public TimeSpan TotalDuration { get; }

  public void RecordValue(in PerformanceCounterValue value);

  void IValueRecorder.RecordValue(in PerformanceCounterValue value);
}
