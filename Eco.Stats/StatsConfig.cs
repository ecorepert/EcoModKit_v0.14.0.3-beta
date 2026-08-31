// Decompiled with JetBrains decompiler
// Type: Eco.Stats.StatsConfig
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using Eco.Core.Plugins;
using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Stats;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
[IgnoreHostedWorlds]
public class StatsConfig
{
  [LocDescription("Blocks bulk recording of actions which can help reduce crashes caused by a bug in LiteDB that mostly occur on larger servers, but may lead to some data no longer being available for civic features.")]
  public bool BlockBulkActions { get; set; }

  [LocDescription("How old records can be grouped. It means it will try to process all last X days of records to group them. Usually you want to have this number low (1-2) in order to avoid process already processed records, but you can set high value (by example world age) in order to process at once all records from some old save with disabled grouping.")]
  public int StatsGroupingDays { get; set; }

  [LocDescription("Max count of records that will be proccesed at once hourly. For reference, server with 100 players may reach 1.000.000 records per day. Usually 500.000 (default) should be ok, but you may want to tweak it if you have incredibly big count of records or if you are facing lag while it groups records. ")]
  public int MaxRecordsToGroup { get; set; }

  [LocDescription("Most recent records wont be processed in order to have more exact values for laws like 'Users who in last 1 hour claimed plots ...'. You may want to tweak this value to increase this support. ")]
  public int KeepDetailsHours { get; set; }

  [LocDescription("It rebuilds database file at the moment of exiting the application. It may reduce space of stats file, but it will increase the time needed to exit. ")]
  public bool RebuildDatabaseOnExit { get; set; }

  [LocDescription("Level of grouping data. Essential fields means only citizen, i.e, it may group action of 'drop rubble' and 'drop garbage' for same citizen. Currently othey fields are not used, so it should be good enough. But in the future there are may be another features with database, which may requiere another properties. ")]
  public StatsGroupingLevel GroupingLevel { get; set; }

  [LocDescription("Skip the hourly stats squash while online player count exceeds this, since the LiteDB churn it causes competes with live gameplay for GC time. Set to 0 to disable.")]
  public int SquashPopulationThreshold { get; set; }

  [LocDescription("Even if the server stays busy, force a squash after this many hours so the backlog can't grow unbounded.")]
  public double SquashMaxDeferralHours { get; set; }
}
