// Decompiled with JetBrains decompiler
// Type: Eco.Stats.Stats
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Stats;

[Localized(false, true, "", false)]
[Priority(-100)]
public class Stats : 
  IStats,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IThreadedPlugin,
  IShutdownablePlugin,
  IInitializablePlugin,
  IConfigurablePlugin,
  IEditablePlugin,
  IDisposable
{
  public static Func<double> GetStatsTime;
  /// <summary>Set by a higher layer (networking) at startup so the squash worker can see how many players are online without Eco.Stats needing to reference networking types.</summary>
  public static Func<int> GetOnlinePlayerCount;

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public string GetCategory();

  public Stats();

  public Stats(Eco.Core.Plugins.PluginConfig<StatsConfig> config, string storageDirectory);

  public void Flush();

  public void Record(IStat obj);

  public void RecordBulk(IEnumerable<IStat> objs);

  public void RecordCustom(string statName, int time, float count, int userId, float? value);

  /// <summary> Do a simple time/value record. </summary>
  public void Record(int time, string collection, float value);

  public float MostRecentValue(string collection);

  public float DeltaValue(string collection, int time);

  /// <summary> Returns count for <paramref name="stat" />. For <see cref="T:Eco.Stats.ICountStat" /> it will use sum of value in Count property, otherwise it will return count of records. If you need info for several users you should avoid use it, use CountStatPerPlayer instead. </summary>
  public float CountStat(string stat, float time, double withinSeconds, int userID);

  /// <summary> Returns count for <paramref name="stat" />. For <see cref="T:Eco.Stats.ICountStat" /> it will use sum of value in Count property, otherwise it will return count of records. If you need info for several users you should avoid use it, use CountStatPerPlayer instead. </summary>
  public float CountStat(Type stat, float time, double withinSeconds, int userID);

  /// <summary> Returns a dictionary userId -&gt; value of stat for all users existed. Usefull if you need data for every user, this will be much faster than run CountStat user by user. </summary>
  public Dictionary<int, float> CountStatPerPlayer(string stat, float time, double withinSeconds);

  public Dictionary<int, float> CountStatPerPlayer(Type stat, float time, double withinSeconds);

  public List<TimeValue> QueryTimeValueRange(
    string collectionName,
    int startingSecond,
    int endingSecond);

  public List<TimeValue> QueryTimeValueRange(StatInfo info, int startingSecond, int endingSecond);

  public IEnumerable<BsonDocument> QueryRangeGeneric(
    StatInfo info,
    int startingSecond,
    int endingSecond);

  public List<T> QueryCollection<T>(string collectionName);

  /// <summary>Returns <see cref="T:Eco.Stats.TimeValue" /> recorded before or at <paramref name="time" />.</summary>
  public TimeValue? QueryFirstBefore(string collectionName, int time);

  public List<TimeValue> QueryNeighbors(string collectionName, int second);

  public void AddTimeIndex(StatInfo info);

  public void AddIndex(Type type, string propName);

  public void AddIndex(string collectionName, string propName);

  public string GetDisplayText();

  public string GetStatus();

  public Task ShutdownAsync();

  public void Run();

  public override string ToString();

  public void Initialize(TimedTask timer);

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  protected virtual void Dispose(bool disposing);

  public void Dispose();

  ~Stats();
}
