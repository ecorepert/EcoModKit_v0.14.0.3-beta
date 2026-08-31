// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Async.SingleObjectWaiter
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

#nullable enable
namespace Eco.Core.Utils.Async;

/// <summary>Helper class for async operations which need to wait for <see cref="T:System.Threading.WaitHandle" /> in asynchronous manner. Not intended to be used directly, instead use <see cref="M:Eco.Core.Utils.Async.AsyncFactory.FromWaitHandle(System.Threading.WaitHandle)" />.</summary>
internal class SingleObjectWaiter : IValueTaskSource<bool>
{
  /// <summary>Waits until <paramref name="handle" /> notified or until <paramref name="millisecondsTimeoutInterval" /> expired. Returns <see cref="T:System.Threading.Tasks.ValueTask" /> which will be set to <c>true</c> when timeout and to <c>false</c> otherwise.</summary>
  public ValueTask<bool> WaitAsync(
    WaitHandle handle,
    long millisecondsTimeoutInterval,
    CancellationToken cancellationToken);

  /// <summary>Unregisters <see cref="F:Eco.Core.Utils.Async.SingleObjectWaiter.registration" /> if any currently active.</summary>
  public void Unregister();

  public bool GetResult(short token);

  public ValueTaskSourceStatus GetStatus(short token);

  public void OnCompleted(
    Action<object?> continuation,
    object? state,
    short token,
    ValueTaskSourceOnCompletedFlags flags);
}
