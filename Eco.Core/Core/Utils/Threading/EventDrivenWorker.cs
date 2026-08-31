// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.EventDrivenWorker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Threading;

/// <summary> Worker which controlled by <see cref="F:Eco.Core.Utils.Threading.EventDrivenWorker.autoResetEvent" />. It will wait until <see cref="F:Eco.Core.Utils.Threading.EventDrivenWorker.autoResetEvent" /> set before every call to <see cref="M:Eco.Core.Utils.Threading.EventDrivenWorker.DoRepeatableWork(System.Threading.CancellationToken)" />. </summary>
public class EventDrivenWorker : RepeatableWorkerBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Utils.Threading.EventDrivenWorker" /> class with infinite timeout between events.
  /// </summary>
  public EventDrivenWorker(Action doWork, bool initialEventState = true);

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Utils.Threading.EventDrivenWorker" /> class with infinite timeout between events.
  /// <paramref name="autoResetEvent" /> should be set for initial <paramref name="doWork" /> execution on <see cref="M:Eco.Core.Utils.Threading.WorkerBase.Start" />.
  /// </summary>
  public EventDrivenWorker(AutoResetEvent autoResetEvent, Action doWork);

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Utils.Threading.EventDrivenWorker" /> class with infinite timeout between events.
  /// </summary>
  public EventDrivenWorker(
    Func<CancellationToken, Task<int>> repeatableAction,
    bool initialEventState = true);

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Utils.Threading.EventDrivenWorker" /> class with infinite timeout between events.
  /// <paramref name="autoResetEvent" /> should be set for initial <paramref name="repeatableAction" /> execution on <see cref="M:Eco.Core.Utils.Threading.WorkerBase.Start" />.
  /// </summary>
  public EventDrivenWorker(
    AutoResetEvent autoResetEvent,
    Func<CancellationToken, Task<int>> repeatableAction);

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Utils.Threading.EventDrivenWorker" /> class with timeout between events defined by return value of <paramref name="repeatableAction" /> function in milliseconds.
  /// </summary>
  public EventDrivenWorker(Func<int> repeatableAction, bool initialEventState = true);

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Utils.Threading.EventDrivenWorker" /> class with timeout between events defined by return value of <paramref name="repeatableAction" /> function in milliseconds.
  /// <paramref name="autoResetEvent" /> should be set for initial <paramref name="repeatableAction" /> execution on <see cref="M:Eco.Core.Utils.Threading.WorkerBase.Start" />.
  /// </summary>
  public EventDrivenWorker(AutoResetEvent autoResetEvent, Func<int> repeatableAction);

  public void SetEvent();

  /// <inheritdoc cref="M:Eco.Core.Utils.Threading.RepeatableWorkerBase.DoRepeatableWork(System.Threading.CancellationToken)" />
  protected override Task DoRepeatableWork(CancellationToken token);
}
