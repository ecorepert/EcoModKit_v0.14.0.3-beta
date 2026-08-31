// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.PerformanceManager
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace Eco.Shared.Tools;

/// <summary> Class for managing performance counters (<see cref="T:Eco.Shared.Tools.PerformanceCounter" />) and producing performance reports. </summary>
public class PerformanceManager
{
  /// <summary>Returns Default <see cref="T:Eco.Shared.Tools.PerformanceManager" />.</summary>
  public static PerformanceManager Default { get; }

  public bool Active { get; set; }

  public TimeSpan GetTime();

  public ICollection<PerformanceCounter> GetCounters();

  /// <summary>Adds new performance counter. If performance counter with same name already exists then throws <see cref="T:System.InvalidOperationException" />..</summary>
  public PerformanceCounter AddPerformanceCounter(string name, int maxValues = 2147483647 /*0x7FFFFFFF*/);

  /// <summary>Adds new performance counter. If performance counter with same name already exists then throws <see cref="T:System.InvalidOperationException" />. Uses <paramref name="configure" /> for custom counter configuration.</summary>
  public PerformanceCounter AddPerformanceCounter(
    string name,
    Func<PerformanceCounter, PerformanceCounter> configure);

  /// <summary>Adds new performance counter. If performance counter with same name already exists then throws <see cref="T:System.InvalidOperationException" />. Uses <paramref name="configure" /> for custom counter configuration.</summary>
  public PerformanceCounter AddPerformanceCounter(
    string name,
    int maxValues,
    Func<PerformanceCounter, PerformanceCounter> configure);

  /// <summary>Adds new performance counter. If performance counter with same name already exists then throws <see cref="T:System.InvalidOperationException" />.</summary>
  public PerformanceCounter AddPerformanceCounter(PerformanceCounter performanceCounter);

  public PerformanceCounter GetOrAddPerformanceCounter(string name, int maxValues = 2147483647 /*0x7FFFFFFF*/);

  /// <summary>Saves report to PerformanceManagerReport.txt or PerformanceManagerReport.json (for Trace format).</summary>
  public void SaveReport(PerformanceReportFormat format = PerformanceReportFormat.Full);

  /// <summary>Returns report as string. Content depends on <paramref name="format" />. Read details about format in <see cref="T:Eco.Shared.Tools.PerformanceReportFormat" /> documentation.</summary>
  public string GetReport(PerformanceReportFormat format = PerformanceReportFormat.Full);

  /// <summary>Writes report to <paramref name="writer" />. Content depends on <paramref name="format" />. Read details about format in <see cref="T:Eco.Shared.Tools.PerformanceReportFormat" /> documentation.</summary>
  public void WriteReport(TextWriter writer, PerformanceReportFormat format = PerformanceReportFormat.Full);

  /// <summary>Writes report in full format with all counter values.</summary>
  protected void WriteReportFullFormat(TextWriter writer);

  /// <summary>Writes report in short format. Only summary statistic (minimum, maximum and average values).</summary>
  protected void WriteReportShortFormat(TextWriter writer);

  /// <summary>Writes report in Shorter format, condensing information more than Short version, not supporting specific periods.</summary>
  protected void WriteReportShorterFormat(TextWriter writer);

  /// <summary>Writes report in trace format. Contains all data from counters in JSON format.</summary>
  protected void WriteReportTraceFormat(TextWriter writer);
}
