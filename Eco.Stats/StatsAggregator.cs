// Decompiled with JetBrains decompiler
// Type: Eco.Stats.StatsAggregator
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using LiteDB;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Stats;

/// <summary>
/// This class responsible for aggregating multiple similar stats into single record per hour when detailed time scale no more needed.
/// Maximum hours to preserve detailed information defined by <see cref="P:Eco.Stats.StatsConfig.KeepDetailsHours" />.
/// This class should be initialize with call to <see cref="M:Eco.Stats.StatsAggregator.Initialize(System.Collections.Generic.IEnumerable{Eco.Stats.StatInfo})" /> with enumerable of <see cref="T:Eco.Stats.StatInfo" /> instances which used
/// to build aggregatable stats collection with <see cref="P:Eco.Stats.StatInfo.IsAggregatable" /> equal to true.
/// Once initialized this class may be used to aggregate all registered stats with call to <see cref="M:Eco.Stats.StatsAggregator.Aggregate(System.Double)" /> method.
/// Use of this class may help greatly reduce size of database and effectiveness of queries, because many stats like craft actions or pollution events
/// may create thousands of records within a hour at same position, for same item etc.
/// </summary>
public class StatsAggregator
{
  public StatsConfig Config { get; }

  public StatsAggregator(LiteDbService liteDbService, StatsConfig config);

  public void Initialize(IEnumerable<StatInfo> statInfos);

  /// <summary>Aggregates stats into fewer records. Read more details in class summary.</summary>
  public void Aggregate(double now);

  /// <summary>
  /// Creates compiled aggregate action which aggregates values from aggregatable to aggregator. I.e. it may be sum of Count property.
  /// All properties with <see cref="T:Eco.Stats.SumInAggregateGroupingAttribute" /> will be summed up.
  /// </summary>
  internal static Action<BsonDocument, BsonDocument> CreateAggregateFromFunc(Type statType);

  /// <summary>Creates compiled function for <paramref name="statType" /> for all or only essential fields (specified by <paramref name="essentialOnly" />).</summary>
  internal static IEqualityComparer<BsonDocument> CreateGroupingComparer(
    Type statType,
    bool essentialOnly);
}
