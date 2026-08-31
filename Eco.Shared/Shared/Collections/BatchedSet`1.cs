// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.BatchedSet`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Collections;

/// <summary>
/// Batched queue which allows to process queued objects by batches.
/// It should be provided with <see cref="F:Eco.Shared.Collections.BatchedSet`1.fetcher" /> which will perform fetching of new objects to the queue either incremental or with full re-fetch way.
/// In case of full re-fetch it will replace current queue content with new data. For incremental fetch it will add fetched items to end of the queue.
/// You can use <see cref="M:Eco.Shared.Collections.BatchedSet`1.Fetch(System.Boolean)" /> and <see cref="M:Eco.Shared.Collections.BatchedSet`1.GetNextBatch(System.Int32)" /> separate or you can use <see cref="M:Eco.Shared.Collections.BatchedSet`1.FetchNextBatch(System.Boolean,System.Int32)" /> which combines these two methods calls.
/// This class isn't thread-safe!
/// </summary>
public class BatchedSet<T>
{
  public BatchedSet(BatchedSet<T>.Fetcher fetcher, IComparer<T> comparer);

  /// <summary> Combines call to <see cref="M:Eco.Shared.Collections.BatchedSet`1.Fetch(System.Boolean)" /> and <see cref="M:Eco.Shared.Collections.BatchedSet`1.GetNextBatch(System.Int32)" />. </summary>
  public IEnumerable<T> FetchNextBatch(bool incremental, int batchSize);

  /// <summary> Returns next batch of max size batchSize from pre-fetched objects. </summary>
  public IEnumerable<T> GetNextBatch(int batchSize);

  /// <summary>
  /// Fetches data using <see cref="F:Eco.Shared.Collections.BatchedSet`1.fetcher" /> and adds it to end of the queue.
  /// If <paramref name="incremental" /> is <c>false</c> then it will clear the queue and replace it with fetched data.
  /// </summary>
  public void Fetch(bool incremental);

  public delegate IEnumerable<T> Fetcher(bool incremental);
}
