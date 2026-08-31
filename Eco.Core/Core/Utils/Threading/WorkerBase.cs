// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.WorkerBase
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Threading;

/// <summary> Base class for workers which implements default Worker workflow. </summary>
public abstract class WorkerBase : IWorker
{
  /// <summary> Actual work performed in this method. </summary>
  protected abstract Task DoWork(CancellationToken token);

  /// <summary> Starts worker with default <see cref="T:System.Threading.Tasks.TaskFactory`1" />. </summary>
  public void Start();

  /// <summary> Starts worker with <paramref name="taskFactory" /> <see cref="T:System.Threading.Tasks.TaskFactory`1" />. </summary>
  public void Start(TaskFactory taskFactory);

  /// <summary> Shutdowns worker by setting cancellation token <see cref="F:Eco.Core.Utils.Threading.WorkerBase.cts" /> and waiting for <see cref="F:Eco.Core.Utils.Threading.WorkerBase.task" /> to be completed. </summary>
  public Task ShutdownAsync();
}
