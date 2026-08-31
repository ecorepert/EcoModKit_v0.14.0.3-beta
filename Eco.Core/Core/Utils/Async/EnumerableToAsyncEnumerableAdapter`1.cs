// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Async.EnumerableToAsyncEnumerableAdapter`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Utils.Async;

public class EnumerableToAsyncEnumerableAdapter<T> : IAsyncEnumerable<T>
{
  public EnumerableToAsyncEnumerableAdapter(IEnumerable<T> enumerable);

  public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default (CancellationToken));

  public class Enumerator : IAsyncEnumerator<T>, IAsyncDisposable
  {
    public Enumerator(IEnumerator<T> enumerator);

    public ValueTask DisposeAsync();

    public ValueTask<bool> MoveNextAsync();

    public T Current { get; }
  }
}
