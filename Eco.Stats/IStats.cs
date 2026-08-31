// Decompiled with JetBrains decompiler
// Type: Eco.Stats.IStats
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using LiteDB;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Stats;

public interface IStats
{
  void Record(IStat obj);

  void RecordBulk(IEnumerable<IStat> objs);

  void RecordCustom(string name, int time, float count, int userId, float? value);

  void Record(int time, string collection, float value);

  float MostRecentValue(string collection);

  float DeltaValue(string collection, int time);

  /// <summary> Returns sum of stat values stored in db based on stat type </summary>
  float CountStat(Type stat, float time, double withinSeconds, int userID);

  /// <summary> Returns sum of 'count' values of stat values stored in db based on ActionName </summary>
  /// <exception cref="T:System.OverflowException">Thrown when sum is too large or to small.</exception>
  float CountStat(string stat, float time, double withinSeconds, int userID);

  /// <summary> Returns sum of stat values stored in db per user. You can use it instead of CountStat when you work at all users same time, by example, when you evaulting demographic criteria for all useres. It uses type of stat </summary>
  Dictionary<int, float> CountStatPerPlayer(Type stat, float time, double withinSeconds);

  /// <summary> Returns sum of stat values stored in db per user. You can use it instead of CountStat when you work at all users same time, by example, when you evaulting demographic criteria for all useres. It uses action name </summary>
  Dictionary<int, float> CountStatPerPlayer(string stat, float time, double withinSeconds);

  List<TimeValue> QueryTimeValueRange(string collectionName, int startingSecond, int endingSecond);

  List<T> QueryCollection<T>(string collectionName);

  IEnumerable<BsonDocument> QueryRangeGeneric(StatInfo info, int startingSecond, int endingSecond);

  TimeValue? QueryFirstBefore(string collectionName, int time);

  List<TimeValue> QueryNeighbors(string collectionName, int second);

  void AddIndex(Type type, string propName);

  void AddIndex(string collection, string propName);

  void Flush();
}
