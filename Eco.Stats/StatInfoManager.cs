// Decompiled with JetBrains decompiler
// Type: Eco.Stats.StatInfoManager
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable disable
namespace Eco.Stats;

/// <summary> Maintains all the info about stats, and builds that info on init. </summary>
public class StatInfoManager : AutoSingleton<StatInfoManager>
{
  public static Action<StatInfo> OnRegisterStat;
  public ConcurrentDictionary<string, StatInfo> StatNameToNode;
  public StatCategory Root;

  public bool ContainsStat(string s);

  public StatInfo GetInfo(string s);

  public StatInfo GetInfo(Type statType);

  public StatInfo GetInfo(IStat stat);

  public void Initialize(ICollection<ShortNameEntry> entries);

  public void MakeStatInfo(
    LocString displayName,
    string name,
    string categoriesString,
    StatAttribute stat,
    Type type,
    string[] tags);
}
