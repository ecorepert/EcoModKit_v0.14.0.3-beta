// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.PeriodicWorkerFactory
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Threading;

public static class PeriodicWorkerFactory
{
  /// <summary>Creates a new instance of the <see cref="T:Eco.Core.Utils.Threading.RepeatableActionWorker" /> class with specified delay between executions.</summary>
  public static 
  #nullable disable
  RepeatableActionWorker Create(TimeSpan delay, Action doWork);

  /// <summary>Creates a new instance of the <see cref="T:Eco.Core.Utils.Threading.RepeatableActionWorker" /> class with specified execution interval.</summary>
  public static IntervalActionWorker CreateWithInterval(TimeSpan interval, Action doWork);

  /// <summary>Creates a new instance of the <see cref="T:Eco.Core.Utils.Threading.RepeatableActionWorker" /> class from async action with specified execution interval.</summary>
  public static IntervalActionWorker CreateWithInterval(
    TimeSpan interval,
    Func<CancellationToken, Task> doWork);

  /// <summary>Creates a new instance of the <see cref="T:Eco.Core.Utils.Threading.RepeatableActionWorker" /> class with specified interval between executions with cancellation support.</summary>
  public static RepeatableActionWorker Create(TimeSpan delay, Action<CancellationToken> doWork);

  /// <summary>Creates a new instance of the <see cref="T:Eco.Core.Utils.Threading.PeriodicWorkerFactory" /> class from function which returns delay before next work.</summary>
  public static RepeatableActionWorker Create(Func<TimeSpan> doWork);

  /// <summary>Creates a new instance of the <see cref="T:Eco.Core.Utils.Threading.PeriodicWorkerFactory" /> class from function which returns delay before next work.</summary>
  public static RepeatableActionWorker Create(Func<Task<TimeSpan>> doWork);
}
