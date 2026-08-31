// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.ThreadPriorityTaskScheduler
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Utils.Threading;

public sealed class ThreadPriorityTaskScheduler : TaskScheduler, IDisposable
{
  public static readonly ThreadPriorityTaskScheduler BelowNormal;
  public static readonly ThreadPriorityTaskScheduler Lowest;

  public ThreadPriorityTaskScheduler(ThreadPriority threadPriority, int poolSize = 0, string poolName = null);

  public static ThreadPriorityTaskScheduler CreateAutoDisposable(
    ThreadPriority threadPriority,
    string poolName,
    int poolSize = 0);

  protected override void QueueTask(Task task);

  protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

  protected override IEnumerable<Task> GetScheduledTasks();

  public void Dispose();
}
