// Decompiled with JetBrains decompiler
// Type: Eco.Stats.StatInfo
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Stats;

[Serialized]
public class StatInfo
{
  public static ShortNameMap NameMap;
  [Serialized]
  public string Name;
  [Serialized]
  public string DisplayName;
  [Serialized]
  public string Unit;
  [Serialized]
  public string UnitDisplayName;
  [Serialized]
  public StatType StatType;
  [Serialized]
  public string ShortName;
  [Serialized]
  public string Description;
  [Serialized]
  public string[] Tags;
  [Serialized]
  public string ValueKey;
  public Type SystemType;

  [Serialized]
  public bool HasValueKey { get; set; }

  public bool IsCustom { get; }

  public bool IsAction { get; }

  public bool IsCountable { get; }

  public bool IsAggregatable { get; }

  public StatInfo();

  public StatInfo(
    LocString displayName,
    string name,
    StatAttribute stat,
    Type type,
    string[] tags);

  public string TimeKey { get; }

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();
}
