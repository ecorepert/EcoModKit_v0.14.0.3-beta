// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Monitoring.NetTrafficTracker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Networking.Monitoring;

public static class NetTrafficTracker
{
  public static void SetEnabled(bool show);

  public static 
  #nullable disable
  Dictionary<INetObjectViewer, string> GetDescription();

  public static Dictionary<INetObjectViewer, string> GetDescriptionAndClear();

  public class NetTrafficData
  {
    public ConcurrentDictionary<string, NetTrafficTracker.TrafficEntry> CategoryToEntry;
    public Dictionary<string, NetTrafficTracker.TrafficEntry> CategoryToEntryCumulative;
    public Dictionary<string, NetTrafficTracker.TrafficEntryAverage> CategoryToEntryAverage;

    public IEnumerable<string> Describe(
      KeyValuePair<string, NetTrafficTracker.TrafficEntry>[] categoryToEntry,
      double delta);
  }

  public class TrafficEntry
  {
    protected const int SizeCountPadding = 15;
    protected const int UpdateSeriPadding = 20;
    public int Count;
    public int Size;
    public double UpdateMS;
    public double SerializationMS;

    /// <summary> Describe over period of time delta </summary>
    public string Describe(double delta);

    /// <summary> Describe total </summary>
    public virtual string Describe();
  }

  public class TrafficEntryAverage : NetTrafficTracker.TrafficEntry
  {
    public double TotalDelta;

    /// <summary> Describe over total time </summary>
    public override string Describe();
  }
}
