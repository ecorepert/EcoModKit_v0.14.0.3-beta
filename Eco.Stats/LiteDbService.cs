// Decompiled with JetBrains decompiler
// Type: Eco.Stats.LiteDbService
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using LiteDB;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Stats;

/// <summary> <see cref="T:Eco.Stats.LiteDbService" /> manages creation, access and transactions for LiteDB. </summary>
public sealed class LiteDbService : IDisposable
{
  /// <summary> Database accessor. </summary>
  public LiteDatabase Database { get; }

  public LiteDbService(string filename);

  internal void WithLock(Action action);

  internal T WithLock<T>(Func<T> func);

  /// <summary> Invokes <paramref name="action" /> with paused the database file writes. It ensures no modifications to the database file happen during the action execution and you can safely copy or backup the file. </summary>
  public Task WithPausedWritesAsync(Func<Task> action, bool makeCheckpoint = true);

  /// <summary> Performs set of operations in a transaction. All operations within transaction will either be committed or rollback. </summary>
  public void WithTransaction(Action action);

  public void Dispose();

  internal void Flush();
}
