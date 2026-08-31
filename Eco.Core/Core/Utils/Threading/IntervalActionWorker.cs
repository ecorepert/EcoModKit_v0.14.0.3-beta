// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.IntervalActionWorker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Threading;

/// <summary> Executes an action with specific interval (it will adjust delay between executions based on the action execution time). </summary>
public class IntervalActionWorker : RepeatableActionWorker
{
  /// <summary> Interval between <see cref="P:Eco.Core.Utils.Threading.RepeatableActionWorker.RepeatableAction" /> executions. </summary>
  public TimeSpan Interval { get; set; }

  public IntervalActionWorker(TimeSpan interval, Func<CancellationToken, Task> repeatableAction);

  /// <inheritdoc cref="M:Eco.Core.Utils.Threading.RepeatableActionWorker.DoRepeatableWork(System.Threading.CancellationToken)" />
  protected override Task DoRepeatableWork(CancellationToken token);
}
